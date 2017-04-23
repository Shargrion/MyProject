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
    public partial class UserRoomForm : Form
    {
        public UserRoomForm()
        {
            InitializeComponent();
            label1.Text = "Вы     " + Properties.Settings.Default.UserName;
            if (Properties.Settings.Default.Add != 0)
            {
                CheckAdd.Checked = true;
            }
            else
            {
                CheckAdd.Checked = false;
            }
            if (Properties.Settings.Default.Delete != 0)
            {
                CheckDelete.Checked = true;
            }
            else
            {
                CheckDelete.Checked = false;
            }
            if (Properties.Settings.Default.Editing != 0)
            {
                CheckEdit.Checked = true;
            }
            else
            {
                CheckEdit.Checked = false;
            }
            if (Properties.Settings.Default.Eduser != 0)
            {
                CheckControl.Checked = true;
            }
            else
            {
                CheckControl.Checked = false;
            }
        }

        private void UserRoomForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idПользователя,idКниги,ИмяПользователя,НазваниеКниги FROM UserOpenBook WHERE ИмяПользователя LIKE '%" + textBox1.Text + "%'", MyConnection);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idПользователя,idКниги,ИмяПользователя,НазваниеКниги FROM UserOpenBook WHERE НазваниеКниги LIKE '%" + textBox1.Text + "%'", MyConnection);
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
    }
}
