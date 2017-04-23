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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Enabled = true;                  
            //217.20.190.105
            //178.136.129.214
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= "+Properties.Settings.Default.UserPass;
                MySqlConnection myConnection = new MySqlConnection(Connect);
                myConnection.Open(); 
                label5.ForeColor = Color.Green;
                label5.Text = "Сервер Доступен";
                myConnection.Close();
            }
            catch
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Сервер недоступен";
            }
        }


        private void RegForm_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                string username;
                string log;
                string password;
                SByte Add, Delete, Edit, UserControl;
                username = "0";

                log = Login.Text;
                password = Pass.Text;
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password="+Properties.Settings.Default.UserPass;
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = MyConnection.CreateCommand();
                MyConnection.Open();

                MyCommand.CommandText = "SELECT idПользователя,ИмяПользователя FROM user WHERE Логин ='" + log + "'and Пароль ='" + password + "'";

                using (MySqlDataReader reader = MyCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetFieldValue<int>(0);
                        Properties.Settings.Default.UserName = reader.GetFieldValue<string>(1);
                        Properties.Settings.Default.UserLogId = id;

                        MyConnection.Close(); 
                        try
                        {
                            MyCommand.CommandText = "SELECT bookadd,bookdelete,bookedit,usercontrol FROM UserRights WHERE idUserRights = '" + id + "'";
                            MyConnection.Open();

                            using (MySqlDataReader reader1 = MyCommand.ExecuteReader())
                            {  
                                if (reader1.Read())
                                {
                                    Add = reader1.GetFieldValue<SByte>(0);
                                    Delete = reader1.GetFieldValue<SByte>(1);
                                    Edit = reader1.GetFieldValue<SByte>(2);
                                    UserControl = reader1.GetFieldValue<SByte>(3);

                                    Properties.Settings.Default.Add = Add;
                                    Properties.Settings.Default.Delete = Delete;
                                    Properties.Settings.Default.Editing = Edit;
                                    Properties.Settings.Default.Eduser = UserControl;

                                    MessageBox.Show("Добро пожаловать "+Properties.Settings.Default.UserName);
                                    Data.EventHanler1(username);

                                    MyConnection.Close();
                                    Close();

                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        groupBox1.Text = "Неверный логин или пароль";
                        groupBox1.ForeColor = Color.Red;
                    }
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            groupBox1.Text = " Введите логин и пароль";
            groupBox1.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
    
}
