using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.Models.Comparers
{
    public class GenreComparer : IEqualityComparer<Genre>
    {
        public bool Equals(Genre x, Genre y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Genre obj)
        {
            return obj.GetHashCode();
        }
    }
}
