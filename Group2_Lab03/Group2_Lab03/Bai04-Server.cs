using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai04_Server : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<TcpClient, string> userNames = new Dictionary<TcpClient, string>();
        private Thread listenThread;
        private const int PORT = 8080;

        public Bai04_Server()
        {
            InitializeComponent();
        }

        private void rbtManageMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi động server
                server = new TcpListener(IPAddress.Any, PORT);
                server.Start();
                listenThread = new Thread(AcceptClients);
                listenThread.Start();

                MessageBox.Show($"Server is listening on port {PORT}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting server: {ex.Message}");
            }
        }

        private void AcceptClients()
        {
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    lock (clients)
                    {
                        clients.Add(client);
                    }

                    Thread clientThread = new Thread(HandleClient);
                    clientThread.Start(client);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error accepting client: {ex.Message}");
                }
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                // Nhận tên người dùng
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                string userName = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                lock (userNames)
                {
                    userNames[client] = userName;
                }

                // Gửi danh sách người dùng hiện tại đến tất cả các client
                BroadcastParticipants();

                // Thông báo rằng người dùng đã tham gia
                BroadcastMessage($"{userName} đã tham gia phòng chat.", client);
                UpdateManageMessage($"{userName} đã tham gia phòng chat.");

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                    // Nếu client gửi "quit", ngắt kết nối
                    if (message.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    {
                        BroadcastMessage($"{userName} đã rời phòng chat.", client);
                        UpdateManageMessage($"{userName} đã rời phòng chat.");
                        break;
                    }

                    // Gửi tin nhắn từ người dùng đến tất cả client khác
                    BroadcastMessage($"{userName}: {message}", client);
                    UpdateManageMessage($"{userName}: {message}");
                }
            }
            catch (Exception ex)
            {
                UpdateManageMessage($"Lỗi xử lý client: {ex.Message}");
            }
            finally
            {
                lock (clients)
                {
                    clients.Remove(client);
                }
                lock (userNames)
                {
                    if (userNames.ContainsKey(client))
                        userNames.Remove(client);
                }
                // Gửi lại danh sách người dùng sau khi có người rời
                BroadcastParticipants();

                client.Close();
            }
        }

        private void UpdateManageMessage(string message)
        {
            if (rbtManageMessage.InvokeRequired)
            {
                rbtManageMessage.Invoke(new Action(() =>
                {
                    rbtManageMessage.AppendText($"{message}{Environment.NewLine}");
                }));
            }
            else
            {
                rbtManageMessage.AppendText($"{message}{Environment.NewLine}");
            }
        }


        private void BroadcastMessage(string message, TcpClient excludeClient)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            lock (clients)
            {
                foreach (var client in clients)
                {
                    if (client != excludeClient)
                    {
                        try
                        {
                            NetworkStream stream = client.GetStream();
                            stream.Write(data, 0, data.Length);
                        }
                        catch
                        {
                            // Ngắt kết nối với client nếu không gửi được
                            client.Close();
                        }
                    }
                }
            }
        }

        // Gửi danh sách participant đến tất cả các client
        private void BroadcastParticipants()
        {
            lock (userNames)
            {
                string participants = string.Join("\n", userNames.Values);
                byte[] data = Encoding.UTF8.GetBytes($"PARTICIPANTS:{participants}");

                foreach (var client in clients)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                    }
                    catch
                    {
                        client.Close();
                    }
                }
            }
        }
    }
}
