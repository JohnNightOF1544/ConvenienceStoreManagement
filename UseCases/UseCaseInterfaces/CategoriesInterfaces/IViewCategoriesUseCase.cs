using CoreBusiness;

namespace UseCases.UseCaseInterfaces.CategoriesInterfaces
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}