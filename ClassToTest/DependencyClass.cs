using ClassToTest.Interfaces;
using ClassToTest.Models;

namespace ClassToTest;

public class DependencyClass : IDependencyClass
{
    public int GetPriceFromFirstProduct(List<Product> products)
    {
        return products[0].Price;
    }
    
    public int GetPriceFromSecondProduct(List<Product> products)
    {
        return products[1].Price;
    }
    
    public int GetPriceFromThirdProduct(List<Product> products)
    {
        return products[2].Price;
    }
}