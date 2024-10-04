using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab01
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private bool kiemTraNamnhuan(int nam)
        {
            if ((nam % 4 == 0 & nam % 100 != 0) || (nam % 400 == 0))
                return true;
            return false;
        }

        private bool kiemTraHople(int ngay, int thang, int nam)
        {
            int[] ngaytrongthang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (kiemTraNamnhuan(nam)) ngaytrongthang[1] = 29;
            if (nam < 1)
            {
                MessageBox.Show("Không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ngay < 1 || ngay > ngaytrongthang[thang - 1])
            {
                MessageBox.Show("Không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {
            int ngay, thang, nam;
            int.TryParse(tbNgay.Text, out ngay);
            int.TryParse(tbThang.Text, out thang);
            int.TryParse(tbNam.Text, out nam);
            tbKetqua.Text = KetQua(ngay, thang, nam);
            tbKetqua.Show();
        }

        private string KetQua(int ngay, int thang, int nam)
        {
            string cung = "";
            if (kiemTraHople(ngay, thang, nam))
            {
                switch (thang)
                {
                    case 1:
                        cung = (ngay <= 20) ? "Cung Ma Kết" : "Cung Bảo Bình";
                        break;
                    case 2:
                        cung = (ngay < 20) ? "Cung Bảo Bình" : "Cung Song Ngư";
                        break;
                    case 3:
                        cung = (ngay <= 20) ? "Cung Song Ngư" : "Cung Bạch Dương";
                        break;
                    case 4:
                        cung = (ngay <= 20) ? "Cung Bạch Dương" : "Cung Kim Ngưu";
                        break;
                    case 5:
                        cung = (ngay <= 21) ? "Cung Kim Ngưu" : "Cung Song Tử";
                        break;
                    case 6:
                        cung = (ngay <= 21) ? "Cung Song Tử" : "Cung Cự Giải";
                        break;
                    case 7:
                        cung = (ngay <= 22) ? "Cung Cự Giải" : "Cung Sư Tử";
                        break;
                    case 8:
                        cung = (ngay <= 22) ? "Cung Sư Tử" : "Cung Xử Nữ";
                        break;
                    case 9:
                        cung = (ngay <= 23) ? "Cung Xử Nữ" : "Cung Thiên Bình";
                        break;
                    case 10:
                        cung = (ngay <= 23) ? "Cung Thiên Bình" : "Cung Thần Nông";
                        break;
                    case 11:
                        cung = (ngay <= 22) ? "Cung Thần Nông" : "Cung Nhân Mã";
                        break;
                    case 12:
                        cung = (ngay <= 21) ? "Cung Nhân Mã" : "Cung Ma Kết";
                        break;
                }
            }
            return cung;
        }

        private void Lab01_Bai04_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
        }
    }
}
