using Ploeh.AutoFixture.Xunit2;
using System;
using System.Threading;

namespace SlowNCrunch.Fixtures
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public class MyAutoDataAttribute : AutoDataAttribute
    {
        public MyAutoDataAttribute()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }
    }
}
