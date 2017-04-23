namespace Diplom
{
    partial class AddUserForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPass = new System.Windows.Forms.TextBox();
            this.AddLogin = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckControl = new System.Windows.Forms.CheckBox();
            this.CheckDelete = new System.Windows.Forms.CheckBox();
            this.CheckAdd = new System.Windows.Forms.CheckBox();
            this.CheckEdit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUserName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Пароль пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Логин пользователя";
            // 
            // AddPass
            // 
            this.AddPass.Location = new System.Drawing.Point(12, 116);
            this.AddPass.Name = "AddPass";
            this.AddPass.Size = new System.Drawing.Size(348, 20);
            this.AddPass.TabIndex = 14;
            // 
            // AddLogin
            // 
            this.AddLogin.Location = new System.Drawing.Point(12, 64);
            this.AddLogin.Name = "AddLogin";
            this.AddLogin.Size = new System.Drawing.Size(348, 20);
            this.AddLogin.TabIndex = 13;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 282);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 40);
            this.Add.TabIndex = 22;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(248, 282);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(115, 40);
            this.Cancel.TabIndex = 23;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckControl);
            this.groupBox1.Controls.Add(this.CheckDelete);
            this.groupBox1.Controls.Add(this.CheckAdd);
            this.groupBox1.Controls.Add(this.CheckEdit);
            this.groupBox1.Location = new System.Drawing.Point(15, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 118);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Права пользователя";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CheckControl
            // 
            this.CheckControl.AutoSize = true;
            this.CheckControl.Location = new System.Drawing.Point(6, 88);
            this.CheckControl.Name = "CheckControl";
            this.CheckControl.Size = new System.Drawing.Size(176, 17);
            this.CheckControl.TabIndex = 17;
            this.CheckControl.Text = "Управление пользователями";
            this.CheckControl.UseVisualStyleBackColor = true;
            // 
            // CheckDelete
            // 
            this.CheckDelete.AutoSize = true;
            this.CheckDelete.Location = new System.Drawing.Point(6, 42);
            this.CheckDelete.Name = "CheckDelete";
            this.CheckDelete.Size = new System.Drawing.Size(102, 17);
            this.CheckDelete.TabIndex = 9;
            this.CheckDelete.Text = "Удаление книг";
            this.CheckDelete.UseVisualStyleBackColor = true;
            // 
            // CheckAdd
            // 
            this.CheckAdd.AutoSize = true;
            this.CheckAdd.Location = new System.Drawing.Point(6, 19);
            this.CheckAdd.Name = "CheckAdd";
            this.CheckAdd.Size = new System.Drawing.Size(115, 17);
            this.CheckAdd.TabIndex = 11;
            this.CheckAdd.Text = "Добавление книг";
            this.CheckAdd.UseVisualStyleBackColor = true;
            // 
            // CheckEdit
            // 
            this.CheckEdit.AutoSize = true;
            this.CheckEdit.Location = new System.Drawing.Point(6, 65);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Size = new System.Drawing.Size(136, 17);
            this.CheckEdit.TabIndex = 10;
            this.CheckEdit.Text = "Редактирование книг";
            this.CheckEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Имя пользователя";
            // 
            // AddUserName
            // 
            this.AddUserName.Location = new System.Drawing.Point(12, 25);
            this.AddUserName.Name = "AddUserName";
            this.AddUserName.Size = new System.Drawing.Size(348, 20);
            this.AddUserName.TabIndex = 25;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUserName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddPass);
            this.Controls.Add(this.AddLogin);
            this.MaximumSize = new System.Drawing.Size(391, 372);
            this.MinimumSize = new System.Drawing.Size(391, 372);
            this.Name = "AddUserForm";
            this.Text = "Добавление нового пользователя";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddPass;
        private System.Windows.Forms.TextBox AddLogin;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckControl;
        private System.Windows.Forms.CheckBox CheckDelete;
        private System.Windows.Forms.CheckBox CheckAdd;
        private System.Windows.Forms.CheckBox CheckEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddUserName;

    }
}