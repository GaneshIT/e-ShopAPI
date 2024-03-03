using eShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopData.Repository
{
    public interface ICategoryRepository
    {
        object Add(Category category);
        object Update(Category category);
        object Delete(int id);
        Category Get(int id);
        IList<Category> GetAll();
    }
}
