namespace home_library
{
    partial class AdminLoginForm
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
            this.RestorePassword = new System.Windows.Forms.LinkLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Login = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.EnterBtn = new MaterialSkin.Controls.MaterialButton();
            this.Password = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // RestorePassword
            // 
            this.RestorePassword.AutoSize = true;
            this.RestorePassword.LinkColor = System.Drawing.Color.BlueViolet;
            this.RestorePassword.Location = new System.Drawing.Point(320, 304);
            this.RestorePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestorePassword.Name = "RestorePassword";
            this.RestorePassword.Size = new System.Drawing.Size(124, 20);
            this.RestorePassword.TabIndex = 5;
            this.RestorePassword.TabStop = true;
            this.RestorePassword.Text = "Забыли пароль?";
            this.RestorePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RestorePassword_LinkClicked);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(81, 140);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(70, 213);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.AllowPromptAsInput = true;
            this.Login.AnimateReadOnly = false;
            this.Login.AsciiOnly = false;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.BeepOnError = false;
            this.Login.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Login.Depth = 0;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login.HidePromptOnLeave = false;
            this.Login.HideSelection = true;
            this.Login.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Login.LeadingIcon = null;
            this.Login.Location = new System.Drawing.Point(206, 111);
            this.Login.Mask = "";
            this.Login.MaxLength = 32767;
            this.Login.MouseState = MaterialSkin.MouseState.OUT;
            this.Login.Name = "Login";
            this.Login.PasswordChar = '\0';
            this.Login.PrefixSuffixText = null;
            this.Login.PromptChar = '_';
            this.Login.ReadOnly = false;
            this.Login.RejectInputOnFirstFailure = false;
            this.Login.ResetOnPrompt = true;
            this.Login.ResetOnSpace = true;
            this.Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login.SelectedText = "";
            this.Login.SelectionLength = 0;
            this.Login.SelectionStart = 0;
            this.Login.ShortcutsEnabled = true;
            this.Login.Size = new System.Drawing.Size(250, 48);
            this.Login.SkipLiterals = true;
            this.Login.TabIndex = 8;
            this.Login.TabStop = false;
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Login.TrailingIcon = null;
            this.Login.UseSystemPasswordChar = false;
            this.Login.ValidatingType = null;
            // 
            // EnterBtn
            // 
            this.EnterBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EnterBtn.Depth = 0;
            this.EnterBtn.HighEmphasis = true;
            this.EnterBtn.Icon = null;
            this.EnterBtn.Location = new System.Drawing.Point(373, 241);
            this.EnterBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EnterBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EnterBtn.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.EnterBtn.Size = new System.Drawing.Size(71, 36);
            this.EnterBtn.TabIndex = 9;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EnterBtn.UseAccentColor = false;
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click_1);
            // 
            // Password
            // 
            this.Password.AllowPromptAsInput = true;
            this.Password.AnimateReadOnly = false;
            this.Password.AsciiOnly = false;
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Password.BeepOnError = false;
            this.Password.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.HidePromptOnLeave = false;
            this.Password.HideSelection = true;
            this.Password.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(206, 184);
            this.Password.Mask = "";
            this.Password.MaxLength = 32767;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PrefixSuffixText = null;
            this.Password.PromptChar = '_';
            this.Password.ReadOnly = false;
            this.Password.RejectInputOnFirstFailure = false;
            this.Password.ResetOnPrompt = true;
            this.Password.ResetOnSpace = true;
            this.Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(250, 48);
            this.Password.SkipLiterals = true;
            this.Password.TabIndex = 10;
            this.Password.TabStop = false;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.Password.TrailingIcon = null;
            this.Password.UseSystemPasswordChar = false;
            this.Password.ValidatingType = null;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 359);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.RestorePassword);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLoginForm";
            this.Text = "Форма входа администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel RestorePassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox Login;
        private MaterialSkin.Controls.MaterialButton EnterBtn;
        private MaterialSkin.Controls.MaterialMaskedTextBox Password;
    }
}