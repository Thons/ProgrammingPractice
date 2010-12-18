using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH04Inherit
{
    class MyDerivedClass:MyBaseClass
    {
        static void Main(string[ ] args)
        {
            MyBaseClass b = new MyBaseClass();
            MyDerivedClass d = new MyDerivedClass();
            Console.WriteLine(b.VirtualMethod());
            Console.WriteLine(b.NonVirtualMethod());
            Console.WriteLine(d.VirtualMethod());
            Console.WriteLine(d.NonVirtualMethod());
            Console.WriteLine(d.CalculatePrice());
        }

        public override string VirtualMethod()
        {
            return base.VirtualMethod();
        }

        public new string NonVirtualMethod()
        {
            return "This is a derived method...";
        }

        public override decimal CalculatePrice()
        {
            return base.CalculatePrice() * 0.9M;
        }
    }
}
