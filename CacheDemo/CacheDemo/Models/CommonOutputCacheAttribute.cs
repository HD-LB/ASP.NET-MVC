using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CacheDemo.Models
{
    public class CommonOutputCacheAttribute : OutputCacheAttribute
    {
        public CommonOutputCacheAttribute()
        {
            this.Duration = 10;
            this.VaryByParam = "none";
        }
    }
}