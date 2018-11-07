using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearGift.Models;

namespace NewYearGift.Comparators
{
    class ManufacturerComparer<T> : IComparer<T> where T : Candy
    {
        public int Compare(T x, T y)
        {
           return x.Manufacturer.CompareTo(y.Manufacturer);
        }
    }
}
