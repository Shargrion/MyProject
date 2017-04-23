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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(AddUserName.Text) && !String.IsNullOrWhiteSpace(AddLogin.Text) && !String.IsNullOrWhiteSpace(AddPass.Text))
                {
                    try
                    {                        
                        sbyte checkadd;
                        sbyte checkdelete;
                        sbyte checkedit;
                        sbyte checkcontrol;
                        string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
                        MySqlConnection MyConnection = new MySqlConnection(Connect);
                        MySqlCommand MyCommand = MyConnection.CreateCommand();


                        var command = MyConnection.CreateCommand();
                        command.CommandText = "INSERT INTO user" + " (ИмяПользователя,Логин,Пароль)  VALUES (@username,@login,@pass)";
                        MyConnection.Open();
                        MySqlParameter param = new MySqlParameter();
                        param.ParameterName = "@username";
                        param.Value = AddUserName.Text;
                        param.MySqlDbType = MySqlDbType.VarChar;
                        command.Parameters.Add(param);

                        param = new MySqlParameter();
                        param.ParameterName = "@login";
                        param.Value = AddLogin.Text;
                        param.MySqlDbType = MySqlDbType.VarChar;
                        command.Parameters.Add(param);

                        param = new MySqlParameter();
                        param.ParameterName = "@pass";
                        param.Value = AddPass.Text;
                        param.MySqlDbType = MySqlDbType.VarChar;
                        command.Parameters.Add(param);

                        command.ExecuteNonQuery();
                        MyConnection.Close();
                        command.CommandText = "INSERT INTO Userrights" + " (bookadd,bookdelete,bookedit,usercontrol)  VALUES (@bookadd,@bookdelete,@bookedit,@usercontrol)";
                        MyConnection.Open();
                        if(CheckAdd.Checked == true)
                        {
                            checkadd = 1;                     
                        }
                        else
                        {
                            checkadd = 0;
                        }
                        if (CheckDelete.Checked == true)
                        {
                            checkdelete = 1;
                        }
                        else
                        {
                            checkdelete = 0;                           
                        }
                        if (CheckEdit.Checked == true)
                        {
                            checkedit = 1;                            
                        }
                        else
                        {
                            checkedit = 0;                           
                        }
                        if (CheckControl.Checked == true)
                        {
                            checkcontrol = 1;
                        }
                        else
                        {
                            checkcontrol = 0;                       
                        }

                        MySqlParameter param1 = new MySqlParameter();
                        param1 = new MySqlParameter();
                        param1.ParameterName = "@bookadd";
                        param1.Value = checkadd;
                        param1.MySqlDbType = MySqlDbType.Byte;
                        command.Parameters.Add(param1);

                        param1 = new MySqlParameter();
                        param1.ParameterName = "@bookdelete";
                        param1.Value = checkdelete;
                        param1.MySqlDbType = MySqlDbType.Byte;
                        command.Parameters.Add(param1);

                        param1 = new MySqlParameter();
                        param1.ParameterName = "@bookedit";
                        param1.Value = checkedit;
                        param1.MySqlDbType = MySqlDbType.Byte;
                        command.Parameters.Add(param1);

                        param1 = new MySqlParameter();
                        param1.ParameterName = "@usercontrol";
                        param1.Value = checkcontrol;
                        param1.MySqlDbType = MySqlDbType.Byte;
                        command.Parameters.Add(param1);

                        command.ExecuteNonQuery();
                        MyConnection.Close();

                        MessageBox.Show("Новый пользователь успешно добавлен");
                        Close();
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Нобходимо заполнить все поля", " Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }        
}

