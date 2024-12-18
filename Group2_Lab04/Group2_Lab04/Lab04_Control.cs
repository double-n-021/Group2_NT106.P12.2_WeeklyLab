using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab04
{
    public partial class Lab04_Control : Form
    {
        public Lab04_Control()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab04_Bai01 formBai01 = new Lab04_Bai01();
            formBai01.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab04_Bai02 formBai02 = new Lab04_Bai02();
            formBai02.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab04_Bai03 formBai03 = new Lab04_Bai03();
            formBai03.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Lab04_Bai04 formBai04 = new Lab04_Bai04();
            formBai04.Show();
            
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Lab04_Bai05 formBai05 = new Lab04_Bai05();
            formBai05.Show();
        }
    }
}
