using CoreBusiness;

namespace UseCases.UseCaseInterfaces.ProductsInterfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}