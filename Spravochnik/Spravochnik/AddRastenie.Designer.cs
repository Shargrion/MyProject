namespace Spravochnik
{
    partial class AddRastenie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label латиницаLabel;
            System.Windows.Forms.Label местоПроизрастанияLabel;
            System.Windows.Forms.Label составПолезныхВеществLabel;
            System.Windows.Forms.Label храниеLabel;
            System.Windows.Forms.Label приготовлениеLabel;
            System.Windows.Forms.Label чтоЛечитLabel;
            this.localDBDataSet = new Spravochnik.LocalDBDataSet();
            this.rastenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rastenieTableAdapter = new Spravochnik.LocalDBDataSetTableAdapters.RastenieTableAdapter();
            this.tableAdapterManager = new Spravochnik.LocalDBDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            названиеLabel = new System.Windows.Forms.Label();
            латиницаLabel = new System.Windows.Forms.Label();
            местоПроизрастанияLabel = new System.Windows.Forms.Label();
            составПолезныхВеществLabel = new System.Windows.Forms.Label();
            храниеLabel = new System.Windows.Forms.Label();
            приготовлениеLabel = new System.Windows.Forms.Label();
            чтоЛечитLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rastenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "LocalDBDataSet";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rastenieBindingSource
            // 
            this.rastenieBindingSource.DataMember = "Rastenie";
            this.rastenieBindingSource.DataSource = this.localDBDataSet;
            // 
            // rastenieTableAdapter
            // 
            this.rastenieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BolezniTableAdapter = null;
            this.tableAdapterManager.RastenieTableAdapter = this.rastenieTableAdapter;
            this.tableAdapterManager.ReseptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Spravochnik.LocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(481, 47);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(481, 79);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(481, 105);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(481, 134);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(481, 159);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(481, 192);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 16;
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(385, 19);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(57, 13);
            названиеLabel.TabIndex = 20;
            названиеLabel.Text = "Название";
            // 
            // латиницаLabel
            // 
            латиницаLabel.AutoSize = true;
            латиницаLabel.Location = new System.Drawing.Point(385, 50);
            латиницаLabel.Name = "латиницаLabel";
            латиницаLabel.Size = new System.Drawing.Size(56, 13);
            латиницаLabel.TabIndex = 21;
            латиницаLabel.Text = "Латиница";
            // 
            // местоПроизрастанияLabel
            // 
            местоПроизрастанияLabel.AutoSize = true;
            местоПроизрастанияLabel.Location = new System.Drawing.Point(354, 82);
            местоПроизрастанияLabel.Name = "местоПроизрастанияLabel";
            местоПроизрастанияLabel.Size = new System.Drawing.Size(121, 13);
            местоПроизрастанияLabel.TabIndex = 22;
            местоПроизрастанияLabel.Text = "Место Произрастания";
            // 
            // составПолезныхВеществLabel
            // 
            составПолезныхВеществLabel.AutoSize = true;
            составПолезныхВеществLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            составПолезныхВеществLabel.Location = new System.Drawing.Point(327, 108);
            составПолезныхВеществLabel.Name = "составПолезныхВеществLabel";
            составПолезныхВеществLabel.Size = new System.Drawing.Size(148, 13);
            составПолезныхВеществLabel.TabIndex = 23;
            составПолезныхВеществLabel.Text = "Состав Полезных Веществ:";
            составПолезныхВеществLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // храниеLabel
            // 
            храниеLabel.Location = new System.Drawing.Point(393, 137);
            храниеLabel.Name = "храниеLabel";
            храниеLabel.Size = new System.Drawing.Size(82, 13);
            храниеLabel.TabIndex = 24;
            храниеLabel.Text = "Храние";
            храниеLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // приготовлениеLabel
            // 
            приготовлениеLabel.Location = new System.Drawing.Point(385, 162);
            приготовлениеLabel.Name = "приготовлениеLabel";
            приготовлениеLabel.Size = new System.Drawing.Size(88, 13);
            приготовлениеLabel.TabIndex = 25;
            приготовлениеLabel.Text = "Приготовление";
            приготовлениеLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // чтоЛечитLabel
            // 
            чтоЛечитLabel.Location = new System.Drawing.Point(413, 199);
            чтоЛечитLabel.Name = "чтоЛечитLabel";
            чтоЛечитLabel.Size = new System.Drawing.Size(62, 13);
            чтоЛечитLabel.TabIndex = 26;
            чтоЛечитLabel.Text = "Что Лечит";
            чтоЛечитLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddRastenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(латиницаLabel);
            this.Controls.Add(местоПроизрастанияLabel);
            this.Controls.Add(составПолезныхВеществLabel);
            this.Controls.Add(храниеLabel);
            this.Controls.Add(приготовлениеLabel);
            this.Controls.Add(чтоЛечитLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddRastenie";
            this.Text = "AddRastenie";
            this.Load += new System.EventHandler(this.AddRastenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rastenieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalDBDataSet localDBDataSet;
        private System.Windows.Forms.BindingSource rastenieBindingSource;
        private LocalDBDataSetTableAdapters.RastenieTableAdapter rastenieTableAdapter;
        private LocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}