using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Corner
    {
        int gradus;
        int minute;
        int second;
        public bool isCorrect = true;
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    gradus = value % 360;

            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Gradus += value / 60;
                    minute = value % 60;
                }
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Minute += value / 60;
                    second = value % 60;
                }
            }
        }
        public Corner(int gradus, int minute, int second)
        {
            this.Gradus = gradus;
            this.Minute = minute;
            this.Second = second;
        }
        public double ToRadians()
        {
            return Math.PI / 180 * (gradus + (minute + second / 60) / 60);
        }
    }
}
