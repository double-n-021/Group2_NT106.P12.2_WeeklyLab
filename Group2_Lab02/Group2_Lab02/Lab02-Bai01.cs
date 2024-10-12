using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;

namespace Group2_Lab02
{
    public partial class Bai01 : Form
    {
        private int fileCount;

        public Bai01()
        {
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/32281622/how-to-read-from-a-file-in-c-sharp

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fo.ShowDialog();
            if (File.Exists(fo.FileName))
            {
                using (StreamReader reader = new StreamReader(fo.FileName, Encoding.UTF8))
                {
                    rtb1.Text = reader.ReadToEnd();
                }
            }
            string filePath = Directory.GetCurrentDirectory();
            tbFilePath.Text = filePath;
        }

        //https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter.-ctor?view=net-8.0#system-io-streamwriter-ctor(system-string

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            string content = rtb1.Text;
            string upperContent = content.ToUpper();

            fileCount++;
            string outputPath = Path.Combine("D:\\", $"output{fileCount}.txt");

            try
            {
                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    sw.Write(upperContent);
                }
                MessageBox.Show("Ghi file thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}");
            }
        }
    }
}
