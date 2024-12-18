using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using HtmlAgilityPack;
using System.IO;
using System.Net;


namespace Group2_Lab04
{
    public partial class Lab04_Bai03 : Form
    {
        public Lab04_Bai03()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
           await wvShow.EnsureCoreWebView2Async();
        }

        string sURL = "";

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbURL.Text))
                MessageBox.Show("Hãy nhập URL trước khi nhấn Load!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                sURL = tbURL.Text;
                wvShow.CoreWebView2.Navigate(sURL);
            }
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sURL))
                MessageBox.Show("Hãy load nội dung trang web trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                wvShow.CoreWebView2.Reload();
            }
        }

        private void btDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sURL))
                MessageBox.Show("URL chưa được nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "TXT Files|*.txt",
                    FileName = "downloaded.txt"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    try
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(sURL, filePath);
                        }

                        MessageBox.Show("Tải nội dung thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Không thể ghi file! Vui lòng kiểm tra quyền truy cập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show($"Lỗi tải file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btVS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sURL))
            {
                MessageBox.Show("Hãy nhập URL của trang web trước khi muốn xem source code!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            View_Form view_Form = new View_Form(sURL);
            view_Form.Show();
        }

        private void btDR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sURL))
                MessageBox.Show("Hãy load nội dung trang web trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var html = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = html.Load(sURL);

                var imageUrls = doc.DocumentNode.Descendants("img")
                    .Select(img => img.GetAttributeValue("src", null))
                    .Where(src => !string.IsNullOrEmpty(src))
                    .ToList();

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = fbd.SelectedPath;
                    foreach (var imageUrl in imageUrls)
                    {
                        Uri uri = new Uri(new Uri(sURL), imageUrl);
                        string fileName = Path.Combine(folderPath, Path.GetFileName(uri.LocalPath));
                        try
                        {
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(uri, fileName);
                            }
                        }
                        catch (WebException ex)
                        {
                            MessageBox.Show($"Lỗi tải file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    MessageBox.Show("Tải tài nguyên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
