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
    public partial class UserLogForm : Form
    {
        public UserLogForm()
        {
            InitializeComponent();
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


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT idПользователя,idКниги,Имяпользователя,НазваниеКниги FROM UserOpenBook", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();
                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void UserLogForm_Shown(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();

                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT  idПользователя,idКниги,ИмяПользователя,НазваниеКниги FROM UserOpenBook", MyConnection);
                dataAdapter.Fill(setdata, "user");
                dataGridView1.DataSource = setdata.Tables["user"];
                MyConnection.Close();
                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
 
                MySqlConnection MyConnection = new MySqlConnection(Connect);
                MySqlCommand MyCommand = new MySqlCommand();

                MyConnection.Open();
                DataSet setdata = new DataSet();


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT  idПользователя,idКниги,ИмяПользователя,НазваниеКниги FROM UserOpenBook WHERE ИмяПользователя LIKE '%" + textBox2.Text + "%'", MyConnection);
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

        private void UserLogForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
