using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Point
    {
        float x, y;
        public Point ()
        {
            x = 0;
            y = 0;
        }
        public Point(float diemX, float diemY)
        {
            x = diemX;
            y = diemY;
        }
        public void DisplayPoint()
        {
            Console.WriteLine($"Tọa độ điểm là: ({x}, {y})");
        }
        public double Distance(Point diem)
        {
            double distance = Math.Round(Math.Sqrt(Math.Pow((diem.x - x), 2) + Math.Pow((diem.y - y), 2)), 3);
            return distance;
        }
    }
}
