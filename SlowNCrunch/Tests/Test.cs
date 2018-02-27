using AutoFixture.Xunit2;
using Shouldly;
using SlowNCrunch.Fixtures;
using Xunit;

namespace SlowNCrunch
{
    public class Test
    {
        [Fact]
        // [AutoData] // this works fine
        [MyAutoData]  // this is slow
        public void Test1()
        {
            true.ShouldBe(true);
        }
    }
}
