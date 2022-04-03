using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Bai3_1()
        {
            PhanSo ps1 = new PhanSo(2, 3);
            PhanSo ps2 = new PhanSo(7, 6);
            PhanSo p3 = new PhanSo();
            //p3 = ps1.Cong(ps2);
            
            p3 = ps1 + ps2;
            p3.RutGon();
            p3.Xuat();
            p3 = ps1 - ps2;
            p3.RutGon();
            Console.WriteLine($"{p3}")
            p3.Xuat();
            p3 = ps1 * ps2;
            p3.RutGon();
            p3.Xuat();
            p3 = ps1 / ps2;
            p3.RutGon();
            p3.Xuat();
        }
        static void Bai3_2()
        {
            //SinhVien sv = new SinhVien("61134177", "Đặng Anh Phú", 3);
            //sv.XuatTTSV();
            //sv.XetHB();
            SinhVien sv1 = new SinhVien();
            sv1.NhapDSSV();
            sv1.XuatTTSV();
            sv1.XetHB();
        }
        static void Bai3_3()
        {
            Chuoi str = new Chuoi();
            str.ChuyenDong();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bai3_1();
            //Bai3_2();
            Bai3_3();

            Console.ReadKey();
        }
    }
}
