using ClassToTest;
using ClassToTest.Interfaces;
using ClassToTest.Models;
using Moq;

namespace UnitTestImprovementProject.Models;

public class AddNumberContext(List<Product> products, Mock<IDependencyClass> dependencyMock, MockSetup mockSetup)
{
    public List<Product> Products { get; } = products;

    public Mock<IDependencyClass> DependencyMock { get; } = dependencyMock;

    public MethodsToTest MethodsToTest { get; } = new(dependencyMock.Object);

    public MockSetup MockSetup { get; } = mockSetup;
}
