using ClassToTest.Models;

namespace ClassToTest.Interfaces;

public interface IDependencyClass
{
    int GetPriceFromFirstProduct(List<Product> products);
    int GetPriceFromSecondProduct(List<Product> products);
    int GetPriceFromThirdProduct(List<Product> products);
}