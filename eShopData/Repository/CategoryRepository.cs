using eShopData.DataContext;
using eShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopData.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EShopDbContext _dbcontext;
        public CategoryRepository(EShopDbContext eShopDbContext)
        {
            _dbcontext = eShopDbContext;
        }
        public object Add(Category category)
        {
            _dbcontext.Categories.Add(category);
            _dbcontext.SaveChanges();
            return "Category added succesfully";
        }

        public object Delete(int id)
        {
            _dbcontext.Categories.Remove(_dbcontext.Categories.Find(id));
            _dbcontext.SaveChanges();
            return "Category deleted succesfully";
        }

        public Category Get(int id)
        {
            return _dbcontext.Categories.Find(id);
        }

        public IList<Category> GetAll()
        {
            return _dbcontext.Categories.ToList();
        }

        public object Update(Category category)
        {
            _dbcontext.Categories.Update(category);
            _dbcontext.SaveChanges();
            return "Category updated succesfully";
        }
    }
}
