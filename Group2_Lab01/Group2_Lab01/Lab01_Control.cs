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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Bai01 formbai01 = new Bai01();
            formbai01.Show();
        }

        private void btn_Bai02_Click(object sender, EventArgs e)
        {
            Bai02 formBai02 = new Bai02();
            formBai02.Show();
        }

        private void btn_Bai03_Click(object sender, EventArgs e)
        {
            Bai03 formbai01 = new Bai03();
            formbai01.Show();
        }

        private void btn_Bai04_Click(object sender, EventArgs e)
        {
            Bai04 formbai04 = new Bai04();
            formbai04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai05 formbai04 = new Bai05();
            formbai04.Show();
        }
    }
}
