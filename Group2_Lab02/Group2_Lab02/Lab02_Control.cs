using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab02
{
    public partial class Lab02_Control : Form
    {
        public Lab02_Control()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Bai01 formBai01 = new Bai01();
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
            Bai04 formBai04 = new Bai04();
            formBai04.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Bai05 formBai05 = new Bai05();
            formBai05.Show();
        }
    }
}
