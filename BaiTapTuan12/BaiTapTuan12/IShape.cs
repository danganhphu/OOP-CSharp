using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan12
{
    internal interface IShape
    {
        string TenHinh { get; set; }

        float ChuVi();

        float DienTich();
    }

    internal class Square : IShape
    {
        private string tenHinh;
        private int chieuDai, chieuRong;
        public string TenHinh { get => tenHinh; set => tenHinh = value; }

        public Square(string tenHinh = "", int chieuDai = 1, int chieuRong = 1)
        {
            this.tenHinh = tenHinh;
            this.chieuRong = chieuRong;
            this.chieuDai = chieuDai;
        }

        public float ChuVi() => (chieuDai + chieuRong) * 2;

        public float DienTich() => chieuDai * chieuRong;

        public void XuatTT() => Console.Write($"Tên hình: {tenHinh}\tChu vi: {ChuVi()}\tDiện tích: {DienTich()}");
    }
}