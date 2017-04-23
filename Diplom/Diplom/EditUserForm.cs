using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diplom
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            sbyte checkadd = 0;
            sbyte checkdelete = 0;
            sbyte checkedit = 0;
            sbyte checkcontrol = 0;

            try
            {
                string Connect = "Database=mydb;Data Source=sorok.pp.ua;User Id=root;Password=";
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = MyConnection.CreateCommand();



                MyCommand.CommandText = "SELECT ИмяПользователя,Логин,Пароль FROM User WHERE idПользователя ='" + Properties.Settings.Default.UserId + "'";
                MyConnection.Open();
                using (MySqlDataReader reader = MyCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label4.Text = reader.GetFieldValue<string>(0);
                        label5.Text = reader.GetFieldValue<string>(1);
                        label6.Text = reader.GetFieldValue<string>(2);
                        MyConnection.Close();

                        try
                        {
                            MyCommand.CommandText = "SELECT bookadd,bookdelete,bookedit,usercontrol FROM UserRights WHERE idUserRights ='" + Properties.Settings.Default.UserId + "'";
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
            if (!String.IsNullOrWhiteSpace(UserName.Text) && !String.IsNullOrWhiteSpace(Login.Text) && !String.IsNullOrWhiteSpace(Pass.Text))
            {
                try
                {
                    sbyte checkadd = 0;
                    sbyte checkdelete = 0;
                    sbyte checkedit = 0;
                    sbyte checkcontrol = 0;


                    string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
                    MySqlConnection MyConnection = new MySqlConnection(Connect);
                    MySqlCommand MyCommand = new MySqlCommand();
                    MyConnection.Open();

                    var command = MyConnection.CreateCommand();
                    command.CommandText = "UPDATE User SET ИмяПользователя='" + UserName.Text + "',Логин ='" + Login.Text + "',Пароль ='" + Pass.Text + "' WHERE idПользователя ='" + Properties.Settings.Default.UserId +"'";

                    command.ExecuteNonQuery();
                    MyConnection.Close();

                    if (CheckAdd.Checked == true)
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

                    command.CommandText = "UPDATE UserRights SET bookadd='" + checkadd + "',bookdelete ='" + checkdelete + "',bookedit ='" + checkedit + "',usercontrol =" + checkcontrol + " WHERE iduserrights =" + Properties.Settings.Default.UserId;
                    MyConnection.Open();


                    MessageBox.Show("Пользователь успешно обновлен");
                    command.ExecuteNonQuery();
                    MyConnection.Close();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
