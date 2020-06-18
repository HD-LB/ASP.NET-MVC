using MK.ForumSystem.Data.Models;
using MK.ForumSystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK.ForumSystem.Services
{
    public class PostsService : IPostsService
    {
        private readonly IEfRepository<Post> postsRepo;

        public PostsService(IEfRepository<Post> postsRepo)
        {
            this.postsRepo = postsRepo;
        }

        public IQueryable<Post> GetAll()
        {
            return this.postsRepo.All;
        }
    }
}
