using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual_Periodic_Table
{
    public partial class Tinhkhoangcach : Form
    {
        public Tinhkhoangcach()
        {
            InitializeComponent();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            double xA, xB, yA, yB,ketqua;
            xA = Convert.ToDouble(tbx1.Text);
            yA = Convert.ToDouble(tbx2.Text);
            xB = Convert.ToDouble(tbx3.Text);
            yB = Convert.ToDouble(tbx4.Text);
            ketqua = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB));
            MessageBox.Show("Đường thẳng AB có khoảng cách là "+ketqua , "Kết quả");
        }

        private void btngiai_Click_1(object sender, EventArgs e)
        {
            double xA, xB, yA, yB, ketqua;
            xA = Convert.ToDouble(tbx1.Text);
            yA = Convert.ToDouble(tbx2.Text);
            xB = Convert.ToDouble(tbx3.Text);
            yB = Convert.ToDouble(tbx4.Text);
            ketqua = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB));
            MessageBox.Show("Đường thẳng AB có khoảng cách là " + ketqua, "Kết quả");
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            tbx1.Text = "";
            tbx2.Text = "";
            tbx3.Text = "";
            tbx4.Text = "";
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
