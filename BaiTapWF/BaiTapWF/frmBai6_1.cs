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
    public partial class frmBai6_1 : Form
    {
        private int a, b;

        public frmBai6_1()
        {
            InitializeComponent();
        }

        private void txtSoa_Leave(object sender, EventArgs e)
        {
            bool kt = int.TryParse(txtSoa.Text, out a);
            if (kt == false)
                if (MessageBox.Show("Lỗi định dạng\nBạn có nhập lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtSoa.Clear();
                    txtSoa.Focus();
                }
        }

        private void txtSob_Leave(object sender, EventArgs e)
        {
            bool kt = int.TryParse(txtSob.Text, out b);
            if (kt == false)//số nhập không đúng định dạng
                if (MessageBox.Show("Lỗi định dạng\nBạn có nhập lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtSob.Clear();
                    txtSob.Focus();
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoa.Text = "";
            txtSob.Clear();
            txtKQ.Clear();
            txtSoa.Focus();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtKQ.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtKQ.Text = ((float)a / b).ToString();
        }

        private void txtSoa_TextChanged(object sender, EventArgs e)
        {
        }
    }
}