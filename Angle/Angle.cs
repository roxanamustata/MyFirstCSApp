using System;
using System.Diagnostics.CodeAnalysis;

namespace Angle
{
    public struct Angle:IEquatable<Angle>
    {

        
        public Angle(int degrees, int minutes, int seconds)
        {
            if (degrees < 360&&degrees>=0)
            {
                Degrees = degrees;
            }
            else
            {
                throw new ArgumentException("Value must be less than 360 and greater than 0");
            }
            if (minutes < 60&&minutes>=0)
            {
                Minutes = minutes;
            }
            else
            {
                throw new ArgumentException("Value must be less than 60 and greater than 0");
            }
            if (seconds < 60&&seconds>=0)
            {
                Seconds = seconds;
            }
            else
            {
                throw new ArgumentException("Value must be less than 60 and greater than 0");
            }
        }

        public int Degrees { get; private set; }
           

        public int Minutes { get; private set; }

        public int Seconds { get; private set; }

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
            return Degrees + "\x00B0" + Minutes + "'" + Seconds + "\"";
        }


        public bool Equals([AllowNull] Angle other)
        {
            
            if (Degrees ==other.Degrees && Minutes == other.Minutes && Seconds == other.Seconds)
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

