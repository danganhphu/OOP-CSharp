using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal abstract class Shape
    {
        protected string tenHinh;

        public Shape(string tenHinh = "") => this.tenHinh = tenHinh;

        public abstract float ChuVi();

        public abstract float DienTich();

        public void Xuat() => Console.Write($"Tên hình: {tenHinh}\tChu vi: {ChuVi()}\tDiện tích: {DienTich()}");
    }

    internal class Triangle : Shape
    {
        private float a, b, c;

        public Triangle(string tenHinh = "Tam Giác", float a = 3, float b = 4, float c = 5) : base(tenHinh)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override float ChuVi()
        {
            return a + b + c;
        }

        public override float DienTich()
        {
            float p = (a + b + c) / 2;
            float dt = p * (p - a) * (p - b) * (p - c);
            return (float)Math.Sqrt(dt);
        }
    }

    internal class Square : Shape
    {
        private float chieuDai, chieuRong;

        public Square(string tenHinh = "Chữ nhật", float chieuDai = 1, float chieuRong = 1) : base(tenHinh)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }

        public override float ChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }

        public override float DienTich()
        {
            return chieuDai * chieuRong;
        }
    }
}