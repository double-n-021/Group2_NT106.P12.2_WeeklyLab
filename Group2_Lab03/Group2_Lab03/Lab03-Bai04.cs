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
    public partial class Bai04 : Form
    {
        private Bai04_Server tcpServerForm;
        private List<Bai04_Client> tcpClientForms = new List<Bai04_Client>();

        public Bai04()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            //Hiển thị form TCP Server của bài 4
            if(tcpServerForm == null) 
            {
                tcpServerForm = new Bai04_Server();
            }
            tcpServerForm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            //Hiển thị form TCP Client của bài 4
            Bai04_Client newClientForm = new Bai04_Client();
            tcpClientForms.Add(newClientForm);
            newClientForm.FormClosed += (s, args) =>
            {
                tcpClientForms.Remove(newClientForm);
            };
            newClientForm.Show();

        }
    }
}
