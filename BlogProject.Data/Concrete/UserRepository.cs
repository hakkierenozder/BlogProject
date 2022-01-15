using BlogProject.Data.Abstract;
using BlogProject.Shared.Data.Concrete.EntityFramework;
using BlogProject.Shared.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Concrete
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }
    }
}
