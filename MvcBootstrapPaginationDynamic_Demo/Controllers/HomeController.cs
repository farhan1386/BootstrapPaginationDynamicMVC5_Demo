using MvcBootstrapPaginationDynamic_Demo.Models;
using MvcBootstrapPaginationDynamic_Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootstrapPaginationDynamic_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcDemoContext db = new MvcDemoContext();

        public ActionResult Index(int page=1)
        {
            var blogsView = new BlogViewModel
            {
                BlogPerPage = 5,
                Blogs = db.Blogs.OrderBy(d=>d.Date),
                CurrentPage = page
            };
            return View(blogsView);
        }
    }
}