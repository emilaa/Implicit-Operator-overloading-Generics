using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit
{
    public class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double k)
        {
            Degree = k;
        }

        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree - 273);
        }
    }
}
