using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab03
{
    public partial class Bai05_Client : Form
    {
        private Button selectedButton;
        private TcpClient tcpClient;
        private StreamReader sReader;
        private StreamWriter sWriter;
        private Thread clientThread;
        private Manage seatManager;

        public Bai05_Client()
        {
            InitializeComponent();
            InitializeButtonEvents();
            seatManager = new Manage();
        }

        private void InitializeButtonEvents()
        {
            // Tìm và gán sự kiện cho tất cả các nút từ btn1 đến btn25
            for (int i = 1; i <= 25; i++)
            {
                string buttonName = $"btn{i}";
                Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    button.Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Kiểm tra nếu ghế đã được đặt (màu xám = "Booked")
            if (clickedButton.BackColor == SystemColors.ActiveBorder)
            {
                MessageBox.Show("Ghế này đã được đặt, vui lòng chọn ghế khác.");
                return;  // Không thay đổi trạng thái ghế nếu đã được đặt
            }

            // Kiểm tra nếu ghế đang được chọn
            if (clickedButton.BackColor == Color.PaleTurquoise)
            {
                MessageBox.Show("Ghế này đang được đặt, vui lòng chọn ghế khác.");
                return;  // Không thay đổi trạng thái ghế nếu đang được đặt
            }

            // Nếu ghế trước đó có màu xám, không thay đổi trạng thái ghế cũ
            if (selectedButton != null && selectedButton.BackColor != SystemColors.ActiveBorder)
            {
                // Nếu ghế cũ chưa bị đặt (không phải màu xám), cập nhật lại trạng thái ghế cũ về trạng thái ban đầu
                selectedButton.BackColor = SystemColors.ButtonHighlight;
                selectedButton.Text = selectedButton.Name.Replace("btn", "");

                // Gửi thông điệp tới server để cập nhật trạng thái ghế cũ về trạng thái bình thường
                int oldSeatNumber = int.Parse(selectedButton.Name.Replace("btn", ""));
                string oldMessage = $"CancelSelect,{oldSeatNumber},";
                SendMessageToServer(oldMessage);
            }

            // Cập nhật ghế mới được chọn
            selectedButton = clickedButton;
            selectedButton.BackColor = Color.PaleTurquoise; // Đổi màu nút được chọn
            selectedButton.Text = "Đang chọn..."; // Hiển thị "Đang chọn"

            // Gửi thông điệp tới server để thông báo thay đổi trạng thái ghế
            int seatNumber = int.Parse(clickedButton.Name.Replace("btn", ""));
            string message = $"Select,{seatNumber},";
            SendMessageToServer(message);
        }

        private void ReceiveDataFromServer()
        {
            try
            {
                while (true)
                {
                    string data = sReader.ReadLine(); // Đọc dữ liệu từ server
                    if (data == null) break;

                    if (data.StartsWith("SeatUpdate"))
                    {
                        // Xử lý thông điệp đồng bộ trạng thái ghế
                        string[] parts = data.Split(',');
                        {
                            int seatNumber = int.Parse(parts[1]);
                            string seatStatus = parts[2];

                            // Tìm nút ghế và cập nhật trạng thái
                            string buttonName = $"btn{seatNumber}";
                            Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                            if (button != null)
                            {
                                // Đảm bảo cập nhật trên UI thread
                                this.Invoke(new Action(() =>
                                {
                                    switch (seatStatus)
                                    {
                                        case "Booked":
                                            button.Text = seatNumber.ToString();
                                            button.BackColor = SystemColors.ActiveBorder; // Màu ghế đã chọn
                                            break;

                                        case "Selecting":
                                            button.BackColor = Color.PaleTurquoise; // Màu ghế đang chọn
                                            button.Text = "Đang chọn...";
                                            break;
                                        case "Cancelled":
                                            button.BackColor = SystemColors.ButtonHighlight; // Trạng thái ghế bình thường
                                            button.Text = seatNumber.ToString();
                                            button.Enabled = true;
                                            break;
                                        default:
                                            break;
                                    }
                                }));
                            }
                        }
                    }
                    else
                    {
                        AppendText("Dữ liệu nhận từ server: " + data);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendText("Lỗi khi nhận dữ liệu: " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Visible = true;
            btnDisconnect.Visible = false;
            btnConnect.Enabled = true;

            try
            {
                // Gửi thông báo "Disconnect" đến server
                if (sWriter != null)
                {
                    sWriter.WriteLine("Disconnect"); // Gửi thông báo ngắt kết nối
                    sWriter.Flush(); // Đảm bảo dữ liệu đã được gửi
                }

                // Đóng kết nối và giải phóng tài nguyên
                clientThread?.Abort(); // Dừng luồng đọc từ server
                sReader?.Dispose(); // Giải phóng đối tượng sReader
                sWriter?.Dispose(); // Giải phóng đối tượng sWriter
                tcpClient?.Close(); // Đóng kết nối TCP

                // Hiển thị thông báo về việc ngắt kết nối
                AppendText("Đã ngắt kết nối với server.");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                AppendText("Lỗi khi ngắt kết nối: " + ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Visible = false;
            btnDisconnect.Visible = true;

            string ipAddress = tbIP.Text.Trim(); // Lấy IP từ TextBox tbIP
            int port = 0;

            // Kiểm tra xem port có phải là một số hợp lệ không
            if (!int.TryParse(tbPort.Text.Trim(), out port))
            {
                MessageBox.Show("Port phải là một số hợp lệ.");
                return;
            }

            try
            {
                // Tạo kết nối TCP với server
                tcpClient = new TcpClient(ipAddress, port);
                AppendText($"Đã kết nối tới server {ipAddress}:{port}");

                // Tạo StreamReader và StreamWriter cho việc giao tiếp với server
                NetworkStream networkStream = tcpClient.GetStream();
                sReader = new StreamReader(networkStream);
                sWriter = new StreamWriter(networkStream) { AutoFlush = true };

                // Khởi tạo một luồng mới để đọc dữ liệu từ server
                clientThread = new Thread(ReceiveDataFromServer);
                clientThread.IsBackground = true;
                clientThread.Start();

                // Tắt các điều khiển kết nối sau khi đã kết nối thành công
                tbIP.Enabled = false;
                tbPort.Enabled = false;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}");
            }
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            if (selectedButton != null)
            {
                string seatName = selectedButton.Name;
                int seatNumber = int.Parse(seatName.Replace("btn", ""));  // Chuyển tên nút thành số ghế

                // Gửi thông điệp đến server với định dạng Select,1,John
                string message = $"Book,{seatNumber},{txtName.Text}";  // Gửi seatNumber là int
                SendMessageToServer(message);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ghế!");
            }
        }

        private void SendMessageToServer(string message)
        {
            try
            {
                if (sWriter != null)
                {
                    sWriter.WriteLine(message); // Gửi thông điệp tới server
                }
            }
            catch (Exception ex)
            {
                AppendText("Lỗi khi gửi dữ liệu: " + ex.Message);
            }
        }

        private void AppendText(string text)
        {
            // Kiểm tra xem form có đã bị Dispose chưa
            if (this.IsDisposed || this.InvokeRequired == false)
                return;

            // Kiểm tra xem có phải đang chạy trên UI thread không
            if (this.InvokeRequired)
            {
                rtb.Invoke(new Action(() => rtb.AppendText(text + Environment.NewLine)));
            }
            else
            {
                // Thêm dòng vào RichTextBox
                rtb.AppendText(text + Environment.NewLine);
            }
        }
    }
}
