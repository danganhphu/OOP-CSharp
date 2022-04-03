using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWF
{
    public partial class frmBai6_2 : Form
    {
        public frmBai6_2()
        {
            InitializeComponent();
        }

        private void rdpt1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpt1.Checked == true)
                txtSoc.Visible = lblSoc.Visible = false;
        }

        private void frmBai6_2_Load(object sender, EventArgs e)
        {
            rdpt1.Checked = true;
            txtKetqua.Enabled = false;
        }

        private void rdpt2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpt2.Checked == true)
                txtSoc.Visible = lblSoc.Visible = true;
        }

        public static string GiaiPT1(float a1, float b1)
        {
            string kq = "";
            if (a1 == 0)
            {
                if (b1 == 0)
                    kq = "Infinite Sol";
                else
                    kq = "No-Solution";
            }
            else
                kq = "Phương trình có nghiệm \r\n\t x = " + (-b1 / a1).ToString();
            return kq;
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            string kq = "";
            float a, b, c;
            if (string.IsNullOrEmpty(txtSoa.Text) || string.IsNullOrEmpty(txtSob.Text))
            {
                if (rdpt2.Checked)
                {
                    if (string.IsNullOrEmpty(txtSoc.Text))
                    {
                        MessageBox.Show("Chưa nhập đủ a, b, c", "Thông báo");
                    }
                }
                else
                    MessageBox.Show("Chưa nhập đủ a, b", "Thông  báo");
            }
            else
                if (rdpt1.Checked)
                if (!float.TryParse(txtSoa.Text, out a) || !float.TryParse(txtSob.Text, out b))
                    MessageBox.Show("a hoặc b không phải là số", "Thông báo");
                else
                    kq = GiaiPT1(a, b);
            else
            {
                float delta;
                if (!float.TryParse(txtSoa.Text, out a) || !float.TryParse(txtSob.Text, out b) || !float.TryParse(txtSoc.Text, out c))
                    MessageBox.Show("a, b hoặc c không phải là số", "Thông báo");
                else
                    if (a == 0)
                {
                    if (MessageBox.Show("a = 0, Pt này trở thành pt bậc 1, bạn có muốn giải pt này?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        kq = GiaiPT1(b, c);
                    else
                    {
                        txtSoa.Clear();
                        txtSoa.Focus();
                    }
                }
                else
                {
                    delta = (b * b) - 4 * a * c;
                    if (delta < 0)
                        kq = "Phương trình vô nghiệm";
                    else
                        if (delta == 0)
                    {
                        kq = "Phương trình có nghiệm kép";
                        kq += "\t x1 = x2 = " + (-b / (2 * a)).ToString();
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        kq = "Phương trình có 2 nghiệm phân biệt: \r\n";
                        kq += " x1=" + x1.ToString() + "\r\n";
                        kq += " x2=" + x2.ToString();
                    }
                }
            }
            txtKetqua.Text = kq;
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtSoa.Text = txtSob.Text = txtSoc.Text = txtKetqua.Text = null;
            txtSoa.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}