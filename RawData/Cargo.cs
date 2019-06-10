using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public int cargoWeight;
        public string cargoType;


        public Cargo (int cargoWieght, string cargoType)
        {
            this.cargoWeight = cargoWieght;
            this.cargoType = cargoType;
        }
    }
}
