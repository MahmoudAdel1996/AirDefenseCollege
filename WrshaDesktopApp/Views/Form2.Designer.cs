namespace WrshaDesktopApp.Views
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbHandOverToDraga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHandOverToName = new System.Windows.Forms.TextBox();
            this.BtnHandOver = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.lblReciveTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(485, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "درجة";
            // 
            // CmbHandOverToDraga
            // 
            this.CmbHandOverToDraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbHandOverToDraga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CmbHandOverToDraga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHandOverToDraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbHandOverToDraga.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbHandOverToDraga.FormattingEnabled = true;
            this.CmbHandOverToDraga.Location = new System.Drawing.Point(363, 70);
            this.CmbHandOverToDraga.Name = "CmbHandOverToDraga";
            this.CmbHandOverToDraga.Size = new System.Drawing.Size(116, 27);
            this.CmbHandOverToDraga.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(313, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "الاسم";
            // 
            // TxtHandOverToName
            // 
            this.TxtHandOverToName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtHandOverToName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtHandOverToName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHandOverToName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHandOverToName.Location = new System.Drawing.Point(20, 73);
            this.TxtHandOverToName.Name = "TxtHandOverToName";
            this.TxtHandOverToName.PlaceholderText = "مثال / محمود عادل محمد";
            this.TxtHandOverToName.Size = new System.Drawing.Size(287, 22);
            this.TxtHandOverToName.TabIndex = 0;
            this.TxtHandOverToName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnHandOver
            // 
            this.BtnHandOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnHandOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.BtnHandOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHandOver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHandOver.ForeColor = System.Drawing.Color.White;
            this.BtnHandOver.Location = new System.Drawing.Point(234, 131);
            this.BtnHandOver.Name = "BtnHandOver";
            this.BtnHandOver.Size = new System.Drawing.Size(164, 32);
            this.BtnHandOver.TabIndex = 4;
            this.BtnHandOver.Text = "تسليم";
            this.BtnHandOver.UseVisualStyleBackColor = false;
            this.BtnHandOver.Click += new System.EventHandler(this.BtnHandOver_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(159, 131);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(64, 32);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "اغلاق";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblReciveTitle
            // 
            this.lblReciveTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReciveTitle.AutoSize = true;
            this.lblReciveTitle.Font = new System.Drawing.Font("هشام الشرق طبيعي", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReciveTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.lblReciveTitle.Location = new System.Drawing.Point(199, 9);
            this.lblReciveTitle.Name = "lblReciveTitle";
            this.lblReciveTitle.Size = new System.Drawing.Size(115, 34);
            this.lblReciveTitle.TabIndex = 1;
            this.lblReciveTitle.Text = "تسليم جهاز";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(542, 199);
            this.Controls.Add(this.lblReciveTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnHandOver);
            this.Controls.Add(this.TxtHandOverToName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbHandOverToDraga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بيانات الشخص مستلم الجهاز";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbHandOverToDraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHandOverToName;
        private System.Windows.Forms.Button BtnHandOver;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label lblReciveTitle;
    }
}