using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            LopHoc lh1 = new LopHoc("OOP", 10);
            //lh1.InputDS();
            byte result = lh1.DemSV();
            Console.WriteLine($"Sinh viên có ĐTB trên 5.5: {result}");
            //lh1.OutputDS();
            lh1.PrintDSTN();
            lh1.SapXep();
            Console.WriteLine();
            Console.WriteLine("Danh sách sinh viên đã sắp xếp chiều giảm dần theo STC:");
            lh1.OutputDS();
            Console.ReadKey();
        }
    }
}
