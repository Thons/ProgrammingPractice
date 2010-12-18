using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH07OperatorsTypeCast
{
    struct Vector
    {
        public double x, y, z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(Vector rhs)
        {
            x = rhs.x;
            y = rhs.y;
            z = rhs.z;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }

        public static Vector operator +(Vector lhs, Vector rhs)
        {
            Vector result = new Vector(lhs);
            result.x += rhs.x;
            result.y += rhs.y;
            result.z += rhs.z;

            return result;
        }

        public static Vector operator -(Vector lhs, Vector rhs)
        {
            Vector result = new Vector(lhs);
            result.x -= rhs.x;
            result.y -= rhs.y;
            result.z -= rhs.z;

            return result;
        }

        public static Vector operator *(double lhs, Vector rhs)
        {
            return new Vector(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }

        public static Vector operator *(Vector lhs, double rhs)
        {
            return rhs * lhs;
        }

        public static double operator *(Vector lhs, Vector rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }

        public static bool operator ==(Vector lhs, Vector rhs)
        {
            if (lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z)
                return true;
            else
                return false;
        }

        public static bool operator !=(Vector lhs, Vector rhs)
        {
            return !(lhs == rhs);
        }
    }
}
