using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;

namespace Group2_Lab05
{
    public partial class Lab05_Bai02 : Form
    {
        public Lab05_Bai02()
        {
            InitializeComponent();
            //Thiết lập các cột sẽ hiện bị bên trong ListView
            lvDisplayEmail.Columns.Add("Email", 300);
            lvDisplayEmail.Columns.Add("From", 200);
            lvDisplayEmail.Columns.Add("Thời gian", 150);
            lvDisplayEmail.View = View.Details;
            lvDisplayEmail.FullRowSelect = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string server = "imap.gmail.com";
            int port = 993;
            string username = txtEmail.Text;
            string password = txtPassword.Text;

            try
            {
                using (var client = new ImapClient())
                {

                    client.Connect(server, port, true); //Connect đến IMAP server
                    client.Authenticate(username, password); //Xác thực email và password

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Mở hộp thư đến
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    //Hiển thị tổng số email
                    int totalEmails = inbox.Count;

                    if (totalEmails > nmrRecent.Maximum)
                    {
                        nmrRecent.Maximum = totalEmails;
                    }
                    nmrRecent.Value = totalEmails;

                    //Lấy số email mới nhất
                    int recent = (int)nmrRecent.Value;

                    int count = Math.Min(recent, totalEmails);
                    lvDisplayEmail.Items.Clear(); //Xóa dữ liệu cũ trên ListView

                    //Lấy và hiển thị eamil
                    for (int i = totalEmails - count; i < totalEmails; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(message.Subject);  //Chủ đề
                        item.SubItems.Add(message.From.ToString());             //Người gửi
                        item.SubItems.Add(message.Date.ToString());             //Thời gian
                        lvDisplayEmail.Items.Add(item);
                        lvDisplayEmail.Refresh(); //cập nhật ListView ngay lập tức

                        //Thêm await và task để giúp UI không bị treo trong quá trình load mail
                        await Task.Delay(500); //Thời gian giữa mỗi lần hiển thị email (mặc định 500ms)
                    }

                    //Ngắt kết nối
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
