namespace home_library
{
    partial class AdminFormStep2
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
            this.save_caution = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // save_caution
            // 
            this.save_caution.AutoSize = true;
            this.save_caution.Location = new System.Drawing.Point(26, 386);
            this.save_caution.Name = "save_caution";
            this.save_caution.Size = new System.Drawing.Size(136, 15);
            this.save_caution.TabIndex = 0;
            this.save_caution.Text = "Не забудь сохраниться!";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(583, 386);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(166, 49);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Сохраниться";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(336, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 15);
            this.Title.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(26, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поля";
            // 
            // AdminFormStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.save_caution);
            this.Name = "AdminFormStep2";
            this.Text = "AdminFormStep2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label save_caution;
        private Button SaveBtn;
        private Label Title;
        private GroupBox groupBox1;
    }
}