using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Bai2_1()
        {
            Point diem = new Point();
            Point diem1 = new Point(3, 4);
            diem.DisplayPoint();
            diem1.DisplayPoint();
            double kc = diem.Distance(diem1);
            Console.Write($"\nKhoảng cách giữa 2 điểm là: {kc}");
        }

        static void Bai2_2()
        {
            Circle hinhTron = new Circle();
            Console.WriteLine($"Chu vi là : {hinhTron.GetPerimeter()}");
            Console.WriteLine($"Diện tích là: {hinhTron.GetArea()}");
            Console.Write(Environment.NewLine);

            float banKinh;
            Console.Write("Nhập vào bán kính: ");
            banKinh = float.Parse(Console.ReadLine());
            hinhTron.SetRadius(banKinh);
            Console.WriteLine($"Bán kính là {hinhTron.GetRadius()}");
            Console.WriteLine($"Chu vi là: {hinhTron.GetPerimeter()}");
            Console.Write(Environment.NewLine);

            Circle hinhTron2 = new Circle(3);
            Console.WriteLine($"Chu vi là : {hinhTron2.GetPerimeter()}");
            Console.WriteLine($"Diện tích là: {hinhTron2.GetArea()}");
        }
        static void Bai2_3()
        {
            Time time = new Time(12, 24, 29);
            Console.WriteLine($"{time.Hour}:{time.Minute}:{time.Second}");
            time.NetxSecond(time);
            //Console.WriteLine($"{time.Hour}:{time.Minute}:{time.Second}");
            time.Show();

            //Time time1 = new Time(17, 26, 48);
            //time1.PreviousSecond();
            //time1.Show();

        }
        static void Bai2_4()
        {
            Adult adult = new Adult();
            adult.OutPut();
            adult.tangGiam();

            Adult adult1 = new Adult("Nguyễn Văn A", 80, 1.70f);
            adult1.OutPut();
            adult1.tangGiam();

            Adult adult2 = new Adult(adult1);
            adult2.OutPut();
            adult2.tangGiam();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai2_1();
            //Bai2_2();
            Bai2_3();
            //Bai2_4();
            
            Console.ReadKey();
        }
    }
}
