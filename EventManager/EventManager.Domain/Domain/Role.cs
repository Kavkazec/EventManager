using EventManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Domain
{
    public class Role : BaseModel
    {
        public string RoleName { get; set; }
    }
}
