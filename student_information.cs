using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projct1
{
    public partial class student_information : Form
    {
        //DEFINE CON STRING
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Richardlee\\Desktop\\project 1\\student_information.xls;Extended Properties=Excel 8.0;";


        Batch bat;
       

        public student_information(Batch frm)
        {
            InitializeComponent();
            this.bat = frm;
           
            
        }

        
      
        private void student_information_Load(object sender, EventArgs e)
        {

            stdtextBox.Text = bat.batchtextBox.Text;          

            string sql = "SELECT * FROM [studentinformation$]";
            //CREATE  ON OBJECT
            OleDbConnection con = new OleDbConnection(conString);
            //ADAPTOR
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            /////dataset
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            for (int j = 0; j <= 26; j++)
            {
                if (stdtextBox.Text == "41081610400" + j)
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        nametxtbox.Text = dataGridView1.Rows[j].Cells["NAME"].Value.ToString();
                        regnotxtbox.Text = dataGridView1.Rows[j].Cells["REGISTER NO"].Value.ToString();
                        rollnotxtbox.Text = dataGridView1.Rows[j].Cells["ROLL NO"].Value.ToString();
                        dobtxtbox.Text = dataGridView1.Rows[j].Cells["DOB"].Value.ToString();
                        gendertxtbox.Text = dataGridView1.Rows[j].Cells["gender"].Value.ToString();
                        batchtxtbox.Text = dataGridView1.Rows[j].Cells["BATCH"].Value.ToString();
                        phnotxtbox.Text = dataGridView1.Rows[j].Cells["PHONE NUMBER"].Value.ToString();

                    }
                }
                else
                if (stdtextBox.Text == "4108161040" + j)
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {
                        nametxtbox.Text = dataGridView1.Rows[j].Cells["NAME"].Value.ToString();
                        regnotxtbox.Text = dataGridView1.Rows[j].Cells["REGISTER NO"].Value.ToString();
                        rollnotxtbox.Text = dataGridView1.Rows[j].Cells["ROLL NO"].Value.ToString();
                        dobtxtbox.Text = dataGridView1.Rows[j].Cells["DOB"].Value.ToString();
                        gendertxtbox.Text = dataGridView1.Rows[j].Cells["gender"].Value.ToString();
                        batchtxtbox.Text = dataGridView1.Rows[j].Cells["BATCH"].Value.ToString();
                        phnotxtbox.Text = dataGridView1.Rows[j].Cells["PHONE NUMBER"].Value.ToString();

                    }
                }

            }
            pictureBox1.Image = Image.FromFile("C:\\Users\\Richardlee\\Desktop\\project 1\\pic.png");



        }


        private void button3_Click(object sender, EventArgs e)
        {
            Assessment ass = new Assessment();
            ass.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            others oth = new others(this);
            oth.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regnotxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rollnotxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dobtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gendertxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phnotxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void batchtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
