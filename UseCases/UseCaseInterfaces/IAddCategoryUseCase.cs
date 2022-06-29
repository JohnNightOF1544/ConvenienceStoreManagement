using DataAccessLibrary;

namespace UseCases.UseCaseInterfaces
{
    public interface IAddCategoryUseCase
    {
        void Execute(Category category);
    }
}