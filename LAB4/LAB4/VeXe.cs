using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class VeXe
    {
        protected string soXe;
        protected string gioDi;
        protected DateTime ngayDi;
        protected string tuyenDi;
        protected int chieuDai;
        protected static byte giaSan = 100;
        public VeXe()
        {
            soXe = "77A";
            gioDi = "8h:30";
            ngayDi = new DateTime(2021, 12, 20);
            tuyenDi = "Quy Nhơn - Nha Trang";
            chieuDai = 100;
        }
        public VeXe(string soXe, string gioDi, DateTime ngayDi, string tuyenDi, int chieuDai)
        {
            this.soXe = soXe;
            this.gioDi = gioDi;
            this.ngayDi = ngayDi;
            this.tuyenDi = tuyenDi;
            this.chieuDai = chieuDai;
        }
        public virtual float GiaVe()
        {
            if (chieuDai < 100)
                return giaSan;
            else
            {
                if (chieuDai >= 100 && chieuDai <= 150)
                    return giaSan * 1.3f;
                else
                    return giaSan * 1.5f;
            }    
        }
        public virtual void Xuat() => Console.Write($"{soXe}\t{ngayDi.ToShortDateString()}\t{tuyenDi}\t{GiaVe()}");
    }
    
}
