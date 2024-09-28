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

        private void btnReadNum_Click(object sender, EventArgs e)
        {
            string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười Một", "Mười Hai", "Mười Ba", "Mười Bốn", "Mười Lăm", "Mười Sáu", "Mười Bảy", "Mười Tám", "Mười Chín" };
            string[] Tens = { "Mười", "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };
            string[] ThousandScales = { "", "Nghìn", "Triệu", "Tỷ" };

            long no;
    if (!long.TryParse(enterNum.Text, out no) || no < -999999999999 || no > 999999999999)
    {
        showResults.Text = "Vui lòng nhập số nguyên hợp lệ.";
        return;
    }

            if (no == 0)
            {
                showResults.Text = "Không";
                return;
            }
            // Kiểm tra và chuyển số âm thành số dương
            bool isNegative = no < 0;
            if (isNegative) 
            {
                no = Math.Abs(no);
            }

            string strWords = ""; //Chuỗi rỗng để lưu kết quả cuối cùng
            int scaleIndex = 0; //Biến để theo dõi nhóm hiện tại là "hàng nghìn", "triệu", hay "tỷ"

            while (no > 0)
            {
                int group = (int)(no % 1000); //Mỗi lần lặp, chương trình lấy 3 chữ số cuối của số no (dùng phép toán % 1000 để chia lấy phần dư)
                if (group > 0 || scaleIndex == 0)
                {
                    string groupWords = ReadHundreds(group, Ones, Tens);
                    if (scaleIndex > 0)
                    {
                        groupWords += " " + ThousandScales[scaleIndex];
                    }
                    strWords = groupWords + (strWords.Length > 0 ? " " : "") + strWords;
                }
                no /= 1000;
                scaleIndex++;
            }

            if (isNegative)
            {
                strWords = "Âm " + strWords;
            }

            showResults.Text = strWords.Trim();
        }

        private string ReadHundreds(int number, string[] Ones, string[] Tens)
        {
            string result = "";

            int hundreds = number / 100;
            int tensAndOnes = number % 100;

            if (hundreds > 0)
            {
                result += Ones[hundreds - 1] + " Trăm";
                if (tensAndOnes > 0)
                {
                    result += " ";
                    if (tensAndOnes < 10)
                    {
                        result += "Lẻ ";
                    }
                }
            }

            if (tensAndOnes > 0)
            {
                if (tensAndOnes < 20)
                {
                    result += Ones[tensAndOnes - 1];
                }
                else
                {
                    int tens = tensAndOnes / 10;
                    int ones = tensAndOnes % 10;

                    result += Tens[tens - 1];
                    if (ones > 0)
                    {
                        result += " " + Ones[ones - 1];
                    }
                }
            }

            return result;
        }
    }
}
