using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MK.ForumSystem.Web.Models.Home
{
    public class PostViewModel
    {
        public string Titel { get; set; }

        public string Content { get; set; }

        public string AuthorEmail { get; set; }

        public DateTime PostedOn { get; set; }
    }
}