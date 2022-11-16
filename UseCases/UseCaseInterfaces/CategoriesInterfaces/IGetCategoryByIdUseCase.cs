using CoreBusiness;

namespace UseCases.UseCaseInterfaces.CategoriesInterfaces
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int categoryId);
    }
}