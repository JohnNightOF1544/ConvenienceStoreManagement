namespace UseCases.UseCaseInterfaces.ProductsCateoriesInterfaces
{
    public interface IRecordTransactionUseCase
    {
        void Execute(string cashierName, int productId, int qty);
    }
}