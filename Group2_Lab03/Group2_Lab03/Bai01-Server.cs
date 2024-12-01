using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai01_Server : Form
    {
        private UdpClient udpClient;
        private Thread serverThread;

        public Bai01_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(txtPort.Text);
            StartUDPServer(port);
        }
        private void StartUDPServer(int port)
        {
            try
            {
                udpClient = new UdpClient(port);
                serverThread = new Thread(serverThread_Function);
                serverThread.Start();
                rtbReceivedMessages.AppendText($"Listening on port {port}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting UDP server: {ex.Message}");
            }
        }
        private void serverThread_Function()
        {
            try
            {
                while (true)
                {
                    IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receivedBytes = udpClient.Receive(ref remoteEndPoint);
                    string message = Encoding.UTF8.GetString(receivedBytes);
                    rtbReceivedMessages.Invoke((MethodInvoker)delegate
                    {
                        rtbReceivedMessages.AppendText($"Received: {message}\n");
                    });
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error in server thread: {ex.Message}");
            }
        }
    }
}
