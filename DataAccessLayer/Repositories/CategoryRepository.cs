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
    public class CategoryRepository : ICategoryDal
    {
        Context con = new Context();
        public void AddCategory(Category category)
        {
            con.Add(category);
            con.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            con.Remove(category);
            con.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return con.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return con.Categories.Find(id);
        }

        public void UpdateCategory(Category category)
        {
            con.Update(category);
            con.SaveChanges();
        }
    }
}
