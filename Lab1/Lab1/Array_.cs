using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Array_
    {
        byte n;
        int[] arr;
        #region Nhập mảng
        public void InputArray()
        {
            //nhập n
            Console.Write("\nNhập số phần tử trong mảng ( 3 <= n <= 20): ");
            while (byte.TryParse(Console.ReadLine(), out n) == false || n < 3 || n > 20)
            {
                Console.Write("Bạn nhập sai yêu cầu. Vui lòng nhập lại: ");
            }
            Console.Write(Environment.NewLine);
            arr = new int[n];
            //nhập value
            for (int i = 0; i < n; i++)
            {
                Console.Write($"   arr[{i}]= ");
                while (Int32.TryParse(Console.ReadLine(), out arr[i]) == false)
                {
                    Console.WriteLine("Nhập sai định dạng. Vui lòng nhập lại.");
                    Console.Write(Environment.NewLine);
                    Console.Write($"   arr[{i}]= ");
                }
            }
        }
        #endregion

        #region Xuất mảng
        public void OutputArray()
        {
            Console.Write(Environment.NewLine);
            Console.Write("Mảng vừa nhập là: ");
            foreach (var item in arr)
            {
                Console.Write($"\t {item}");
            }
        }
        #endregion

        #region tổng các phần tử có giá trị dương nằm ở vị trí lẻ
        public void TongLeDuong()
        {
            long total = 0;

            for (int i = 1; i < n; i += 2)
            {
                if (arr[i] > 0)
                {
                    total += arr[i];
                }
            }
            Console.Write($"\nTổng các phần tử có giá trị dương nằm ở vị trí lẻ trong mảng là: {total}");
        }
        #endregion
    }
}
