using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVien
{
    class SinhVien
    {
        string id, name;
        bool sex;
        float dtb;
        byte credits;
        static byte tongSTC = 155;

        public float Dtb { get => dtb; set => dtb = value; }
        public byte Credits { get => credits; set => credits = value; }
        public static byte TongSTC { get => tongSTC; set => tongSTC = value; }

        public SinhVien(string mssv = "", string ten = "", bool gt = true, float mark = 0, byte stc = 0)
        {
            id = mssv;
            name = ten;
            sex = gt;
            dtb = mark;
            credits = stc;
        }
        public void InputSV()
        {
            Console.Write("Nhập mã số sinh viên: ");
            id = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên: ");
            name = Console.ReadLine();
            Console.Write("Nhập giới tính (True: name || False: nữ): ");
            while (bool.TryParse(Console.ReadLine(), out sex) == false)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
            Console.Write("Nhập điểm trung bình tích lũy: ");
            while (float.TryParse(Console.ReadLine(), out dtb) == false)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }    
            Console.Write("Nhập số tín chỉ tích lũy: ");
            while (byte.TryParse(Console.ReadLine(), out credits) == false || credits < 0)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
        }
        public void OutputSV()
        {
            Console.WriteLine($"{id}\t{name}\t{sex}\t{dtb}\t{credits}\t{tongSTC}");
        }
        public static bool operator > (SinhVien sv1, SinhVien sv2)
        {
            return sv1.credits > sv2.credits;
        }
        public static bool operator < (SinhVien sv1, SinhVien sv2)
        {
            return sv1.credits < sv2.credits;
        }    
    }
}
