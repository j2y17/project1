using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projct1
{
    public partial class Searchstudent_info : Form
    {

        //DEFINE CON STRING
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Richardlee\\Desktop\\project 1\\student_information.xls;Extended Properties=Excel 8.0;";
        startup_page start;


        public Searchstudent_info(startup_page frm)
        {
            InitializeComponent();
            this.start = frm;
        }

        private void SearchAssessment_Load(object sender, EventArgs e)
        {
            textBox1.Text = start.Rollnotxtbox.Text;
            stdtextBox.Text = start.Regnotxtbox.Text;
            for (int j = 0; j <= 100; j++)
            {
                if (stdtextBox.Text == "41081610400" + j)
                {
                    
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
                pictureBox1.Image = Image.FromFile("C:\\Users\\Richardlee\\Desktop\\project 1\\pic.png");

                if (textBox1.Text == "21cse16" + j)
                {
                    string sql = "SELECT * FROM [ROLLNO_info$]";
                    //CREATE  ON OBJECT
                    OleDbConnection con = new OleDbConnection(conString);
                    //ADAPTOR
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
                    /////dataset
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();

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
                pictureBox1.Image = Image.FromFile("C:\\Users\\Richardlee\\Desktop\\project 1\\pic.png");


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Assessment assmt = new Assessment();
            assmt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result reslt = new Result();
            reslt.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }
    }
}                   
                 
            
        
    


