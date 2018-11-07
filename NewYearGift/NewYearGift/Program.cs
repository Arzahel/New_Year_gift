using NewYearGift.Comparators;
using NewYearGift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NewYearGift.AppData;

namespace NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy bestChoko = new Chocolate("Ritter Sport with coconut", 100, 3.44, 30, "Ritter Sport", 36, Enums.ChocolateKinds.Milk);
            Candy zefir = new Marshmallow("Domashniy", 230, 2.77, 50, "AirSweet", Enums.MarshmallowKinds.Pink);

            Gift gift = new Gift("Christmas Gift", new List<Candy>());
            gift.Add(bestChoko);
            gift.Add(zefir);

            Console.WriteLine("Gift weight: " + gift.Weight +"g\r\n");

            var filtered = CandyFilters.WeightFilter(gift.Candies, 100, 300);
            filtered = CandyFilters.PriceFilter(filtered, 3, 4);

            Console.WriteLine("Filtered values:\r\n");

            foreach (var item in filtered)
                Console.WriteLine(item + "\r\n");

            gift.Candies.Sort(new PriceComparer<Candy>());

            Console.WriteLine("Sorted values:\r\n");

            foreach (var item in gift.Candies)
                Console.WriteLine(item + "\r\n");

            DataManager manage = new DataManager();

            manage.SaveJson(ref gift, "newgift.json");

            Console.Read();
        }
    }
}
