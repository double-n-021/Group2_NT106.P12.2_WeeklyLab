using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Largest_Smallest_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            disNum1.Clear();
            disNum2.Clear();
            disNum3.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;

            if (!float.TryParse(disNum1.Text, out num1) || !float.TryParse(disNum2.Text, out num2) || !float.TryParse(disNum3.Text, out num3)){
                MessageBox.Show("Vui lòng nhập số hợp lệ cho tất cả các ô.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Tìm số lớn nhất và nhỏ nhất bằng phương thức Math.Max() và Math.Min()
            float max = Math.Max(num1, Math.Max(num2, num3));
      
            float min = Math.Min(num1, Math.Min(num2, num3));

            biggestNum.Text = max.ToString();
            smallestNum.Text = min.ToString();
        }

    }
}
