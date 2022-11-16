using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class TransactionInMemoryRepository : ITransactionRepository
    {
        private List<Transaction> _transactions;
        public TransactionInMemoryRepository()
        {
            _transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> Get(string cashierName)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return _transactions;
            else
                return _transactions.Where(x => string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return _transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return _transactions.Where(x => 
                    string.Equals(x.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                    x.TimeStamp.Date == date.Date);
        }

        public void Save(string cashierName, int productId, double price, int beforeQty, int soldQty)
        {
            int transactionId = 0;
            if (_transactions != null && _transactions.Count > 0)
            {
                int maxId = _transactions.Max(x => x.TransactionId);
                transactionId = maxId + 1;
            }
            else
            {
                transactionId = 1;
            }

            _transactions.Add(new Transaction
            {
                ProductId = productId,
                TimeStamp = DateTime.Now,
                Price = price,
                BeforeQty = beforeQty,
                SoldQty = soldQty,
                CashierName = cashierName,
            });
        }

        IEnumerable<System.Transactions.Transaction> ITransactionRepository.Get(string cashierName)
        {
            throw new NotImplementedException();
        }

        IEnumerable<System.Transactions.Transaction> ITransactionRepository.GetByDay(string cashierName, DateTime date)
        {
            throw new NotImplementedException();
        }


    }
}
