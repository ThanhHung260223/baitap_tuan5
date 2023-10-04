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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] ds = { "Giám đốc", "Tố chức hành chính", "Kế hoạch", "Kế toán"};
            foreach (string s in ds)
            {
                treeView1.Nodes.Add(s);
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
        }

        public bool kiemtra(string s)
        {
            foreach (TreeNode kt in treeView1.Nodes)
                if (kt.Text == s)
                    return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtra(textBox1.Text))
            {
                treeView1.Nodes.Add(textBox1.Text);
                comboBox1.Items.Add(textBox1.Text);
            }
            else
                MessageBox.Show("Phòng ban đã tồn tại!");
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (treeView1.SelectedNode != null)
                {
                    comboBox1.Items.Remove(treeView1.SelectedNode.Text);
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in treeView1.Nodes)
            if (node.Text == comboBox1.Text)
            {
                index = node.Index;
                break;
            }
            treeView1.Nodes[index].Nodes.Add(textBox3.Text + "("+textBox2.Text+")");
            treeView1.ExpandAll();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

    }
}
