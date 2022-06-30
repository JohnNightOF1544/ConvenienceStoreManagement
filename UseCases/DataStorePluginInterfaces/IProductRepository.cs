using DataAccessLibrary;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Execute();
    }
}
