namespace ClassToTest;

public class MethodsToTest(IDependencyClass dependencyClass) : IMethodsToTest
{
    private readonly IDependencyClass _dependencyClass = dependencyClass;

    public int Add(List<Product> products)
    {
        var firstPrice = _dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = _dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = _dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice + secondPrice + thirdPrice;
    }
    
    public int Subtract(List<Product> products)
    {
        var firstPrice = _dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = _dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = _dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice - secondPrice - thirdPrice;
    }
    
    public int Multiply(List<Product> products)
    {
        var firstPrice = _dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = _dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = _dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice * secondPrice * thirdPrice;
    }
    
    public double Divide(List<Product> products)
    {
        var firstPrice = _dependencyClass.GetPriceFromFirstProduct(products);
        var secondPrice = _dependencyClass.GetPriceFromSecondProduct(products);
        var thirdPrice = _dependencyClass.GetPriceFromThirdProduct(products);
        
        return firstPrice / secondPrice / thirdPrice;
    }
}