using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit3;

namespace UnitTestImprovementProject.Attributes;

public class AutoMoqData() : AutoDataAttribute(() =>
{
    var fixture = new Fixture()
        .Customize(new AutoMoqCustomization());

    fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(b => fixture.Behaviors.Remove(b));
    fixture.Behaviors.Add(new OmitOnRecursionBehavior());

    return fixture;
});