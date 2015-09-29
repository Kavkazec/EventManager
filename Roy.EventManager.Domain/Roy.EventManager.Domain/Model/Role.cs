using Roy.EventManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy.EventManager.Domain.Model
{
    class Role:BaseModel
    {
        public bool isUser { get; set; }
        public bool isAdmin { get; set; }
        public bool isArtist { get; set; }
    }
}
