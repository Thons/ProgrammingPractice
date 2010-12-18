using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public class LinkedListNode
    {
        public object Value { get; private set; }

        public LinkedListNode(object value)
        {
            this.Value = value;
        }

        public LinkedListNode Next { get; internal set; }
        public LinkedListNode Prev { get; internal set; }
    }
}
