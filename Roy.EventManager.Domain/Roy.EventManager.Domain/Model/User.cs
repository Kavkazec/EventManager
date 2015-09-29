using Roy.EventManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy.EventManager.Domain.Model
{
    class User: BaseModel
    {
        public string NickName { get; set; }

        public string Info { get; set; }

        public int Age { get; set; }

        public List<string> YearsOfExsistence { get; set; }

        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }
        public List<GenreTags> GenreTags { get; set; }
        public List<PlaceTags> PlaceTags { get; set; }

        public List<UserGroup> UserGroups { get; set; }
    }
}
