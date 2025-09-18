namespace Book
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAutor = new TextBox();
            txtGenre = new TextBox();
            txtyearOfPublishing = new TextBox();
            lstBooks = new ListBox();
            AddBook = new Button();
            BtnRemove = new Button();
            BtnSearch = new Button();
            BtnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 77);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 152);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 3;
            label4.Text = "Год издательства";
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 23);
            txtName.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(146, 74);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(172, 23);
            txtAutor.TabIndex = 5;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(146, 110);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(172, 23);
            txtGenre.TabIndex = 6;
            // 
            // txtyearOfPublishing
            // 
            txtyearOfPublishing.Location = new Point(146, 149);
            txtyearOfPublishing.Name = "txtyearOfPublishing";
            txtyearOfPublishing.Size = new Size(172, 23);
            txtyearOfPublishing.TabIndex = 7;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(331, 12);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(457, 394);
            lstBooks.TabIndex = 8;
            // 
            // AddBook
            // 
            AddBook.Location = new Point(25, 231);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(117, 23);
            AddBook.TabIndex = 9;
            AddBook.Text = "Добавить книгу";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += AddBook_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(25, 278);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(114, 23);
            BtnRemove.TabIndex = 10;
            BtnRemove.Text = "Удалить книгу";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(21, 333);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(118, 23);
            BtnSearch.TabIndex = 11;
            BtnSearch.Text = "Поиск книги";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(25, 383);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(114, 23);
            BtnClear.TabIndex = 12;
            BtnClear.Text = "Очистить поиск";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClear);
            Controls.Add(BtnSearch);
            Controls.Add(BtnRemove);
            Controls.Add(AddBook);
            Controls.Add(lstBooks);
            Controls.Add(txtyearOfPublishing);
            Controls.Add(txtGenre);
            Controls.Add(txtAutor);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Books";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAutor;
        private TextBox txtGenre;
        private TextBox txtyearOfPublishing;
        private ListBox lstBooks;
        private Button AddBook;
        private Button BtnRemove;
        private Button BtnSearch;
        private Button BtnClear;
    }
}
