namespace Diplom
{
    partial class OpenUserForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckDelete = new System.Windows.Forms.CheckBox();
            this.CheckEdit = new System.Windows.Forms.CheckBox();
            this.CheckAdd = new System.Windows.Forms.CheckBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckControl = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(327, 485);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.Enabled = false;
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserName.Location = new System.Drawing.Point(333, 25);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(182, 20);
            this.UserName.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Enabled = false;
            this.Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login.Location = new System.Drawing.Point(333, 77);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(182, 20);
            this.Login.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.Enabled = false;
            this.Pass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pass.Location = new System.Drawing.Point(333, 129);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(182, 20);
            this.Pass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(333, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин пользователя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(333, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль пользователя";
            // 
            // CheckDelete
            // 
            this.CheckDelete.AutoSize = true;
            this.CheckDelete.Enabled = false;
            this.CheckDelete.Location = new System.Drawing.Point(6, 42);
            this.CheckDelete.Name = "CheckDelete";
            this.CheckDelete.Size = new System.Drawing.Size(102, 17);
            this.CheckDelete.TabIndex = 9;
            this.CheckDelete.Text = "Удаление книг";
            this.CheckDelete.UseVisualStyleBackColor = true;
            this.CheckDelete.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckEdit
            // 
            this.CheckEdit.AutoSize = true;
            this.CheckEdit.Enabled = false;
            this.CheckEdit.Location = new System.Drawing.Point(6, 65);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Size = new System.Drawing.Size(136, 17);
            this.CheckEdit.TabIndex = 10;
            this.CheckEdit.Text = "Редактирование книг";
            this.CheckEdit.UseVisualStyleBackColor = true;
            // 
            // CheckAdd
            // 
            this.CheckAdd.AutoSize = true;
            this.CheckAdd.Enabled = false;
            this.CheckAdd.Location = new System.Drawing.Point(6, 19);
            this.CheckAdd.Name = "CheckAdd";
            this.CheckAdd.Size = new System.Drawing.Size(115, 17);
            this.CheckAdd.TabIndex = 11;
            this.CheckAdd.Text = "Добавление книг";
            this.CheckAdd.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(521, 77);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(126, 49);
            this.DeleteUser.TabIndex = 12;
            this.DeleteUser.Text = "Удалить выбраного пользователя";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(333, 424);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(126, 49);
            this.AddUser.TabIndex = 13;
            this.AddUser.Text = "Добавить пользователя";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(521, 25);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(126, 49);
            this.EditUser.TabIndex = 14;
            this.EditUser.Text = "Редактировать выбраного позователя";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(521, 424);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(126, 49);
            this.Close.TabIndex = 15;
            this.Close.Text = "Назад";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckControl);
            this.groupBox1.Controls.Add(this.CheckDelete);
            this.groupBox1.Controls.Add(this.CheckAdd);
            this.groupBox1.Controls.Add(this.CheckEdit);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(333, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 118);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Возможности пользователя";
            // 
            // CheckControl
            // 
            this.CheckControl.AutoSize = true;
            this.CheckControl.Enabled = false;
            this.CheckControl.Location = new System.Drawing.Point(6, 88);
            this.CheckControl.Name = "CheckControl";
            this.CheckControl.Size = new System.Drawing.Size(176, 17);
            this.CheckControl.TabIndex = 17;
            this.CheckControl.Text = "Управление пользователями";
            this.CheckControl.UseVisualStyleBackColor = true;
            this.CheckControl.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Обновить таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Открыть лог таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // OpenUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(675, 523);
            this.MinimumSize = new System.Drawing.Size(675, 523);
            this.Name = "OpenUserForm";
            this.Text = "Контроль пользователей";
            this.Activated += new System.EventHandler(this.OpenForm_Activated);
            this.Load += new System.EventHandler(this.OpenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckDelete;
        private System.Windows.Forms.CheckBox CheckEdit;
        private System.Windows.Forms.CheckBox CheckAdd;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckControl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}