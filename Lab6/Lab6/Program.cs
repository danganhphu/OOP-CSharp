using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab6
{
    internal class Program
    {
        private static void Bai6_1()
        {
            NSmartPhone nSmartPhone = new NSmartPhone();
            nSmartPhone.NhapDS();
            nSmartPhone.XuatDS();
            nSmartPhone.InTT();
            nSmartPhone.Them();
            nSmartPhone.DemVaIn();
            nSmartPhone.SapXep();
        }

        private static void Bai6_2()
        {
            NCircle nCircle = new NCircle();
            nCircle.XuatTT();
            nCircle.Xoa();
            nCircle.Dem();
        }

        private static void Bai6_3()
        {
            NXeVinfast nXeVinfast = new NXeVinfast();
            nXeVinfast.SapXep();
            nXeVinfast.InTT();
            nXeVinfast.XuatGiaLB();
        }

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Bai6_1();
            Bai6_2();
            //Bai6_3();

            Console.ReadKey();
        }
    }
}