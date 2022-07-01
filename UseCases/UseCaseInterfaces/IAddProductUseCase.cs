using DataAccessLibrary;

namespace UseCases.UseCaseInterfaces
{
    public interface IAddProductUseCase
    {
        void Execute(Product product);
    }
}