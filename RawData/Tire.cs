using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public int tireAge;
        public double tirePressure;

        public Tire(int tireAge, double tirePressure)
        {
            this.tirePressure = tirePressure;
            this.tireAge = tireAge;
        }
    }
}
