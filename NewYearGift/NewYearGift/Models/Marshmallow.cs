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
    public class Marshmallow : Candy
    {
        [DataMember]
        public string Type { get; set; }

        public Marshmallow()
        {
            Type = "White";
        }

        public Marshmallow(string name, decimal weight, double price, decimal sugarContent, string manufacturer, MarshmallowKinds type)
            : base(name, weight, price, sugarContent, manufacturer)
        {
            Type = type.ToString();
        }
        public override string GetFullInfo()
        {
            return $"Type: {Type.ToString()}\n";
        }
    }
}
