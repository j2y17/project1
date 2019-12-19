namespace projct1
{
    partial class startup_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startup_page));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.deptcomboBox = new System.Windows.Forms.ComboBox();
            this.graduationcomboBox = new System.Windows.Forms.ComboBox();
            this.Batchcombobox = new System.Windows.Forms.ComboBox();
            this.studentpictureBox = new System.Windows.Forms.PictureBox();
            this.Homepagepanel2 = new System.Windows.Forms.Panel();
            this.Roll_no = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Regno = new System.Windows.Forms.Label();
            this.Rollnobtn = new System.Windows.Forms.Button();
            this.regnobtn = new System.Windows.Forms.Button();
            this.Regnotxtbox = new System.Windows.Forms.TextBox();
            this.Rollnotxtbox = new System.Windows.Forms.TextBox();
            this.Import = new System.Windows.Forms.Label();
            this.importpictureBox = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.homepagepanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentpictureBox)).BeginInit();
            this.Homepagepanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importpictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            this.homepagepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1316, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // minimize
            // 
            this.minimize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1208, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(49, 38);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 6;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click_1);
            // 
            // deptcomboBox
            // 
            this.deptcomboBox.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptcomboBox.FormattingEnabled = true;
            this.deptcomboBox.Items.AddRange(new object[] {
            "CSE",
            "ECE",
            "BME",
            "EEE",
            "IT",
            "MECH",
            "AUTO",
            "MARINE",
            "CIVIL",
            "AREO"});
            this.deptcomboBox.Location = new System.Drawing.Point(261, 3);
            this.deptcomboBox.Name = "deptcomboBox";
            this.deptcomboBox.Size = new System.Drawing.Size(184, 24);
            this.deptcomboBox.TabIndex = 5;
            this.deptcomboBox.Text = "DEPARTMENT";
            // 
            // graduationcomboBox
            // 
            this.graduationcomboBox.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graduationcomboBox.FormattingEnabled = true;
            this.graduationcomboBox.Items.AddRange(new object[] {
            "UNDER GRADUATE",
            "POST GRADUATE"});
            this.graduationcomboBox.Location = new System.Drawing.Point(501, 3);
            this.graduationcomboBox.Name = "graduationcomboBox";
            this.graduationcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.graduationcomboBox.Size = new System.Drawing.Size(174, 24);
            this.graduationcomboBox.TabIndex = 4;
            this.graduationcomboBox.Text = "UG/PG";
            // 
            // Batchcombobox
            // 
            this.Batchcombobox.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batchcombobox.FormattingEnabled = true;
            this.Batchcombobox.Items.AddRange(new object[] {
            "2k16-2020",
            "2017-2021",
            "2018-2022",
            "2019-2023",
            "2020-2024"});
            this.Batchcombobox.Location = new System.Drawing.Point(35, 3);
            this.Batchcombobox.Name = "Batchcombobox";
            this.Batchcombobox.Size = new System.Drawing.Size(152, 24);
            this.Batchcombobox.TabIndex = 3;
            this.Batchcombobox.Text = "                BATCH";
            this.Batchcombobox.SelectedIndexChanged += new System.EventHandler(this.Batchcombobox_SelectedIndexChanged);
            // 
            // studentpictureBox
            // 
            this.studentpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("studentpictureBox.Image")));
            this.studentpictureBox.Location = new System.Drawing.Point(12, 162);
            this.studentpictureBox.Name = "studentpictureBox";
            this.studentpictureBox.Size = new System.Drawing.Size(237, 263);
            this.studentpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentpictureBox.TabIndex = 29;
            this.studentpictureBox.TabStop = false;
            // 
            // Homepagepanel2
            // 
            this.Homepagepanel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Homepagepanel2.Controls.Add(this.deptcomboBox);
            this.Homepagepanel2.Controls.Add(this.graduationcomboBox);
            this.Homepagepanel2.Controls.Add(this.Batchcombobox);
            this.Homepagepanel2.Location = new System.Drawing.Point(12, 71);
            this.Homepagepanel2.Name = "Homepagepanel2";
            this.Homepagepanel2.Size = new System.Drawing.Size(721, 31);
            this.Homepagepanel2.TabIndex = 28;
            // 
            // Roll_no
            // 
            this.Roll_no.AutoSize = true;
            this.Roll_no.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Roll_no.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll_no.ForeColor = System.Drawing.Color.White;
            this.Roll_no.Location = new System.Drawing.Point(11, 10);
            this.Roll_no.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Roll_no.Name = "Roll_no";
            this.Roll_no.Size = new System.Drawing.Size(216, 26);
            this.Roll_no.TabIndex = 5;
            this.Roll_no.Text = "ROLL NUMBER                       :";
            this.Roll_no.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.Roll_no);
            this.panel2.Location = new System.Drawing.Point(259, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 41);
            this.panel2.TabIndex = 30;
            // 
            // Regno
            // 
            this.Regno.AutoSize = true;
            this.Regno.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Regno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Regno.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regno.ForeColor = System.Drawing.Color.White;
            this.Regno.Location = new System.Drawing.Point(11, 9);
            this.Regno.Name = "Regno";
            this.Regno.Size = new System.Drawing.Size(218, 26);
            this.Regno.TabIndex = 6;
            this.Regno.Text = "REGISTER  NUMBER           :";
            // 
            // Rollnobtn
            // 
            this.Rollnobtn.Location = new System.Drawing.Point(739, 175);
            this.Rollnobtn.Name = "Rollnobtn";
            this.Rollnobtn.Size = new System.Drawing.Size(30, 25);
            this.Rollnobtn.TabIndex = 40;
            this.Rollnobtn.Text = "->";
            this.Rollnobtn.UseVisualStyleBackColor = true;
            this.Rollnobtn.Click += new System.EventHandler(this.Rollnobtn_Click);
            // 
            // regnobtn
            // 
            this.regnobtn.Location = new System.Drawing.Point(739, 243);
            this.regnobtn.Name = "regnobtn";
            this.regnobtn.Size = new System.Drawing.Size(30, 25);
            this.regnobtn.TabIndex = 39;
            this.regnobtn.Text = "->";
            this.regnobtn.UseVisualStyleBackColor = true;
            this.regnobtn.Click += new System.EventHandler(this.regnobtn_Click);
            // 
            // Regnotxtbox
            // 
            this.Regnotxtbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regnotxtbox.Location = new System.Drawing.Point(538, 243);
            this.Regnotxtbox.Name = "Regnotxtbox";
            this.Regnotxtbox.Size = new System.Drawing.Size(231, 25);
            this.Regnotxtbox.TabIndex = 38;
            // 
            // Rollnotxtbox
            // 
            this.Rollnotxtbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rollnotxtbox.Location = new System.Drawing.Point(538, 175);
            this.Rollnotxtbox.Name = "Rollnotxtbox";
            this.Rollnotxtbox.Size = new System.Drawing.Size(231, 25);
            this.Rollnotxtbox.TabIndex = 37;
            // 
            // Import
            // 
            this.Import.AutoSize = true;
            this.Import.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.Location = new System.Drawing.Point(716, 315);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(50, 16);
            this.Import.TabIndex = 36;
            this.Import.Text = "IMPORT";
            // 
            // importpictureBox
            // 
            this.importpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("importpictureBox.Image")));
            this.importpictureBox.Location = new System.Drawing.Point(668, 334);
            this.importpictureBox.Name = "importpictureBox";
            this.importpictureBox.Size = new System.Drawing.Size(137, 135);
            this.importpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.importpictureBox.TabIndex = 35;
            this.importpictureBox.TabStop = false;
            this.importpictureBox.Click += new System.EventHandler(this.importpictureBox_Click);
            this.importpictureBox.DoubleClick += new System.EventHandler(this.importpictureBox_DoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(719, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 22);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.Regno);
            this.panel3.Location = new System.Drawing.Point(259, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 41);
            this.panel3.TabIndex = 31;
            // 
            // maximize
            // 
            this.maximize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maximize.Image = ((System.Drawing.Image)(resources.GetObject("maximize.Image")));
            this.maximize.Location = new System.Drawing.Point(1262, 12);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(48, 38);
            this.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximize.TabIndex = 7;
            this.maximize.TabStop = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click_1);
            // 
            // homepagepanel
            // 
            this.homepagepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homepagepanel.BackgroundImage")));
            this.homepagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homepagepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homepagepanel.Controls.Add(this.Rollnobtn);
            this.homepagepanel.Controls.Add(this.regnobtn);
            this.homepagepanel.Controls.Add(this.Regnotxtbox);
            this.homepagepanel.Controls.Add(this.Rollnotxtbox);
            this.homepagepanel.Controls.Add(this.Import);
            this.homepagepanel.Controls.Add(this.importpictureBox);
            this.homepagepanel.Controls.Add(this.dateTimePicker1);
            this.homepagepanel.Controls.Add(this.panel3);
            this.homepagepanel.Controls.Add(this.panel2);
            this.homepagepanel.Controls.Add(this.studentpictureBox);
            this.homepagepanel.Controls.Add(this.Homepagepanel2);
            this.homepagepanel.Location = new System.Drawing.Point(76, 79);
            this.homepagepanel.Name = "homepagepanel";
            this.homepagepanel.Size = new System.Drawing.Size(812, 486);
            this.homepagepanel.TabIndex = 4;
            // 
            // startup_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.maximize);
            this.Controls.Add(this.homepagepanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startup_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "pic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.startup_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentpictureBox)).EndInit();
            this.Homepagepanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importpictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            this.homepagepanel.ResumeLayout(false);
            this.homepagepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.ComboBox deptcomboBox;
        private System.Windows.Forms.ComboBox graduationcomboBox;
        public System.Windows.Forms.ComboBox Batchcombobox;
        private System.Windows.Forms.PictureBox studentpictureBox;
        private System.Windows.Forms.Panel Homepagepanel2;
        private System.Windows.Forms.Label Roll_no;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Regno;
        private System.Windows.Forms.Button Rollnobtn;
        private System.Windows.Forms.Button regnobtn;
        public System.Windows.Forms.TextBox Regnotxtbox;
        public System.Windows.Forms.TextBox Rollnotxtbox;
        private System.Windows.Forms.Label Import;
        private System.Windows.Forms.PictureBox importpictureBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox maximize;
        private System.Windows.Forms.Panel homepagepanel;
    }
}

