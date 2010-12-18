using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CH06Array
{
    class HelloCollection
    {
        public IEnumerator GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }

        public class Enumerator : IEnumerator<string>, IEnumerator, IDisposable
        {
            private int state;
            private string current;

            public Enumerator(int state)
            {
                this.state = state;
            }

            public void Dispose() { }

            public object Current
            {
                get { throw new NotImplementedException(); }
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            object IEnumerator.Current
            {
                get { return current; }
            }

            string IEnumerator<string>.Current
            {
                get { return current; }
            }
        }

    }
}
