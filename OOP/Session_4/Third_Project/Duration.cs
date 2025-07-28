using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int _Hours, int _Minutes, int _Seconds)
        {
            if (_Seconds > 60)
                _Minutes += _Seconds / 60;
            if (_Minutes > 60)
                _Hours += _Minutes / 60;

            Hours = _Hours;
            Minutes = _Minutes;
            Seconds = _Seconds;
        }
        public Duration(int Seconds)
        {
            Hours = Seconds / 3600;
            Minutes = Seconds / 60 - Hours * 60;
            Seconds = Seconds - (Hours * 3600 + Minutes * 60);
        }

        public override string ToString()
        {
            if (Hours == 0 && Minutes == 0)
                return $"Seconds : {Seconds}";
            if (Hours == 0)
                return $"Minutes : {Minutes} | Seconds : {Seconds}";

            return $"Hours : {Hours} | Minutes : {Minutes} | Seconds : {Seconds} ";
        }

        public override bool Equals(object? obj)
        {
            Duration duration = (Duration)obj!;

            return Hours == duration.Hours
                && Minutes == duration.Minutes
                && Seconds == duration.Seconds;
        }
        public override int GetHashCode()
        {
            return Hours.GetHashCode()
                ^ Minutes.GetHashCode()
                ^ Seconds.GetHashCode();
        }

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(left.Hours + right.Hours, left.Minutes + right.Minutes, left.Seconds + right.Seconds);
        }
        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration(left.Hours - right.Hours, left.Minutes - right.Minutes, left.Seconds - right.Seconds);
        }

        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes + 1, duration.Seconds);
        }

        public static Duration operator --(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes - 1, duration.Seconds);
        }

        public static bool operator >(Duration left, Duration right)
        {
            if (left.Hours > right.Hours)
                return true;
            if (left.Hours < right.Hours)
                return false;
            if (left.Minutes > right.Minutes)
                return true;
            if (left.Minutes < right.Minutes)
                return false;
            return left.Seconds > right.Seconds;
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours < right.Hours)
                return true;
            if (left.Hours > right.Hours)
                return false;
            if (left.Minutes < right.Minutes)
                return true;
            if (left.Minutes > right.Minutes)
                return false;
            return left.Seconds < right.Seconds;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            return left > right || left.Equals(right);
        }
        public static bool operator <=(Duration left, Duration right)
        {
            return left < right || left.Equals(right);



        }

        public static explicit operator bool(Duration d)
        {
            // Returns true if any of the fields are non-zero
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

        public static explicit operator DateTime(Duration d)
        {
        
            // Converts Duration to DateTime, assuming Duration represents a time span from midnight
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
    }
}
