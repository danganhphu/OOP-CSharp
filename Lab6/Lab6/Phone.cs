using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Phone
    {
        private string maSo, nhanHieu;
        private float giaNhap;
        private int namSX;
        public int NamSX { get => namSX; set => namSX = value; }
        public float GiaNhap { get => giaNhap; set => giaNhap = value; }

        public Phone(string maSo = "", string nhanHieu = "", float giaNhap = 0, int namSX = 2021)
        {
            this.maSo = maSo;
            this.nhanHieu = nhanHieu;
            this.giaNhap = giaNhap;
            this.namSX = namSX;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập mã số: ");
            maSo = Console.ReadLine();
            Console.Write("Nhập nhãn hiệu: ");
            nhanHieu = Console.ReadLine();

            Console.Write("Nhập giá nhập (giá nhập > 0): ");
            while (float.TryParse(Console.ReadLine(), out giaNhap) == false || giaNhap < 0)
            {
                Console.Write("Nhập sai yêu cầu, nhập lại: ");
            }
            Console.Write("Nhập năm sản xuất: ");
            while (int.TryParse(Console.ReadLine(), out namSX) == false || namSX < 0)
            {
                Console.Write("Nhập sai yêu cầu, nhập lại: ");
            }
        }

        public double ThueNhap()
        {
            if (nhanHieu == "Iphone")
                return giaNhap * 0.1;
            else
                return giaNhap * 0.05;
        }

        public virtual void Xuat()
        {
            Console.Write($"Mã số: {maSo}\tNhãn hiệu: {nhanHieu}\tNăm sản xuất: {namSX}");
        }
    }
}