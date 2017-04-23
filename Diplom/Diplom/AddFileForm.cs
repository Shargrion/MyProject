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
using System.Text.RegularExpressions;

namespace Diplom
{
    public partial class AddFileForm : Form
    {
        public AddFileForm()
        {
            InitializeComponent();
            label1.Visible = false;
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
        
        private void button1_Click(object sender, EventArgs e)
        {
          //  var newdialog = new OpenFileDialog();
            openFileDialog1.Filter = "Текстовые файлы (*.txt;)|*.txt|Не совсем текстовые файлы (*.fb2;*.rtf)|*.fb2;*.rtf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
              if (openFileDialog1.ShowDialog() == DialogResult.OK)
              {
                  try 
                  {
                      label1.Text = openFileDialog1.SafeFileName;
                      textBox1.Text = openFileDialog1.FileName;
                  }
                  catch
                  {

                  }
              }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(AddBookName.Text) && !String.IsNullOrWhiteSpace(AddLan.Text) && !String.IsNullOrWhiteSpace(AddBookGenre.Text) && !String.IsNullOrWhiteSpace(AddBookAuthor.Text) && !String.IsNullOrWhiteSpace(AddBookDate.Text) && !String.IsNullOrWhiteSpace(AddBookDesc.Text))
            {
                try
                {
                    string filename = String.Format(@"{0}.mydb", System.Guid.NewGuid());

                    string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;

                    MySqlConnection MyConnection = new MySqlConnection(Connect);
                    MySqlCommand MyCommand = new MySqlCommand();
                    MyConnection.Open();

                    var command = MyConnection.CreateCommand();
                    command.CommandText = "INSERT INTO Books" + "(НазваниеКниги,Язык,Жан,Автор,ДатаВыпуска,Описание) VALUES (@NameBook,@BookLan,@BookGenre,@BookAuthor,@BookData,@BookDesc)";

                    MySqlParameter param = new MySqlParameter();
                    param.ParameterName = "@NameBook";
                    param.Value = AddBookName.Text;
                    param.MySqlDbType = MySqlDbType.VarChar;
                    command.Parameters.Add(param);

                    param = new MySqlParameter();
                    param.ParameterName = "@BookLan";
                    param.Value = AddLan.Text;
                    param.MySqlDbType = MySqlDbType.VarChar;
                    command.Parameters.Add(param);

                    param = new MySqlParameter();
                    param.ParameterName = "@BookGenre";
                    param.Value = AddBookGenre.Text;
                    param.MySqlDbType = MySqlDbType.VarChar;
                    command.Parameters.Add(param);

                    param = new MySqlParameter();
                    param.ParameterName = "@BookAuthor";
                    param.Value = AddBookAuthor.Text;
                    param.MySqlDbType = MySqlDbType.VarChar;
                    command.Parameters.Add(param);

                    param = new MySqlParameter();
                    param.ParameterName = "@BookData";
                    param.Value = AddBookDate.Text;
                    param.MySqlDbType = MySqlDbType.VarChar;
                    command.Parameters.Add(param);

                    param = new MySqlParameter();
                    param.ParameterName = "@BookDesc";
                    param.Value = AddBookDesc.Text;
                    param.MySqlDbType = MySqlDbType.VarChar;
                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO booklocation" + " (bookway)  VALUES (@bookway)";

                    MySqlParameter param1 = new MySqlParameter();
                    param1.ParameterName = "@bookway";
                    param1.Value = filename;
                    param1.MySqlDbType = MySqlDbType.VarChar;
                    command.Parameters.Add(param1);

                    command.ExecuteNonQuery();
                    try
                    {

                        //  для имени файла
                        string path;
                        path = "/";
                        FileStream uploadedFile = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                        ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path + "/" + filename);
                        ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
                        ftpRequest.EnableSsl = _UseSSL;
                        ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

                        // Буфер для загружаемых данных
                        byte[] file_to_bytes = new byte[uploadedFile.Length];
                        // Считываем данные в буфер
                        uploadedFile.Read(file_to_bytes, 0, file_to_bytes.Length);

                        uploadedFile.Close();

                        //Поток для загрузки файла
                        Stream writer = ftpRequest.GetRequestStream();

                        writer.Write(file_to_bytes, 0, file_to_bytes.Length);
                        writer.Close();

                        MessageBox.Show("Новая книга успешно добавлена");
                        MyConnection.Close();
                        Close();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Плоля данных не могут быть пустыми ");
            }                  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddFileForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddBookAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddBookGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
