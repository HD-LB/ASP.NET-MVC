using MK.ForumSystem.Services;
using MK.ForumSystem.Web.Models.Home;
using System.Linq;
using System.Web.Mvc;

namespace MK.ForumSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostsService postsService;

        public HomeController(IPostsService postsService)
        {
            this.postsService = postsService;
        }
        public ActionResult Index()
        {
            var posts = this.postsService
                            .GetAll()
                            .Select(x => new PostViewModel()
                            {
                                Titel = x.Titel,
                                Content = x.Content,
                                AuthorEmail = x.Author.Email,
                                PostedOn = x.CreatedOn.Value
                            })
                            .ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}