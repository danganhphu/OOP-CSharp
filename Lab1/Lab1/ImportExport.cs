using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ImportExport
    {
        string name;
        DateTime birthDay;
        bool sex;
        
        public void Import()
        {
            Console.Write("Nhập họ tên: ");
            name = Console.ReadLine();

            Console.Write("Nhập ngày sinh: ");
            while (DateTime.TryParse(Console.ReadLine(), out birthDay) == false)
            {
                Console.WriteLine("Nhập sai định dạng. Vui lòng nhập lại!!!");
            }

            Console.Write("Nhập true nếu là nam, false nếu là nữ: ");
            sex = bool.Parse(Console.ReadLine());
        }
        public void Export()
        {
            if(sex)
            {
                Console.WriteLine($"Giá trị vừa nhập là: {name}\t {birthDay.ToShortDateString()}\t nam");
            }
            else
            {
                Console.WriteLine($"Giá trị vừa nhập là: {name}\t {birthDay.ToShortDateString()}\t nữ");
            }
        }
    }
}
