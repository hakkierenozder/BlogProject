using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Shared.Entities.Concrete
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime PublishedAt { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
