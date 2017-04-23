using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using System.Diagnostics;

namespace MyClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text != "" && textBox1.Text != "" && textBox1.Text != " " && textBox1.Text != " ")
                { 
                    try
                    {
                         DirectoryInfo Data = new DirectoryInfo("Client_info");
                         Data.Create();

                         var sw = new StreamWriter(@"Client_info/Data_info.txt");
                         sw.WriteLine(textBox2.Text + ":" + textBox1.Text);

                         sw.Close();

                         this.Hide();
                 
                         Application.Restart();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Ошибка: "+ex.Message);
                    }
                }
            }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  IP;
            string  port;
            IP = "127.0.0.1";
            port = "7770";
            textBox2.Text = IP;
            textBox1.Text = port;
            DirectoryInfo Data = new DirectoryInfo("Client_info");
            Data.Create();

            var sw = new StreamWriter(@"Client_info/Data_info.txt");
            sw.WriteLine(textBox2.Text + ":" + textBox1.Text);

            sw.Close();

            this.Hide();

            Process.Start("Server.exe");
            Application.Restart();
        }
       }   
}
