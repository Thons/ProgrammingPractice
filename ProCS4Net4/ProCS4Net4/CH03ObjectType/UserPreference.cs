using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CH03ObjectType
{
    class UserPreference
    {
        public static readonly Color BackColor;

        static UserPreference()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                BackColor = Color.Red;
            else
                BackColor = Color.Green;
        }
    }
}
