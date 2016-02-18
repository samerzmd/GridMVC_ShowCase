using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridMVC_ShowCase.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Foo> list=new List<Foo>();
            for (int i = 0; i < 100; i++)
            {
                Foo foo=new Foo {Title = "Title " + i,Description = "Description "+i };
                list.Add(foo);
            }
            return View(list);
        }
        public class Foo
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}