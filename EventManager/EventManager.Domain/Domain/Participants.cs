using EventManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Domain
{
    public class Participants : BaseModel
    {
        public string Name { get; set; }
        public List<string> YearsOfExsistence { get; set; }
        public List<PlaceTags> PlaseTagsList { get; set; }
        public List<GenreTags> GenreTagsList { get; set; }
        public List<Event> EventsList { get; set; }

    }
}
