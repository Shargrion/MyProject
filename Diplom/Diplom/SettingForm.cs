using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.DataSourse;
            textBox2.Text = Properties.Settings.Default.DataBase;
            textBox3.Text = Properties.Settings.Default.UserLog;
            textBox4.Text = Properties.Settings.Default.UserPass;            
            textBox6.Text = Properties.Settings.Default.FTPuserlog;               
            textBox8.Text = Properties.Settings.Default.FTPuserpass;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Адрес сервера
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                Properties.Settings.Default.DataSourse = textBox1.Text;
            }            
            //Название базы данных
            if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                Properties.Settings.Default.DataBase = textBox2.Text;
            }           
            //логин и пароль для БД
            if (!String.IsNullOrWhiteSpace(textBox3.Text) && !String.IsNullOrWhiteSpace(textBox4.Text))
            {
                Properties.Settings.Default.UserLog = textBox3.Text;
                Properties.Settings.Default.UserPass = textBox4.Text;
            }
            //Логин и пароль для FTP сервера
            if (!String.IsNullOrWhiteSpace(textBox6.Text) && !String.IsNullOrWhiteSpace(textBox8.Text))
            {
                Properties.Settings.Default.FTPuserlog = textBox6.Text;
                Properties.Settings.Default.FTPuserpass = textBox8.Text;
            }
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
