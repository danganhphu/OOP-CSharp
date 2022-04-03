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
    public partial class frmBai6_5 : Form
    {
        public frmBai6_5()
        {
            InitializeComponent();
        }

        private void Bai6_1Item_Click(object sender, EventArgs e)
        {
            //đóng tất cả các form con
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmBai6_1 frm = new frmBai6_1();
            this.AddOwnedForm(frm);
            //frm.ShowDialog();
            frm.Show();
        }

        private void bai6_2Item_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmBai6_2 frm = new frmBai6_2();
            this.AddOwnedForm(frm);
            //frm.ShowDialog();
            frm.Show();
        }

        private void Bao6_3Item_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmBai6_3 frm = new frmBai6_3();
            this.AddOwnedForm(frm);
            //frm.ShowDialog();
            frm.Show();
        }

        private void bai6_4Item_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            frmBai6_4 frm = new frmBai6_4();
            this.AddOwnedForm(frm);
            frm.Show();
        }

        private void thoatItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}