using DataAccessLibrary;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}