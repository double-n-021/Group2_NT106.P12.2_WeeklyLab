using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab04
{
    public partial class Lab04_Bai02 : Form
    {
        public Lab04_Bai02()
        {
            InitializeComponent();
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = tbLink.Text; // Lấy URL từ TextBox
            string filePath = tbAddress.Text; // Lấy đường dẫn lưu file từ TextBox

            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Vui lòng nhập URL và đường dẫn lưu file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                MessageBox.Show("URL không hợp lệ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                MessageBox.Show("Thư mục lưu file không tồn tại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            try
            {
                // Khởi tạo WebClient và tải nội dung
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, filePath); // Tải nội dung về file
                }

                // Đọc nội dung từ file đã lưu và hiển thị lên RichTextBox
                string htmlInfo = File.ReadAllText(filePath);
                rtbDisplayInfo.Text = htmlInfo; // Hiển thị nội dung HTML trong RichTextBox

                MessageBox.Show("Tải nội dung thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException webEx)
            {
                MessageBox.Show($"Lỗi khi kết nối đến {webEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Không thể ghi file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
