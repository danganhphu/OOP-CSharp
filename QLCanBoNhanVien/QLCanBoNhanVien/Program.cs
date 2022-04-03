using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBoNhanVien
{
    class Program
    {
        static List<CanBoNV> canBoList = new List<CanBoNV>();
        static void ThemCB()
        {
            Console.Write("Nhập số cán bộ cần thêm (5 <= n <= 30): ");
            byte n;
            while (byte.TryParse(Console.ReadLine(), out n) == false)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }    
            for (int i = 0; i < n; i++)
            {
                Console.Write(Environment.NewLine);
                CanBoNV canBo = TaocanBo();
                canBoList.Add(canBo);
            }    
        }   
        static CanBoNV TaocanBo()
        {
            byte option;
            CanBoNV objCanBo;

            Console.WriteLine("1. Nhập thông tin nhân viên hành chính.");
            Console.WriteLine("2. Nhập thông tin giáo viên.");
            Console.Write("Chọn: ");
        l1:
            option = byte.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);
            switch (option)
            {
                case 1:
                    objCanBo = new NhanVienHC();
                    break;
                case 2:
                    objCanBo = new GiaoVien();
                    break;
                default:
                    Console.Write("Lựa chọn không hợp lệ. Nhập lại lựa chọn khác: ");
                    goto l1;
            }
            objCanBo.NhapTT();
            return objCanBo;
        }    
        static void HienThiCB()
        {
            if (canBoList.Count == 0)
            {
                Console.WriteLine("Không có thông tin trong dánh sách cán bộ");
            }
            else
            {
                Console.WriteLine("-------Thông tin cán bộ-------");
                for (int i = 0; i < canBoList.Count; i++)
                {
                    canBoList[i].XuatTT();
                    Console.Write(Environment.NewLine);
                }
            }    
        }    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte choose;
            do
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("1. Nhập thông tin cho cán bộ.");
                Console.WriteLine("2. Hiển thị thông tin.");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn: ");
                choose = byte.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
                switch (choose)
                {
                    case 1:
                        ThemCB();
                        break;
                    case 2:
                        HienThiCB();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn.");
                        break;
                }
            } while (choose != 3);

            Console.ReadKey();
        }
    }
}
