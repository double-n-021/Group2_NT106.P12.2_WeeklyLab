using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;

namespace Group2_Lab05
{
    public partial class Bai04_Formsend : Form
    {
        public Bai04_Formsend(string From, string Pass, string addrSMTP, string portSMTP)
        {
            InitializeComponent();
            tbPath.ReadOnly = true;
            tbFrom.Text = From;
            this.Pass = Pass;
            this.addrSMTP = addrSMTP;
            this.portSMTP = portSMTP;
        }

        string Pass;
        string addrSMTP, portSMTP;

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect(addrSMTP, int.Parse(portSMTP), true);
                client.Authenticate(tbFrom.Text.Trim(), Pass);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text.Trim()));
                message.To.Add(new MailboxAddress("", tbTo.Text.Trim()));
                message.Subject = tbSubject.Text.Trim();

                message.Body = new TextPart();
                var bodyBuilder = new BodyBuilder();
                if (checkBox1.Checked == true)
                {
                    bodyBuilder.HtmlBody = rtbDisplayEmail.Text;
                }
                else
                {
                    bodyBuilder.TextBody = rtbDisplayEmail.Text;
                }
                string filePath = tbPath.Text;
                if (!string.IsNullOrEmpty(filePath))
                {
                    bodyBuilder.Attachments.Add(filePath);
                }
                message.Body = bodyBuilder.ToMessageBody();

                client.Send(message);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                tbPath.Text = filePath;
            }
        }
    }
}
