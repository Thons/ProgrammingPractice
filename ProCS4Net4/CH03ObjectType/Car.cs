using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH03ObjectType
{
    class Car
    {
        private string description;
        private uint nWheels;

        public Car(string description, uint nWheels, string brand)
        {

        }

        public Car(string description, uint nWheels)
            : this(description, nWheels, brand: "Audi")
        {
            this.description = description;
            this.nWheels = nWheels;
        }

        public Car(string description)
            : this(description, nWheels: 4)
        {

        }
    }
}
