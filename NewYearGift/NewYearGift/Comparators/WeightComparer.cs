using NewYearGift.Models;
using System.Collections.Generic;

namespace NewYearGift.Comparators
{
    class WeightComparer<T> : IComparer<T> where T : Candy
    {
        public int Compare(T x, T y)
        {
            if (x.Weight > y.Weight)
                return 1;
            else if (x.Weight < y.Weight)
                return -1;
            else
                return 0;
        }
    }
}
