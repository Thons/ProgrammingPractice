using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH06Array
{
    class Person : IEquatable<Person>
    {
        public string ID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{2}, {0} {1}", FirstName, LastName, ID);
        }

        public bool Equals(Person other)
        {
            if (other == null) throw new ArgumentNullException("other");
            return this.ID == other.ID && this.FirstName == other.FirstName && this.LastName == other.LastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            return Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
