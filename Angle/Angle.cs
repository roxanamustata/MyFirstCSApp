using System;
using System.Collections.Generic;
using System.Text;

namespace Angle
{
    public struct Angle
    {

        private int degrees;
        private int minutes;
        private int seconds;


        public int Degrees
        {
            get { return degrees; }
            set
            {
                this.degrees = value;
            }

        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 60)
                {
                    this.minutes = value;
                }

            }

        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value < 60)
                {
                    this.seconds = value;
                }

            }

        }

        public static Angle operator +(Angle a, Angle b)
        {
            Angle result = new Angle
            {
                Seconds = (a.Seconds + b.Seconds) % 60,
                Minutes = (a.Minutes + b.Minutes + (a.Seconds + b.Seconds) / 60) % 60,
                Degrees = a.Degrees + b.Degrees + (a.Minutes + b.Minutes) / 60 + (a.Seconds + b.Seconds) / 3600
            };
            return result;
        }

        public static bool operator ==(Angle a, Angle b)
        {
            if (a.Degrees == b.Degrees && a.Minutes == b.Minutes && a.Seconds == b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool operator !=(Angle a, Angle b)
        {
            return !(a == b);

        }


        public override string ToString()
        {
            return this.Degrees + "\x00B0" + this.Minutes + "'" + this.Seconds + "\"";
        }


        public override bool Equals(object obj)
        {
            if (!(obj is Angle))
            {
                return false;
            }

            Angle angle = (Angle)obj;

            if (this.Degrees == angle.Degrees && this.Minutes == angle.Minutes && this.Seconds == angle.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

