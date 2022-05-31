using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWinForm
{
    public class Props
    {
        public Props(string name, string country, int cost)
        {
            Name = name;
            Country = country;
            Cost = cost;
        }
        public Props()
        {

        }

        public Props(string prop)
        {
            string[] propList = prop.Split('~');
            Name = propList[0];
            Country = propList[1];
            Cost = Convert.ToInt32(propList[2]);
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public int Cost { get; set; }

        public override string ToString() => $"{Name} ~ {Country} ~ {Cost}";
    }
}
