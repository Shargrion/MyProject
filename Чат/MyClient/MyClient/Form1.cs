using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;
using System.Timers;
using System.Resources;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClient
{  
    public partial class Form1 : Form
    {
        static private Socket Client;
        private IPAddress ip = null;
        private int port = 0;
        private Thread th;

        public Form1()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();

            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;

            timer1.Interval = 200;
            timer1.Enabled = true;
            label5.ForeColor = Color.Red;

            timer2.Interval = 2800;
            timer2.Enabled = true;

            timer3.Interval = 1200;
            timer3.Enabled = true;

            string Host = System.Net.Dns.GetHostName();
            string IP = System.Net.Dns.GetHostByName(Host).AddressList[0].ToString();
            label6.Text = IP;

            string name = Environment.UserName;
            textBox1.Text = name;

                try
                {
                    var sr = new StreamReader(@"Client_info/Data_info.txt");
                    string buffer = sr.ReadToEnd();
                    sr.Close();
                    string[] connect_info = buffer.Split(':');
                    ip = IPAddress.Parse(connect_info[0]);
                    port = int.Parse(connect_info[1]);

                    label4.ForeColor = Color.Green;
                    label4.Text = "настройки: \n IP сервера:" + connect_info[0] + "\n Порт сервера:" + connect_info[1];

                }
                catch (Exception ex)
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "настройки не найдены!";
                    MessageBox.Show("Ошибка: " + ex.Message);
                    Form2 form = new Form2();
                    form.Show();
                }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        void SendMessage(string message)
        {
            if(message != " " && message != "")
            {
                byte[] buffer = new byte[1024];
                buffer = Encoding.UTF8.GetBytes(message);
                
                Client.Send(buffer);
            }
        }

     //   public static string Mesajcurrent = "Idle";

       protected void FileReceiver()
       {
           string name;

           name = textBox1.Text;
           //Создаем Listener на порт "по умолчанию"
           TcpListener Listen = new TcpListener(6999);
           Listen.Stop();
           //Начинаем прослушку
           Listen.Start();
           //и заведем заранее сокет
           Socket ReceiveSocket;
           while (true)
           {
               try
               {
                   //Пришло сообщение
                   ReceiveSocket = Listen.AcceptSocket();
                   Byte[] Receive = new Byte[1024];
                   //Читать сообщение в поток
                   using (MemoryStream MessageR = new MemoryStream())
                   {

                       //Количество считанных байт
                       Int32 ReceivedBytes;
                       Int32 Firest1024Bytes = 0;
                       String FilePath = "";
                       do
                       {// читаем
                           ReceivedBytes = ReceiveSocket.Receive(Receive, Receive.Length, 0);
                           //Разбираем первые 1024 байт
                           if (Firest1024Bytes < 1024)
                           {
                               Firest1024Bytes += ReceivedBytes;
                               Byte[] ToStr = Receive;
                               //проверка на то что не всегда они передаются сразу
                               if (Firest1024Bytes > 1024)
                               {
                                   Int32 Start = Firest1024Bytes - ReceivedBytes;
                                   Int32 CountToGet = 1024 - Start;
                                   Firest1024Bytes = 1024;
                                   //В случае если было принято >1024 байт (двумя сообщениями к примеру)
                                   //Остаток (до 1024) записываем в "путь файла"
                                   ToStr = Receive.Take(CountToGet).ToArray();
                                   //А остальную часть - в будующий файл
                                   Receive = Receive.Skip(CountToGet).ToArray();
                                   MessageR.Write(Receive, 0, ReceivedBytes);
                               }
                               //Накапливаем имя файла
                               FilePath += Encoding.Default.GetString(ToStr);
                           }
                           else
                               //и записываем в поток
                               MessageR.Write(Receive, 0, ReceivedBytes);
                           //Читаем до тех пор, пока в очереди не останется данных
                       } while (ReceivedBytes == Receive.Length);
                       //Убираем лишние байты
                       String resFilePath = FilePath.Substring(0, FilePath.IndexOf('\0'));
                       using (var File = new FileStream(resFilePath, FileMode.Create))
                       {//Записываем в файл
                           File.Write(MessageR.ToArray(), 0, MessageR.ToArray().Length);
                       }
                       SendMessage("\n " + name + ":" + "Файл отправляется" + ";;;5");
                   }
               }
               catch (System.Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
               SendMessage("\n " + name + ":" + "Файл отправлен" + ";;;5");
           }
       }
        void RecvMessadge()
        {
            byte[] buffer = new byte[1024];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = 0;
            }
            for (; ; )
            {
                try
                {
                    Client.Receive(buffer);
                    string message = Encoding.UTF8.GetString(buffer);
                    int count = message.IndexOf(";;;5");
                    if (count == -1)
                    {
                        continue;
                    }
                    string Clear_Message = "";

                    for (int i = 0; i < count; i++)
                    {
                        Clear_Message += message[i];
                    }

                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = 0;
                    }

                    this.Invoke((MethodInvoker)delegate()
                    {
                        richTextBox1.AppendText(Clear_Message);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Socket s = null;
            if (textBox1.Text != " " && textBox1.Text != " ")
            {
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                   if (s == null)
                {
                    Client.Connect(ip, port);
                    th = new Thread(delegate() { RecvMessadge(); });
   
                    th.Start();

                    richTextBox2.Focus(); 
          
                }
                   else
                   {
                       MessageBox.Show(Message.Messagetext, Message.title);
                   }
                   new Thread(new ThreadStart(FileReceiver)).Start();
                   button3.Enabled = true;
                   button2.Visible = false;
                   button1.Enabled = true;

                   richTextBox2.Enabled = true;
                   richTextBox1.Enabled = true;
         
            }
            textBox1.Visible = false;
            label1.Visible = false;
         }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Environment.UserName;
            string check = ";;;5";

            name = textBox1.Text;
            if (richTextBox2.Text != "")
            {
                if (richTextBox2.Text != check)
                {
                    SendMessage("\n " + name + ":" + richTextBox2.Text + ";;;5");
                }
                else
                {
                    label3.Text = "Ошибка введите сообщение";
                    label3.ForeColor = Color.Red;
                }
            }
            richTextBox2.Clear();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog(this);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(     MessageBox.Show("Вы действительно хотите выити из программы?", "Выход",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendMessage("\n" + textBox1.Text + ": " + richTextBox2.Text + ";;;5");
                richTextBox2.Clear();
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void настрокиКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog(this);
        }

        private void настрокиСервераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog(this);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label5.Text = dt.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = "Введите сообщение";
            label3.ForeColor = Color.Black;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog(this);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.Text.Length, 0);
            richTextBox1.ScrollToCaret();
        }
    }
}



