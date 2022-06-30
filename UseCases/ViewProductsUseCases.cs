using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class ViewProductsUseCases : IViewProductsUseCases
    {
        private readonly IProductRepository _productRepository;

        public ViewProductsUseCases(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return _productRepository.GetProducts();
        }
    }
}
