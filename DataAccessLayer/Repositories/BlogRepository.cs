using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var con = new Context();
            con.Add(blog);
            con.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var con = new Context();
            con.Remove(blog);
            con.SaveChanges();
        }

        public Blog GetBlogById(int id)
        {
            using var con = new Context();
            return con.Blogs.Find(id);
        }

        public List<Blog> GetBlogs()
        {
            using var con = new Context();
            return con.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var con = new Context();
            con.Update(blog);
            con.SaveChanges();
        }
    }
}
