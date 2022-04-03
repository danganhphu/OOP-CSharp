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
    public partial class frmBai6_3 : Form
    {
        private const int boss = 1020;
        private const int emp1 = 9652;
        private const int emp2 = 9843;
        private const int scie = 6372;
        private const int tech = 4361;

        private string _code = "";

        public frmBai6_3()
        {
            InitializeComponent();
        }

        private void btnSharp_Click(object sender, EventArgs e)
        {
            int code = int.Parse(txtCode.Text);
            string name = "";
            bool signup = false;

            switch (code)
            {
                case boss:
                    name = "Boss";
                    signup = true;
                    break;

                case emp1:
                case emp2:
                    name = "Employee";
                    signup = true;
                    break;

                case scie:
                    name = "Scientist";
                    signup = true;
                    break;

                case tech:
                    name = "Technician";
                    signup = true;
                    break;
            }
            _code = "";
            txtCode.Clear();
            if (signup)
                lsbCode.Items.Add(DateTime.Now + "\t" + name);
            else
            {
                MessageBox.Show("Invalid access code(◕︵◕)", "Message", MessageBoxButtons.OKCancel);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            _code += "1";
            txtCode.Text = _code;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _code += "2";
            txtCode.Text = _code;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _code += "3";
            txtCode.Text = _code;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            _code += "4";
            txtCode.Text = _code;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            _code += "5";
            txtCode.Text = _code;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            _code += "6";
            txtCode.Text = _code;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            _code += "7";
            txtCode.Text = _code;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            _code += "8";
            txtCode.Text = _code;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            _code += "9";
            txtCode.Text = _code;
        }

        private void bn0_Click(object sender, EventArgs e)
        {
            _code += "0";
            txtCode.Text = _code;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                _code = _code.Remove(_code.Length - 1, 1);
                txtCode.Text = _code;
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}