using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class NSmartPhone
    {
        private List<SmartPhone> lsSM = new List<SmartPhone>();
        private byte n;

        public NSmartPhone(byte n = 0)
        {
            this.n = n;
            for (byte i = 0; i < n; i++)
            {
                Console.Write(Environment.NewLine);
                Console.Write("Nhập mã số: ");
                string maSo = Console.ReadLine();
                Console.Write("Nhập nhãn hiệu: ");
                string nhanHieu = Console.ReadLine();
                float giaNhap;
                Console.Write("Nhập giá nhập (giá nhập > 0): ");
                while (float.TryParse(Console.ReadLine(), out giaNhap) == false || giaNhap < 0)
                {
                    Console.Write("Nhập sai yêu cầu, nhập lại: ");
                }
                int namSX;
                Console.Write("Nhập năm sản xuất: ");
                while (int.TryParse(Console.ReadLine(), out namSX) == false || namSX < 0)
                {
                    Console.Write("Nhập sai yêu cầu, nhập lại: ");
                }
                int dl;
                Console.Write("Nhập dung lượng: ");
                while (int.TryParse(Console.ReadLine(), out dl) == false || dl < 0)
                {
                    Console.Write("Nhập sai yêu cầu, nhập lại: ");
                }
                SmartPhone sm = new SmartPhone(maSo, nhanHieu, giaNhap, namSX, dl);
                lsSM.Add(sm);
            }
        }

        public void NhapDS()
        {
            Console.Write("Nhập số SmartPhone (2 <= n <= 30): ");
            while (byte.TryParse(Console.ReadLine(), out n) == false || n < 2 || n > 30)
            {
                Console.Write("Nhập sai yêu cầu, nhập lại: ");
            }
            for (int i = 0; i < n; i++)
            {
                SmartPhone s = new SmartPhone();
                Console.Write(Environment.NewLine);
                Console.WriteLine($"Nhập SmartPhone thứ {i + 1}");
                s.Nhap();
                lsSM.Add(s);
            }
        }

        public void XuatDS()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Thông tin danh sách SmartPhone");
            foreach (SmartPhone sm in lsSM)
            {
                sm.Xuat();
                Console.Write(Environment.NewLine);
            }
        }

        public void InTT()
        {
            double max = 0;
            for (int i = 0; i < lsSM.Count; i++)
            {
                for (int j = i + 1; j < lsSM.Count; j++)
                {
                    if (lsSM[i].GiaBan() > max)
                    {
                        max = lsSM[i].GiaBan();
                    }
                }
            }
            Console.WriteLine(Environment.NewLine + $"SmartPhone có giá bán cao nhất: {max} " + Environment.NewLine);
        }

        public void Them()
        {
            //SmartPhone sm = null;
            Console.Write($"Nhập vào vị trí cần thêm (0 <= p <= {lsSM.Count}): ");
            byte p;
            while (byte.TryParse(Console.ReadLine(), out p) == false || p > lsSM.Count)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
            SmartPhone sm1 = new SmartPhone();
            sm1.Nhap();
            lsSM.Insert(p, sm1);
        }

        public void DemVaIn()
        {
            Console.Write("Nhập vào dung lượng bộ nhớ: ");
            byte x;
            byte count = 0;
            while (byte.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.Write("Nhập sai giá trị x. Nhập lại: ");
            }
            foreach (SmartPhone sm in lsSM)
                if (x == sm.DungLuong)
                    count++;

            Console.WriteLine($"Số lượng SmartPhone có dung lượng bộ nhớ là {x}: {count}");
        }

        public void SapXep()
        {
            lsSM.Sort(
                (sm1, sm2) =>
                {
                    if (sm1.GiaNhap < sm1.GiaNhap)
                        return 1;
                    else if (sm1.GiaNhap == sm2.GiaNhap)
                        return 0;
                    else return -1;
                }
            );
            foreach (SmartPhone sm in lsSM)
            {
                sm.Xuat();
                Console.Write(Environment.NewLine);
            }
        }
    }
}