using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai05_Server : Form
    {
        private TcpListener server;
        private List<TcpClient> connectedClients = new List<TcpClient>();
        private int connectionCount = 0;
        private int emptySeat = 25;
        private int pickedSeat = 0;
        private Manage seatManager = new Manage();

        public Bai05_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                server = new TcpListener(IPAddress.Any, int.Parse(tbPort.Text));
                server.Start();

                Thread clientListener = new Thread(Listen);
                clientListener.IsBackground = true;
                clientListener.Start();
                AppendText("Server is listening ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting server: " + ex.Message);
            }
        }

        private void Listen()
        {
            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();

                    // Thêm client vào danh sách
                    connectedClients.Add(client);
                    AppendText($"Client connected. Total clients: {connectedClients.Count}");

                    // Cập nhật connectionCount một lần duy nhất
                    UpdateConnectionCount(1);

                    // Tạo luồng xử lý client
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                AppendText($"Error in listener: {ex.Message}");
            }
        }

        private void BroadcastMessage(string message)
        {
            lock (connectedClients) // Đảm bảo các thao tác trên danh sách client được thread-safe
            {
                foreach (var client in connectedClients.ToList())
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
                        writer.WriteLine(message);
                    }
                    catch (Exception ex)
                    {
                        AppendText($"Error broadcasting to client: {ex.Message}");
                        connectedClients.Remove(client);
                    }
                }
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

            try
            {
                while (true)
                {
                    string data = reader.ReadLine();
                    if (string.IsNullOrEmpty(data))
                        break;

                    if (data == "Disconnect")
                    {
                        AppendText("Client disconnected.");
                        UpdateConnectionCount(-1);
                        break;
                    }




                    string[] parts = data.Split(',');

                    if (parts.Length < 3)
                    {
                        writer.WriteLine("Error: Invalid data format.");
                        continue;
                    }

                    string action = parts[0]; // "Select" hoặc "Book"
                    int seatNumber = int.Parse(parts[1]);
                    string customerName = parts[2];
                    string result = string.Empty;

                    if (action == "Select")
                    {
                        result = seatManager.SelectSeat(seatNumber, customerName);

                        UpdateSelectSeat(seatNumber, customerName);

                        // Broadcast trạng thái ghế được chọn tới tất cả client
                        BroadcastMessage($"SeatUpdate,{seatNumber},Selecting");
                    }
                    else if (action == "Book")
                    {
                        result = seatManager.BookSeat(seatNumber, customerName);

                        UpdateSeatButtonAppearance(seatNumber, customerName);
                        UpdateSeatEmpty(-1);
                        UpdateSeatPicked(1);

                        // Broadcast trạng thái ghế được đặt tới tất cả client
                        BroadcastMessage($"SeatUpdate,{seatNumber},Booked");
                    }
                    else if (action == "CancelSelect")
                    {
                        result = seatManager.CancelSeatSelection(seatNumber);

                        // Hủy chọn ghế và đưa ghế về trạng thái bình thường
                        UpdateCancelSeat(seatNumber);

                        // Broadcast trạng thái ghế bị hủy chọn tới tất cả client
                        BroadcastMessage($"SeatUpdate,{seatNumber},Cancelled");
                    }
                    writer.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                AppendText($"Error handling client: {ex.Message}");
            }
            finally
            {
                // Loại bỏ client khỏi danh sách kết nối
                connectedClients.Remove(client);
                AppendText($"Client disconnected. Total clients: {connectedClients.Count}");
                client.Close();
            }
        }

        // Phương thức hủy chọn ghế và đưa ghế về trạng thái bình thường
        private void UpdateCancelSeat(int seatNumber)
        {
            Button seatButton = this.Controls.Find($"btn{seatNumber}", true).FirstOrDefault() as Button;

            if (seatButton != null)
            {
                // Kiểm tra xem chúng ta có đang ở trên luồng chính không, nếu không thì sử dụng Invoke
                if (seatButton.InvokeRequired)
                {
                    // Sử dụng Invoke để thực thi hành động cập nhật giao diện trên luồng chính
                    seatButton.Invoke(new Action(() =>
                    {
                        seatButton.BackColor = SystemColors.ButtonHighlight; // Màu sắc mặc định của ghế
                        seatButton.Text = seatNumber.ToString(); // Khôi phục lại tên ghế
                    }));
                }
                else
                {
                    // Nếu đang ở trên luồng chính, trực tiếp cập nhật UI
                    seatButton.BackColor = SystemColors.ButtonHighlight;
                    seatButton.Text = seatNumber.ToString();
                }
            }
        }


        private void UpdateSeatButtonAppearance(int seatNumber, string customerName)
        {
            Button seatButton = this.Controls.Find($"btn{seatNumber}", true).FirstOrDefault() as Button;

            if (seatButton != null)
            {
                // Kiểm tra xem chúng ta có đang ở trên luồng chính không, nếu không thì sử dụng Invoke
                if (seatButton.InvokeRequired)
                {
                    seatButton.Invoke(new Action(() =>
                    {
                        seatButton.BackColor = SystemColors.ActiveBorder;
                        seatButton.Text = customerName;
                    }));
                }
                else
                {
                    seatButton.BackColor = SystemColors.ActiveBorder;
                    seatButton.Text = customerName;
                }
            }
        }

        private void UpdateSelectSeat(int seatNumber, string customerName)
        {
            Button seatButton = this.Controls.Find($"btn{seatNumber}", true).FirstOrDefault() as Button;

            if (seatButton != null)
            {
                // Kiểm tra xem chúng ta có đang ở trên luồng chính không, nếu không thì sử dụng Invoke
                if (seatButton.InvokeRequired)
                {
                    seatButton.Invoke(new Action(() =>
                    {
                        seatButton.BackColor = Color.PaleTurquoise;
                    }));
                }
                else
                {
                    seatButton.BackColor = Color.PaleTurquoise;
                }
            }
        }

        private void UpdateConnectionCount(int delta)
        {
            lock (this)
            {
                connectionCount += delta;

                // Cập nhật TextBox trên UI thread
                if (tbConnection.InvokeRequired)
                {
                    tbConnection.Invoke(new Action(() => tbConnection.Text = connectionCount.ToString()));
                }
                else
                {
                    tbConnection.Text = connectionCount.ToString();
                }
            }
        }

        private void UpdateSeatPicked(int delta)
        {
            lock (this)
            {
                pickedSeat += delta;

                // Cập nhật TextBox trên UI thread
                if (tbSeatPicked.InvokeRequired)
                {
                    tbSeatPicked.Invoke(new Action(() => tbSeatPicked.Text = pickedSeat.ToString()));
                }
                else
                {
                    tbSeatPicked.Text = pickedSeat.ToString();
                }
            }
        }

        private void UpdateSeatEmpty(int delta)
        {
            lock (this)
            {
                emptySeat += delta;

                // Cập nhật TextBox trên UI thread
                if (tbSeatNotPicked.InvokeRequired)
                {
                    tbSeatNotPicked.Invoke(new Action(() => tbSeatNotPicked.Text = emptySeat.ToString()));
                }
                else
                {
                    tbSeatNotPicked.Text = emptySeat.ToString();
                }
            }
        }

        private void AppendText(string text)
        {
            // Thêm log vào RichTextBox từ luồng UI chính
            if (rtb.InvokeRequired)
            {
                rtb.Invoke(new Action(() => rtb.AppendText(text + Environment.NewLine)));
            }
            else
            {
                rtb.AppendText(text + Environment.NewLine);
            }
        }
    }
}
