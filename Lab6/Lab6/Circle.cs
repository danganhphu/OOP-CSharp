using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Circle : Shape, IPaint
    {
        private float banKinh;

        public Circle(string tenHinh = "Hình tròn", float banKinh = 0) : base(tenHinh) => this.banKinh = banKinh;

        public override float ChuVi()
        {
            double cv = 2 * 3.14 * banKinh;

            return (float)cv;
        }

        public override float DienTich()
        {
            double dt = 3.14 * Math.Pow(banKinh, 2);
            return (float)dt;
        }

        public float Cost(int c) => c * DienTich();
    }
}