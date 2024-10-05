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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        string []DIGITS = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        string []UNITS = { "", "Nghìn", "Triệu", "Tỷ" };

        // Hàm đọc hai chữ số (a, b, c)
        string readTwo(int b, int c, bool hasHundred)
        {
            string output = "";

            switch (b)
            {
                case 0:
                    {
                        if (hasHundred && c == 0)
                            break;
                        if (hasHundred)
                            output += "Lẻ ";
                        output += DIGITS[c];
                        break;
                    }
                case 1:
                    {
                        output += "Mười ";
                        if (c == 5)
                            output += "Lăm";
                        else if (c != 0)
                            output += DIGITS[c];
                        break;
                    }
                default:
                    {
                        output += DIGITS[b] + " Mươi ";
                        if (c == 1)
                            output += "Mốt";
                        else if (c == 5)
                            output += "Lăm";
                        else if (c != 0)
                            output += DIGITS[c];
                        break;
                    }
            }

            return output;
        }

        // Hàm đọc ba chữ số (a, b, c)
        string readThree(int a, int b, int c, bool readZeroHundred)
        {
            string output = "";

            // Đọc phần trăm (a) trước
            if (a != 0 || readZeroHundred)
                output += DIGITS[a] + " Trăm ";

            // Nối thêm phần sau (b, c)
            output += readTwo(b, c, a != 0 || readZeroHundred);

            return output;
        }

        // Hàm chính
        string ReadNumber(string num)
        {
            string output = "";
            int length = num.Length;
            int groupCount = (length + 2) / 3;  // Số nhóm 3 chữ số

            for (int i = 0; i < groupCount; i++)
            {
                int start = length - (i + 1) * 3;
                int end = start + 3;
                if (start < 0) start = 0;

                string group = num.Substring(start, end - start);
                int groupSize = group.Length;

                // Chuyển đổi từng chữ số trong nhóm thành int
                int a = groupSize > 2 ? group[0] - '0' : 0;
                int b = groupSize > 1 ? group[groupSize - 2] - '0' : 0;
                int c = group[groupSize - 1] - '0';

                // Đọc nhóm ba chữ số
                bool isFirstGroup = (i == groupCount - 1);
                string groupOutput = readThree(a, b, c, !isFirstGroup);

                // Chỉ thêm đơn vị khi nhóm có giá trị
                if (!string.IsNullOrEmpty(groupOutput) && (a != 0 || b != 0 || c != 0))
                {
                    if (i > 0)
                    {
                        output = UNITS[i] + " " + output;
                    }
                    output = groupOutput + " " + output;
                }
            }

            // Xóa dấu cách thừa ở đầu và cuối chuỗi
            output = output.Trim();

            return output;
        }


        private void btnReadNum_Click(object sender, EventArgs e)
        {
            long num; //Lưu mã người dùng nhập vào

            if (!long.TryParse(enterNum.Text, out num) || num < -999999999999 || num > 999999999999)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int isNegative = 0;
            
            if (num<0) 
            {
                isNegative = 1;
                num = Math.Abs(num);
            }

            string result = num.ToString();
            if (isNegative == 0) showResults.Text = ReadNumber(result);
            else showResults.Text = "Âm " + ReadNumber(result);
        }

    }
}
