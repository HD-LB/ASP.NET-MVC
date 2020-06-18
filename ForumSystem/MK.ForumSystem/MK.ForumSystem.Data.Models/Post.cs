using MK.ForumSystem.Data.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK.ForumSystem.Data.Models
{
    public class Post : DataModel
    {
        public string Titel { get; set; }

        public string Content { get; set; }

        public virtual User Author { get; set; }
    }
}
