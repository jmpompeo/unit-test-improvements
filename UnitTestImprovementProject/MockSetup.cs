using ClassToTest.Interfaces;
using ClassToTest.Models;
using Moq;

namespace UnitTestImprovementProject;

public class MockSetup
{
    public void SetupProductPriceMocks(List<Product> products, Mock<IDependencyClass> dependencyClass)
    {
        dependencyClass.Setup(x => x.GetPriceFromFirstProduct(products))
            .Returns(products[0].Price);
        dependencyClass.Setup(x => x.GetPriceFromSecondProduct(products))
            .Returns(products[1].Price);
        dependencyClass.Setup(x => x.GetPriceFromThirdProduct(products))
            .Returns(products[2].Price);
    }
}