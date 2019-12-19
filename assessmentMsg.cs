using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projct1
{
    public partial class assessmentMsg : Form
    {
        Assessment assessmentmsg;
        public assessmentMsg(Assessment frm)
        {
            InitializeComponent();
            this.assessmentmsg = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String result;
            string apiKey = "FiDvD3vqqIk-M2M1RL4ZjH6iiDmhEmgBpp3CufDnFb";
            string numbers = "9445102952"; // in a comma seperated list
            string message = richTextBox1.Text;
            string send = "TXTLCL";


            String url = "https://api.textlocal.in/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + send;
            //refer to parameters to complete correct url string

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);
            }
            catch (Exception ex)
            {
                //return e.Message;
                MessageBox.Show(null, "the error is" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }
            //     return result;
            MessageBox.Show(result);



        }

        private void assessmentMsg_Load(object sender, EventArgs e)
        {
            textBox1.Text = assessmentmsg.assessmenttxtbox.Text;
            object filename =textBox1.Text;
            Microsoft.Office.Interop.Word.Application ac = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;
            try
            {
                doc = ac.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible);
                doc.Content.Select();
                doc.Content.Copy();
                richTextBox1.Paste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);

            }
            finally
            {
                doc.Close(ref missing, ref missing, ref missing);

            }

        }
    }
}
