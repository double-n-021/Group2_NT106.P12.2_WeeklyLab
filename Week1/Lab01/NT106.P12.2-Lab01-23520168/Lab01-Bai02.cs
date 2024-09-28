using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.P12._2_Lab01_23520168
{
    public partial class Bai02 : Form
    {
        private int A;
        private int B;
        private int kq;

        public Bai02()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            textBox_A.Clear();
            textBox_B.Clear();
            textBox_KQ.Clear();
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_A.Text, out A) || !int.TryParse(textBox_B.Text, out B))
            {
                MessageBox.Show("Cần nhập số nguyên!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if(string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Hãy chọn 1 cách tính!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }    
            if (comboBox1.Text == "Bảng cửu chương")
            {
                kq = TinhBangCuuChuong(A, B);
                textBox_KQ.Text = kq.ToString();
            }
            else if (comboBox1.Text == "Tính toán giá trị")
            {
                kq = TinhToanGiaTri(A, B);
                textBox_KQ.Text = kq.ToString();
            }
        }

        private int TinhBangCuuChuong(int A, int B)
        {
            int h = Math.Abs(A-B);
            int gt = 1;
            for (int i = 1; i <= h; i++)
            {
                gt = gt * i;
            }
            return gt;
        }

        private int TinhToanGiaTri(int A, int B)
        {
            int t = 1;
            int s = 0;
            for (int i = 0; i < B; i++)
            {
                t = t * A;
                s = s + t;
            }
            return s;
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }
    }
}
