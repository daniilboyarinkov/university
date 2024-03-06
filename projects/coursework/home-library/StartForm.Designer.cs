namespace home_library
{
    partial class StartForm
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UserButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.UserName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AdminButton.Location = new System.Drawing.Point(370, 277);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(175, 30);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Войти как админ";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(136, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Домашняя библиотека";
            // 
            // UserButton
            // 
            this.UserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UserButton.Depth = 0;
            this.UserButton.HighEmphasis = true;
            this.UserButton.Icon = null;
            this.UserButton.Location = new System.Drawing.Point(406, 138);
            this.UserButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserButton.Name = "UserButton";
            this.UserButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UserButton.Size = new System.Drawing.Size(71, 36);
            this.UserButton.TabIndex = 5;
            this.UserButton.Text = "Войти";
            this.UserButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UserButton.UseAccentColor = false;
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(68, 148);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(33, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Имя";
            // 
            // UserName
            // 
            this.UserName.AllowPromptAsInput = true;
            this.UserName.AnimateReadOnly = false;
            this.UserName.AsciiOnly = false;
            this.UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserName.BeepOnError = false;
            this.UserName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.UserName.Depth = 0;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserName.HidePromptOnLeave = false;
            this.UserName.HideSelection = true;
            this.UserName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.UserName.LeadingIcon = null;
            this.UserName.Location = new System.Drawing.Point(136, 126);
            this.UserName.Mask = "";
            this.UserName.MaxLength = 32767;
            this.UserName.MouseState = MaterialSkin.MouseState.OUT;
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PrefixSuffixText = null;
            this.UserName.PromptChar = '_';
            this.UserName.ReadOnly = false;
            this.UserName.RejectInputOnFirstFailure = false;
            this.UserName.ResetOnPrompt = true;
            this.UserName.ResetOnSpace = true;
            this.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.ShortcutsEnabled = true;
            this.UserName.Size = new System.Drawing.Size(250, 48);
            this.UserName.SkipLiterals = true;
            this.UserName.TabIndex = 7;
            this.UserName.TabStop = false;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.UserName.TrailingIcon = null;
            this.UserName.UseSystemPasswordChar = false;
            this.UserName.ValidatingType = null;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 312);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.Text = "Добро Пожаловать!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AdminButton;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton UserButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox UserName;
    }
}