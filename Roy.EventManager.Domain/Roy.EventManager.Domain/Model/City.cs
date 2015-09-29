using Roy.EventManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy.EventManager.Domain.Model
{
    class City: BaseModel
    {
        public string Name { set; get; }
        public List<UserGroup> UserGroupList { set; get; }
        public List<User> UserList { set; get; }
        public List<Event> EventList { set; get; }
        public string Plase { set; get; }
    }
}
