namespace home_library
{
    partial class UserFormStep2
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
            this.ActionBtn = new System.Windows.Forms.Button();
            this.DataGridUser = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionBtn
            // 
            this.ActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ActionBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActionBtn.Location = new System.Drawing.Point(74, 337);
            this.ActionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(277, 31);
            this.ActionBtn.TabIndex = 5;
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // DataGridUser
            // 
            this.DataGridUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUser.Location = new System.Drawing.Point(74, 78);
            this.DataGridUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridUser.MultiSelect = false;
            this.DataGridUser.Name = "DataGridUser";
            this.DataGridUser.RowHeadersVisible = false;
            this.DataGridUser.RowHeadersWidth = 51;
            this.DataGridUser.RowTemplate.Height = 29;
            this.DataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUser.Size = new System.Drawing.Size(547, 242);
            this.DataGridUser.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(374, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 15);
            this.Title.TabIndex = 6;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(381, 335);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(240, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Сохранить таблицу в WORD";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // UserFormStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 414);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.DataGridUser);
            this.Name = "UserFormStep2";
            this.Text = "UserFormStep2";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ActionBtn;
        private DataGridView DataGridUser;
        private Label Title;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}