using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public class RectangleCollection : IIndex<Rectangle>
    {
        private Rectangle[ ] data = new Rectangle[3]
        {
            new Rectangle {Height=2,Width=5},
            new Rectangle {Height=3,Width=7},
            new Rectangle {Height=4,Width=8}
        };

        public static RectangleCollection GetCollections()
        {
            return new RectangleCollection();
        }

        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index > data.Length)
                    throw new ArgumentOutOfRangeException("index");
                return data[index];
            }
        }

        public int Count
        {
            get { return data.Length; }
        }
    }
}
