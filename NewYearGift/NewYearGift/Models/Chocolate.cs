using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using NewYearGift.Enums;

namespace NewYearGift.Models
{
    [DataContract]
    public class Chocolate : Candy
    {
        [DataMember]
        public decimal CacaoPercent { get; set; }
        [DataMember]
        public string Kind { get; set; }

        public Chocolate()
        {
            CacaoPercent = 0;
            Kind = "White";
        }

        public Chocolate(string name, decimal weight, double price, decimal sugarContent, string manufacturer, decimal cacaoPercent, ChocolateKinds kind)
            : base (name, weight, price, sugarContent, manufacturer)
        {
            CacaoPercent = cacaoPercent;
            Kind = kind.ToString();
        }

        public override string GetFullInfo()
        {
            return $"Cacao percent: {CacaoPercent}\n"
                + $"Kind of chocolate: {Kind.ToString()}";
        }
    }
}
