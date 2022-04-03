using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal abstract class Shape
    {
        private string tenHinh;
        public string TenHinh { get => tenHinh; set => tenHinh = value; }

        public Shape(string tenHinh = "") => this.tenHinh = tenHinh;

        public abstract float ChuVi();

        public abstract float DienTich();

        public void Xuat() => Console.Write($"Tên hình: {tenHinh}\tChu vi: {ChuVi()}\tDiện tích: {DienTich()}");
    }

    internal interface IPaint
    {
        float Cost(int c);
    }
}