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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        int rowIndexNext = 1;
        int rowIndexPrev = -1;


        private void rastenieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rastenieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localDBDataSet);

        }

        private void rastenieBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rastenieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.Bolezni". При необходимости она может быть перемещена или удалена.
            this.bolezniTableAdapter.Fill(this.localDBDataSet.Bolezni);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.Resept". При необходимости она может быть перемещена или удалена.
            this.reseptTableAdapter.Fill(this.localDBDataSet.Resept);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localDBDataSet.Rastenie". При необходимости она может быть перемещена или удалена.
            this.rastenieTableAdapter.Fill(this.localDBDataSet.Rastenie);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rastenieId;
            rastenieId = this.rastenieDataGridView.RowCount;
            rastenieId = rastenieId - 1;
            try
            {
                if(rowIndexNext < rastenieId)
                {
                    rastenieDataGridView.CurrentCell = rastenieDataGridView.Rows[rowIndexNext++].Cells[0];

                    названиеTextBox.Text = rastenieDataGridView.CurrentRow.Cells[1].Value.ToString();
                    латиницаTextBox.Text = rastenieDataGridView.CurrentRow.Cells[2].Value.ToString();
                    местоПроизрастанияTextBox.Text = rastenieDataGridView.CurrentRow.Cells[3].Value.ToString();
                    составПолезныхВеществTextBox.Text = rastenieDataGridView.CurrentRow.Cells[4].Value.ToString();
                    храниеTextBox.Text = rastenieDataGridView.CurrentRow.Cells[5].Value.ToString();
                    приготовлениеTextBox.Text = rastenieDataGridView.CurrentRow.Cells[6].Value.ToString();
                    чтоЛечитTextBox.Text = rastenieDataGridView.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    rowIndexNext = 0;
                    rastenieDataGridView.CurrentCell = rastenieDataGridView.Rows[rowIndexNext++].Cells[0];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rastenieId;
            rastenieId = this.rastenieDataGridView.RowCount;
            rastenieId = rastenieId - 2;
            try
            {
                if (rowIndexPrev > -1)
                {
                    rastenieDataGridView.CurrentCell = rastenieDataGridView.Rows[rowIndexPrev--].Cells[0];

                    названиеTextBox.Text = rastenieDataGridView.CurrentRow.Cells[1].Value.ToString();
                    латиницаTextBox.Text = rastenieDataGridView.CurrentRow.Cells[2].Value.ToString();
                    местоПроизрастанияTextBox.Text = rastenieDataGridView.CurrentRow.Cells[3].Value.ToString();
                    составПолезныхВеществTextBox.Text = rastenieDataGridView.CurrentRow.Cells[4].Value.ToString();
                    храниеTextBox.Text = rastenieDataGridView.CurrentRow.Cells[5].Value.ToString();
                    приготовлениеTextBox.Text = rastenieDataGridView.CurrentRow.Cells[6].Value.ToString();
                    чтоЛечитTextBox.Text = rastenieDataGridView.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    rowIndexPrev = rastenieId;
                    rastenieDataGridView.CurrentCell = rastenieDataGridView.Rows[rowIndexPrev--].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRastenie f = new AddRastenie();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vlad\Desktop\TEST\Spravochnik\Spravochnik\LocalDB.mdf;Integrated Security=True;User Instance=False;ConnectRetryCount=10;ConnectRetryInterval=2");
                    SqlCommand command = connect.CreateCommand();
                    SqlDataReader Dread;

                    string CurrentId = rastenieDataGridView.CurrentRow.Cells[0].Value.ToString();
                    MessageBox.Show(CurrentId);

                    connect.Open();
                    command.CommandText = "DELETE FROM rastenie where id='" + CurrentId + "'";
                    command.ExecuteNonQuery();
                    connect.Close();

                    int CurrentRow = rastenieDataGridView.SelectedCells[0].RowIndex;
                    rastenieDataGridView.Rows.RemoveAt(CurrentRow);
                }            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
