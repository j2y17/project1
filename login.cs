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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text=="gkmcet"&&maskedTextBox2.Text=="cse2525")
            {
                importfiles imp = new importfiles();
                imp.ShowDialog();
            }
            else
                if (maskedTextBox1.Text != null && maskedTextBox2.Text != null)
                MessageBox.Show("Please enter your correct username and password");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Shown(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void login_Deactivate(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }
    }
}
