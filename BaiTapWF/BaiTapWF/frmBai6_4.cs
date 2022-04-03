using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaiTapWF
{
    public partial class frmBai6_4 : Form
    {
        private List<Student> ls;
        private string pic_path = @"D:\BaiTapLapTrinh\c#\OOP_Csharp\oop_cntt2\BaiTapWF\BaiTapWF\bin\Release\mygang.jpg";
        private string input_path = @"D:\BaiTapLapTrinh\c#\OOP_Csharp\oop_cntt2\BaiTapWF\BaiTapWF\bin\Release\Student.txt";
        private string out_path = @"D:\BaiTapLapTrinh\c#\OOP_Csharp\oop_cntt2\BaiTapWF\BaiTapWF\bin\Release\Student_Output.txt";

        public frmBai6_4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Read_File()
        {
            ls = new List<Student>();
            try
            {
                FileStream f = new FileStream(input_path, FileMode.Open);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);
                string line;
                // doc du lieu tu file
                while ((line = rd.ReadLine()) != null)
                {
                    string id = line;
                    string name = rd.ReadLine();
                    string pic = rd.ReadLine();
                    Student c = new Student(id, name, pic);
                    ls.Add(c);
                }
            }
            catch
            {
                MessageBox.Show("Không thể đọc file", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void frmBai6_4_Load(object sender, EventArgs e)
        {
            pic1.Image = Image.FromFile(pic_path);
            Read_File();
            dgvStudent.DataSource = ls;
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image file|*.png;*jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                pic_path = f.FileName;
                pic1.Image = Image.FromFile(pic_path);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student(txtid.Text, txtname.Text, pic_path);
            ls.Add(s);
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = ls;
            txtid.Text = "";
            txtname.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < ls.Count; i++)
                if (String.Compare(ls[i].Id, txtid.Text) == 0)
                    break;
            if (i < ls.Count)
            {
                ls.RemoveAt(i);
                txtid.Clear();
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = ls;
            }
            else
                MessageBox.Show("Không có sinh viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < ls.Count; i++)
                if (String.Compare(ls[i].Id, txtid.Text) == 0)
                    break;
            if (i < ls.Count)
            {
                ls[i].Name = txtname.Text;
                //cập nhật lại dữ liệu hiện trong DataGridView
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = ls;
            }
            else
                MessageBox.Show("Không có sinh viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtid.Text = "";
            txtname.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //ghi dữ liệu từ datagridview vào file
            try
            {
                FileStream f = new FileStream(out_path, FileMode.Create);
                StreamWriter sw = new StreamWriter(f, Encoding.UTF8);
                foreach (Student s in ls)
                {
                    sw.WriteLine(s.Id);
                    sw.Flush();
                    sw.WriteLine(s.Name);
                    sw.Flush();
                    sw.WriteLine(s.Pic);
                    sw.Flush();
                }
            }
            catch
            {
                MessageBox.Show("Không thể tạo file", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}