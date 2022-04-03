using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SinhVien
    {
        string mssv, hoten;
        byte sm;
        MonHoc[] ds;
        public SinhVien(string mssv = "", string hoten = "", byte sm = 0)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.sm = sm;
            ds = new MonHoc[sm];
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine($"Nhập vào môn học thứ {i + 1}");
                Console.Write("Nhập mã số môn học: ");
                string ms = Console.ReadLine();
                Console.Write("Nhập tên môn học: ");
                string ten = Console.ReadLine();
                Console.Write("Nhập đơn vị học trình: ");
                byte tc;
                while (byte.TryParse(Console.ReadLine(), out tc) == false || tc < 0)
                {
                    Console.Write("Nhập sai yêu cầu. Nhập lại: ");
                }
                float dkt;
                Console.Write("Nhập điểm kiểm tra: ");
                while (float.TryParse(Console.ReadLine(), out dkt) == false || dkt < 0 || dkt > 10)
                {
                    Console.Write("Nhập sai yêu cầu. Nhập lại: ");
                }    
                Console.Write("Nhập điểm thi: ");
                float dt;
                while (float.TryParse(Console.ReadLine(), out dt) == false || dt < 0 || dt > 10)
                {
                    Console.Write("Nhập sai yêu cầu. Nhập lại: ");
                }    
                ds[i] = new MonHoc(ms, ten, tc, dkt, dt);
                Console.Write(Environment.NewLine);
            }
        }
        public void NhapDSSV()
        {
            Console.Write("Nhập mã số sinh viên: ");
            mssv = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập số môn học (3 <= n <= 10): ");
            while (byte.TryParse(Console.ReadLine(), out sm) == false || sm < 3 || sm > 10)
            {
                Console.Write("Bạn nhập sai yêu cầu. Nhập lại: ");
            }
            ds = new MonHoc[sm];
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i] = new MonHoc();
                Console.Write(Environment.NewLine);
                Console.WriteLine($"Nhập vào môn học thứ {i + 1}");
                ds[i].NhapTT();
            }
            Console.Write(Environment.NewLine);
        }
        public float DTBHK()
        {
            byte tong = 0;
            float d = 0;
            foreach (MonHoc mh in ds)
            {
                tong += mh.Dvht;
                d += mh.DiemTB() * mh.Dvht;
            }
            return d / tong;
        }
        public float DTBTL()
        {
            byte tong = 0;
            float d = 0;

            foreach (MonHoc mh in ds)
            {
                if (mh.DiemTB() >= 5.5)
                {
                    tong += mh.Dvht;
                    d += mh.DiemTB() * mh.Dvht;
                }
            }
            return d / tong;
        }
        public bool KiemTraD()
        {

            foreach (MonHoc mh in ds)
                if (mh.Dthi >= 5.5 && mh.DiemTB() >= 5.5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            return true;
        }
        public void XetHB()
        {
            if (DTBHK() > 7 && KiemTraD() == true)
            {
                Console.WriteLine("Đủ điều kiện xét học bổng");
            }
            else
            {
                Console.WriteLine("Không đủ điều kiện xét học bổng");
            }
        }
        public void XuatTTSV()
        {
            Console.Write($"Mã số sv: {mssv}\tHọ tên: {hoten}");
            Console.Write(Environment.NewLine);
            foreach (MonHoc mh in ds)
            {
                mh.XuatTT();
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine($"Điểm TB học kỳ: {DTBHK()}");
            Console.WriteLine($"Điểm TB tích lũy: {DTBTL()}");
        }
    }
}
