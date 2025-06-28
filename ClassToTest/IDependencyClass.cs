namespace ClassToTest;

public interface IDependencyClass
{
    int GetPriceFromFirstProduct(List<Product> products);
    int GetPriceFromSecondProduct(List<Product> products);
    int GetPriceFromThirdProduct(List<Product> products);
}