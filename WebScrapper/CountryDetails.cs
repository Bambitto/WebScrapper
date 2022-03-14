using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapper
{
    public class CountryDetails
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public IEnumerable<CityModel> Cities { get; set; }
    }
}
