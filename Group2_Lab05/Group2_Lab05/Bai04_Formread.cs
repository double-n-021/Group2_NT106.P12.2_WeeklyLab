using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab05
{
    public partial class Bai04_Formread : Form
    {
        private string EmailContent;
        public Bai04_Formread(string From, string to, string title, string EmailContent)
        {
            InitializeComponent();
            lbFrom.Text = From;
            lbTo.Text = to;
            lbTitle.Text = title;
            this.EmailContent = EmailContent;
        }

        private void Bai04_Formread_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = EmailContent;
        }
    }
}
