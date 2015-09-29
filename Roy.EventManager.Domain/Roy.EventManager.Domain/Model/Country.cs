using Roy.EventManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy.EventManager.Domain.Model
{
    class Country: BaseModel
    {
        public string CountryName { set; get; }
        public List<City> CityList { set; get; }
    }
}
