using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH04Inherit
{
    class MyAbsDerivedClass:MyAbstructClass
    {
        static void Main(string[ ] args)
        {
            MyAbsDerivedClass ad = new MyAbsDerivedClass();
            Console.WriteLine(ad.AbstructMethod());
        }

        public override string AbstructMethod()
        {
            return "This is MyAbstructMethod class derived...";
        }
    }
}
