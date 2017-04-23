namespace Diplom
{
    partial class AddFileForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddBookGenre = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddBook = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBookDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBookDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddLan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBookAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(388, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBookGenre
            // 
            this.AddBookGenre.AutoCompleteCustomSource.AddRange(new string[] {
            "Антиутопия",
            "Вестерн",
            "Детектив",
            "Детская литература",
            "Документальная литература",
            "Драма",
            "Исторический роман",
            "Компьтерная литература",
            "Легенты и мифы",
            "Любовный роман",
            "Научная фантастика",
            "Новелла",
            "Повесть",
            "Поэма",
            "Притча",
            "Проза",
            "Сказка",
            "Триллер",
            "Учебная литература",
            "Фентези"});
            this.AddBookGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.AddBookGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AddBookGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddBookGenre.FormattingEnabled = true;
            this.AddBookGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddBookGenre.Items.AddRange(new object[] {
            "Антиутопия",
            "Вестерн",
            "Детектив",
            "Детская литература",
            "Документальная литература",
            "Драма",
            "Исторический роман",
            "Компьтерная литература",
            "Легенты и мифы",
            "Любовный роман",
            "Научная фантастика",
            "Новелла",
            "Повесть",
            "Поэма",
            "Притча",
            "Проза",
            "Сказка",
            "Триллер",
            "Учебная литература",
            "Фантастика",
            "Фентези"});
            this.AddBookGenre.Location = new System.Drawing.Point(6, 168);
            this.AddBookGenre.MaxDropDownItems = 6;
            this.AddBookGenre.Name = "AddBookGenre";
            this.AddBookGenre.Size = new System.Drawing.Size(210, 21);
            this.AddBookGenre.Sorted = true;
            this.AddBookGenre.TabIndex = 2;
            this.AddBookGenre.SelectedIndexChanged += new System.EventHandler(this.AddBookGenre_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(12, 329);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(109, 37);
            this.AddBook.TabIndex = 5;
            this.AddBook.Text = "Добавить книгу";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(513, 329);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 37);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "назад";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBookDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AddBookDesc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AddLan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddBookAuthor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddBookName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.AddBookGenre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 298);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заполните все поля";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddBookDate
            // 
            this.AddBookDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddBookDate.Location = new System.Drawing.Point(6, 209);
            this.AddBookDate.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.AddBookDate.Name = "AddBookDate";
            this.AddBookDate.Size = new System.Drawing.Size(103, 20);
            this.AddBookDate.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Краткое описание книги (не обязательно)";
            // 
            // AddBookDesc
            // 
            this.AddBookDesc.Location = new System.Drawing.Point(260, 129);
            this.AddBookDesc.Name = "AddBookDesc";
            this.AddBookDesc.Size = new System.Drawing.Size(344, 163);
            this.AddBookDesc.TabIndex = 20;
            this.AddBookDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Укажите язык книги";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddLan
            // 
            this.AddLan.AutoCompleteCustomSource.AddRange(new string[] {
            "азербайджанский",
            "албанский",
            "алюторский",
            "английский ",
            "арабский",
            "арамейский ",
            "армянский ",
            "африкаанс",
            "ацтекский",
            "белорусский",
            "болгарский",
            "венгерский",
            "вьетнамский",
            "голландский ",
            "грузинский",
            "датский",
            "еврейский (иврит)",
            "еврейский (идиш) ",
            "индонезийский",
            "ирландский",
            "исландский",
            "испанский",
            "итальянский",
            "казахский",
            "ольского)",
            "китайский",
            "корейский",
            "крымско-татарский",
            "латинский ",
            "латышский",
            "литовский",
            "македонский",
            "молдавский ",
            "монгольский",
            "мордовские",
            "немецкий ",
            "нидерландский ",
            "осетинский",
            "персидский ",
            "польский ",
            "португальский",
            "прусский",
            "румынский",
            "русский",
            "сербский",
            "словацкий",
            "словенский",
            "татарский",
            "турецкий",
            "украинский",
            "фарлинго",
            "фарси",
            "финский",
            "французский",
            "хорватский",
            "чероки",
            "чеченский",
            "чешский",
            "чукотский ",
            "чувашский",
            "шведский",
            "швейцарско-ретороманский",
            "шумерский",
            "эстонский",
            "якутский",
            "японский"});
            this.AddLan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.AddLan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AddLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddLan.FormattingEnabled = true;
            this.AddLan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddLan.Items.AddRange(new object[] {
            "азербайджанский",
            "албанский",
            "алюторский",
            "английский ",
            "арабский",
            "арамейский ",
            "армянский ",
            "африкаанс",
            "ацтекский",
            "белорусский",
            "болгарский",
            "венгерский",
            "вьетнамский",
            "голландский ",
            "грузинский",
            "датский",
            "еврейский (иврит)",
            "еврейский (идиш) ",
            "индонезийский",
            "ирландский",
            "исландский",
            "испанский",
            "итальянский",
            "казахский",
            "китайский",
            "корейский",
            "крымско-татарский",
            "латинский ",
            "латышский",
            "литовский",
            "македонский",
            "молдавский ",
            "монгольский",
            "мордовские",
            "немецкий ",
            "нидерландский ",
            "ольского)",
            "осетинский",
            "персидский ",
            "польский ",
            "португальский",
            "прусский",
            "румынский",
            "русский",
            "сербский",
            "словацкий",
            "словенский",
            "татарский",
            "турецкий",
            "украинский",
            "фарлинго",
            "фарси",
            "финский",
            "французский",
            "хорватский",
            "чероки",
            "чеченский",
            "чешский",
            "чувашский",
            "чукотский ",
            "шведский",
            "швейцарско-ретороманский",
            "шумерский",
            "эстонский",
            "якутский",
            "японский"});
            this.AddLan.Location = new System.Drawing.Point(6, 248);
            this.AddLan.MaxDropDownItems = 6;
            this.AddLan.Name = "AddLan";
            this.AddLan.Size = new System.Drawing.Size(103, 21);
            this.AddLan.Sorted = true;
            this.AddLan.TabIndex = 18;
            this.AddLan.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Выберите год выпуска книги";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выберите книгу которую хотите лобавить";
            // 
            // AddBookAuthor
            // 
            this.AddBookAuthor.Location = new System.Drawing.Point(6, 129);
            this.AddBookAuthor.MaxLength = 35;
            this.AddBookAuthor.Name = "AddBookAuthor";
            this.AddBookAuthor.Size = new System.Drawing.Size(213, 20);
            this.AddBookAuthor.TabIndex = 14;
            this.AddBookAuthor.TextChanged += new System.EventHandler(this.AddBookAuthor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Автор книги";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddBookName
            // 
            this.AddBookName.Location = new System.Drawing.Point(6, 90);
            this.AddBookName.MaxLength = 35;
            this.AddBookName.Name = "AddBookName";
            this.AddBookName.Size = new System.Drawing.Size(210, 20);
            this.AddBookName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Укажите жанр книги";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 416);
            this.MinimumSize = new System.Drawing.Size(650, 416);
            this.Name = "AddFileForm";
            this.Text = "Добавление новой книги";
            this.Load += new System.EventHandler(this.AddFileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox AddBookGenre;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddBookAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AddLan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox AddBookDesc;
        private System.Windows.Forms.DateTimePicker AddBookDate;
    }
}