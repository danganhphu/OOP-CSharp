using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class VeKhuHoi : VeXe
    {
        private string gioVe;

        public VeKhuHoi() : base() => gioVe = "13h:00";

        public VeKhuHoi(string soXe, string gioDi, DateTime ngayDi, string tuyenDi, int chieuDai, string gioVe)
            : base(soXe, gioDi, ngayDi, tuyenDi, chieuDai) => this.gioVe = gioVe;

        public override float GiaVe()
        {
            return base.GiaVe() * 1.75f;
        }

        public override void Xuat() => base.Xuat();
    }
}