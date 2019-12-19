using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projct1
{
    public partial class startup_page : Form
    {
        public startup_page()
        {
            InitializeComponent();
        }

        private void startup_page_Load(object sender, EventArgs e)
        {

        }

        
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void maximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximize.Image = maximize.Image;
                this.WindowState = FormWindowState.Normal;

            }
            else
                if (this.WindowState == FormWindowState.Normal)
            {
                maximize.Image = maximize.Image;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
               
                this.WindowState = FormWindowState.Minimized;

            }
            else
                if (this.WindowState == FormWindowState.Normal)
            {
               
                this.WindowState = FormWindowState.Minimized;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Batchcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Batchcombobox.Text == "2k16-2020")
            {
                Batch bat = new Batch(this);
                bat.ShowDialog();

            }
            
        }

        private void Rollnobtn_Click(object sender, EventArgs e)
        {
            Searchstudent_info srchinfo = new Searchstudent_info(this);
            srchinfo.ShowDialog();
            if (Rollnotxtbox.Text == null)
                MessageBox.Show("Enter your correct Roll Number");
        }

        private void importpictureBox_DoubleClick(object sender, EventArgs e)
        {
            login lgin= new login();
            lgin.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void maximize_Click_1(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximize.Image = maximize.Image;
                this.WindowState = FormWindowState.Normal;

            }
            else
                if (this.WindowState == FormWindowState.Normal)
            {
                maximize.Image = maximize.Image;
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Minimized;

            }
            else
            if (this.WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Minimized;
            }

        }

        private void importpictureBox_Click(object sender, EventArgs e)
        {

        }

        private void regnobtn_Click(object sender, EventArgs e)
        {    Searchstudent_info srchinfo = new Searchstudent_info(this);
                    srchinfo.ShowDialog();
                
            


        }
    }
}
