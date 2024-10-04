using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group2_Lab01
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            textBox_A.Clear();
            textBox_B.Clear();
            comboBox1.SelectedIndex= -1;
            textBox_KQ.Clear();
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            int A;
            int B;
            int kq1, kq2;

            if (!int.TryParse(textBox_A.Text, out A) || !int.TryParse(textBox_B.Text, out B))
            {
                MessageBox.Show("Cần nhập số nguyên!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Hãy chọn 1 cách tính!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (comboBox1.Text == "Bảng cửu chương B - A")
            {
                TinhBangCuuChuong(A, B);
            }
            else if (comboBox1.Text == "Tính toán giá trị (A - B)! và S = A^1 + A^2 + ... + A^B")
            {
                if(A<B || B<=0)
                {
                    MessageBox.Show("Cần nhập A >= B và B > 0!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                kq1 = TinhToanGiaTri1(A, B);
                kq2 = TinhToanGiaTri2(A, B);
                textBox_KQ.Text = $"({A} - {B})! = {kq1}{Environment.NewLine}S = {kq2}";
            }
        }

        private void TinhBangCuuChuong(int A, int B)
        {
            textBox_KQ.Clear();
            int h = B - A;
            for(int i=1;i<10;i++)
            {
                textBox_KQ.AppendText($"{h} x {i} = {h * i}{Environment.NewLine}");
            }
            textBox_KQ.AppendText($"{h} x {10} = {h * 10}");
        }

        private int TinhToanGiaTri1(int A, int B)
        {
            int h = A - B;
            int gt = 1;
            for (int i = 1; i <= h; i++)
            {
                gt = gt * i;
            }
            return gt;
        }

        private int TinhToanGiaTri2(int A, int B)
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

    }
}

