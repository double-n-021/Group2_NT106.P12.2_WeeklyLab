using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit.Net.Smtp;
using MimeKit;

/* Mẫu gửi body dạng html
                 * <html>
            <body>
                <h1 style='color:LightPink;'>Demo lab05 C#</h1>
                <p>Ứng dụng gửi mail.</p>
                <img src='https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/C_Sharp_Logo_2023.svg/1200px-C_Sharp_Logo_2023.svg.png' alt='Hình ảnh mẫu' style='width:300px;height:300px;' />
            </body>
        </html>
Đường dẫn ảnh lấy từ google (copy url ảnh)
*/
//Đổi gmail gửi nhớ đổi app password theo gmail đó

namespace Group2_Lab05
{
    public partial class Lab05_Bai01 : Form
    {
        public Lab05_Bai01()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem người dùng đã đầy đủ thông tin và đã chọn loại body chưa
            if (String.IsNullOrEmpty(txtFrom.Text) || String.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show("Xin hãy điền gmail người gửi và người nhận!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb.SelectedIndex == -1)
            {
                MessageBox.Show("Xin hãy chọn body type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string SMTPHost = "smtp.gmail.com";
            int SMTPPort = 587;
            string gmail = txtFrom.Text;
            string password = "xdfv sjxf yhuw prip"; // App Password đã tạo từ Gmail
            string from = txtFrom.Text;
            string to = txtTo.Text;
            string subject = txtSubject.Text;

            try
            {
                // Tạo một đối tượng email
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(from, from));
                message.To.Add(new MailboxAddress(from, to));
                message.Subject = subject;

                //Tạo body của thư cần gửi (ở dạng plain text hoặc html)
                if (cb.SelectedIndex == 0)
                {
                    string body = rtbBody.Text;
                    message.Body = new TextPart("plain")
                    {
                        Text = body
                    };
                }
                else if (cb.SelectedIndex == 1)
                {
                    string body = rtbBody.Text;
                    message.Body = new TextPart("html")
                    {
                        Text = body
                    };
                }

                // Cấu hình SMTP client
                using (var client = new SmtpClient())
                {
                    client.Connect(SMTPHost, SMTPPort, MailKit.Security.SecureSocketOptions.StartTls); // Kết nối đến Gmail
                    client.Authenticate(from, password); // Xác thực Gmail và App Password
                    client.Send(message); // Gửi email
                    client.Disconnect(true); // Ngắt kết nối
                }
                MessageBox.Show("Email đã gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}