using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btOpenServer_Click(object sender, EventArgs e)
        {
            Bai03_Server Form_server = new Bai03_Server();
            Form_server.Show();
        }

        private void btOpenClient_Click(object sender, EventArgs e)
        {
            Bai03_Client Form_client = new Bai03_Client();
            Form_client.Show();
        }
    }
}
