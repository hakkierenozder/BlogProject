using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IPostRepository Posts { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
        Task<int> SaveAsync();


    }
}
