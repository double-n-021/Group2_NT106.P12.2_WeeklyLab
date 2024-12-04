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
    public partial class Bai03_Client : Form
    {
        public Bai03_Client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;
        Byte[] data = null;

        private void btConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipEndPoint);
            btConnect.Enabled = false;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            ns = tcpClient.GetStream();
            // 4. Dùng phương thức Write để gửi dữ liệu đến Server
            data = Encoding.ASCII.GetBytes(rtbMessage.Text + "\n");
            ns.Write(data, 0, data.Length);
            rtbMessage.Clear();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            // 5. Gửi dữ liệu mang dấu hiệu kết thúc cho Server biết và đóng kết nối
            data = Encoding.ASCII.GetBytes("quit\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
            btConnect.Enabled = true;
        }
    }
}
