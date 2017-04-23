namespace Diplom
{
    partial class EditBookForm
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
            this.AddBookDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBookDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddLan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBookAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBookGenre = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBookDate
            // 
            this.AddBookDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddBookDate.Location = new System.Drawing.Point(12, 144);
            this.AddBookDate.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.AddBookDate.Name = "AddBookDate";
            this.AddBookDate.Size = new System.Drawing.Size(103, 20);
            this.AddBookDate.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Краткое описание книги (не обязательно)";
            // 
            // AddBookDesc
            // 
            this.AddBookDesc.Location = new System.Drawing.Point(12, 223);
            this.AddBookDesc.Name = "AddBookDesc";
            this.AddBookDesc.Size = new System.Drawing.Size(349, 175);
            this.AddBookDesc.TabIndex = 32;
            this.AddBookDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Укажите язык книги";
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
            this.AddLan.Location = new System.Drawing.Point(12, 183);
            this.AddLan.MaxDropDownItems = 6;
            this.AddLan.Name = "AddLan";
            this.AddLan.Size = new System.Drawing.Size(103, 21);
            this.AddLan.Sorted = true;
            this.AddLan.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Выберите год выпуска книги";
            // 
            // AddBookAuthor
            // 
            this.AddBookAuthor.Location = new System.Drawing.Point(12, 64);
            this.AddBookAuthor.MaxLength = 35;
            this.AddBookAuthor.Name = "AddBookAuthor";
            this.AddBookAuthor.Size = new System.Drawing.Size(210, 20);
            this.AddBookAuthor.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Автор книги";
            // 
            // AddBookName
            // 
            this.AddBookName.Location = new System.Drawing.Point(12, 25);
            this.AddBookName.MaxLength = 35;
            this.AddBookName.Name = "AddBookName";
            this.AddBookName.Size = new System.Drawing.Size(210, 20);
            this.AddBookName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Укажите жанр книги";
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
            this.AddBookGenre.Location = new System.Drawing.Point(12, 103);
            this.AddBookGenre.MaxDropDownItems = 6;
            this.AddBookGenre.Name = "AddBookGenre";
            this.AddBookGenre.Size = new System.Drawing.Size(210, 21);
            this.AddBookGenre.Sorted = true;
            this.AddBookGenre.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 35;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 36;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddBookDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddBookDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddLan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddBookAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBookGenre);
            this.MaximumSize = new System.Drawing.Size(389, 448);
            this.MinimumSize = new System.Drawing.Size(389, 448);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker AddBookDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox AddBookDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AddLan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddBookAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddBookGenre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}