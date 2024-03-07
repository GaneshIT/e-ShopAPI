using eShopData.DataContext;
using eShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopData.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly EShopDbContext _dbcontext;
        public ProductRepository(EShopDbContext eShopDbContext)
        {
            _dbcontext = eShopDbContext;
        }
        public object Add(Product product)
        {
            _dbcontext.products.Add(product);
            _dbcontext.SaveChanges();
            return "Product added succesfully";
        }

        public object Delete(int id)
        {
            _dbcontext.products.Remove(_dbcontext.products.Find(id));
            _dbcontext.SaveChanges();
            return "Product deleted succesfully";
        }

        public Product Get(int id)
        {
            return _dbcontext.products.Find(id);
        }

        public IList<Product> GetAll()
        {
            return _dbcontext.products.ToList();
        }

        public object Update(Product product)
        {
            _dbcontext.products.Update(product);
            _dbcontext.SaveChanges();
            return "Product updated succesfully";
        }
    }
}
