using Roy.EventManager.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy.EventManager.Domain.Model
{
    class News: BaseModel
    {
        public string New { set; get; }
        public List<Event> EventList { set; get; }
    }
}
