using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Pixcel
    {
        protected int x, y;

        public Pixcel(int x = 3, int y = 3)
        {
            this.x = x;
            this.y = y;
        }

        //public void Xuat() => Console.Write($"({x}, {y})");

        //Đa hình động
        public virtual void Print() => Console.Write($"({x}, {y})");
    }

    class Colored_Pixel : Pixcel
    {
        byte c;
        public Colored_Pixel(int x = 7, int y = 5, byte c = 10) : base(x, y) => this.c = c;
        //public new void Xuat()
        //{
        //    Console.CursorTop = x;
        //    Console.CursorLeft = y;
        //    Console.ForegroundColor = (ConsoleColor)c;
        //    base.Xuat();
        //}
        //đa hình động
        public override void Print()
        {
            Console.CursorTop = x;
            Console.CursorLeft = y;
            Console.ForegroundColor = (ConsoleColor)c;
            base.Print();
        }    
    }
}
