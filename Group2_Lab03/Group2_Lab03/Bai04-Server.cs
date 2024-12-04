using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai04_Server : Form
    {
        private TcpListener server;
        private List<User> userList = new List<User>();

        public Bai04_Server()
        {
            InitializeComponent();
        }
        private void btListen_Click(object sender, EventArgs e)
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8080);
                server.Start();
                MessageBox.Show("Server is listening...");
                btListen.Enabled = false;
                Thread clientListener = new Thread(Listen);
                clientListener.IsBackground = true;
                clientListener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi động server: " + ex.Message);
            }
        }

        private void Listen()
        {
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show($"Lỗi socket: {ex.Message}");
                    break;
                }
            }
        }

        void HandleClient(object obj)
        {
            TcpClient client = obj as TcpClient;
            NetworkStream stream = client.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);
            {
                User user = new User(client);
                userList.Add(user);
                try
                {
                    string requestInJson = string.Empty;
                    while (true)
                    {
                        requestInJson = user.Reader.ReadString();

                        Packet request = JsonConvert.DeserializeObject<Packet>(requestInJson);

                        switch (request.code)
                        {
                            case 0:
                                connecting_handler(user, request);
                                break;
                            case 1:
                                send_message_handler(user, request);
                                break;
                            case 2:
                                send_file_handler(user, request);
                                break;
                        }
                    }
                }
                catch
                {
                    close_client(user);
                }
            }
        }

        private void connecting_handler(User user, Packet request)
        {
            IPEndPoint clientEndPoint = user.tcpClient.Client.RemoteEndPoint as IPEndPoint;
            string clientIP = clientEndPoint.Address.ToString();
            int clientPort = clientEndPoint.Port;
            AppendTextSafe($"New client connected from {clientIP} at port {clientPort}");
            user.Username = request.username;

            // gửi danh sách user sau khi thêm user mới cho các user cũ trong phòng tương ứng
            request.username = GetUsernameListInString();

            foreach (User _user in userList)
            {
                sendSpecific(_user, request);
            }
        }

        private string GetUsernameListInString()
        {
            List<string> usernames = new List<string>();
            foreach (User user in userList)
            {
                usernames.Add(user.Username);
            }
            string[] s = usernames.ToArray();
            string res = string.Join(",", s);
            return res;
        }


        private void send_message_handler(User user, Packet request)
        {
            Packet messagePacket = new Packet
            {
                code = 1,
                username = user.Username,
                message = request.message
            };

            foreach (User Users in userList)
            {
                if (request.tofriend != "")
                {
                    if (Users.Username == request.tofriend)
                    {
                        sendSpecific(Users, messagePacket);
                        return;
                    }
                }
                else if (Users != user) // Bỏ qua người gửi
                {
                    sendSpecific(Users, messagePacket);
                }
            }

            AppendTextSafe(user.Username + ": " + request.message);
        }

        private void send_file_handler(User user, Packet request)
        {
            Packet messagePacket = new Packet
            {
                code = 2,
                username = user.Username,
                data = request.data
            };

            foreach (User Users in userList)
            {
                if (request.tofriend != "")
                {
                    if (Users.Username == request.tofriend)
                    {
                        sendSpecific(Users, messagePacket);
                        AppendTextSafe(user.Username + "sent a file");
                        return;
                    }
                }
                else if (Users != user) // Bỏ qua người gửi
                {
                    sendSpecific(Users, messagePacket);
                }
            }
            AppendTextSafe(user.Username + "sent a file");
        }

        private void close_client(User user)
        {
            userList.Remove(user);
            user.tcpClient.Close();

            if (user.Username != string.Empty)
            {
                AppendTextSafe(user.Username + " left the group.");
            }

            //Gửi thông báo về client vừa ngắt kết nối đến client khác trong phòng
            Packet message = new Packet()
            {
                code = 0,
                username = "!" + user.Username,
            };

            foreach (User _user in userList)
            {
                sendSpecific(_user, message);
            }
        }

        private void sendSpecific(User user, Object message)
        {
            if (user.tcpClient.Connected)
            {
                string messageInJson = JsonConvert.SerializeObject(message);
                try
                {
                    user.Writer.Write(messageInJson);
                    user.Writer.Flush();
                }
                catch (Exception ex)
                {
                    rtbMessage.Text = rtbMessage.Text + $"Cannot send data to user: {user.Username}\nError: {ex.Message}";
                }
            }
        }
        private void AppendTextSafe(string text)
        {
            if (rtbMessage.InvokeRequired)
            {
                rtbMessage.Invoke(new Action(() => rtbMessage.AppendText(text + Environment.NewLine)));
            }
            else
            {
                rtbMessage.AppendText(text + Environment.NewLine);
            }
        }

        class Packet
        {
            public string username { get; set; }
            public string message { get; set; }
            public byte[] data { get; set; }
            public string tofriend { get; set; }
            public int code { get; set; }
        }

        class User
        {
            public string Username { get; set; }
            public TcpClient tcpClient { get; set; }
            public BinaryReader Reader { get; set; }
            public BinaryWriter Writer { get; set; }

            public User(TcpClient client)
            {
                tcpClient = client;
                Username = string.Empty;
                NetworkStream stream = tcpClient.GetStream();
                Reader = new BinaryReader(stream);
                Writer = new BinaryWriter(stream);
            }
        }
    }
}
