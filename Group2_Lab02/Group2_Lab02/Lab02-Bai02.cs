using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            // Thiết lập các textbox chỉ đọc
            txtFileName.ReadOnly = true;
            txtSize.ReadOnly = true;
            txtURL.ReadOnly = true;
            txtLineCount.ReadOnly = true;
            txtWordCount.ReadOnly = true;
            txtCharCount.ReadOnly = true;
            rtbContent.ReadOnly = true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            //Tạo và cấu hình OpenFileDialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Đọc file và hiển thị thông tin
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        //Hiển thị tên file
                        txtFileName.Text = ofd.SafeFileName;

                        //Hiển thị kích thước file
                        txtSize.Text = fs.Length.ToString() + " bytes";

                        //Hiển thị đường dẫn
                        txtURL.Text = fs.Name;

                        //Đọc nội dung file
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string content = sr.ReadToEnd();
                            rtbContent.Text = content;

                            //Đếm số dòng
                            string[] lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                            txtLineCount.Text = lines.Length.ToString();

                            //Đếm số từ
                            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                            txtWordCount.Text = words.Length.ToString();

                            //Đếm số ký tự
                            txtCharCount.Text = content.Length.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
