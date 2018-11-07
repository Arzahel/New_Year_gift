using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewYearGift.Models
{
    [XmlInclude(typeof(Marshmallow))]
    [XmlInclude(typeof(Chocolate))]
    [XmlInclude(typeof(Sweet))]
    [KnownType(typeof(Marshmallow))]
    [KnownType(typeof(Chocolate))]
    [KnownType(typeof(Sweet))]
    [DataContract]
    public class Gift
    {
        [DataMember]
        public string Name { get; set; }
        
        public decimal Weight { get { return Candies.Sum(x => x.Weight); } }
        [DataMember]
        public List<Candy> Candies { get; set; }

        ///////Methods///////

        public Gift()
        {
            Name = "default";
            Candies = new List<Candy>();
        }

        public Gift (string name, List<Candy> candies)
        {
            Name = name;
            Candies = candies;
        }

        public void Add (Candy candy)
        {
            Candies.Add(candy);
        }

        public bool Remove (Candy candy)
        {
            return Candies.Remove(candy);
        }
    }
}
