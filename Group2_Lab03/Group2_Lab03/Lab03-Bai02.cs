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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            MessageBox.Show("Server đang lắng nghe...");
        }

        void StartUnsafeThread()
        {
            int bytesReceived = 0; // Số byte đã nhận
            byte[] recv = new byte[1]; // Khởi tạo mảng byte nhận dữ liệu (buffer)
            Socket clientSocket; // Tạo socket gửi
                                 // Tạo socket nhận
            Socket listenerSocket = new Socket
            (
                AddressFamily.InterNetwork, // Họ địa chỉ của địa chỉ IP hiện hành
                SocketType.Stream, // Kiểu kết nối socket
                ProtocolType.Tcp // Giao thức sử dụng để kết nối
            );

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1); // Đặt độ dài tối đa của hàng đợi là -1: backlog
            clientSocket = listenerSocket.Accept(); // Chờ và chấp nhận kết nối đến
            lvMessage.Items.Add(new ListViewItem("New client connected"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                lvMessage.Items.Add(new ListViewItem(text));
            }
            listenerSocket.Close();
        }

    }
}
