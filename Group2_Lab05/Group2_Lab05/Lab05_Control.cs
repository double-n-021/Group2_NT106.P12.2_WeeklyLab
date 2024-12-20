using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab05
{
    public partial class Lab05_Control : Form
    {
        public Lab05_Control()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab05_Bai01 formBai01 = new Lab05_Bai01();
            formBai01.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {

        }

        private void btnBai03_Click(object sender, EventArgs e)
        {

        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Lab05_Bai04 formBai04 = new Lab05_Bai04();
            formBai04.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {

        }
    }
}
