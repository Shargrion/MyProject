using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spravochnik
{
    public partial class AddRastenie : Form
    {
        public AddRastenie()
        {
            InitializeComponent();
        }

        private void rastenieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rastenieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localDBDataSet);

        }

        private void AddRastenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.Rastenie". При необходимости она может быть перемещена или удалена.
            this.rastenieTableAdapter.Fill(this.localDBDataSet.Rastenie);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vlad\Desktop\TEST\Spravochnik\Spravochnik\LocalDB.mdf;Integrated Security=True;User Instance=False;ConnectRetryCount=10;ConnectRetryInterval=2");
                SqlCommand command = connect.CreateCommand();
                SqlDataReader Dread;

                //   command.CommandText = "UPDATE Books SET Название ='" + textBox1.Text + "',Латиница ='" + AddLan.Text + "',МестоПроизростания ='" + AddBookGenre.Text + "',СоставПолезныхВеществ ='" + AddBookAuthor.Text + "',Хранение ='" + AddBookDate.Text + "',Приготовление ='" + AddBookDesc.Text + "'WHERE idКниги ='" + Properties.Settings.Default.Bookid + "'";
                command.CommandText = "INSERT INTO rastenie" + " (Название,Латиница,МестоПроизрастания,СоставПолезныхВеществ,Храние,Приготовление,ЧтоЛечит) VALUES (@Название,@Латиница,@МестоПроизрастания,@СоставПолезныхВеществ,@Храние,@Приготовление,@ЧтоЛечит)";
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Название";
                param.Value = textBox1.Text;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Латиница";
                param.Value = textBox2.Text;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@МестоПроизрастания";
                param.Value = textBox3.Text;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@СоставПолезныхВеществ";
                param.Value = textBox4.Text;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Храние";
                param.Value = textBox5.Text;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Приготовление";
                param.Value = textBox6.Text;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ЧтоЛечит";
                param.Value = textBox7.Text;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                this.Close();
            }
          
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
