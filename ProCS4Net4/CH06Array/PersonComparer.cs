using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH06Array
{
    public enum PersonCompareType
    {
        FirstName,
        LastName
    }

    class PersonComparer:IComparer<Person>
    {
        private PersonCompareType comparerType;

        public PersonComparer(PersonCompareType compareType)
        {
            this.comparerType = compareType;
        }

        public int Compare(Person x, Person y)
        {
            if (x == null) throw new ArgumentNullException("x");
            if (y == null) throw new ArgumentNullException("y");

            switch (comparerType)
            {
                case PersonCompareType.FirstName:
                    return x.FirstName.CompareTo(y.FirstName);
                case PersonCompareType.LastName:
                    return x.LastName.CompareTo(y.LastName);
                default:
                    throw new ArgumentException("unexcepted compare type...");
            }
        }
    }
}
