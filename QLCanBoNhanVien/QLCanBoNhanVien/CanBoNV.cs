using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanBoNhanVien
{
    abstract class CanBoNV
    {
        string maSo, hoTen;
        bool gioiTinh;
        public CanBoNV(string maSo = "", string hoTen = "", bool gioiTinh = true)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
        }
        public virtual void NhapTT()
        {
            Console.Write("Nhập mã số cán bộ: ");
            maSo = Console.ReadLine();
            Console.Write("Nhập họ tên cán bộ: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập giới tính (True: name || False: nữ): ");
            while (bool.TryParse(Console.ReadLine(), out gioiTinh) == false)
            {
                Console.Write("Nhập sai yêu cầu. Nhập lại: ");
            }
        }
        //phương thức trừu trượng
        public abstract float TinhLuong();
        public virtual void XuatTT()
        {
            Console.WriteLine($"\tMã số: {maSo}");
            Console.WriteLine($"\tHọ tên: {hoTen}");
            Console.WriteLine($"\tLương: {TinhLuong()}");
        }
    }
}
