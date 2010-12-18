using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public class ShapeDisplay : IDisplay<Shape>
    {
        public void Show(Shape item)
        {
            Console.WriteLine("{0} Width: {1}, Height: {2}", item.GetType().Name, item.Width, item.Height);
        }
    }
}
