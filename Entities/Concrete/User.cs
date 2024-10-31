using Entities.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserType { get; set; }
        public string UserDepartment { get; set; }
        public string UserPhoto { get; set; }
    }
}
