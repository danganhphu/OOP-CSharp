using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic4
{
    class Student
    {
        string id, name;
        private float mark;

        //public float Mark { get => mark; set => mark = value; }
        public float Mark
        {
            get { return mark; }
            set
            {
                if (value > 0)
                    mark = value;
            }
        }
        //phương thức thiết lập không tham số
        public Student()
        {
            id = "61134177";
            name = "Đặng Anh Phú";
            mark = 7.8f;
        }
        
        //pthuc thiết lập có tso
        public Student(string i, string ten, float diem  = 5)
        {
            id = i;
            name = ten;
            mark = diem;
        }

        //phương thức thiết lập sao chép
        public Student (Student s)
        {
            id = s.id;
            name = s.name;
            mark = s.mark;
        }

        //phương thức truy nhập
        public float GetMark()
        {
            return Mark;
        }
        public void SetMark(float d)
        {
            Mark = d;
        }
        public void Set(string ms, string ten, float diem)
        {
            id = ms;
            name = ten;
            Mark = diem;
        }
        public void Info()
        {
            Console.Write($"{id}\t{name}\t\t{Mark}");
        }
        public bool CheckHB(float dhb)
        {
            if (Mark >= dhb)
                return true;
            else
                return false;
        }
    }
}