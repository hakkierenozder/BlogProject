using BlogProject.Shared.Data.Abstract;
using BlogProject.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
