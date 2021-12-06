namespace WrshaDesktopApp.Views
{
    partial class Note
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
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoteTitle.AutoSize = true;
            this.lblNoteTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoteTitle.Font = new System.Drawing.Font("هشام الشرق طبيعي", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.lblNoteTitle.Location = new System.Drawing.Point(183, 9);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(100, 34);
            this.lblNoteTitle.TabIndex = 0;
            this.lblNoteTitle.Text = "ملاحظات";
            this.lblNoteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNote.Location = new System.Drawing.Point(30, 50);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PlaceholderText = "اكتب ملاحظة";
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNote.Size = new System.Drawing.Size(464, 155);
            this.txtNote.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(155, 226);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(64, 32);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "اغلاق";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(225, 226);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(164, 32);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "تعديل";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 270);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNoteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل الملاحظات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoteTitle;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
    }
}