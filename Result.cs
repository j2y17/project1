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
    public partial class Result : Form
    {
        //DEFINE CON STRING
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Richardlee\\Desktop\\project 1\\MARKRESULT.xls;Extended Properties=Excel 8.0;";

        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem1$]";
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

        private void button1_Click(object sender, EventArgs e)
        {
            resultMsgload load = new resultMsgload(this);
            load.ShowDialog();
        }

        private void sem1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem1$]";
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

        private void sem2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem2$]";
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

        private void sem3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem3$]";
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

        private void sem4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem4$]";
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

        private void sem5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem5$]";
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

        private void sem6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem6$]";
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

        private void sem7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem7$]";
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

        private void sem8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [sem8$]";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;

                resulttxtbox.Text = openFileDialog1.FileName;
            }


        }
    }
}
