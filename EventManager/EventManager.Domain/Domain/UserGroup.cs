using EventManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Domain
{
    public class UserGroup : BaseModel
    {
        public string Name { get; set; }
        public Country Place { get; set; }
        public List<User> UserList { get; set; }
        public List<GenreTags> GenreTags { get; set; }
        public List<PlaceTags> PlaceTags { get; set; }
        public string Type { get; set; }
        public UserGroup()
        {
            this.UserList = new List<User>();
        }
    }
}
