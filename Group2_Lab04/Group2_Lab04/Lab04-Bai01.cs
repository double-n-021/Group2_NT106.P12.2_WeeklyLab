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

namespace Group2_Lab04
{
    public partial class Lab04_Bai01 : Form
    {
        public Lab04_Bai01()
        {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbURL.Text))
                MessageBox.Show("Hãy nhập URL trước khi nhấn GET!");
            else
            {
                string sURL = tbURL.Text;
                WebRequest request = WebRequest.Create(sURL);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                response.Close();
                rtbShow.Text = responseFromServer;
            }
        }
    }
}
