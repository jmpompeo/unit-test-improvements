using ClassToTest;
using ClassToTest.Interfaces;
using ClassToTest.Models;
using Moq;

namespace UnitTestImprovementProject.Models;

/// <summary>
/// Helper context that wires up a <see cref="MethodsToTest"/> instance with a
/// pre-created <see cref="Mock{IDependencyClass}"/> so the same mock can be
/// configured and used by the tests.
/// </summary>
public class AddNumberContext
{
    public AddNumberContext(List<Product> products, Mock<IDependencyClass> dependencyMock, MockSetup mockSetup)
    {
        Products = products;
        DependencyMock = dependencyMock;
        MockSetup = mockSetup;
        MethodsToTest = new MethodsToTest(dependencyMock.Object);
    }

    public List<Product> Products { get; }

    public Mock<IDependencyClass> DependencyMock { get; }

    public MethodsToTest MethodsToTest { get; }

    public MockSetup MockSetup { get; }
}
