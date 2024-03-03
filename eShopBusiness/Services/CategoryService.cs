using eShopData.Repository;
using eShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopBusiness.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public object Add(Category category)
        {
            return _categoryRepository.Add(category);
        }

        public object Delete(int id)
        {
            return _categoryRepository.Delete(id);
        }

        public Category Get(int id)
        {
            return _categoryRepository.Get(id);
        }

        public IList<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public object Update(Category category)
        {
            return _categoryRepository.Update(category);
        }
    }
}
