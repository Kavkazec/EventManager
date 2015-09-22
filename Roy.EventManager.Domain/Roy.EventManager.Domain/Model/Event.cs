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
        public List<Tags> Tags { get; set; }
        public List<Participant> Participants { get; set; }
        public List<User> Users { get; set; }
        public DateTime date { get; set; }

    }
}
