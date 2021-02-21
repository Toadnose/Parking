using System;
using System.Xml.Schema;

namespace Parking
{
    public class Charges
    {
        public const double min_charge = 2.0;
        public const double additional = 0.5;
        public const double max_charge = 10;
        public const int max_time = 24;
        public double time;
        public string name;
        public double total;

        public double calculateCharges()
        {
            if (time < 0 || time > 24)
            {
                throw new ArgumentException("Too short or too long amount of time");
            }
            if (time <= 3)
            {
                return time * min_charge;
            }
            else
            {
                total = (min_charge + additional) * (time - 3) + 6;
            }

            if (total > max_charge || time == max_time)
            {
                total = max_charge;
            }

            return total;
        }
        public Charges (string _name, double _time)
        {
            time = _time;
            name = _name;
            total = calculateCharges();
        }
    }
}