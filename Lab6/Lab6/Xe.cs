using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Xe
    {
        private string loaiXe;
        private float giaXe;
        private string noiDK;

        public string LoaiXe { get => loaiXe; set => loaiXe = value; }
        public float GiaXe { get => giaXe; set => giaXe = value; }
        public string NoiDK { get => noiDK; set => noiDK = value; }

        public Xe(string loaiXe = "", float giaXe = 0, string noiDK = "")
        {
            this.loaiXe = loaiXe;
            this.giaXe = giaXe;
            this.noiDK = noiDK;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập loại xe: ");
            loaiXe = Console.ReadLine();
            Console.Write("Nhập giá xe: ");
            giaXe = float.Parse(Console.ReadLine());
            Console.Write("Nhập nơi đăng ký: ");
            noiDK = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.Write($"Loại xe: {loaiXe}\tGiá xe:{giaXe}\tNơi đăng ký: {noiDK}");
        }

        public double GiaBan()
        {
            if (loaiXe == "Ha Noi")
                return giaXe + 0.12 * giaXe;
            else
                return giaXe + 0.12 * giaXe;
        }
    }
}