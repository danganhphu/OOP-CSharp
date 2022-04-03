using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTBac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        public static string GiaiPTb1(float a, float b)
        {
            string kq = "";
            if (a == 0)
            {
                if (b == 0)
                    kq = "Infinite Sol";
                else
                    kq = "No-Solution";
            }
            else
                kq = (-b / a).ToString();
            return kq;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            string kq = "";
            float a, b;
            if (string.IsNullOrEmpty(txtSoa.Text) || string.IsNullOrEmpty(txtSob.Text))
            {
                MessageBox.Show("Chưa nhập đủ a, b, b", "Thông báo");
            }
            else
            {
                if (!float.TryParse(txtSoa.Text, out a) || !float.TryParse(txtSob.Text, out b))
                    MessageBox.Show("a hoặc b không phải là số", "Thông báo");
                else
                    kq = GiaiPTb1(a, b);
            }
            txtKetqua.Text = kq;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSoa.Text = txtSob.Text = txtKetqua.Text = null;
            txtSoa.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}