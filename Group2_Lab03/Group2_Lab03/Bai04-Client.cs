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
                byte[] data = Encoding.UTF8.GetBytes(userName);
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
                string recipient = cbListParticipants.SelectedItem?.ToString() ?? "All";
                string message = tbMess.Text.Trim();

                if (recipient.Equals("All", StringComparison.OrdinalIgnoreCase))
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
                else
                {
                    string privateMessage = $"PRIVATE:{recipient}:{message}";
                    byte[] data = Encoding.UTF8.GetBytes(privateMessage);
                    stream.Write(data, 0, data.Length);
                }

                tbMess.Clear();
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

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    if (message.StartsWith("PARTICIPANTS:"))
                    {
                        string participants = message.Replace("PARTICIPANTS:", "").Trim();
                        Invoke(new Action(() =>
                        {
                            rtbListParticipants.Clear();
                            rtbListParticipants.AppendText(participants);

                            // Cập nhật comboBox danh sách người dùng
                            cbListParticipants.Items.Clear();
                            cbListParticipants.Items.Add("All");
                            foreach (var participant in participants.Split('\n'))
                            {
                                if (!string.IsNullOrWhiteSpace(participant))
                                    cbListParticipants.Items.Add(participant.Trim());
                            }
                        }));
                    }
                    else
                    {
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

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Supported Files|*.jpg;*.png;*.txt|All Files|*.*";
                openFileDialog.Title = "Select a File or Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = System.IO.Path.GetFileName(filePath);
                    string recipient = cbListParticipants.SelectedItem?.ToString() ?? "All";

                    try
                    {
                        // Đọc dữ liệu file
                        byte[] fileData = System.IO.File.ReadAllBytes(filePath);

                        // Kiểm tra loại file
                        string messageType;
                        if (filePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                            filePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                        {
                            messageType = "IMAGE";
                        }
                        else if (filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                        {
                            messageType = "FILE";
                        }
                        else
                        {
                            MessageBox.Show("Unsupported file type. Only .jpg, .png, and .txt are allowed.");
                            return;
                        }

                        // Đóng gói tin nhắn với tiêu đề và dữ liệu file
                        string header = $"{messageType}:{recipient}:{fileName}:{fileData.Length}";
                        byte[] headerData = Encoding.UTF8.GetBytes(header);
                        stream.Write(headerData, 0, headerData.Length); // Gửi tiêu đề

                        // Gửi dữ liệu file
                        stream.Write(fileData, 0, fileData.Length); // Gửi nội dung file

                        MessageBox.Show($"{fileName} sent successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error sending file: {ex.Message}");
                    }
                }
            }
        }

    }
}
