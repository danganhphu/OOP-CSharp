using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class MonHoc
    {
        string msmh, tenmh;
        byte dvht;
        static float tlkt = 0.5f;
        float diemKT, dthi;

        public byte Dvht { get => dvht; set => dvht = value; }
        public float DiemKT { get => diemKT; set => diemKT = value; }
        public float Dthi { get => dthi; set => dthi = value; }

        public MonHoc(string msmh = "", string tenmh = "", byte dvht = 0, float diemKT = 0, float dthi = 0)
        {
            this.msmh = msmh;
            this.tenmh = tenmh;
            this.dvht = dvht;
            this.diemKT = diemKT;
            this.dthi = dthi;
        }
        public void NhapTT()
        {
            Console.Write("Nhập mã số môn học: ");
            msmh = Console.ReadLine();
            Console.Write("Nhập tên môn học: ");
            tenmh = Console.ReadLine();
            Console.Write("Nhập đơn vị học trình: ");
            while (byte.TryParse(Console.ReadLine(), out dvht) == false || dvht < 0)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
            Console.Write("Nhập điểm kiểm tra: ");
            while (float.TryParse(Console.ReadLine(), out diemKT) == false || diemKT < 0 || diemKT > 10)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
            Console.Write("Nhập điểm thi: ");
            while (float.TryParse(Console.ReadLine(), out dthi) == false || dthi < 0 || dthi > 10)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
        }
        public float DiemTB()
        {
            float dtb = 0;
            dtb = tlkt * this.diemKT + (1 - tlkt) * this.dthi;
            return dtb;
        }
        public void XuatTT()
        {
            Console.WriteLine($"Môn học: {this.tenmh}\t Điểm kiểm tra: {this.diemKT}\tĐiểm thi: {this.dthi}\tĐiểm trung bình: {this.DiemTB()}");
        }
    }
}
