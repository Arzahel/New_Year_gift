using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace NewYearGift.Models
{
    [DataContract]
    public abstract class Candy
    {
        [DataMember]
        public decimal Weight { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public decimal SugarContent { get; set; }

        public Candy()
        {
            Name = "default";
            Weight = 0;
            Manufacturer = "default";
            SugarContent = 0;
        }

        public Candy (string name, decimal weight, double price, decimal sugarContent, string manufacturer)
        {
            Name = name;
            Weight = weight;
            Price = price;
            SugarContent = sugarContent;
            Manufacturer = manufacturer;
        }

        public abstract string GetFullInfo();

        public override string ToString()
        {
            return $"Name: {Name}" + '\n' +
                $"Weight: {Weight}" + '\n' +
                $"Price: {Price}" + '\n' +
                $"Sugar content: {SugarContent}" + '\n' +
                $"Manufacturer: {Manufacturer}" + '\n' +
                GetFullInfo();
        }

    }
}
