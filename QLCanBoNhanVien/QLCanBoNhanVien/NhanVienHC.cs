using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBoNhanVien
{
    class NhanVienHC : CanBoNV
    {
        byte soNgayCong;
        float luong;
        public NhanVienHC(string maSo = "", string hoTen = "", bool gioiTinh = true, byte soNgayCong = 0, float luong = 0):base(maSo, hoTen, gioiTinh)
        {
            this.soNgayCong = soNgayCong;
            this.luong = luong;
        }
        public override void NhapTT()
        {
            base.NhapTT();
            Console.Write("Nhập số ngày công: ");
            while (byte.TryParse(Console.ReadLine(), out soNgayCong) == false || soNgayCong < 0)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
            Console.Write("Nhập lương tháng: ");
            while (float.TryParse(Console.ReadLine(), out luong) == false || luong < 0)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
        }
       
        public sealed override float TinhLuong()
        {
            return soNgayCong * luong / 26;
        }
    }
}
