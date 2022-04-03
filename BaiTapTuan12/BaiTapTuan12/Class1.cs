using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan12
{
    internal class Class1
    {
        protected int x;

        public Class1(int x1 = 1)
        {
            x = x1;
        }

        public void Di()
        {
            Console.Write($"{x}");
        }
    }

    internal class Class2 : Class1
    {
        private int y;

        public Class2() : base()
        {
            y = 0;
        }

        public void Di()
        {
            Console.Write($"{x}, {y}");
        }
    }
}