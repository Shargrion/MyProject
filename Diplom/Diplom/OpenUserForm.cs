using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Diplom
{
    public partial class OpenUserForm : Form
    {
        public OpenUserForm()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Enabled = true;
        }
                   

        private void OpenForm_Load(object sender, EventArgs e)        
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM user", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];

                MyConnection.Close();
            }
            catch
            {
                this.Close();
                MessageBox.Show(" Ошибка, не удалось установить подключение к серверу обратитесь к всевышнему", " Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
           

        private void button2_Click(object sender, EventArgs e)
        {
            AddUserForm f = new AddUserForm();
            f.ShowDialog();
        }

        private void OpenForm_Activated(object sender, EventArgs e)
        {            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            string userid;
            try
            {
                userid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = MyConnection.CreateCommand();

                MyConnection.Open();
                        try
                        {

                            MyCommand.CommandText = "DELETE FROM user WHERE idПользователя =" + userid;                         

                            MyCommand.ExecuteNonQuery();                                                        
                            MyConnection.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }                                                                  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);          
            }        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditUserForm f = new EditUserForm();
            f.ShowDialog();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string userid;
            sbyte checkadd = 0;
            sbyte checkdelete = 0;
            sbyte checkedit = 0;
            sbyte checkcontrol = 0;

            userid = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = MyConnection.CreateCommand();



                MyCommand.CommandText = "SELECT ИмяПользователя,Логин,Пароль FROM User WHERE idПользователя ='" + userid + "'";
                MyConnection.Open();
                using (MySqlDataReader reader = MyCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserName.Text = reader.GetFieldValue<string>(0);
                        Login.Text = reader.GetFieldValue<string>(1);
                        Pass.Text = reader.GetFieldValue<string>(2);
                        MyConnection.Close();

                        try
                        {
                            MyCommand.CommandText = "SELECT bookadd,bookdelete,bookedit,usercontrol FROM UserRights WHERE idUserRights ='" + userid + "'";
                            MyConnection.Open();
                            using (MySqlDataReader reader1 = MyCommand.ExecuteReader())
                            {
                                if (reader1.Read())
                                {
                                    checkadd = reader1.GetFieldValue<sbyte>(0);
                                    checkdelete = reader1.GetFieldValue<sbyte>(1);
                                    checkedit = reader1.GetFieldValue<sbyte>(2);
                                    checkcontrol = reader1.GetFieldValue<sbyte>(3);
                                    if (checkadd != 0)
                                    {
                                        CheckAdd.Checked = true;
                                    }
                                    else
                                    {
                                        CheckAdd.Checked = false;
                                    }
                                    if (checkdelete != 0)
                                    {
                                        CheckDelete.Checked = true;
                                    }
                                    else
                                    {
                                        CheckDelete.Checked = false;
                                    }
                                    if (checkedit != 0)
                                    {
                                        CheckEdit.Checked = true;
                                    }
                                    else
                                    {
                                        CheckEdit.Checked = false;
                                    }
                                    if (checkcontrol != 0)
                                    {
                                        CheckControl.Checked = true;
                                    }
                                    else
                                    {
                                        CheckControl.Checked = false;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM user", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];

                MyConnection.Close();
            }
            catch
            {
                this.Close();
                MessageBox.Show(" Ошибка, не удалось установить подключение к серверу обратитесь к всевышнему", " Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserLogForm f = new UserLogForm();
            f.ShowDialog();
        }                
    }   
}

