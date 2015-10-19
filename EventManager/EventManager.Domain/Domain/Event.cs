using EventManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Domain
{
    public class Event : BaseModel
    {
        public Country Country { get; set; }
        public City City { get; set; }
        public List<City> PlaceTags { get; set; }
        public List<GenreTags> GenreTags { get; set; }
        public List<Participants> Participants { get; set; }
        public List<User> Users { get; set; }
        public DateTime date { get; set; }
    }
}
