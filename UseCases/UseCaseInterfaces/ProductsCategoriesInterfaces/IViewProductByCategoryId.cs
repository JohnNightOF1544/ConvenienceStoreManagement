using CoreBusiness;

namespace UseCases.UseCaseInterfaces.ProductsCateoriesInterfaces
{
    public interface IViewProductByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}