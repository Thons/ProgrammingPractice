using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH06Array
{
    class MusicTitles
    {
        string[ ] names = { "Tubular Bells", "Hergest Ridge", "Ommadawn" };

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return names[i];
            }
        }

        public IEnumerable<string> Reverse()
        {
            for (int i = 2; i >= 0; i--)
            {
                yield return names[i];
            }
        }

        public IEnumerable<string> Subset(int index, int length)
        {
            for (int i = index; i < index + length; i++)
            {
                yield return names[i];
            }
        }
    }
}
