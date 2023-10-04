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
    public partial class Form1_trenlop : Form
    {
        ErrorProvider errorProvider1;
        public Form1_trenlop()
        {
            errorProvider1 = new ErrorProvider();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Không phải số");
            else
                this.errorProvider1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int k = int.Parse(comboBox1.SelectedItem.ToString());
            for (int i = 1; i < k; i++)
                if (k % i == 0)
                    listBox1.Items.Add(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int s in listBox1.Items)
                sum += s;
            MessageBox.Show("Tổng các ước sô: " + sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int s in listBox1.Items)
                if (s % 2 == 0)
                    dem++;
            MessageBox.Show("Số lượng các ước số chẵn là: " + dem);
        }
        public bool kiemtrasnt(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int s in listBox1.Items)
                if (kiemtrasnt(s))
                    dem++;
            MessageBox.Show("Số lượng các ước số nguyên tố: " + dem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
