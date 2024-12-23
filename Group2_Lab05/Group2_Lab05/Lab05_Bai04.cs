using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab05
{
    public partial class Lab05_Bai04 : Form
    {
        ImapClient client;
        public Lab05_Bai04()
        {
            InitializeComponent();
            client = new ImapClient();
            lvDisplayEmail.View = View.Details;
            lvDisplayEmail.FullRowSelect = true;
        }

        string IMAP, SMTP;
        int portIMAP, portSMTP;

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Refresh_Mail(sender, e);
        }

        private async void Refresh_Mail(object sender, EventArgs e)
        {
            lvDisplayEmail.Clear();
            lvDisplayEmail.Columns.Add("#", 70);
            lvDisplayEmail.Columns.Add("From", 200);
            lvDisplayEmail.Columns.Add("Subject", 300);
            lvDisplayEmail.Columns.Add("Datetime", 100);
            try
            {
                //Mở hộp thư đến
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                //Hiển thị tổng số email
                int totalEmails = inbox.Count;
                int nmrRecent = 0;

                if (totalEmails > nmrRecent)
                {
                    nmrRecent = totalEmails;
                }
                nmrRecent = totalEmails;

                //Lấy số email mới nhất
                int recent = (int)nmrRecent;

                int count = Math.Min(recent, totalEmails);
                lvDisplayEmail.Items.Clear(); //Xóa dữ liệu cũ trên ListView

                //Lấy và hiển thị eamil
                for (int i = totalEmails - count; i < totalEmails; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(message.From.ToString());             //Người gửi
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());             //Thời gian
                    lvDisplayEmail.Items.Add(item);
                    lvDisplayEmail.Refresh(); //cập nhật ListView ngay lập tức

                    //Thêm await và task để giúp UI không bị treo trong quá trình load mail
                    await Task.Delay(500); //Thời gian giữa mỗi lần hiển thị email (mặc định 500ms)
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btSendmail_Click(object sender, EventArgs e)
        {
            Bai04_Formsend sendMail = new Bai04_Formsend(tbUsername.Text, tbPassword.Text, tbSMTP.Text, dmportSMTP.Text);
            sendMail.Show();
        }

        private void lvDisplayEmail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Get the selected item
                ListViewItem selectedItem = e.Item;

                // Open Form2 and pass the selected item's data
                string subject = lvDisplayEmail.SelectedItems[0].SubItems[2].Text;
                string From = lvDisplayEmail.SelectedItems[0].SubItems[1].Text;
                string emailContent = lvDisplayEmail.SelectedItems[0].SubItems[3].Text;
                if (lvDisplayEmail.SelectedItems.Count > 0)
                {

                    Bai04_Formread readMail = new Bai04_Formread(From, tbUsername.Text, subject, emailContent);
                    readMail.Show();
                }
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.UseSystemPasswordChar = true;
        }

        private void Lab05_Bai04_Load(object sender, EventArgs e)
        {

        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            if (btLogin.Text == "Đăng xuất")
            {
                lvDisplayEmail.Clear();
                tbUsername.ReadOnly = false;
                tbPassword.ReadOnly = false;
                tbIMAP.ReadOnly = false;
                dmportIMAP.ReadOnly = false;
                dmportSMTP.ReadOnly = false;
                tbSMTP.ReadOnly = false;
                btRefresh.Visible = false;
                btSendmail.Visible = false;
                tbUsername.Text = "";
                tbPassword.Text = "";
                tbIMAP.Text = "";
                dmportIMAP.Text = "";
                dmportSMTP.Text = "";
                tbSMTP.Text = "";
                btLogin.Text = "Đăng nhập";

                try
                {
                    if (client.IsConnected)
                    {
                        client.Disconnect(true);
                        MessageBox.Show("Đã đăng xuất");
                        Lab05_Bai04_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không có kết nối đến server");
                    }
                    btLogin.Text = "Đăng nhập";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                tbUsername.ReadOnly = true;
                tbPassword.ReadOnly = true;
                tbIMAP.ReadOnly = true;
                dmportIMAP.ReadOnly = true;
                tbSMTP.ReadOnly = true;
                dmportSMTP.ReadOnly = true;
                btRefresh.Visible = true;
                btSendmail.Visible = true;
                btLogin.Text = "Đăng xuất";

                if (tbIMAP.Text == "")
                {
                    tbIMAP.Text = "imap.gmail.com";
                }
                if (dmportIMAP.Text == "")
                {
                    dmportIMAP.Text = "993";
                }
                if (tbSMTP.Text == "")
                {
                    tbSMTP.Text = "smtp.gmail.com";
                }
                if (dmportSMTP.Text == "")
                {
                    dmportSMTP.Text = "465";
                }

                lvDisplayEmail.Columns.Add("#", 70);
                lvDisplayEmail.Columns.Add("From", 200);
                lvDisplayEmail.Columns.Add("Subject", 300);
                lvDisplayEmail.Columns.Add("Datetime", 100);
                //Tạo cột và phạm vi cột

                try
                {
                    client.Connect(tbIMAP.Text, int.Parse(dmportIMAP.Text), true);
                    client.Authenticate(tbUsername.Text.Trim(), tbPassword.Text.Trim());
                    //Mở hộp thư đến
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    //Hiển thị tổng số email
                    int totalEmails = inbox.Count;
                    int nmrRecent = 0;

                    if (totalEmails > nmrRecent)
                    {
                        nmrRecent = totalEmails;
                    }
                    nmrRecent = totalEmails;

                    //Lấy số email mới nhất
                    int recent = (int)nmrRecent;

                    int count = Math.Min(recent, totalEmails);
                    lvDisplayEmail.Items.Clear(); //Xóa dữ liệu cũ trên ListView

                    //Lấy và hiển thị eamil
                    for (int i = totalEmails - count; i < totalEmails; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(i.ToString());
                        item.SubItems.Add(message.From.ToString());             //Người gửi
                        item.SubItems.Add(message.Subject.ToString());
                        item.SubItems.Add(message.Date.ToString());             //Thời gian
                        lvDisplayEmail.Items.Add(item);
                        lvDisplayEmail.Refresh(); //cập nhật ListView ngay lập tức

                        //Thêm await và task để giúp UI không bị treo trong quá trình load mail
                        await Task.Delay(500); //Thời gian giữa mỗi lần hiển thị email (mặc định 500ms)
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
