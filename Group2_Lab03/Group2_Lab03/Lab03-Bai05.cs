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
    public partial class Lab03_Bai05 : Form
    {
        public Lab03_Bai05()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Bai05_Server server = new Bai05_Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Bai05_Client client = new Bai05_Client();  
            client.Show();
        }

        private void Lab03_Bai05_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }
    }
}
