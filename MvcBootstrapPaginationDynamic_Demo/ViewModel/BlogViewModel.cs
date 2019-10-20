using MvcBootstrapPaginationDynamic_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcBootstrapPaginationDynamic_Demo.ViewModel
{
    public class BlogViewModel
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public int BlogPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Blogs.Count() / (double)BlogPerPage));
        }
        public IEnumerable<Blog> PaginatedBlogs()
        {
            int start = (CurrentPage - 1) * BlogPerPage;
            return Blogs.OrderBy(b=>b.Id).Skip(start).Take(BlogPerPage);
        }
    }
}