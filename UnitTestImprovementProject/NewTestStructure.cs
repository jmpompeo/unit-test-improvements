using Shouldly;
using UnitTestImprovementProject.Attributes;
using UnitTestImprovementProject.Models;

namespace UnitTestImprovementProject;

public class UnitTest1
{
    [Theory]
    [AutoMoqData]
    public void Add_Should_Return_Same_Sum(AddNumberContext context)
    {
        context.MockSetup.SetupProductPriceMocks(
            context.Products,
            context.DependencyMock);
        
        var sum = context.MethodsToTest.Add(context.Products);
        
        sum.ShouldBe(context.Products[0].Price + context.Products[1].Price + context.Products[2].Price);
    }
    
    [Theory]
    [AutoMoqData]
    public void Subtract_Should_Return_Same_Difference(AddNumberContext context)
    {
        context.MockSetup.SetupProductPriceMocks(context.Products, context.DependencyMock);

        var sum = context.MethodsToTest.Subtract(context.Products);
        
        sum.ShouldBe(context.Products[0].Price - context.Products[1].Price - context.Products[2].Price);
    }
}