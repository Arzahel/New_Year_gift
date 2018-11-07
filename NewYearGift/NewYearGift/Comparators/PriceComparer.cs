using NewYearGift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Comparators
{
    class PriceComparer<T> : IComparer<T> where T : Candy
    {
        public int Compare(T x, T y)
        {
            if (x.Price > y.Price)
                return 1;
            else if (x.Price < y.Price)
                return -1;
            else
                return 0;
        }
    }
}
