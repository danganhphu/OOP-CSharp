using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class XeVinfast : Xe, IPhi
    {
        private float phiTruocBa;
        public float PhiTruocBa { get => phiTruocBa; set => phiTruocBa = value; }

        private byte soChoNgoi;
        public byte SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }

        public XeVinfast(string loaiXe = "Mercedes", float giaXe = 0, string noiDK = "Nha Trang", float phiTruocBa = 0, byte soChoNgoi = 0) : base(loaiXe, giaXe, noiDK)
        {
            this.phiTruocBa = phiTruocBa;
            this.soChoNgoi = soChoNgoi;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập phí trước bạ: ");
            phiTruocBa = float.Parse(Console.ReadLine());
        }

        public double TienPhi()
        {
            double tb = Math.Round(phiTruocBa * GiaXe, 2);
            return tb;
        }

        public double GiaLanBanh()
        {
            double glb = Math.Round(GiaBan() + TienPhi(), 2);
            return glb;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"\tSố chỗ ngồi: {soChoNgoi}\tTiền phí trước bạ: {TienPhi()}\tGiá lăn bánh {GiaLanBanh()}");
        }
    }
}