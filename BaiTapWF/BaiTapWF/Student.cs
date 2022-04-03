using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWF
{
    internal class Student
    {
        private string id;
        private string name;
        private string pic;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Pic { get => pic; set => pic = value; }

        public Student(string id, string name, string pic)
        {
            this.id = id;
            this.name = name;
            this.pic = pic;
        }
    }
}