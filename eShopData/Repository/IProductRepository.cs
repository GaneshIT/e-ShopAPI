using eShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopData.Repository
{
    public interface IProductRepository
    {
        object Add(Product product);
        object Update(Product product);
        object Delete(int id);
        Product Get(int id);
        IList<Product> GetAll();
    }
}
