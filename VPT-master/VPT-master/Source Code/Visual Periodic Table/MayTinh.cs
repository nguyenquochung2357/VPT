
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace Visual_Periodic_Table
{
    public partial class MayTinh : Form
    {

        public MayTinh()
        {
            InitializeComponent();
        }
        Double ResultValue = 0; //Hiện thị kết quả tính toán
        String OperationPerformed = ""; //Các phép toán cộng trừ nhân chia
        bool IsOperationPerformed = false;

        private void button_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "0") || (IsOperationPerformed))
                textBox1.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
        }
        private void tinhtoan_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultValue != 0)
            {
                button15.PerformClick();
            }
            OperationPerformed = button.Text;
            ResultValue = Double.Parse(textBox1.Text);
            label_HT.Text = ResultValue + " " + OperationPerformed;
            IsOperationPerformed = true;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    textBox1.Text = (ResultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (ResultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (ResultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (ResultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ResultValue = 0;
            label_HT.Text = "";
        }

        private void MayTinh_Load(object sender, EventArgs e)
        {

        }

        private void label_HT_Click(object sender, EventArgs e)
        {

        }
    }
}
