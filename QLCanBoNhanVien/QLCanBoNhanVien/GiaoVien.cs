using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBoNhanVien
{
    class GiaoVien:CanBoNV
    {
        byte soTiet;
        float thuLao;
        public GiaoVien(string maSo = "", string hoTen = "", bool gioiTinh = true, byte soLuong = 0, byte soTiet = 0, float thuLao = 0) : base(maSo, hoTen, gioiTinh)
        {
            this.soTiet = soTiet;
            this.thuLao = thuLao;
        }
        public override void NhapTT()
        {
            base.NhapTT();
            Console.Write("Nhập số tiết dạy: ");
            while (byte.TryParse(Console.ReadLine(), out soTiet) == false || soTiet < 0)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }    
            Console.Write("Nhập thù lao 1 tiết: ");
            while (float.TryParse(Console.ReadLine(), out thuLao) == false || thuLao < 0)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }    
        }
        public sealed override float TinhLuong()
        {
            return soTiet * thuLao;
        }
    }
}
