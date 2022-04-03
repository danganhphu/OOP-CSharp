using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Adult
    {
        string name;
        float weight;
        float height;
        public Adult()
        {
            name = "Đặng Anh Phú";
            weight = 45;
            height = 1.72f;
        }
        public Adult(string ten, float cn, float cc)
        {
            name = ten;
            weight = cn;
            height = cc;
        }
        public Adult (Adult adultCP)
        {
            name = adultCP.name;
            weight = adultCP.weight;
            height = adultCP.height;
        }
        public void OutPut()
        {
            Console.WriteLine("---------User Information------------");
            Console.WriteLine($"\tTên: {name}.");
            Console.WriteLine($"\tCân nặng: {weight}kg.");
            Console.WriteLine($"\tChiều cao {height}m.");
            
            if (CheckBMI() == 0)
            {
                Console.WriteLine("\tTình trạng: thiếu cân.");
            }
            else
            {
                if (CheckBMI() == 1)
                {
                    Console.WriteLine("\tTình trạng: bình thường.");
                }
                else
                {
                    if (CheckBMI() == 2 )
                    {
                        Console.WriteLine("\tTình trạng: thừa cân");
                    }
                    else
                    {
                        Console.WriteLine("\tTình trạng: béo phì");
                    }
                }    
            }    
        }
        private byte CheckBMI()
        {

            double BMI = Math.Round(weight / Math.Pow(height, 2), 3);
            if (BMI < 18.5)
                return 0;//thiếu cân
            else
            {
                if (BMI <= 25)
                {
                    return 1;//bình thường
                }
                else
                   if (BMI < 30)
                {
                    return 2;//thừa cân
                }
                else
                    return 3;//béo phì
            }
        }

        public void tangGiam()
        {
            double a, b;
            if (CheckBMI() == 0)
            {
                a = 18.5 * Math.Pow(height, 2);
                b = Math.Round(a - weight, 3);
                Console.WriteLine($"Bạn cần tăng: {b}");
            }
            else
            {
                if (CheckBMI() > 1)
                {
                    a = 25 * Math.Pow(height, 2);
                    b = Math.Abs(Math.Round(a - weight, 3));
                    Console.WriteLine($"Bạn cần giảm: {b}");
                }
                else
                {
                    Console.WriteLine("Bạn đang ở trong tình trạng bình thường. Nên không cần tăng hay giảm");
                }
            }    
        }    
    }
}
