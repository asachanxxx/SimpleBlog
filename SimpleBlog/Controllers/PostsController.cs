using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController:Controller
    {
        public ActionResult Index()
        {
            return Content("<h2>Hello World</h2><br>" + 
                            System.Reflection.MethodBase.GetCurrentMethod().ToString());
        }
    }
}