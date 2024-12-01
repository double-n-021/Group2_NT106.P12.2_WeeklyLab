using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai01 : Form
    {
        private Bai01_Client udpClientForm;
        private Bai01_Server udpServerForm;

        public Bai01()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            // Hiển thị form UDP Server
            if (udpServerForm == null)
            {
                udpServerForm = new Bai01_Server();
            }
            udpServerForm.Show();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            // Hiển thị form UDP Client
            if (udpClientForm == null)
            {
                udpClientForm = new Bai01_Client();
            }
            udpClientForm.Show();
            //this.Hide();
        }

    }

}
