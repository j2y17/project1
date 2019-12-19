namespace projct1
{
    partial class student_information
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.dobtxtbox = new System.Windows.Forms.TextBox();
            this.regnotxtbox = new System.Windows.Forms.TextBox();
            this.rollnotxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.batchtxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phnotxtbox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hiiiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gendertxtbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stdtextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(447, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(139, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of the candidate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(142, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(139, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Roll no";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(139, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(139, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Register No";
            // 
            // nametxtbox
            // 
            this.nametxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nametxtbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nametxtbox.Location = new System.Drawing.Point(321, 202);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.ReadOnly = true;
            this.nametxtbox.Size = new System.Drawing.Size(303, 29);
            this.nametxtbox.TabIndex = 10;
            this.nametxtbox.TextChanged += new System.EventHandler(this.nametxtbox_TextChanged);
            // 
            // dobtxtbox
            // 
            this.dobtxtbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobtxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dobtxtbox.Location = new System.Drawing.Point(321, 376);
            this.dobtxtbox.Name = "dobtxtbox";
            this.dobtxtbox.ReadOnly = true;
            this.dobtxtbox.Size = new System.Drawing.Size(189, 29);
            this.dobtxtbox.TabIndex = 11;
            this.dobtxtbox.TextChanged += new System.EventHandler(this.dobtxtbox_TextChanged);
            // 
            // regnotxtbox
            // 
            this.regnotxtbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regnotxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regnotxtbox.Location = new System.Drawing.Point(321, 265);
            this.regnotxtbox.Name = "regnotxtbox";
            this.regnotxtbox.ReadOnly = true;
            this.regnotxtbox.Size = new System.Drawing.Size(237, 29);
            this.regnotxtbox.TabIndex = 12;
            this.regnotxtbox.TextChanged += new System.EventHandler(this.regnotxtbox_TextChanged);
            // 
            // rollnotxtbox
            // 
            this.rollnotxtbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollnotxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rollnotxtbox.Location = new System.Drawing.Point(321, 324);
            this.rollnotxtbox.Name = "rollnotxtbox";
            this.rollnotxtbox.ReadOnly = true;
            this.rollnotxtbox.Size = new System.Drawing.Size(237, 29);
            this.rollnotxtbox.TabIndex = 13;
            this.rollnotxtbox.TextChanged += new System.EventHandler(this.rollnotxtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(142, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Batch";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(886, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Internal Assessment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1165, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "University Examination";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1097, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "PHOTO";
            // 
            // batchtxtbox
            // 
            this.batchtxtbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchtxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.batchtxtbox.Location = new System.Drawing.Point(321, 464);
            this.batchtxtbox.Name = "batchtxtbox";
            this.batchtxtbox.ReadOnly = true;
            this.batchtxtbox.Size = new System.Drawing.Size(237, 29);
            this.batchtxtbox.TabIndex = 23;
            this.batchtxtbox.TextChanged += new System.EventHandler(this.batchtxtbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone number";
            // 
            // phnotxtbox
            // 
            this.phnotxtbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnotxtbox.Location = new System.Drawing.Point(321, 514);
            this.phnotxtbox.Name = "phnotxtbox";
            this.phnotxtbox.ReadOnly = true;
            this.phnotxtbox.Size = new System.Drawing.Size(237, 29);
            this.phnotxtbox.TabIndex = 25;
            this.phnotxtbox.TextChanged += new System.EventHandler(this.phnotxtbox_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1037, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 30);
            this.button5.TabIndex = 26;
            this.button5.Text = "Others";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiiiiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hiiiiToolStripMenuItem
            // 
            this.hiiiiToolStripMenuItem.Name = "hiiiiToolStripMenuItem";
            this.hiiiiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hiiiiToolStripMenuItem.Text = "Welcome!!!";
            // 
            // gendertxtbox
            // 
            this.gendertxtbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertxtbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gendertxtbox.Location = new System.Drawing.Point(321, 418);
            this.gendertxtbox.Name = "gendertxtbox";
            this.gendertxtbox.ReadOnly = true;
            this.gendertxtbox.Size = new System.Drawing.Size(140, 29);
            this.gendertxtbox.TabIndex = 32;
            this.gendertxtbox.TextChanged += new System.EventHandler(this.gendertxtbox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 335);
            this.dataGridView1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1045, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // stdtextBox
            // 
            this.stdtextBox.Location = new System.Drawing.Point(88, 79);
            this.stdtextBox.Name = "stdtextBox";
            this.stdtextBox.Size = new System.Drawing.Size(115, 20);
            this.stdtextBox.TabIndex = 35;
            this.stdtextBox.TextChanged += new System.EventHandler(this.stdtextBox_TextChanged);
            // 
            // student_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1358, 737);
            this.Controls.Add(this.stdtextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gendertxtbox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.phnotxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.batchtxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rollnotxtbox);
            this.Controls.Add(this.regnotxtbox);
            this.Controls.Add(this.dobtxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "student_information";
            this.Text = "Student Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.student_information_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox dobtxtbox;
        private System.Windows.Forms.TextBox regnotxtbox;
        private System.Windows.Forms.TextBox rollnotxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox batchtxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiiiiToolStripMenuItem;
        private System.Windows.Forms.TextBox gendertxtbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox stdtextBox;
        public System.Windows.Forms.TextBox phnotxtbox;
    }
}