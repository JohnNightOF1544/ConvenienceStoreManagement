using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ProductsCateoriesInterfaces;

namespace UseCases.ProductsUseCases
{
    public class ViewProductByCategoryId : IViewProductByCategoryId
    {
        private readonly IProductRepository _productRepository;

        public ViewProductByCategoryId(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> Execute(int categoryId)
        {
            return _productRepository.GetProductByCategoryId(categoryId);
        }
    }
}
