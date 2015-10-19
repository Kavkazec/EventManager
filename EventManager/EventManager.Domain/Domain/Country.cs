using EventManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{

    public class Country : BaseModel
    {
        public string CountryName { set; get; }
        public List<City> CityList { set; get; }
    }
}
