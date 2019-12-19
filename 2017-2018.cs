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
    public partial class _2017_2018 : Form
    {
        //DEFINE CON STRING
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Richardlee\\Desktop\\project 1\\Batch1.xls;Extended Properties=Excel 8.0;";

        public _2017_2018()
        {
            InitializeComponent();
        }

        private void _2017_2018_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [Sheet2$]";
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

        
    }
}
