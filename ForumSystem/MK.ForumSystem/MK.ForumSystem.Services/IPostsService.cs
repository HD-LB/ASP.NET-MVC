using System.Linq;
using MK.ForumSystem.Data.Models;

namespace MK.ForumSystem.Services
{
    public interface IPostsService
    {
        IQueryable<Post> GetAll();
    }
}