using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Program
    {
        private static void NhapPixel(ref int x, ref int y)
        {
            Console.Write("Nhập x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            y = int.Parse(Console.ReadLine());
        }

        private static void Bai4_1()
        {
            //Pixcel objP = new Pixcel();
            //objP.Xuat();
            //Colored_Pixel objCP = new Colored_Pixel();
            //objCP.Xuat();
            Pixcel objP1;
            int x = 0;
            int y = 0;
            Console.Write("Nhập lựa chọn.\n1. Pixel\n2. Colored_Pixel\nChọn: ");
            byte choose = byte.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);
            if (choose == 1)
            {
                NhapPixel(ref x, ref y);
                objP1 = new Pixcel(x, y);
            }
            else
            {
                NhapPixel(ref x, ref y);
                Console.Write("Nhập màu bằng số: ");
                byte c = byte.Parse(Console.ReadLine());
                objP1 = new Colored_Pixel(x, y, c);
            }

            objP1.Print();
        }

        private static void NhapVe(ref string soXe, ref string gioDi, ref DateTime ngayDi, ref string tuyenDi, ref int chieuDai)
        {
            Console.Write("Nhập số xe: ");
            soXe = Console.ReadLine();
            Console.Write("Nhập giờ đi: ");
            gioDi = Console.ReadLine();
            Console.Write("Nhập ngày đi: ");

            while (DateTime.TryParse(Console.ReadLine(), out ngayDi) == false || ngayDi < DateTime.Now)
            {
                Console.Write("Nhập sai định dạng ngày. Nhập lại: ");
            }
            Console.Write("Nhập tuyến đi: ");
            tuyenDi = Console.ReadLine();
            Console.Write("Nhập chiều dài tuyến đi: ");
            while (int.TryParse(Console.ReadLine(), out chieuDai) == false)
            {
                Console.Write("Nhập sai định dạng. Nhập lại: ");
            }
        }

        private static void Bai4_2()
        {
            VeXe vxe = null;
            Console.Write("Nhập lựa chọn.\n1. Vé Xe\n2. Vé khứ hồi\nChọn: ");
        L2:
            byte choose = byte.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);
            string soXe = "";
            string gioiDi = "";
            DateTime ngayDi = new DateTime(2021, 11, 11);
            string tuyenDi = "";
            int chieuDai = 0;
            if (choose == 1)
            {
                NhapVe(ref soXe, ref gioiDi, ref ngayDi, ref tuyenDi, ref chieuDai);
                vxe = new VeXe(soXe, gioiDi, ngayDi, tuyenDi, chieuDai);
            }
            else
            {
                if (choose == 2)
                {
                    NhapVe(ref soXe, ref gioiDi, ref ngayDi, ref tuyenDi, ref chieuDai);
                    Console.Write("Nhập giờ về: ");
                    string gioVe = Console.ReadLine();
                    vxe = new VeKhuHoi(soXe, gioiDi, ngayDi, tuyenDi, chieuDai, gioVe);
                }
                else
                {
                    Console.Write("Nhập sai lựa chọn. Nhập lại: ");
                    goto L2;
                }
            }
            vxe.Xuat();
        }

        private static void Bai4_3()
        {
            Shape[] hinh;
            byte n, choose;
            Console.Write("Nhập số hình cần tạo (2 <= n <= 20): ");
            while (byte.TryParse(Console.ReadLine(), out n) == false || n < 2)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }

            hinh = new Shape[n];

            for (int i = 0; i < hinh.Length; i++)
            {
                Console.Write("\nNhập lựa chọn.\n1. Hình tam giác\n2. Hình chữu nhật\n3. Thoát\nChọn: ");
            L1:
                while (byte.TryParse(Console.ReadLine(), out choose) == false || choose < 0)
                {
                    Console.Write("Nhập sai định dạng. Nhập lại: ");
                }

                switch (choose)
                {
                    case 1:
                        float a, b, c;
                    L2:
                        Console.Write("\nNhập cạnh a: ");
                        while (float.TryParse(Console.ReadLine(), out a) == false || a <= 0)
                        {
                            Console.Write("nhập sai yêu cầu. Nhập lại: ");
                        }
                        Console.Write("Nhập cạnh b: ");
                        while (float.TryParse(Console.ReadLine(), out b) == false || b <= 0)
                        {
                            Console.Write("nhập sai yêu cầu. Nhập lại: ");
                        }
                        Console.Write("Nhập cạnh c: ");
                        while (float.TryParse(Console.ReadLine(), out c) == false || c <= 0)
                        {
                            Console.Write("nhập sai yêu cầu. Nhập lại: ");
                        }

                        if (a + b > c && b + c > a && c + a > b)
                            hinh[i] = new Triangle("Tam Giác", a, b, c);
                        else
                        {
                            Console.Write("Dữ liệu bạn nhập không phải tam giác. Nhập lại.");
                            goto L2;
                        }
                        break;

                    case 2:
                        float cd, cr;
                        Console.Write("\nNhập chiều dài: ");
                        while (float.TryParse(Console.ReadLine(), out cd) == false || cd <= 0)
                        {
                            Console.Write("Nhập sai yêu cầu. nhập lại: ");
                        }
                        Console.Write("Nhập chiều rộng: ");
                        while (float.TryParse(Console.ReadLine(), out cr) == false || cr <= 0)
                        {
                            Console.Write("Nhập sai yêu cầu. Nhập lại: ");
                        }
                        hinh[i] = new Square("Chữ nhật", cd, cr);
                        break;

                    default:
                        Console.Write("Nhập sai lựa chọn. Nhập lại: ");
                        goto L1;
                }
            }
            Console.Write($"\n--------Thông tin {n} hình vừa nhập----------");
            foreach (Shape item in hinh)
            {
                Console.Write(Environment.NewLine);
                item.Xuat();
            }
            float sum = 0;
            byte count = 0;
            foreach (Shape item in hinh)
            {
                if (item.GetType() == typeof(Square))
                {
                    sum += item.DienTich();
                    count++;
                }
            }
            Console.Write($"\n\nDiện tích trung bình các HCN: {sum / count}");
        }

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bai4_1();
            Bai4_2();
            //Bai4_3();

            Console.ReadKey();
        }
    }
}