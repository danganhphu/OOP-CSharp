using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Time
    {
        int hour, minute, second;
        //public Time()
        //{
        //    hour = 0;
        //    minute = 0;
        //    second = 0;
        //}
        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }

        public Time NetxSecond(Time tgNext)
        {
            //Time tgNext = new Time(12, 14, 16);
            tgNext.second = second + 1;
            tgNext.minute = minute;
            tgNext.hour = hour;
            //tgNext.second = second;
            if (tgNext.hour < 24 && tgNext.minute < 60 && tgNext.second >= 60)
            {
                if (tgNext.second < 60)
                {
                    return tgNext;
                }
                else
                if (tgNext.second == 60)
                {
                    tgNext.second = 0;
                    tgNext.minute += 1;
                    if (tgNext.minute == 60)
                    {
                        tgNext.minute = 0;
                        tgNext.hour += 1;
                        if (tgNext.hour == 24 )
                        {
                            tgNext.hour = 0;
                        }    
                    }
                }
            }
            return tgNext;
        }
        public void PreviousSecond()
        {
            if (hour < 24 && minute < 60 && second < 60)
            {
                if (second - 1 >= 0)
                {
                    second -= 1;
                }
                else if (second - 1 < 0)
                {
                    second = 59;
                    minute -= 1;
                    if (minute < 0)
                    {
                        minute = 59;
                        hour -= 1;
                        if (hour < 0)
                        {
                            hour = 23;
                        }
                    }
                }
            }
        }
        public void Show()
        {
            Console.Write($"{hour}:{minute}:{second}");
        }    
    }
}
