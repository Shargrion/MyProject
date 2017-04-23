namespace Spravochnik
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rastenieDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.латиницаTextBox = new System.Windows.Forms.TextBox();
            this.местоПроизрастанияTextBox = new System.Windows.Forms.TextBox();
            this.составПолезныхВеществTextBox = new System.Windows.Forms.TextBox();
            this.храниеTextBox = new System.Windows.Forms.TextBox();
            this.приготовлениеTextBox = new System.Windows.Forms.TextBox();
            this.чтоЛечитTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rastenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localDBDataSet = new Spravochnik.LocalDBDataSet();
            this.rastenieTableAdapter = new Spravochnik.LocalDBDataSetTableAdapters.RastenieTableAdapter();
            this.tableAdapterManager = new Spravochnik.LocalDBDataSetTableAdapters.TableAdapterManager();
            this.bolezniTableAdapter = new Spravochnik.LocalDBDataSetTableAdapters.BolezniTableAdapter();
            this.reseptTableAdapter = new Spravochnik.LocalDBDataSetTableAdapters.ReseptTableAdapter();
            this.reseptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolezniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            названиеLabel = new System.Windows.Forms.Label();
            латиницаLabel = new System.Windows.Forms.Label();
            местоПроизрастанияLabel = new System.Windows.Forms.Label();
            составПолезныхВеществLabel = new System.Windows.Forms.Label();
            храниеLabel = new System.Windows.Forms.Label();
            приготовлениеLabel = new System.Windows.Forms.Label();
            чтоЛечитLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rastenieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rastenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reseptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolezniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(429, 5);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(57, 13);
            названиеLabel.TabIndex = 7;
            названиеLabel.Text = "Название";
            // 
            // латиницаLabel
            // 
            латиницаLabel.AutoSize = true;
            латиницаLabel.Location = new System.Drawing.Point(429, 31);
            латиницаLabel.Name = "латиницаLabel";
            латиницаLabel.Size = new System.Drawing.Size(56, 13);
            латиницаLabel.TabIndex = 9;
            латиницаLabel.Text = "Латиница";
            // 
            // местоПроизрастанияLabel
            // 
            местоПроизрастанияLabel.AutoSize = true;
            местоПроизрастанияLabel.Location = new System.Drawing.Point(429, 57);
            местоПроизрастанияLabel.Name = "местоПроизрастанияLabel";
            местоПроизрастанияLabel.Size = new System.Drawing.Size(121, 13);
            местоПроизрастанияLabel.TabIndex = 11;
            местоПроизрастанияLabel.Text = "Место Произрастания";
            // 
            // составПолезныхВеществLabel
            // 
            составПолезныхВеществLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            составПолезныхВеществLabel.Location = new System.Drawing.Point(20, 146);
            составПолезныхВеществLabel.Name = "составПолезныхВеществLabel";
            составПолезныхВеществLabel.Size = new System.Drawing.Size(97, 48);
            составПолезныхВеществLabel.TabIndex = 13;
            составПолезныхВеществLabel.Text = "Состав Полезных Веществ:";
            составПолезныхВеществLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // храниеLabel
            // 
            храниеLabel.Location = new System.Drawing.Point(23, 215);
            храниеLabel.Name = "храниеLabel";
            храниеLabel.Size = new System.Drawing.Size(82, 13);
            храниеLabel.TabIndex = 15;
            храниеLabel.Text = "Храние";
            храниеLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // приготовлениеLabel
            // 
            приготовлениеLabel.Location = new System.Drawing.Point(28, 284);
            приготовлениеLabel.Name = "приготовлениеLabel";
            приготовлениеLabel.Size = new System.Drawing.Size(88, 13);
            приготовлениеLabel.TabIndex = 17;
            приготовлениеLabel.Text = "Приготовление";
            приготовлениеLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // чтоЛечитLabel
            // 
            чтоЛечитLabel.Location = new System.Drawing.Point(28, 353);
            чтоЛечитLabel.Name = "чтоЛечитLabel";
            чтоЛечитLabel.Size = new System.Drawing.Size(62, 13);
            чтоЛечитLabel.TabIndex = 19;
            чтоЛечитLabel.Text = "Что Лечит";
            чтоЛечитLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.rastenieDataGridView);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(названиеLabel);
            this.tabPage1.Controls.Add(this.названиеTextBox);
            this.tabPage1.Controls.Add(латиницаLabel);
            this.tabPage1.Controls.Add(this.латиницаTextBox);
            this.tabPage1.Controls.Add(местоПроизрастанияLabel);
            this.tabPage1.Controls.Add(this.местоПроизрастанияTextBox);
            this.tabPage1.Controls.Add(составПолезныхВеществLabel);
            this.tabPage1.Controls.Add(this.составПолезныхВеществTextBox);
            this.tabPage1.Controls.Add(храниеLabel);
            this.tabPage1.Controls.Add(this.храниеTextBox);
            this.tabPage1.Controls.Add(приготовлениеLabel);
            this.tabPage1.Controls.Add(this.приготовлениеTextBox);
            this.tabPage1.Controls.Add(чтоЛечитLabel);
            this.tabPage1.Controls.Add(this.чтоЛечитTextBox);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(692, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Растения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rastenieDataGridView
            // 
            this.rastenieDataGridView.AutoGenerateColumns = false;
            this.rastenieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rastenieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.rastenieDataGridView.DataSource = this.rastenieBindingSource;
            this.rastenieDataGridView.Location = new System.Drawing.Point(270, 8);
            this.rastenieDataGridView.Name = "rastenieDataGridView";
            this.rastenieDataGridView.Size = new System.Drawing.Size(138, 115);
            this.rastenieDataGridView.TabIndex = 21;
            this.rastenieDataGridView.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rastenieBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(555, 2);
            this.названиеTextBox.Multiline = true;
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(128, 20);
            this.названиеTextBox.TabIndex = 8;
            // 
            // латиницаTextBox
            // 
            this.латиницаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rastenieBindingSource, "Латиница", true));
            this.латиницаTextBox.Location = new System.Drawing.Point(555, 28);
            this.латиницаTextBox.Multiline = true;
            this.латиницаTextBox.Name = "латиницаTextBox";
            this.латиницаTextBox.Size = new System.Drawing.Size(128, 20);
            this.латиницаTextBox.TabIndex = 10;
            // 
            // местоПроизрастанияTextBox
            // 
            this.местоПроизрастанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rastenieBindingSource, "МестоПроизрастания", true));
            this.местоПроизрастанияTextBox.Location = new System.Drawing.Point(555, 54);
            this.местоПроизрастанияTextBox.Multiline = true;
            this.местоПроизрастанияTextBox.Name = "местоПроизрастанияTextBox";
            this.местоПроизрастанияTextBox.Size = new System.Drawing.Size(128, 20);
            this.местоПроизрастанияTextBox.TabIndex = 12;
            // 
            // составПолезныхВеществTextBox
            // 
            this.составПолезныхВеществTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rastenieBindingSource, "СоставПолезныхВеществ", true));
            this.составПолезныхВеществTextBox.Location = new System.Drawing.Point(123, 143);
            this.составПолезныхВеществTextBox.Multiline = true;
            this.составПолезныхВеществTextBox.Name = "составПолезныхВеществTextBox";
            this.составПолезныхВеществTextBox.Size = new System.Drawing.Size(557, 63);
            this.составПолезныхВеществTextBox.TabIndex = 14;
            // 
            // храниеTextBox
            // 
            this.храниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rastenieBindingSource, "Храние", true));
            this.храниеTextBox.Location = new System.Drawing.Point(123, 212);
            this.храниеTextBox.Multiline = true;
            this.храниеTextBox.Name = "храниеTextBox";
            this.храниеTextBox.Size = new System.Drawing.Size(557, 63);
            this.храниеTextBox.TabIndex = 16;
            // 
            // приготовлениеTextBox
            // 
            this.приготовлениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rastenieBindingSource, "Приготовление", true));
            this.приготовлениеTextBox.Location = new System.Drawing.Point(123, 281);
            this.приготовлениеTextBox.Multiline = true;
            this.приготовлениеTextBox.Name = "приготовлениеTextBox";
            this.приготовлениеTextBox.Size = new System.Drawing.Size(557, 63);
            this.приготовлениеTextBox.TabIndex = 18;
            // 
            // чтоЛечитTextBox
            // 
            this.чтоЛечитTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rastenieBindingSource, "ЧтоЛечит", true));
            this.чтоЛечитTextBox.Location = new System.Drawing.Point(123, 350);
            this.чтоЛечитTextBox.Multiline = true;
            this.чтоЛечитTextBox.Name = "чтоЛечитTextBox";
            this.чтоЛечитTextBox.Size = new System.Drawing.Size(560, 60);
            this.чтоЛечитTextBox.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(488, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Удалить текущую запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить новую запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вперед";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рецепты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(668, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заболевания";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Латиница";
            this.dataGridViewTextBoxColumn3.HeaderText = "Латиница";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "МестоПроизрастания";
            this.dataGridViewTextBoxColumn4.HeaderText = "МестоПроизрастания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "СоставПолезныхВеществ";
            this.dataGridViewTextBoxColumn5.HeaderText = "СоставПолезныхВеществ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Храние";
            this.dataGridViewTextBoxColumn6.HeaderText = "Храние";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Приготовление";
            this.dataGridViewTextBoxColumn7.HeaderText = "Приготовление";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ЧтоЛечит";
            this.dataGridViewTextBoxColumn8.HeaderText = "ЧтоЛечит";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // rastenieBindingSource
            // 
            this.rastenieBindingSource.DataMember = "Rastenie";
            this.rastenieBindingSource.DataSource = this.localDBDataSet;
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "LocalDBDataSet";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rastenieTableAdapter
            // 
            this.rastenieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BolezniTableAdapter = this.bolezniTableAdapter;
            this.tableAdapterManager.RastenieTableAdapter = this.rastenieTableAdapter;
            this.tableAdapterManager.ReseptTableAdapter = this.reseptTableAdapter;
            this.tableAdapterManager.UpdateOrder = Spravochnik.LocalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bolezniTableAdapter
            // 
            this.bolezniTableAdapter.ClearBeforeFill = true;
            // 
            // reseptTableAdapter
            // 
            this.reseptTableAdapter.ClearBeforeFill = true;
            // 
            // reseptBindingSource
            // 
            this.reseptBindingSource.DataMember = "Resept";
            this.reseptBindingSource.DataSource = this.localDBDataSet;
            // 
            // bolezniBindingSource
            // 
            this.bolezniBindingSource.DataMember = "Bolezni";
            this.bolezniBindingSource.DataSource = this.localDBDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rastenieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rastenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reseptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolezniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private LocalDBDataSet localDBDataSet;
        private System.Windows.Forms.BindingSource rastenieBindingSource;
        private LocalDBDataSetTableAdapters.RastenieTableAdapter rastenieTableAdapter;
        private LocalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LocalDBDataSetTableAdapters.ReseptTableAdapter reseptTableAdapter;
        private System.Windows.Forms.BindingSource reseptBindingSource;
        private LocalDBDataSetTableAdapters.BolezniTableAdapter bolezniTableAdapter;
        private System.Windows.Forms.BindingSource bolezniBindingSource;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox латиницаTextBox;
        private System.Windows.Forms.TextBox местоПроизрастанияTextBox;
        private System.Windows.Forms.TextBox составПолезныхВеществTextBox;
        private System.Windows.Forms.TextBox храниеTextBox;
        private System.Windows.Forms.TextBox приготовлениеTextBox;
        private System.Windows.Forms.TextBox чтоЛечитTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView rastenieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

    }
}

