using AutoFixture.Xunit3;
using ClassToTest;
using ClassToTest.Interfaces;
using ClassToTest.Models;
using Moq;

namespace UnitTestImprovementProject.Models;

public record AddNumberContext(
    List<Product> Products,
    [Frozen] Mock<IDependencyClass> DependencyMock,
    MethodsToTest MethodsToTest,
    MockSetup MockSetup);