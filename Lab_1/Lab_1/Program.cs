using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        #region Bài 1.1
        static void Bai1_1()
        {
            short year;
            Console.Write("Nhập vào năm: ");
            while (Int16.TryParse(Console.ReadLine(), out year) == false || year <= 0)
            {
                Console.Write("Bạn nhập sai định dạng. Vui lòng nhập lại: ");
            }

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} là năm nhuận");
            }
            else
                Console.Write($"{year} không phải năm nhuận");
        }
        #endregion

        #region Bài 1.2
        static void Bai1_2()
        {
            Console.WriteLine("       ******************************************");
            Console.WriteLine("       *         Trò chơi Kéo, Búa, Bao         *");
            Console.WriteLine("       *             Chọn 1 là Kéo              *");
            Console.WriteLine("       *             Chọn 2 là Búa              *");
            Console.WriteLine("       *             Chọn 3 là Bao              *");
            Console.WriteLine("       ******************************************");

            byte user, game;
            
            int bot;
            do
            {
                Console.Write("Mời bạn chọn: ");
                while (byte.TryParse(Console.ReadLine(), out user) == false || user < 1 || user > 3)
                {
                    Console.Write("Bạn nhập sai yêu cầu. Vui lòng nhập lại: ");
                }
                
                switch (user)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn Kéo");
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn Búa");
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn Bao");
                        break;
                }

                Random rd = new Random();
                bot = rd.Next(1, 4);

                switch (bot)
                {
                    case 1:
                        Console.WriteLine("Máy đã chọn Kéo");
                        break;
                    case 2:
                        Console.WriteLine("Máy đã chọn Búa");
                        break;
                    case 3:
                        Console.WriteLine("Máy đã chọn Bao");
                        break;
                }

                Console.WriteLine("-----Kết quả------");

                if (user == bot)
                {
                    Console.WriteLine("-------Hòa--------");
                }
                else
                {
                    int resulf;
                    resulf = user - bot;
                    
                    if (resulf == -2 || resulf == 1)
                    {
                        Console.WriteLine("----Bạn Thắng----");
                    } else
                    {
                        Console.WriteLine("----Bạn Thua----");
                    }    
                }
                Console.Write("\nBạn có muốn chơi tiếp không? < 1 - Có | 2 - Không >: ");
                game = byte.Parse(Console.ReadLine());
                
            } while (game == 1);
        }
        #endregion

        #region Bài 1.3
        static void Bai1_3()
        {
            Console.WriteLine("Cú pháp khai báo 1 số nguyên trong C: ");
            Console.WriteLine("A. int 1a;");
            Console.WriteLine("B. float n;");
            Console.WriteLine("C. long b1;");
            Console.WriteLine("D. double c;");

            L:
            Console.Write("Bạn lựa chọn đáp án: ");

            char c;
            c = Console.ReadKey().KeyChar;
            Console.Write(Environment.NewLine);
            switch (c)
            {
                case 'A':
                case 'a':
                case 'B':
                case 'b':
                case 'D':
                case 'd':
                    Console.Write("Lựa chọn không đúng!");
                    break;

                case 'C':
                case 'c':
                    Console.Write("Chúc mừng bạn đã chọn đúng!");
                    break;

                default:
                    Console.WriteLine("\nĐáp án bạn chọn không tồn tại. Vui lòng chọn lại.");
                    goto L;
            }   
        }
        #endregion

        #region Bài 1.4
        static void Bai1_4()
        {
            const int pass = 123;

            int pass1, count = 0;
            do
            {
                Console.Write("Nhập mật khẩu: ");
                while (Int32.TryParse(Console.ReadLine(), out pass1) == false)
                {
                    Console.WriteLine("Bạn nhập sai định dạng. Vui lòng nhập lại: ");
                }
                
                if (pass1 != pass)
                {
                    Console.WriteLine("Mật khẩu không hợp lệ");
                    count++;
                }
            } while (pass1 != pass && count <=2);
        }
        #endregion

        #region Bài 1.5
        static void InputN(out byte n)
        {
            n = 0;
            Console.Write("\nNhập số phần tử trong mảng ( 3 <= n <= 20): ");

            while(byte.TryParse(Console.ReadLine(), out n) == false || n < 3 || n > 20)
            {
                Console.Write("Bạn đã nhập sai yêu cầu. Vui lòng nhập lại ");
            }
        }
        static void InputArr(ref float[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($" arr[{i}]= ");
                while (float.TryParse(Console.ReadLine(), out arr[i]) == false)
                {
                    Console.WriteLine("\nNhập sai định dạng. Vui lòng nhập lại.");
                    Console.Write($" arr[{i}]= ");
                }
            }
        }
        
        static void SapXepTD(float[] arr)
        {
            float temp;
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
        }
        static void OutputArr(float[] arr)
        {
            Console.Write("\nMảng đã sắp xếp tăng dần  là: ");
            foreach (float i in arr)
            {
                Console.Write($"\t {i:0.0}");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bai1_1();
            Bai1_2();
            //Bai1_3();
            //Bai1_4();

            //----------Bài 1.5-------
            //byte n;

            //InputN(out n);
            //float[] arr = new float[n];
            //InputArr(ref arr);
            //SapXepTD(arr);
            //OutputArr(arr);

            Console.ReadKey();
        }
    }
}
