using Shouldly;
using SlowNCrunch.Fixtures;
using Xunit;

namespace SlowNCrunch
{
    public class Test
    {
        // [Scenario]
        [Fact]
        [MyAutoData]
        public void Test1()
        {
            true.ShouldBe(true);
        }
    }
}
