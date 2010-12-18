using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH04Inherit
{
    class MyBaseClass
    {
        public virtual string VirtualMethod()
        {
            return "This is a virtual method...";
        }

        public string NonVirtualMethod()
        {
            return "This is not a virtual method...";
        }

        public virtual decimal CalculatePrice()
        {
            return 10.0M;
        }
    }
}
