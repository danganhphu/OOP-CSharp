using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab6
{
    internal class NCircle
    {
        private List<Circle> lsCri = new List<Circle>();
        private int n;

        public NCircle()
        {
            lsCri = new List<Circle>();

            try
            {
                FileStream file = new FileStream("D:\\BaiTapLapTrinh\\c#\\OOP_Csharp\\oop_cntt2\\Lab6\\Circle.txt", FileMode.Open);
                StreamReader rd = new StreamReader(file, Encoding.UTF8);
                string line;
                n = int.Parse(rd.ReadLine());
                while ((line = rd.ReadLine()) != null)
                {
                    string name = line;
                    float banKinh = float.Parse(rd.ReadLine());
                    Circle c = new Circle(name, banKinh);
                    lsCri.Add(c);
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("Không thể đọc dữ liệu");
            }
            n = lsCri.Count;
        }

        public void XuatTT()
        {
            if (lsCri.Count == 0)
            {
                Console.WriteLine("Không có thông tin tin trong danh sách");
            }
            else
            {
                Console.Write("Nhập chi phí giá sơn 1 đơn vị diện tích hình tròn: ");
                int cp = int.Parse(Console.ReadLine());
                Console.WriteLine("Thông tin danh sách hình tròn");

                foreach (Circle ht in lsCri)
                {
                    ht.Xuat();
                    Console.WriteLine($"\tChi phí: {ht.Cost(cp)}");
                    Console.Write(Environment.NewLine);
                }
            }
        }

        public void Xoa()
        {
            Console.Write("Nhập vào x (hình tròn được xóa có diện tích nhỏ hơn x): ");
            float x = float.Parse(Console.ReadLine());

            int vtri = -1;
            for (int i = 0; i < lsCri.Count; i++)
                if (lsCri[i].DienTich() < x)
                    vtri = i;
            if (vtri >= 0)
                lsCri.RemoveAt(vtri);
            //foreach (Circle ht in lsCri)
            //{
            //    ht.Xuat();
            //    Console.Write(Environment.NewLine);
            //}
        }

        public void Dem()
        {
            byte count = 0;
            foreach (Circle ht in lsCri)
                if (ht.ChuVi() == ht.DienTich())
                    count++;
            Console.WriteLine($"số lượng hình tròn có chu vi bằng diện tích : {count}");
        }
    }
}