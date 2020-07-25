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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize(Application.StartupPath + "\\xulrunner");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate(Application.StartupPath + "\\canbangpthh.html");
        }
    }
}
