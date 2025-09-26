using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.MemoEdits.Tests;

[Collection("Collection")]
public sealed class MemoEditTests : FixturedUnitTest
{
    public MemoEditTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
