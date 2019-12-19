using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace projct1
{
    public partial class importfiles : Form
    {
        public importfiles()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;

                textBox1.Text = openFileDialog1.FileName;
            }
           



        }
        private void button2_Click(object sender, EventArgs e)
        {


            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel File (*.xls)|*.xls";
            saveFileDialog1.Title = "Where do you want to save the file?";
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    
                        Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                        Excel.Workbook xlWorkBook;
                        Excel.Worksheet xlWorkSheet;

                        object misValue = System.Reflection.Missing.Value;
                        xlApp = new Excel.Application();
                        xlWorkBook = xlApp.Workbooks.Add(misValue);
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                  
                    int i = 0;
                        int j = 0;

                    for (i = 0; i <= dataGridView1.RowCount - 2; i++)

                    {

                        for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)

                        {

                            xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();

                        }

                    }



                    xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);


                        xlWorkBook.Close(true, misValue, misValue);
                        xlApp.Quit();

                        releaseObject(xlWorkSheet);
                        releaseObject(xlWorkBook);
                        releaseObject(xlApp);


                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch(Exception ex)
            {
                obj = null;
                MessageBox.Show("unable to release the object" + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            //DEFINE CON STRING
            string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties=Excel 8.0;";
            
                string sql = "SELECT * FROM ["+textBox2.Text+"$]";

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
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
