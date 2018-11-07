using NewYearGift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Models
{
    public static class CandyFilters
    {
        //filter returns all candies in list with given manufacturer names
        public static IEnumerable<Candy> ManufacturerFilter(List<Candy> candyList, params string[] manufacturers)
        {
            foreach (var candy in candyList)
            {
                for (int i = 0; i < manufacturers.Length; i++)
                {
                    if (candy.Manufacturer == manufacturers[i]) {
                        yield return candy;
                        break;
                    }
                }
            }
        }

        //return all candies in the list within following price range
        public static List<Candy> PriceFilter(List<Candy> candies, double min, double max)
        {
            return candies.Where(x => x.Price >= min && x.Price < max).ToList();
        }

        //return all candies in the list within following weight range
        public static List<Candy> WeightFilter(List<Candy> candies, decimal min, decimal max)
        {
            return candies.Where(x => x.Weight >= min && x.Weight < max).ToList();
        }

        //return all candies in the list within following sugar range
        public static List<Candy> SugarFilter(List<Candy> candies, decimal min, decimal max)
        {
            return candies.Where(x => x.Weight >= min && x.Weight < max).ToList();
        }
    }
}
