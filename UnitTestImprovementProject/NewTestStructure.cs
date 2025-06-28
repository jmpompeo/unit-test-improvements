using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit3;
using ClassToTest;
using Moq;
using Shouldly;

namespace UnitTestImprovementProject;

public class UnitTest1
{
    [Theory]
    [AutoMoqData]
    public void Add_Should_Return_Same_Sum(
       List<Product> products,
       [Frozen] Mock<IDependencyClass> dependencyClass,
       MethodsToTest methodsToTest)
    {
        SetupProductPriceMocks(products, dependencyClass);
        
        var sum = methodsToTest.Add(products);
        
        sum.ShouldBe(products[0].Price + products[1].Price + products[2].Price);
    }
    
    [Theory]
    [AutoMoqData]
    public void Subtract_Should_Return_Same_Difference(
        List<Product> products,
        [Frozen] Mock<IDependencyClass> dependencyClass,
        MethodsToTest methodsToTest)
    {
        SetupProductPriceMocks(products, dependencyClass);

        var sum = methodsToTest.Subtract(products);
        
        sum.ShouldBe(products[0].Price - products[1].Price - products[2].Price);
    }

    private static void SetupProductPriceMocks(List<Product> products, Mock<IDependencyClass> dependencyClass)
    {
        dependencyClass.Setup(x => x.GetPriceFromFirstProduct(products))
            .Returns(products[0].Price);
        dependencyClass.Setup(x => x.GetPriceFromSecondProduct(products))
            .Returns(products[1].Price);
        dependencyClass.Setup(x => x.GetPriceFromThirdProduct(products))
            .Returns(products[2].Price);
    }
}