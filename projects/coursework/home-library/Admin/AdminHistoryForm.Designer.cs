namespace home_library
{
    partial class AdminHistoryForm
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
            this.DataGridUser = new System.Windows.Forms.DataGridView();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.RejectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.GenreFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.AuthorFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridUser
            // 
            this.DataGridUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUser.Location = new System.Drawing.Point(23, 102);
            this.DataGridUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridUser.MultiSelect = false;
            this.DataGridUser.Name = "DataGridUser";
            this.DataGridUser.RowHeadersVisible = false;
            this.DataGridUser.RowHeadersWidth = 51;
            this.DataGridUser.RowTemplate.Height = 29;
            this.DataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUser.Size = new System.Drawing.Size(600, 331);
            this.DataGridUser.TabIndex = 5;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitBtn.Location = new System.Drawing.Point(23, 461);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(277, 41);
            this.SubmitBtn.TabIndex = 6;
            this.SubmitBtn.Text = "Одобрить";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // RejectBtn
            // 
            this.RejectBtn.BackColor = System.Drawing.Color.Red;
            this.RejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RejectBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RejectBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RejectBtn.Location = new System.Drawing.Point(346, 461);
            this.RejectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(277, 41);
            this.RejectBtn.TabIndex = 7;
            this.RejectBtn.Text = "Отказать";
            this.RejectBtn.UseVisualStyleBackColor = false;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "По автору:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserFilter);
            this.groupBox1.Controls.Add(this.GenreFilter);
            this.groupBox1.Controls.Add(this.AuthorFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(629, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 331);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // UserFilter
            // 
            this.UserFilter.AutoResize = false;
            this.UserFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserFilter.Depth = 0;
            this.UserFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UserFilter.DropDownHeight = 174;
            this.UserFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserFilter.DropDownWidth = 121;
            this.UserFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UserFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserFilter.FormattingEnabled = true;
            this.UserFilter.IntegralHeight = false;
            this.UserFilter.ItemHeight = 43;
            this.UserFilter.Location = new System.Drawing.Point(5, 253);
            this.UserFilter.MaxDropDownItems = 4;
            this.UserFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.UserFilter.Name = "UserFilter";
            this.UserFilter.Size = new System.Drawing.Size(193, 49);
            this.UserFilter.StartIndex = 0;
            this.UserFilter.TabIndex = 15;
            this.UserFilter.SelectedIndexChanged += new System.EventHandler(this.UserFilter_SelectedIndexChanged_1);
            // 
            // GenreFilter
            // 
            this.GenreFilter.AutoResize = false;
            this.GenreFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GenreFilter.Depth = 0;
            this.GenreFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GenreFilter.DropDownHeight = 174;
            this.GenreFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreFilter.DropDownWidth = 121;
            this.GenreFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.GenreFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GenreFilter.FormattingEnabled = true;
            this.GenreFilter.IntegralHeight = false;
            this.GenreFilter.ItemHeight = 43;
            this.GenreFilter.Location = new System.Drawing.Point(6, 163);
            this.GenreFilter.MaxDropDownItems = 4;
            this.GenreFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.GenreFilter.Name = "GenreFilter";
            this.GenreFilter.Size = new System.Drawing.Size(192, 49);
            this.GenreFilter.StartIndex = 0;
            this.GenreFilter.TabIndex = 14;
            this.GenreFilter.SelectedIndexChanged += new System.EventHandler(this.GenreFilter_SelectedIndexChanged_1);
            // 
            // AuthorFilter
            // 
            this.AuthorFilter.AutoResize = false;
            this.AuthorFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthorFilter.Depth = 0;
            this.AuthorFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AuthorFilter.DropDownHeight = 174;
            this.AuthorFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorFilter.DropDownWidth = 121;
            this.AuthorFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AuthorFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AuthorFilter.FormattingEnabled = true;
            this.AuthorFilter.IntegralHeight = false;
            this.AuthorFilter.ItemHeight = 43;
            this.AuthorFilter.Location = new System.Drawing.Point(6, 66);
            this.AuthorFilter.MaxDropDownItems = 4;
            this.AuthorFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.AuthorFilter.Name = "AuthorFilter";
            this.AuthorFilter.Size = new System.Drawing.Size(192, 49);
            this.AuthorFilter.StartIndex = 0;
            this.AuthorFilter.TabIndex = 12;
            this.AuthorFilter.SelectedIndexChanged += new System.EventHandler(this.AuthorFilter_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "По пользователю:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "По жанру:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(346, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 15);
            this.Title.TabIndex = 11;
            // 
            // AdminHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 571);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RejectBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DataGridUser);
            this.Name = "AdminHistoryForm";
            this.Text = "AdminHistory";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGridUser;
        private Button SubmitBtn;
        private Button RejectBtn;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label Title;
        private MaterialSkin.Controls.MaterialComboBox UserFilter;
        private MaterialSkin.Controls.MaterialComboBox GenreFilter;
        private MaterialSkin.Controls.MaterialComboBox AuthorFilter;
    }
}