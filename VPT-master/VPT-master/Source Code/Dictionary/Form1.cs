using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        DictionaryManage dictionary;

        public Form1()
        {
            InitializeComponent();
            cbWord.DisplayMember = "Key";
            dictionary = new DictionaryManage();
            dictionary.LoadDataToCombobox(cbWord);
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            dictionary.Serialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null)
                return;
            DictionaryData data = cb.SelectedItem as DictionaryData;
            txbMeaning.Text = data.Meaning;

        }
        
    }
}
