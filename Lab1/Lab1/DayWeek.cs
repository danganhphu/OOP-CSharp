using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class DayWeek
    {
        byte day;
        public void InOutPut()
        {
            L1:
            Console.Write("Nhập vào số tương ứng với thứ trong tuần: ");
            while (byte.TryParse(Console.ReadLine(), out day) == false)
            {
                Console.WriteLine("Bạn nhập sai định dạng. Vui lòng nhập lại.");
            }
            switch (day)
            {
                case 1:
                    Console.WriteLine($" {day} => Sunday");
                    break;
                case 2:
                    Console.WriteLine($"{day} => Monday");
                    break;
                case 3:
                    Console.WriteLine($"{day} => Tuesday");
                    break;
                case 4:
                    Console.WriteLine($"{day} => Wednesday");
                    break;
                case 5:
                    Console.WriteLine($"{day} => Thursday");
                    break;
                case 6:
                    Console.WriteLine($"{day} => Friday");
                    break;
                case 7:
                    Console.WriteLine($"{day} => Saturday");
                    break;
                default:
                    Console.WriteLine("Hãy nhập lại số khác (1 <= n <= 7)");
                    goto L1;
            }    
        }
    }
}
