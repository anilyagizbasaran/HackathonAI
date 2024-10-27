using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepository<User, NorthwindContext>, IUserDal
    {
    }
}
