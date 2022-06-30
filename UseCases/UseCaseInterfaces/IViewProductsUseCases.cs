using DataAccessLibrary;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductsUseCases
    {
        IEnumerable<Product> Execute();
    }
}