namespace Diplom
{
    partial class OpenFileForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OpenBook = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBookGenre = new System.Windows.Forms.ComboBox();
            this.AddBookDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AddLan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(846, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // OpenBook
            // 
            this.OpenBook.Location = new System.Drawing.Point(12, 413);
            this.OpenBook.Name = "OpenBook";
            this.OpenBook.Size = new System.Drawing.Size(115, 40);
            this.OpenBook.TabIndex = 1;
            this.OpenBook.Text = "Открыть книгу";
            this.OpenBook.UseVisualStyleBackColor = true;
            this.OpenBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(472, 413);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(115, 40);
            this.Close.TabIndex = 2;
            this.Close.Text = "Назад";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AddBookGenre);
            this.groupBox2.Controls.Add(this.AddBookDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.AddLan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BookAuthor);
            this.groupBox2.Controls.Add(this.BookName);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 128);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Жанр книги";
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
            this.AddBookGenre.Location = new System.Drawing.Point(209, 36);
            this.AddBookGenre.MaxDropDownItems = 6;
            this.AddBookGenre.Name = "AddBookGenre";
            this.AddBookGenre.Size = new System.Drawing.Size(196, 21);
            this.AddBookGenre.Sorted = true;
            this.AddBookGenre.TabIndex = 32;
            this.AddBookGenre.SelectedIndexChanged += new System.EventHandler(this.AddBookGenre_SelectedIndexChanged);
            // 
            // AddBookDate
            // 
            this.AddBookDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddBookDate.Location = new System.Drawing.Point(212, 75);
            this.AddBookDate.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.AddBookDate.Name = "AddBookDate";
            this.AddBookDate.Size = new System.Drawing.Size(103, 20);
            this.AddBookDate.TabIndex = 31;
            this.AddBookDate.ValueChanged += new System.EventHandler(this.AddBookDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Язык книги";
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
            this.AddLan.Location = new System.Drawing.Point(411, 35);
            this.AddLan.MaxDropDownItems = 6;
            this.AddLan.Name = "AddLan";
            this.AddLan.Size = new System.Drawing.Size(113, 21);
            this.AddLan.Sorted = true;
            this.AddLan.TabIndex = 29;
            this.AddLan.SelectedIndexChanged += new System.EventHandler(this.AddLan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Год выпуска книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Автор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Название книги";
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(6, 75);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(197, 20);
            this.BookAuthor.TabIndex = 19;
            this.BookAuthor.TextChanged += new System.EventHandler(this.BookAuthor_TextChanged);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(6, 36);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(197, 20);
            this.BookName.TabIndex = 18;
            this.BookName.TextChanged += new System.EventHandler(this.BookName_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(587, 292);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 159);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Описание  книги";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.добавитьКнигуToolStripMenuItem,
            this.удалитьКнигуToolStripMenuItem,
            this.редактироватьКнигуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            this.добавитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКнигуToolStripMenuItem_Click);
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            this.удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            this.удалитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            this.удалитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.удалитьКнигуToolStripMenuItem_Click);
            // 
            // редактироватьКнигуToolStripMenuItem
            // 
            this.редактироватьКнигуToolStripMenuItem.Name = "редактироватьКнигуToolStripMenuItem";
            this.редактироватьКнигуToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.редактироватьКнигуToolStripMenuItem.Text = "Редактировать книгу";
            this.редактироватьКнигуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьКнигуToolStripMenuItem_Click);
            // 
            // OpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(846, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.OpenBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(862, 501);
            this.MinimumSize = new System.Drawing.Size(862, 501);
            this.Name = "OpenFileForm";
            this.Text = "Хранилище книг";
            this.Activated += new System.EventHandler(this.OpenFileForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenFileForm_FormClosing);
            this.Load += new System.EventHandler(this.OpenFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OpenBook;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.DateTimePicker AddBookDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AddLan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddBookGenre;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКнигуToolStripMenuItem;

    }
}