using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;

namespace MyClient
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
    
        }   

        private void button1_Click(object sender, EventArgs e)
        {//Отправляем файл
            //Добавим на форму OpenFileDialog и вызовем его
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Коннектимся
                IPEndPoint EndPoint = new IPEndPoint(IPAddress.Parse(textBox2.Text), 6999);
                Socket Connector = new Socket(EndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                Connector.Connect(EndPoint);
                //Получаем имя из полного пути к файлу
                StringBuilder FileName = new StringBuilder(openFileDialog1.FileName);
                //Выделяем имя файла
                int index = FileName.Length - 1;
                while (FileName[index] != '\\' && FileName[index] != '/')
                {
                    index--;
                }
                //Получаем имя файла
                String resFileName = "";
                for (int i = index + 1; i < FileName.Length; i++)
                    resFileName += FileName[i];
                //Записываем в лист
                List<Byte> First256Bytes = Encoding.Default.GetBytes(resFileName).ToList();
                Int32 Diff = 1024 - First256Bytes.Count;
                //Остаток заполняем нулями
                for (int i = 0; i < Diff; i++)
                    First256Bytes.Add(0);
                //Начинаем отправку данных
                Byte[] ReadedBytes = new Byte[1024];
                using (var FileStream = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    using (var Reader = new BinaryReader(FileStream))
                    {
                        Int32 CurrentReadedBytesCount;
                        //Вначале отправим название файла
                        Connector.Send(First256Bytes.ToArray());
                        do
                        {
                            //Затем по частям - файл
                            CurrentReadedBytesCount = Reader.Read(ReadedBytes, 0, ReadedBytes.Length);
                            Connector.Send(ReadedBytes, CurrentReadedBytesCount, SocketFlags.None);
                        }
                        while (CurrentReadedBytesCount == ReadedBytes.Length);
                    }
                }
                //Завершаем передачу данных
                Connector.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
