using Roy.EventManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy.EventManager.Domain.Model
{
    class UserGroup: BaseModel
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
