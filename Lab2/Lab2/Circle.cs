using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Circle
    {
        float radius;

        public Circle()
        {
            radius = 1;
        }
        public Circle(float r)
        {
            radius = r;
        }
        public float GetRadius()
        {
            return radius;
        }
        public void SetRadius(float f)
        {
            radius = f;
        }
        public double GetPerimeter()
        {
            double chuVi = 2 * 3.14 * radius;
            return chuVi;
        }
        public double GetArea()
        {
            double dienTich = 3.14 * radius * radius;
            return dienTich;
        }
    }
}
