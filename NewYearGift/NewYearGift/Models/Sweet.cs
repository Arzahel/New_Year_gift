using NewYearGift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace NewYearGift.Models
{
    [DataContract]
    public class Sweet : Candy
    {
        [DataMember]
        public string Kind { get; set; }

        public Sweet()
        {
            Kind = "Lolipop";
        }

        public Sweet(string name, decimal weight, double price, decimal sugarContent, string manufacturer, SweetKinds kind)
            : base(name, weight, price, sugarContent, manufacturer)
        {
            Kind = kind.ToString();
        }

        public override string GetFullInfo()
        {
            return $"Sweet kind: {Kind.ToString()}\n";
        }
    }
}
