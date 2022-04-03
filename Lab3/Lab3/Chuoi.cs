using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Chuoi
    {
        string s;
        int x, y;
        public Chuoi(string s1 = "Bò đi chạy nhảy, nhảy chạy đi bò.\n     Đò đi đến đó, đến đó đi đò.", int x1 = 3, int y1 = 4)
        {
            s = s1;
            x = x1;
            y = y1;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void HienThi()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.CursorTop = y;
            Console.CursorLeft = x;
            Console.Write(s);
        }
        public void ChuyenDong()
        {
            HienThi();
            while (true)
            {
                ConsoleKeyInfo phim = Console.ReadKey(true);
                if (phim.Key == ConsoleKey.Escape)
                    break;
                if (phim.Key == ConsoleKey.LeftArrow)
                    x--;
                else if (phim.Key == ConsoleKey.RightArrow)
                    x++;
                else if (phim.Key == ConsoleKey.UpArrow)
                    y--;
                else if (phim.Key == ConsoleKey.DownArrow)
                    y++;

                if (x <= 0)
                    x = Console.WindowWidth;
                if (x >= Console.WindowWidth)
                    x = 0;
                if (y <= 0)
                    y = Console.WindowHeight;
                if (y >= Console.WindowHeight)
                    y = 0;
                HienThi();
            }
        }

    }
}
