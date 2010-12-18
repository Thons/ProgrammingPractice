using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CH05Generics
{
    public class LinkedList : IEnumerable
    {
        public LinkedListNode First { get; private set; }
        public LinkedListNode Last { get; private set; }

        public LinkedListNode AddLast(object node)
        {
            var newNode = new LinkedListNode(node);
            if (First == null)
            {
                First = newNode;
                newNode.Prev = Last;
                Last = First;
            }
            else
            {
                LinkedListNode prev = Last;
                Last.Next = newNode;
                Last = newNode;
                Last.Prev = prev;
            }
            return newNode;
        }

        public IEnumerator GetEnumerator()
        {
            LinkedListNode current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
