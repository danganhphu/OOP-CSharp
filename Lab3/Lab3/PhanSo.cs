using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class PhanSo
    {
        int ts, ms;
        public PhanSo()
        {
            ts = 0;
            ms = 1;
        }
        public PhanSo(int x, int y)
        {
            ts = x;
            ms = y;
        }
        public PhanSo(PhanSo ps)
        {
            ts = ps.ts;
            ms = ps.ms;
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kqC = new PhanSo();
            kqC.ts = ts * p.ms + ms * p.ts;
            kqC.ms = ms * p.ms;
            return kqC;
        }
        public PhanSo Tru(PhanSo p)
        {
            PhanSo kqT = new PhanSo();
            kqT.ts = ts * p.ms - ms * p.ts;
            kqT.ms = ms * p.ms;
            return kqT;
        }
        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kqN = new PhanSo();
            kqN.ts = ts * p.ts;
            kqN.ms = ms * p.ms;
            return kqN;
        }
        public PhanSo Chia(PhanSo p)
        {
            PhanSo kqChia = new PhanSo();
            kqChia.ts = ts * p.ms;
            kqChia.ms = ms * p.ts;
            return kqChia;
        }
        int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while(a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }    
            }
            return a;
        }
        public PhanSo RutGon()
        {
            int ucln = UCLN(ts, ms);
            ts = ts / ucln;
            ms = ms / ucln;
            return this;
        }
        public static PhanSo operator+ (PhanSo p1, PhanSo p2)
        {
            PhanSo kqCTT = new PhanSo();
            kqCTT.ts = p1.ts * p2.ms + p2.ts * p1.ms;
            kqCTT.ms = p1.ms * p2.ms;
            return kqCTT;
        }
        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            PhanSo kqTTT = new PhanSo();
            kqTTT.ts = p1.ts * p2.ms - p2.ts * p1.ms;
            kqTTT.ms = p1.ms * p2.ms;
            return kqTTT;
        }
        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            PhanSo kqNTT = new PhanSo();
            kqNTT.ts = p1.ts * p2.ts;
            kqNTT.ms = p1.ms * p2.ms;
            return kqNTT;
        }
        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            PhanSo kqChTT = new PhanSo();
            kqChTT.ts = p1.ts * p2.ms;
            kqChTT.ms = p1.ms * p2.ts;
            return kqChTT;
        }
        public void Xuat()
        {
            if (ms == 1)
            {
                Console.WriteLine($"kết quả: {ts}");
            }
            else
                Console.WriteLine($"kết quả: {ts}/{ms}");
        }
    }
}
