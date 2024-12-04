using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group2_Lab03
{
    public partial class Bai04_Client : Form
    {
        Packet this_client_info;
        Manager manager;
        TcpClient tcpClient;
        NetworkStream ns;
        BinaryReader reader;
        BinaryWriter writer;
        Byte[] data = null;

        public Bai04_Client()
        {
            InitializeComponent();
            manager = new Manager(lvParticipants);
            this.FormClosing += Client_FormClosing;
        }
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient != null && tcpClient.Connected)
            {
                Packet disconnectPacket = new Packet
                {
                    code = 3,
                    username = tbYourName.Text,
                    message = "Disconnected"
                };

                sendToServer(disconnectPacket);
                tcpClient.Close();
            }
        }
        private void btConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbYourName.Text))
            {
                MessageBox.Show("Please enter your name before connecting to server!");
            }
            else
            {
                this_client_info = new Packet()
                {
                    username = tbYourName.Text,
                    code = 0,
                    message = "",
                    data = null,
                    tofriend = tbYourFriendName.Text,
                };

                try
                {
                    tcpClient = new TcpClient("127.0.0.1", 8080);
                    NetworkStream stream = tcpClient.GetStream();
                    writer = new BinaryWriter(stream);
                    reader = new BinaryReader(stream); // Reader để đọc phản hồi
                    {
                        sendToServer(this_client_info);
                        manager.AddToUserListView(tbYourName.Text);
                        Thread listen = new Thread(Receive);
                        listen.IsBackground = true;
                        listen.Start();
                    }
                    btConnect.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Da dong ket noi: " + ex.Message);
                }
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string yourfriendname = string.IsNullOrEmpty(tbYourFriendName.Text) ? "" : tbYourFriendName.Text;
            if (!string.IsNullOrEmpty(tbMessage.Text))
            {
                rtbMessage.Text = rtbMessage.Text + "Me: " + tbMessage.Text + "\n";
                // Tạo gói tin nhắn Packet để gửi tới server
                Packet chatPacket = new Packet
                {
                    username = tbYourName.Text,
                    code = 1,
                    message = tbMessage.Text,
                    tofriend = yourfriendname,
                };

                // Gửi tin nhắn đến server
                sendToServer(chatPacket);
                tbMessage.Clear();
            }
            else
                MessageBox.Show("Please enter your message");
        }

        private void btSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Image Files (*.jpg;*.png)|*.jpg;*.png",
                Title = "Select a File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                byte[] fileData = File.ReadAllBytes(filePath);
                string fileName = Path.GetFileName(filePath);

                string yourfriendname = string.IsNullOrEmpty(tbYourFriendName.Text) ? "" : tbYourFriendName.Text;

                Packet filePacket = new Packet
                {
                    username = tbYourName.Text,
                    code = 2,
                    data = fileData,
                    message = fileName,
                    tofriend = yourfriendname
                };

                rtbMessage.AppendText($"You sent a file: {fileName}\n");

                // Send the packet to the server
                sendToServer(filePacket);
            }
        }

        private void sendToServer(Packet message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                writer.Write(messageInJson);
                writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Receive()
        {
            try
            {
                string responseInJson = string.Empty;
                while (true)
                {
                    responseInJson = reader.ReadString();

                    Packet response = JsonConvert.DeserializeObject<Packet>(responseInJson);

                    switch (response.code)
                    {
                        case 0:
                            connecting_status(response);
                            break;
                        case 1:
                            displayChatMessage(response.username, response.message);
                            break;
                        case 2:
                            displayFileMessage(response);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                tcpClient.Close();
            }
        }

        void connecting_status(Packet response)
        {
            if (response.username.Contains('!'))
            {
                manager.RemoveFromUserListView(response.username.Substring(1));
            }
            else
            {
                List<string> listusername = response.username.Split(',').ToList();
                foreach (string username in listusername)
                {
                    if (username == tbYourName.Text)
                    {
                        listusername.Remove(username);
                        break;
                    }
                }
                manager.ClearUserListView();
                foreach (string username in listusername)
                {
                    manager.AddToUserListView(username);
                }
            }
            response.code = 3;
            sendToServer(response);
        }

        void displayChatMessage(string Fusername, string Message)
        {
            AppendTextSafe(Fusername + ": " + Message);

        }

        void displayFileMessage(Packet response)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => displayFileMessage(response)));
                return;
            }

            DialogResult result = MessageBox.Show($"{response.username} has sent you a file: {response.message}. Do you want to save it?",
                                                  "File Received",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = response.message;
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Image Files (*.jpg;*.png)|*.jpg;*.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, response.data);
                            MessageBox.Show($"File saved successfully at: {saveFileDialog.FileName}",
                                            "File Saved",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving file: {ex.Message}",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                rtbMessage.AppendText($"{response.username} sent a file, but you chose not to save it.\n");
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

    }

    class Packet
    {
        public string username { get; set; }
        public string message { get; set; }
        public byte[] data { get; set; }
        public string tofriend { get; set; }
        public int code { get; set; }
    }

    class Manager
    {
        ListView List;

        public Manager(ListView list)
        {
            List = list;
        }

        public void AddToUserListView(string line)
        {
            if (List.InvokeRequired)
            {
                List.Invoke(new Action(() =>
                {
                    List.Items.Add(line);
                }));
            }
            else
            {
                List.Items.Add(line);
            }
        }

        public void RemoveFromUserListView(string line)
        {
            Action action = () =>
            {
                foreach (ListViewItem item in List.Items)
                {
                    if (item.Text == line)
                    {
                        List.Items.Remove(item);
                        break;
                    }
                }
            };
            if (List.InvokeRequired)
            {
                List.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public void ClearUserListView()
        {
            Action action = () =>
            {
                ListViewItem firstLine = List.Items[0];
                List.Clear();
                List.Items.Add(firstLine);
            };
            if (List.InvokeRequired)
            {
                List.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
