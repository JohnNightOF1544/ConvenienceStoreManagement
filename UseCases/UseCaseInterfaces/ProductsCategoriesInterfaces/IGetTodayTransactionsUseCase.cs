using System.Transactions;

namespace UseCases.UseCaseInterfaces.ProductsCateoriesInterfaces
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}