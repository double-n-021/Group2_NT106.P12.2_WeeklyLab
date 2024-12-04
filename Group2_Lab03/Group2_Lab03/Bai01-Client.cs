using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai01_Client : Form
    {
        private UdpClient udpClient;

        public Bai01_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string remoteHost = txtRemoteHost.Text;
            int port = Convert.ToInt32(txtPort.Text);
            string message = rtbMessage.Text;

            SendUDPMessage(remoteHost, port, message);
            // Xóa nội dung trong khung nhập tin nhắn sau khi gửi
            rtbMessage.Clear();
        }

        private void SendUDPMessage(string remoteHost, int port, string message)
        {
            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(remoteHost), port);
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient = new UdpClient();
                udpClient.Send(data, data.Length, remoteEndPoint);
                //rtbMessage.AppendText($"Sent: {message}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending UDP message: {ex.Message}");
            }
        }
    }
}
