using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaiTapTuan12
{
    internal class Program
    {
        private static List<Square> square = new List<Square>();

        private static void DocDL()
        {
            try
            {
                FileStream f = new FileStream("D:\\BaiTapLapTrinh\\c#\\OOP_Csharp\\oop_cntt2\\BaiTapTuan12\\Square.txt", FileMode.Open);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);
                string line = rd.ReadLine();
                byte n = byte.Parse(line);
                while ((line = rd.ReadLine()) != null)
                {
                    string th = line;
                    int cd = int.Parse(rd.ReadLine());
                    int cr = int.Parse(rd.ReadLine());
                    Square sq = new Square(th, cd, cr);
                    square.Add(sq);
                }
                f.Close();
            }
            catch
            {
                Console.WriteLine("Không thể đọc file đã cho");
            }
        }

        private static void InTT()
        {
            if (square.Count == 0)
            {
                Console.WriteLine("Không có thông tin trong dánh sách");
            }
            else
            {
                Console.WriteLine("-------Thông tin ds square-------");
                for (int i = 0; i < square.Count; i++)
                {
                    square[i].XuatTT();
                    Console.Write(Environment.NewLine);
                }
            }
        }

        private static void Them()
        {
            Square sq1 = null;
            Console.Write($"Nhập vào vị trí cần thêm (0 <= p <= {square.Count}): ");
            byte p;
            while (byte.TryParse(Console.ReadLine(), out p) == false || p > square.Count)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
            Square sq = new Square();
            Console.Write("Nhập tên hình: ");
            string th = Console.ReadLine();
            Console.Write("Nhập chiều dài: ");
            int cd = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            int cr = int.Parse(Console.ReadLine());
            sq1 = new Square(th, cd, cr);
            square.Insert(p, sq1);
        }

        private static void SapXep()
        {
            square.Sort(
                (p1, p2) =>
                {
                    if (p1.ChuVi() > p2.ChuVi())
                        return 1;
                    else if (p1.ChuVi() == p2.ChuVi())
                        return 0;
                    return -1;
                }
            );
            foreach (Square sq in square)
            {
                sq.XuatTT();
                Console.Write(Environment.NewLine);
            }
        }

        private static void Xoa()
        {
            Console.Write("Nhập vào HCN có chu vi bằng x cần xóa: ");
            byte x;
            while (byte.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.Write("Nhập sai giá trị x. Nhập lại: ");
            }
            for (int i = 0; i < square.Count; i++)
            {
                if (x == square[i].ChuVi())
                    square.RemoveAt(i);
            }
        }

        private static void Bai6_1()
        {
            DocDL();
            InTT();
            Them();
            SapXep();
            Xoa();
            InTT();
        }

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bai6_1();
            Class2 c = new Class2();
            c.Di();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}