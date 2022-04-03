using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student sinhVien = new Student();
            //string i, n;
            //float m;
            //Console.Write("nhap id, name, mark: ");
            //i = Console.ReadLine();
            //n = Console.ReadLine();
            //m = float.Parse(Console.ReadLine());
                       
            //sinhVien.Set("61134177", "anh phu", 8.7f);
            sinhVien.Info();
            sinhVien.Mark = -1;
            Console.Write("\ndiem: " + sinhVien.Mark);
            Console.Write(Environment.NewLine);
            Student sinhVien1 = new Student(sinhVien);
            sinhVien1.Info();
            if (sinhVien.CheckHB(7))
            {
                Console.WriteLine("Được hoc bổng.");
            }
            else
                Console.Write("Không được học bổng");

            Console.ReadKey();
        }
    }
}
