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
    public partial class Batch : Form
    {
        startup_page start;
                //DEFINE CON STRING
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Richardlee\\Desktop\\project 1\\BATCH.xls;Extended Properties=Excel 8.0;";
        public Batch(startup_page frm)
        {
            InitializeComponent();
            this.start = frm;
        
        }

        

        private void Batch_Load(object sender, EventArgs e)
        {
            
            comboBox1.Text = start.Batchcombobox.Text;
            
            string sql = "SELECT * FROM ["+comboBox1.Text+"$]";
            //CREATE  ON OBJECT
            OleDbConnection con = new OleDbConnection(conString);
            //ADAPTOR
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            /////dataset
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            con.Close();
           



        }
        

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
                if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
                {
                dataGridView1.CurrentRow.Selected = true;
                batchtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["REGISTER NO"].FormattedValue.ToString();
                }
            for (int i = 0; i <= 26; i++)
            {
                if (batchtextBox.Text == "41081610400" + i)

                {
                    student_information stdinfo = new student_information(this);
                    stdinfo.ShowDialog();
                }else
                if (batchtextBox.Text == "4108161040"+i)

                {
                    student_information stdinfo = new student_information(this);
                    stdinfo.ShowDialog();
                }
            }

           
        }

        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [" + comboBox1.Text + "$]";
            //CREATE  ON OBJECT
            OleDbConnection con = new OleDbConnection(conString);
            //ADAPTOR
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            /////dataset
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    