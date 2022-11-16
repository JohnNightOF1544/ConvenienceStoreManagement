using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ProductsCateoriesInterfaces;

namespace UseCases.ProductsCategoriesUseCases
{
    public class GetTodayTransactionsUseCase : IGetTodayTransactionsUseCase
    {
        private readonly ITransactionRepository _transactionRepository;

        public GetTodayTransactionsUseCase(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public IEnumerable<System.Transactions.Transaction> Execute(string cashierName)
        {
            return _transactionRepository.GetByDay(cashierName, DateTime.Now);
        }
    }
}
