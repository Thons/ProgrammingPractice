using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public struct Nullable<T>
        where T : struct
    {
        private bool hasValue;
        public bool HasValue
        {
            get { return hasValue; }
        }

        private T value;
        public T Value
        {
            get
            {
                if (!hasValue)
                    throw new InvalidOperationException("no value");
                return value;
            }
        }

        public Nullable(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        public static explicit operator T(Nullable<T> value)
        {
            return value.Value;
        }

        public static implicit operator Nullable<T>(T value)
        {
            return new Nullable<T>(value);
        }

        public override string ToString()
        {
            if (!HasValue)
                return String.Empty;
            return this.value.ToString();
        }
    }
}
