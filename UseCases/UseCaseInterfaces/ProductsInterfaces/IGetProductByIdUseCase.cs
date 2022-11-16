using CoreBusiness;

namespace UseCases.UseCaseInterfaces.ProductsInterfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}