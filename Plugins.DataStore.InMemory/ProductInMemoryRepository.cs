using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductInMemoryRepository()
        {
            _products = new List<Product>()
            {
                new Product { ProductId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99},
                new Product { ProductId = 1, Name = "Canada Dry", Quantity = 200, Price = 1.99},
                new Product { ProductId = 1, Name = "Whole Wheat Bread", Quantity = 300, Price = 1.50},
                new Product { ProductId = 1, Name = "White Bread", Quantity = 400, Price = 1.50},
            };
        }

        public void AddProduct(Product product)
        {
            if (_products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (_products != null && _products.Count > 0)
            {
                var maxId = _products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            _products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

    }
}
