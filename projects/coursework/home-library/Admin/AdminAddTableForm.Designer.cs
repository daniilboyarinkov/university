namespace home_library.Admin
{
    partial class AdminAddTableForm
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
            this.Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectTable = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(429, 444);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(402, 49);
            this.Add.TabIndex = 2;
            this.Add.Text = "Создать таблицу";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поля";
            // 
            // SelectTable
            // 
            this.SelectTable.AutoResize = false;
            this.SelectTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectTable.Depth = 0;
            this.SelectTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectTable.DropDownHeight = 174;
            this.SelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTable.DropDownWidth = 121;
            this.SelectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SelectTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectTable.FormattingEnabled = true;
            this.SelectTable.IntegralHeight = false;
            this.SelectTable.ItemHeight = 43;
            this.SelectTable.Location = new System.Drawing.Point(12, 444);
            this.SelectTable.MaxDropDownItems = 4;
            this.SelectTable.MouseState = MaterialSkin.MouseState.OUT;
            this.SelectTable.Name = "SelectTable";
            this.SelectTable.Size = new System.Drawing.Size(402, 49);
            this.SelectTable.StartIndex = 0;
            this.SelectTable.TabIndex = 9;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 422);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Добавить связь";
            // 
            // AdminAddTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 578);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.SelectTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Add);
            this.Name = "AdminAddTableForm";
            this.Text = "Добавление таблицы в БД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Add;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox SelectTable;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}