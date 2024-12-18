using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab04
{
    public partial class View_Form : Form
    {
        public View_Form(string sURL)
        {
            InitializeComponent();
            ShowSource(sURL);
        }
        private void ShowSource(string sURL)
        {
            WebRequest request = WebRequest.Create(sURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            rtbSource.Text = responseFromServer;
        }
    }
}
