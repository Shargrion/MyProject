using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Resources;
using System.Reflection;
using MySql.Data.MySqlClient;


namespace Diplom
{
    public partial class MainForm : Form
    { 
       

        public MainForm()
        {
            InitializeComponent();
            Data.EventHanler = new Data.MyEvent(func);
            Data.EventHanler1 = new Data.MyEvent(meth);
            if (Properties.Settings.Default.Eduser == 0)
            {
                настрокаПользователейToolStripMenuItem.Enabled = false;
            }
            else
            {
                настрокаПользователейToolStripMenuItem.Enabled = true;
            }
            if (Properties.Settings.Default.UserName == "")
            {
                каталогКнигToolStripMenuItem.Enabled = false;
                пользовательToolStripMenuItem.Visible = false;
            }
            else
            {
                каталогКнигToolStripMenuItem.Enabled = true;
            }
            сменитьПользователяToolStripMenuItem.Visible = false;
        }

        public void meth(string param)
        {
            try
            {
                if (Properties.Settings.Default.Eduser == 0)
                {
                    настрокаПользователейToolStripMenuItem.Enabled = false;
                }
                else
                {
                    настрокаПользователейToolStripMenuItem.Enabled = true;
                }
                if (Properties.Settings.Default.UserName == "")
                {
                    каталогКнигToolStripMenuItem.Enabled = false;
                }
                else
                {
                    пользовательToolStripMenuItem.Text = "Пользователь " + Properties.Settings.Default.UserName;
                    пользовательToolStripMenuItem.Visible = true;
                    входToolStripMenuItem.Visible = false;
                    каталогКнигToolStripMenuItem.Enabled = true;
                }
                насройкаПодключенияToolStripMenuItem.Enabled = false;
                сменитьПользователяToolStripMenuItem.Visible = true;
            }
            catch
            {
                MessageBox.Show(" Ошибка просто ошибка", " Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void func(string param)
        {
            string fullpath;
            string path;

            path = "\\";
            fullpath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + path + Properties.Settings.Default.BookFName;
            try
            {
           // создает новую вкладку в TabControl;
                TabPage new1 = new TabPage(Properties.Settings.Default.BookName);
                RichTextBox newtab = new RichTextBox();
                newtab.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(new1);
                new1.Controls.Add(newtab);
                tabControl1.SelectedTab = new1;

                newtab.ReadOnly = true;
                newtab.ForeColor = Color.Black;
              
                System.IO.StreamReader streamReader;
                streamReader = new System.IO.StreamReader(fullpath, Encoding.Default);
                newtab.Text = streamReader.ReadToEnd();
                streamReader.Close();

                System.IO.File.Delete(fullpath);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
      {
      }


        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show(" Ошибка при закрытии программы", " Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            catch
            {
                MessageBox.Show(" Ошибка при закрытии вкладки обратитесь к всевышнему", " Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void закрытьВсеВкладкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControl1.TabPages.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void настройкиШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog newtextdialog = new FontDialog();
                if (newtextdialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.myfont = newtextdialog.Font;
                    Properties.Settings.Default.Save();
                    tabControl1.SelectedTab.Font = Properties.Settings.Default.myfont;
                    tabControl1.SelectedTab.Refresh();
                    tabControl1.Refresh();
                }
            }
            catch
            {
                MessageBox.Show(" Ошибка при открытии настроек шрифтов", " Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void настрокаПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUserForm f = new OpenUserForm();
            f.ShowDialog();
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {            
        }

        private void открытьКнигуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {          

        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegForm f = new RegForm();
                f.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void каталогКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileForm f = new OpenFileForm();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void насройкаПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm f = new SettingForm();
            f.ShowDialog();
        }

        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRoomForm f = new UserRoomForm();
            f.ShowDialog();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Eduser = 0;
            каталогКнигToolStripMenuItem.Enabled = false;
            настрокаПользователейToolStripMenuItem.Enabled = false;
            пользовательToolStripMenuItem.Visible = false;
            сменитьПользователяToolStripMenuItem.Visible = false;
            входToolStripMenuItem.Visible = true;
            насройкаПодключенияToolStripMenuItem.Enabled = true;

            RegForm f = new RegForm();
            f.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Текстовые файлы (*.txt;)|*.txt|Не совсем текстовые файлы (*.fb2;*.rtf)|*.fb2;*.rtf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    try
                    {
                        // создает новую вкладку в TabControl;
                        TabPage new1 = new TabPage(openFileDialog1.SafeFileName);
                        RichTextBox newtab = new RichTextBox();
                        newtab.Dock = DockStyle.Fill;
                        tabControl1.TabPages.Add(new1);
                        new1.Controls.Add(newtab);
                        tabControl1.SelectedTab = new1;

                        newtab.ReadOnly = true;
                        newtab.ForeColor = Color.Black;

                        System.IO.StreamReader streamReader;
                        streamReader = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);
                        newtab.Text = streamReader.ReadToEnd();
                        streamReader.Close();                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }
    }
}