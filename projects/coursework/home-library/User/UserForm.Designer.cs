namespace home_library
{
    partial class UserForm
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
            this.UserBooks = new System.Windows.Forms.Button();
            this.DataGridUser = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowHistory = new System.Windows.Forms.Button();
            this.AllAuthorsRadioBtn = new System.Windows.Forms.RadioButton();
            this.AuthorFilterBox = new System.Windows.Forms.Panel();
            this.GetBook = new MaterialSkin.Controls.MaterialButton();
            this.filterByGenre = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).BeginInit();
            this.AuthorFilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserBooks
            // 
            this.UserBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserBooks.Location = new System.Drawing.Point(399, 349);
            this.UserBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserBooks.Name = "UserBooks";
            this.UserBooks.Size = new System.Drawing.Size(144, 38);
            this.UserBooks.TabIndex = 0;
            this.UserBooks.Text = "Мои книги";
            this.UserBooks.UseVisualStyleBackColor = true;
            this.UserBooks.Click += new System.EventHandler(this.UserBooks_Click);
            // 
            // DataGridUser
            // 
            this.DataGridUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.genre});
            this.DataGridUser.Location = new System.Drawing.Point(15, 95);
            this.DataGridUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridUser.MultiSelect = false;
            this.DataGridUser.Name = "DataGridUser";
            this.DataGridUser.RowHeadersVisible = false;
            this.DataGridUser.RowHeadersWidth = 51;
            this.DataGridUser.RowTemplate.Height = 29;
            this.DataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUser.Size = new System.Drawing.Size(528, 248);
            this.DataGridUser.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Автор";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Публикация";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // genre
            // 
            this.genre.HeaderText = "Жанр";
            this.genre.Name = "genre";
            // 
            // ShowHistory
            // 
            this.ShowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowHistory.Location = new System.Drawing.Point(249, 349);
            this.ShowHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(144, 38);
            this.ShowHistory.TabIndex = 3;
            this.ShowHistory.Text = "Моя история";
            this.ShowHistory.UseVisualStyleBackColor = true;
            this.ShowHistory.Click += new System.EventHandler(this.ShowHistory_Click);
            // 
            // AllAuthorsRadioBtn
            // 
            this.AllAuthorsRadioBtn.AutoSize = true;
            this.AllAuthorsRadioBtn.Checked = true;
            this.AllAuthorsRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.AllAuthorsRadioBtn.Name = "AllAuthorsRadioBtn";
            this.AllAuthorsRadioBtn.Size = new System.Drawing.Size(87, 19);
            this.AllAuthorsRadioBtn.TabIndex = 0;
            this.AllAuthorsRadioBtn.TabStop = true;
            this.AllAuthorsRadioBtn.Text = "Все авторы";
            this.AllAuthorsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AuthorFilterBox
            // 
            this.AuthorFilterBox.AutoScroll = true;
            this.AuthorFilterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AuthorFilterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorFilterBox.Controls.Add(this.AllAuthorsRadioBtn);
            this.AuthorFilterBox.Location = new System.Drawing.Point(549, 95);
            this.AuthorFilterBox.Name = "AuthorFilterBox";
            this.AuthorFilterBox.Size = new System.Drawing.Size(271, 174);
            this.AuthorFilterBox.TabIndex = 6;
            // 
            // GetBook
            // 
            this.GetBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GetBook.Depth = 0;
            this.GetBook.HighEmphasis = true;
            this.GetBook.Icon = null;
            this.GetBook.Location = new System.Drawing.Point(15, 351);
            this.GetBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GetBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.GetBook.Name = "GetBook";
            this.GetBook.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GetBook.Size = new System.Drawing.Size(119, 36);
            this.GetBook.TabIndex = 7;
            this.GetBook.Text = "Взять книгу";
            this.GetBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GetBook.UseAccentColor = false;
            this.GetBook.UseVisualStyleBackColor = true;
            this.GetBook.Click += new System.EventHandler(this.GetBook_Click_1);
            // 
            // filterByGenre
            // 
            this.filterByGenre.AutoResize = false;
            this.filterByGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filterByGenre.Depth = 0;
            this.filterByGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filterByGenre.DropDownHeight = 174;
            this.filterByGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByGenre.DropDownWidth = 121;
            this.filterByGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.filterByGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filterByGenre.FormattingEnabled = true;
            this.filterByGenre.IntegralHeight = false;
            this.filterByGenre.ItemHeight = 43;
            this.filterByGenre.Location = new System.Drawing.Point(549, 294);
            this.filterByGenre.MaxDropDownItems = 4;
            this.filterByGenre.MouseState = MaterialSkin.MouseState.OUT;
            this.filterByGenre.Name = "filterByGenre";
            this.filterByGenre.Size = new System.Drawing.Size(271, 49);
            this.filterByGenre.StartIndex = 0;
            this.filterByGenre.TabIndex = 8;
            this.filterByGenre.SelectedIndexChanged += new System.EventHandler(this.filterByGenre_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(549, 272);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Фильтр по жанрам:";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(580, 352);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(240, 36);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "Сохранить таблицу в WORD";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 411);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.filterByGenre);
            this.Controls.Add(this.GetBook);
            this.Controls.Add(this.AuthorFilterBox);
            this.Controls.Add(this.DataGridUser);
            this.Controls.Add(this.ShowHistory);
            this.Controls.Add(this.UserBooks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "Форма пользователя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).EndInit();
            this.AuthorFilterBox.ResumeLayout(false);
            this.AuthorFilterBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UserBooks;
        private DataGridView DataGridUser;
        private Button ShowHistory;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private RadioButton AllAuthorsRadioBtn;
        private Panel AuthorFilterBox;
        private DataGridViewTextBoxColumn genre;
        private MaterialSkin.Controls.MaterialButton GetBook;
        private MaterialSkin.Controls.MaterialComboBox filterByGenre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}