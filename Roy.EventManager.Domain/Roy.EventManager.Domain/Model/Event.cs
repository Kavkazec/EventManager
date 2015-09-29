using Roy.EventManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy.EventManager.Domain.Model
{
    class Event: BaseModel
    {
        public Country Country { get; set; }
        public City City { get; set; }
        public City Place { get; set; }
        public List<GenreTags> GenreTags { get; set; }
        public List<PlaceTags> PlaceTags { get; set; }
        public List<Participants> Participants { get; set; }
        public List<User> Users { get; set; }
        public DateTime date { get; set; }
    }
}
