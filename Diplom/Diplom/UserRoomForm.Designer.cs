namespace Diplom
{
    partial class UserRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckControl = new System.Windows.Forms.CheckBox();
            this.CheckDelete = new System.Windows.Forms.CheckBox();
            this.CheckAdd = new System.Windows.Forms.CheckBox();
            this.CheckEdit = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckControl);
            this.groupBox1.Controls.Add(this.CheckDelete);
            this.groupBox1.Controls.Add(this.CheckAdd);
            this.groupBox1.Controls.Add(this.CheckEdit);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Возможности пользователя";
            // 
            // CheckControl
            // 
            this.CheckControl.AutoSize = true;
            this.CheckControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckControl.Enabled = false;
            this.CheckControl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckControl.Location = new System.Drawing.Point(141, 42);
            this.CheckControl.Name = "CheckControl";
            this.CheckControl.Size = new System.Drawing.Size(176, 17);
            this.CheckControl.TabIndex = 17;
            this.CheckControl.Text = "Управление пользователями";
            this.CheckControl.UseVisualStyleBackColor = false;
            // 
            // CheckDelete
            // 
            this.CheckDelete.AutoSize = true;
            this.CheckDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckDelete.Enabled = false;
            this.CheckDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckDelete.Location = new System.Drawing.Point(6, 42);
            this.CheckDelete.Name = "CheckDelete";
            this.CheckDelete.Size = new System.Drawing.Size(102, 17);
            this.CheckDelete.TabIndex = 9;
            this.CheckDelete.Text = "Удаление книг";
            this.CheckDelete.UseVisualStyleBackColor = false;
            // 
            // CheckAdd
            // 
            this.CheckAdd.AutoSize = true;
            this.CheckAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckAdd.Enabled = false;
            this.CheckAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckAdd.Location = new System.Drawing.Point(6, 19);
            this.CheckAdd.Name = "CheckAdd";
            this.CheckAdd.Size = new System.Drawing.Size(115, 17);
            this.CheckAdd.TabIndex = 11;
            this.CheckAdd.Text = "Добавление книг";
            this.CheckAdd.UseVisualStyleBackColor = false;
            // 
            // CheckEdit
            // 
            this.CheckEdit.AutoSize = true;
            this.CheckEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckEdit.Enabled = false;
            this.CheckEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckEdit.Location = new System.Drawing.Point(141, 19);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Size = new System.Drawing.Size(136, 17);
            this.CheckEdit.TabIndex = 10;
            this.CheckEdit.Text = "Редактирование книг";
            this.CheckEdit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Книги которые вы читали или открывали";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Фильтр по названию книги";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UserRoomForm";
            this.Text = "UserRoomForm";
            this.Load += new System.EventHandler(this.UserRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckControl;
        private System.Windows.Forms.CheckBox CheckDelete;
        private System.Windows.Forms.CheckBox CheckAdd;
        private System.Windows.Forms.CheckBox CheckEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}