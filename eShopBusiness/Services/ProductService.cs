using eShopData.Repository;
using eShopEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopBusiness.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public object Add(Product product)
        {
            return _productRepository.Add(product);
        }

        public object Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id);
        }

        public IList<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public object Update(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
