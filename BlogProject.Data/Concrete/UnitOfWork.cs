using BlogProject.Data.Abstract;
using BlogProject.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        private PostRepository _postRepository;
        private CommentRepository _commentRepository;
        private CategoryRepository _categoryRepository;
        private RoleRepository _roleRepository;
        private UserRepository _userRepository;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }

        public IPostRepository Posts => _postRepository ?? new PostRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new CategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new CommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new RoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new UserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
