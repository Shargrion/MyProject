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
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string Connect = "Database=" + Properties.Settings.Default.DataBase + ";Data Source=" + Properties.Settings.Default.DataSourse + ";User Id=" + Properties.Settings.Default.UserLog + ";Password= " + Properties.Settings.Default.UserPass;
                    MySqlConnection MyConnection = new MySqlConnection(Connect);
                    MySqlCommand MyCommand = MyConnection.CreateCommand();

                    MyCommand.CommandText = "UPDATE Books SET НазваниеКниги ='" + AddBookName.Text + "',Язык ='" + AddLan.Text + "',Жан ='" + AddBookGenre.Text + "',Автор ='" + AddBookAuthor.Text + "',ДатаВыпуска ='" + AddBookDate.Text + "',Описание ='" + AddBookDesc.Text + "'WHERE idКниги ='" + Properties.Settings.Default.Bookid + "'";
                    MyConnection.Open();
                    MyCommand.ExecuteNonQuery();
                    MyConnection.Close();               

                    MessageBox.Show("Книга успешно обновлена");
                       
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
