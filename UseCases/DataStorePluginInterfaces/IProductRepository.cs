using DataAccessLibrary;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        //void AddProduct();
        void AddProduct(Product product);
    }
}
