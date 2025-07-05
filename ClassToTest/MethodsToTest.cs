using ClassToTest.Interfaces;
using ClassToTest.Models;

namespace ClassToTest;

public class MethodsToTest(IDependencyClass dependencyClass) : IMethodsToTest
{
    public int Add(List<Product> products)
    {
        var firstPrice = dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice + secondPrice + thirdPrice;
    }
    
    public int Subtract(List<Product> products)
    {
        var firstPrice = dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice - secondPrice - thirdPrice;
    }
    
    public int Multiply(List<Product> products)
    {
        var firstPrice = dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice * secondPrice * thirdPrice;
    }
    
    public double Divide(List<Product> products)
    {
        var firstPrice = dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice / secondPrice / thirdPrice;
    }
}