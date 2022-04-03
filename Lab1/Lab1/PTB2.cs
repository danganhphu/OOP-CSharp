using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class PTB2
    {
        float a, b, c;
        public void InPut()
        {
            Console.Write("Nhập giá trị a: ");
            while (float.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.Write("Bạn nhập sai định dạng. Vui lòng nhập lại.");
            }

            Console.Write("Nhập giá trị b: ");
            while (float.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.Write("Bạn nhập sai định dạng. Vui lòng nhập lại.");
            }

            Console.Write("Nhập giá trị a: ");
            while (float.TryParse(Console.ReadLine(), out c) == false)
            {
                Console.Write("Bạn nhập sai định dạng. Vui lòng nhập lại.");
            }
            Console.Write(Environment.NewLine);

            Console.WriteLine($"Phương trình nhập vào là: {a}x^2 + {b}x + {c} = 0");
        }

        #region Xử lý phương trình bậc 2
        public void OutPut()
        {
            float delta;
            delta = (b / 2) * (b / 2) - a * c;

            Console.WriteLine($"Delta phẩy = {delta}");

            if (delta < 0)
            {
                Console.Write("No Solutions.");
            }
            else if (delta == 0)
            {
                float x;
                x = (-b / 2) / a;
                Console.Write($"Phương trình có nghiệm kép x1 = x2 = {x}");
            }
            else
            {
                double x1, x2;
                x1 = Math.Round(((-b / 2) + Math.Sqrt(delta)) / a, 3);
                x2 = Math.Round(((-b / 2) - Math.Sqrt(delta)) / a, 3);
                
                Console.Write($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }    
        }
        #endregion
    }
}
