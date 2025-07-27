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
public class AddNumberContext(List<Product> products, Mock<IDependencyClass> dependencyMock, MockSetup mockSetup)
{
    public List<Product> Products { get; } = products;

    public Mock<IDependencyClass> DependencyMock { get; } = dependencyMock;

    public MethodsToTest MethodsToTest { get; } = new(dependencyMock.Object);

    public MockSetup MockSetup { get; } = mockSetup;
}
