using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Resources;
using System.Reflection;
using MySql.Data.MySqlClient;


namespace Diplom
{
    public partial class OpenFileForm : Form
    {
        public string FName;
        public OpenFileForm()
        {
            InitializeComponent();
            if(Properties.Settings.Default.Add == 0)
            {
                добавитьКнигуToolStripMenuItem.Enabled = false;
            }
            if(Properties.Settings.Default.Delete == 0)
            {
                удалитьКнигуToolStripMenuItem.Enabled = false;
            }
            if (Properties.Settings.Default.Editing == 0)
            {
                редактироватьКнигуToolStripMenuItem.Enabled = false;
            }
        }

        private string _Host = Properties.Settings.Default.DataSourse;
        //поле для хранения логина
        private string _UserName = Properties.Settings.Default.FTPuserlog;
        //поле для хранения пароля
        private string _Password = Properties.Settings.Default.FTPuserpass;
        //объект для запроса данных
        FtpWebRequest ftpRequest;
        //объект для получения данных
        FtpWebResponse ftpResponse;
        //флаг использования SSL
        private bool _UseSSL = false;

        public string Host
        {
            get
            {
                return _Host;
            }
            set
            {
                _Host = value;
            }
        }
        //логин
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        //пароль
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        //Для установки SSL-чтобы данные нельзя было перехватить
        public bool UseSSL
        {
            get
            {
                return _UseSSL;
            }
            set
            {
                _UseSSL = value;
            }
        }


        private void OpenFileForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= "+Properties.Settings.Default.UserPass;
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idКниги,НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание FROM Books", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }   
        }
        private void OpenFileForm_Activated(object sender, EventArgs e)
        {                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookid;
            string bookname;
            try
            {
                bookid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bookname = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                Properties.Settings.Default.BookName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = MyConnection.CreateCommand();

                MyConnection.Open();     

                MyCommand.CommandText = "SELECT bookway FROM BookLocation WHERE idBookLocation ='" + bookid + "'";

                using (MySqlDataReader reader = MyCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FName = reader.GetFieldValue<string>(0);
                        Properties.Settings.Default.BookFName = reader.GetFieldValue<string>(0);

                        Properties.Settings.Default.BookFName = FName;
                        Properties.Settings.Default.BookName = bookname;

                        try
                        {
                            string path;
                            path = "/";
                            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path + "/" + FName);

                            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
                            //команда фтп RETR
                            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                            ftpRequest.EnableSsl = _UseSSL;
                            //Файлы будут копироваться в кталог программы
                            FileStream downloadedFile = new FileStream(FName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                            //Получаем входящий поток
                            Stream responseStream = ftpResponse.GetResponseStream();
                            //Буфер для считываемых данных
                            byte[] buffer = new byte[1024];
                            int size = 0;

                            while ((size = responseStream.Read(buffer, 0, 1024)) > 0)
                            {
                                downloadedFile.Write(buffer, 0, size);
                            }
                            ftpResponse.Close();
                            downloadedFile.Close();
                            responseStream.Close();
                            MyConnection.Close();
                            try
                            {
                                var command = MyConnection.CreateCommand();
                                command.CommandText = "INSERT INTO UserOpenBook" + " (idПользователя,idКниги,ИмяПользователя,НазваниеКниги) VALUES (@idUser,@idBooks,@UserName,@BookName)";
                                MySqlParameter param = new MySqlParameter();
                                param.ParameterName = "@idUser";
                                param.Value = Properties.Settings.Default.UserLogId;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                param = new MySqlParameter();
                                param.ParameterName = "@idBooks";
                                param.Value = bookid;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                param = new MySqlParameter();
                                param.ParameterName = "@UserName";
                                param.Value = Properties.Settings.Default.UserName;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                param = new MySqlParameter();
                                param.ParameterName = "@BookName";
                                param.Value = bookname;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                MyConnection.Open();
                                command.ExecuteNonQuery();
                                MyConnection.Close();
                                Data.EventHanler(FName);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            this.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MyConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= "+Properties.Settings.Default.UserPass;
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idКниги,НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание FROM Books", MyConnection);
    
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idКниги,НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание FROM Books WHERE НазваниеКниги LIKE '%" + BookName.Text + "%'", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }   
        }

        private void BookAuthor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idКниги,НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание FROM Books WHERE Автор LIKE '%" + BookAuthor.Text + "%'", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }   
        }

        private void AddBookGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idКниги,НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание FROM Books WHERE Жан LIKE '%" + AddBookGenre.Text + "%'", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }   
        }

        private void AddLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idКниги,НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание FROM Books WHERE Язык LIKE '%" + AddLan.Text + "%'", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }   
        }

        private void AddBookDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idКниги,НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание FROM Books WHERE ДатаВыпуска LIKE '%" + AddBookDate.Text + "%'", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }   
        }

        private void добавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFileForm f = new AddFileForm();
            f.ShowDialog();
        }

        private void удалитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bookid;
            try
            {
                bookid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = MyConnection.CreateCommand();

                MyConnection.Open();

                MyCommand.CommandText = "SELECT bookway FROM BookLocation WHERE idBookLocation ='" + bookid + "'";

                using (MySqlDataReader reader = MyCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FName = reader.GetFieldValue<string>(0);

                        MyConnection.Close();
                        try
                        {
                            MyConnection.Open();

                            MyCommand.CommandText = "DELETE FROM Books WHERE idКниги = " + bookid;

                            MyCommand.ExecuteNonQuery();

                            string path = "/";
                            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path + "/" + FName);
                            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
                            ftpRequest.EnableSsl = _UseSSL;
                            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                            ftpResponse.Close();
                            MyConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void редактироватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Bookid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditBookForm f = new EditBookForm();
            f.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string bookid;
            string bookname;
            try
            {
                bookid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bookname = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                Properties.Settings.Default.BookName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = MyConnection.CreateCommand();

                MyConnection.Open();

                MyCommand.CommandText = "SELECT bookway FROM BookLocation WHERE idBookLocation ='" + bookid + "'";

                using (MySqlDataReader reader = MyCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FName = reader.GetFieldValue<string>(0);
                        Properties.Settings.Default.BookFName = reader.GetFieldValue<string>(0);

                        Properties.Settings.Default.BookFName = FName;
                        Properties.Settings.Default.BookName = bookname;

                        try
                        {
                            string path;
                            path = "/";
                            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path + "/" + FName);

                            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
                            //команда фтп RETR
                            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                            ftpRequest.EnableSsl = _UseSSL;
                            //Файлы будут копироваться в кталог программы
                            FileStream downloadedFile = new FileStream(FName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                            //Получаем входящий поток
                            Stream responseStream = ftpResponse.GetResponseStream();
                            //Буфер для считываемых данных
                            byte[] buffer = new byte[1024];
                            int size = 0;

                            while ((size = responseStream.Read(buffer, 0, 1024)) > 0)
                            {
                                downloadedFile.Write(buffer, 0, size);
                            }
                            ftpResponse.Close();
                            downloadedFile.Close();
                            responseStream.Close();
                            MyConnection.Close();
                            try
                            {
                                var command = MyConnection.CreateCommand();
                                command.CommandText = "INSERT INTO UserOpenBook" + " (idПользователя,idКниги,НазваниеКниги,ИмяКниги) VALUES (@idUser,@idBooks,@UserName,@BookName)";
                                MySqlParameter param = new MySqlParameter();
                                param.ParameterName = "@idUser";
                                param.Value = Properties.Settings.Default.UserLogId;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                param = new MySqlParameter();
                                param.ParameterName = "@idBooks";
                                param.Value = bookid;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                param = new MySqlParameter();
                                param.ParameterName = "@UserName";
                                param.Value = Properties.Settings.Default.UserName;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                param = new MySqlParameter();
                                param.ParameterName = "@BookName";
                                param.Value = bookname;
                                param.MySqlDbType = MySqlDbType.VarChar;
                                command.Parameters.Add(param);

                                MyConnection.Open();
                                command.ExecuteNonQuery();
                                MyConnection.Close();
                                Data.EventHanler(FName);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            this.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MyConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}