using CoreBusiness;
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
        private readonly List<Product> _products;

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

            if (_products is not null && _products.Count > 0)
            {
                var maxId = _products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }

            if (_products is null)
            {
                product.ProductId = 1;
            }

            _products.Add(product);

        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.ProductId = product.ProductId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }

        public Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void DeleteProduct(int productId)
        {
            //var productToDelete = GetProductById(productId);
            //if (productToDelete != null) _products.Remove(productToDelete);

            _products.Remove(GetProductById(productId));
        }

        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId);
        }
    }
}
