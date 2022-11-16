using CoreBusiness;

namespace UseCases.UseCaseInterfaces.ProductsInterfaces
{
    public interface IAddProductUseCase
    {
        void Execute(Product product);
    }
}