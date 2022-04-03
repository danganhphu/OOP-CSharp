using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVien
{
    class LopHoc
    {
        string className;
        byte siSo;
        SinhVien[] ds;

        public LopHoc(string tenLop="", byte ss=0)
        {
            className = tenLop;
            siSo = ss;
            ds = new SinhVien[siSo];

            //nhập danh sách
            for (int i = 0; i < ds.Length; i++)
            {
                Console.Write("Nhập mã số sinh viên: ");
                string ms = Console.ReadLine();
                Console.Write("Nhập họ tên sinh viên: ");
                string t = Console.ReadLine();
                Console.Write("Nhập giới tính (True: name || False: nữ): ");
                bool g;
                while (bool.TryParse(Console.ReadLine(), out g) == false)
                {
                    Console.Write("Nhập sai yêu cầu. Nhập lại: ");
                }
                Console.Write("Nhập điểm trung bình tích lũy: ");
                float d;
                while (float.TryParse(Console.ReadLine(), out d) == false)
                {
                    Console.Write("Nhập sai yêu cầu. Nhập lại: ");
                }
                byte tc;
                Console.Write("Nhập số tín chỉ tích lũy: ");
                while (byte.TryParse(Console.ReadLine(), out tc) == false || tc < 0)
                {
                    Console.Write("Nhập sai yêu cầu. Nhập lại: ");
                }
                ds[i] = new SinhVien(ms, t, g, d, tc);

            }

        }
        public void InputDS()
        {
            Console.Write("Nhập tên lớp: ");
            className = Console.ReadLine();
            Console.Write("Nhập sĩ số lớp (5 <= n <= 30): ");
            while (byte.TryParse(Console.ReadLine(), out siSo) == false || siSo < 2 || siSo > 30)
            {
                Console.Write("Bạn nhập sai yêu cầu. Nhập lại: ");
            }    
            
            ds = new SinhVien[siSo];
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i] = new SinhVien();
                Console.Write(Environment.NewLine);
                Console.WriteLine($"Nhập sinh viên thứ {i + 1}");
                ds[i].InputSV();
            }    
        }
        public void OutputDS()
        {
            foreach (SinhVien sv in ds)
            {
                sv.OutputSV();
                Console.Write(Environment.NewLine);
            }
        }
        public byte DemSV()
        {
            byte count = 0;
            foreach (SinhVien sv in ds)
            {
                if (sv.Dtb > 5.5)
                {
                    count++;
                }
            }
            return count;
        }
        public void PrintDSTN()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Danh sách SV tốt nghiệp lớp {className}");
            foreach (SinhVien sv in ds)
            {
                if (sv.Dtb >= 5.5 && sv.Credits >= SinhVien.TongSTC)
                {
                    sv.OutputSV();
                }
            }
        }
        public void SapXep()
        {
            for (int i = 0; i < ds.Length; i++)
            {
                for (int j = i + 1; j < ds.Length; j++)
                {
                    if (ds[i] < ds[j])
                    {
                        SinhVien temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = temp;
                    }    
                }    
            }    
        }    

    }
}
