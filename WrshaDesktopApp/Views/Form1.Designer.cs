namespace WrshaDesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnRecive = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbDeviceType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDeviceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.CmbDaragaReciver = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtReciverName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbOwnerBranch = new System.Windows.Forms.ComboBox();
            this.CmbDaragaOwner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOwnerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtSerialNumberSearch = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(341, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "برنامج الورشة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(844, 529);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnReset);
            this.tabPage1.Controls.Add(this.BtnRecive);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "استلام جهاز";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(529, 370);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(64, 32);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "تفريغ";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnRecive
            // 
            this.BtnRecive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRecive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.BtnRecive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRecive.ForeColor = System.Drawing.Color.White;
            this.BtnRecive.Location = new System.Drawing.Point(604, 370);
            this.BtnRecive.Name = "BtnRecive";
            this.BtnRecive.Size = new System.Drawing.Size(164, 32);
            this.BtnRecive.TabIndex = 4;
            this.BtnRecive.Text = "إستلام";
            this.BtnRecive.UseVisualStyleBackColor = false;
            this.BtnRecive.Click += new System.EventHandler(this.BtnRecive_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtSerialNumber);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.CmbDeviceType);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtDeviceName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(3, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 108);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الجهاز";
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSerialNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSerialNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSerialNumber.Location = new System.Drawing.Point(14, 50);
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.PlaceholderText = "YK3F058952";
            this.TxtSerialNumber.Size = new System.Drawing.Size(195, 22);
            this.TxtSerialNumber.TabIndex = 0;
            this.TxtSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(215, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "السريال";
            // 
            // CmbDeviceType
            // 
            this.CmbDeviceType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbDeviceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbDeviceType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CmbDeviceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbDeviceType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbDeviceType.FormattingEnabled = true;
            this.CmbDeviceType.Location = new System.Drawing.Point(576, 48);
            this.CmbDeviceType.Name = "CmbDeviceType";
            this.CmbDeviceType.Size = new System.Drawing.Size(116, 27);
            this.CmbDeviceType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(526, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "الموديل";
            // 
            // TxtDeviceName
            // 
            this.TxtDeviceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDeviceName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDeviceName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDeviceName.Location = new System.Drawing.Point(266, 50);
            this.TxtDeviceName.Name = "TxtDeviceName";
            this.TxtDeviceName.PlaceholderText = "HP Compaq 8200";
            this.TxtDeviceName.Size = new System.Drawing.Size(254, 22);
            this.TxtDeviceName.TabIndex = 0;
            this.TxtDeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(698, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "نوع الجهاز";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtDescription);
            this.groupBox2.Controls.Add(this.CmbDaragaReciver);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtReciverName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المستلم بالورشة";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(90, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "وصف المشكلة";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescription.Location = new System.Drawing.Point(14, 48);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(238, 46);
            this.TxtDescription.TabIndex = 0;
            // 
            // CmbDaragaReciver
            // 
            this.CmbDaragaReciver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbDaragaReciver.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CmbDaragaReciver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDaragaReciver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbDaragaReciver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbDaragaReciver.FormattingEnabled = true;
            this.CmbDaragaReciver.Location = new System.Drawing.Point(610, 44);
            this.CmbDaragaReciver.Name = "CmbDaragaReciver";
            this.CmbDaragaReciver.Size = new System.Drawing.Size(116, 27);
            this.CmbDaragaReciver.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(560, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "الاسم";
            // 
            // TxtReciverName
            // 
            this.TxtReciverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtReciverName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtReciverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtReciverName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtReciverName.Location = new System.Drawing.Point(267, 47);
            this.TxtReciverName.Name = "TxtReciverName";
            this.TxtReciverName.PlaceholderText = "محمود عادل";
            this.TxtReciverName.Size = new System.Drawing.Size(287, 22);
            this.TxtReciverName.TabIndex = 0;
            this.TxtReciverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(732, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "درجة";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.CmbOwnerBranch);
            this.groupBox1.Controls.Add(this.CmbDaragaOwner);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtOwnerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات مسلم الجهاز";
            // 
            // CmbOwnerBranch
            // 
            this.CmbOwnerBranch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbOwnerBranch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CmbOwnerBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOwnerBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbOwnerBranch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbOwnerBranch.FormattingEnabled = true;
            this.CmbOwnerBranch.Location = new System.Drawing.Point(15, 44);
            this.CmbOwnerBranch.Name = "CmbOwnerBranch";
            this.CmbOwnerBranch.Size = new System.Drawing.Size(181, 27);
            this.CmbOwnerBranch.TabIndex = 1;
            // 
            // CmbDaragaOwner
            // 
            this.CmbDaragaOwner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbDaragaOwner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CmbDaragaOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDaragaOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbDaragaOwner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbDaragaOwner.FormattingEnabled = true;
            this.CmbDaragaOwner.Location = new System.Drawing.Point(609, 44);
            this.CmbDaragaOwner.Name = "CmbDaragaOwner";
            this.CmbDaragaOwner.Size = new System.Drawing.Size(116, 27);
            this.CmbDaragaOwner.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(559, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "الاسم";
            // 
            // TxtOwnerName
            // 
            this.TxtOwnerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtOwnerName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOwnerName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtOwnerName.Location = new System.Drawing.Point(266, 47);
            this.TxtOwnerName.Name = "TxtOwnerName";
            this.TxtOwnerName.PlaceholderText = "فلان الفلاني";
            this.TxtOwnerName.Size = new System.Drawing.Size(287, 22);
            this.TxtOwnerName.TabIndex = 0;
            this.TxtOwnerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(202, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "الفرع";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(731, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "درجة";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "جميع الاجهزة";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 490);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 450);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtSerialNumberSearch);
            this.panel2.Controls.Add(this.TxtSearch);
            this.panel2.Controls.Add(this.CmbFilter);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 40);
            this.panel2.TabIndex = 3;
            // 
            // TxtSerialNumberSearch
            // 
            this.TxtSerialNumberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSerialNumberSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtSerialNumberSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSerialNumberSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSerialNumberSearch.Location = new System.Drawing.Point(80, 6);
            this.TxtSerialNumberSearch.Name = "TxtSerialNumberSearch";
            this.TxtSerialNumberSearch.PlaceholderText = "سريال";
            this.TxtSerialNumberSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtSerialNumberSearch.Size = new System.Drawing.Size(147, 22);
            this.TxtSerialNumberSearch.TabIndex = 0;
            this.TxtSerialNumberSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSerialNumberSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSerialNumberSearch_KeyUp);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearch.Location = new System.Drawing.Point(257, 6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "الموديل";
            this.TxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtSearch.Size = new System.Drawing.Size(147, 22);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // CmbFilter
            // 
            this.CmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbFilter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(462, 4);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(322, 26);
            this.CmbFilter.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(233, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "او";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "ابحث";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(790, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "فلتر";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(844, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج الورشة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbDaragaOwner;
        private System.Windows.Forms.TextBox TxtOwnerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbOwnerBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRecive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbDeviceType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDeviceName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbDaragaReciver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtReciverName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtSerialNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSerialNumberSearch;
        private System.Windows.Forms.Label label13;
    }
}

