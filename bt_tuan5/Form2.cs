using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_tuan5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",

            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string[] ds = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khac" };
            foreach (string s in ds)
                comboBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (comboBox1.SelectedIndex >= 0)
                label2.Text = s + comboBox1.SelectedItem.ToString();
            else
                label2.Text = "Bạn chưa chọn dân tộc!";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("dân tộc được chọn:" + comboBox1.SelectedItem.ToString());
        }


    }
}
