using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab6
{
    internal class NXeVinfast
    {
        private List<XeVinfast> lsXeV = new List<XeVinfast>();
        private int n;

        public NXeVinfast()
        {
            lsXeV = new List<XeVinfast>();
            try
            {
                FileStream file = new FileStream("D:\\BaiTapLapTrinh\\c#\\OOP_Csharp\\oop_cntt2\\Lab6\\XeVinfast.txt", FileMode.Open);
                StreamReader rd = new StreamReader(file, Encoding.UTF8);
                string line;
                n = int.Parse(rd.ReadLine());
                while ((line = rd.ReadLine()) != null)
                {
                    string name = line;
                    float giaXe = float.Parse(rd.ReadLine());
                    string noiDK = rd.ReadLine();
                    float phiTB = float.Parse(rd.ReadLine());
                    byte soCNgoi = byte.Parse(rd.ReadLine());
                    XeVinfast xv = new XeVinfast(name, giaXe, noiDK, phiTB, soCNgoi);
                    lsXeV.Add(xv);
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("Không thể đọc dữ liệu");
            }
            n = lsXeV.Count;
        }

        public void SapXep()
        {
            lsXeV.Sort(
                (p1, p2) =>
                {
                    if (p1.GiaLanBanh() < p2.GiaLanBanh())
                        return 1;
                    else if (p1.GiaLanBanh() == p2.GiaLanBanh())
                        return 0;
                    else return -1;
                }
            );
        }

        public void InTT()
        {
            Console.WriteLine("\t\t\t-----------------Thông tin danh sách xe-----------------");
            Console.WriteLine($"Danh sách sác xe Vinfast: {n}");
            foreach (XeVinfast xv in lsXeV)
            {
                xv.Xuat();
                Console.Write(Environment.NewLine);
            }
        }

        public void XuatGiaLB()
        {
            Console.Write("Nhập vào xe có số chỗ ngồi x: ");
            byte x;
            byte dem = 0;
            double sum = 0;
            while (byte.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.Write("Nhập sai giá trị x. Nhập lại: ");
            }
            foreach (XeVinfast xv in lsXeV)
                if (x == xv.SoChoNgoi)
                {
                    sum += xv.GiaLanBanh();
                    dem++;
                }

            Console.WriteLine($"Giá lăn bánh trung bình của các xe VINFAST có số chỗ ngồi {x} là: {sum / dem}");
        }
    }
}