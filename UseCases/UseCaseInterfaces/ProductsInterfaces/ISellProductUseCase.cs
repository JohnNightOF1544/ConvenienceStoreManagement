namespace UseCases.UseCaseInterfaces.ProductsInterfaces
{
    public interface ISellProductUseCase
    {
        void Execute(string cashierName, int productId, int qtyToSell);
    }
}