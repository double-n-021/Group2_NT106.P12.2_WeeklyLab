using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai04_Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;

        public Bai04_Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please enter your username.");
                return;
            }

            try
            {
                client = new TcpClient("127.0.0.1", 8080);
                stream = client.GetStream();

                // Gửi tên người dùng đến server
                string userName = tbName.Text.Trim();
                byte[] data = Encoding.ASCII.GetBytes(userName);
                stream.Write(data, 0, data.Length);

                // Bắt đầu nhận tin nhắn
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                MessageBox.Show("Connected to server!");
                btnSend.Enabled = true;
                tbMess.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to server: {ex.Message}");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMess.Text)) return;

            try
            {
                string message = tbMess.Text.Trim();
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);

                tbMess.Clear();

                // Nếu gửi "quit", ngắt kết nối
                if (message.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}");
            }
        }
        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];

            try
            {
                while (true)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Kiểm tra nếu server gửi danh sách participant
                    if (message.StartsWith("PARTICIPANTS:"))
                    {
                        string participants = message.Replace("PARTICIPANTS:", "").Trim();
                        Invoke(new Action(() =>
                        {
                            rtbListParticipants.Clear();
                            rtbListParticipants.AppendText(participants);
                        }));
                    }
                    else
                    {
                        // Hiển thị tin nhắn bình thường
                        Invoke(new Action(() =>
                        {
                            rtbChat.AppendText(message + Environment.NewLine);
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Disconnected: {ex.Message}");
            }
            finally
            {
                Disconnect();
            }
        }
        private void Disconnect()
        {
            stream?.Close();
            client?.Close();
            if (receiveThread != null && receiveThread.IsAlive)
                receiveThread.Abort();

            Invoke(new Action(() =>
            {
                btnSend.Enabled = false;
                tbMess.Enabled = false;
            }));
        }

    }
}
