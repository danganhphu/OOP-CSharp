using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class SmartPhone : Phone
    {
        private int dungLuong;

        public int DungLuong { get => dungLuong; set => dungLuong = value; }

        public SmartPhone(string maSo = "SM001", string nhanHieu = "Oppo", float giaNhap = 1, int namSX = 2021, int dungLuong = 2)
            : base(maSo, nhanHieu, giaNhap, namSX)
            => this.dungLuong = dungLuong;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập dung lượng: ");
            while (int.TryParse(Console.ReadLine(), out dungLuong) == false || dungLuong < 0)
            {
                Console.Write("Nhập sai yêu cầu, nhập lại: ");
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write($"\tDung lượng: {dungLuong}GB");
        }

        public double GiaBan()
        {
            DateTime now = DateTime.Now;
            if (now.Year - NamSX <= 1)
                return GiaNhap + (0.2 * GiaNhap) + ThueNhap();
            else
            {
                if (now.Year - NamSX > 1 && now.Year - NamSX <= 3)

                    return GiaNhap + (0.1 * GiaNhap) + ThueNhap();
                else
                    return GiaNhap + (0.5 * ThueNhap());
            }
        }
    }
}