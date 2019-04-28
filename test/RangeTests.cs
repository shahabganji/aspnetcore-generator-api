using System.Linq;
using Xunit;
using api.Controllers;


namespace test
{
    public class RangeTests
    {
        [Fact]
        public void CountShouldControlNumberOfResults()
        {
            var range = new Range{ Count = 3 };

            var generated = range.Of( () => "" );

            Assert.Equal( 3 , generated.Count() );
        }

        // [Fact]
        // public void CountShouldControlNumberOfResults_Fail()
        // {
        //     var range = new Range{ Count = 3 };

        //     var generated = range.Of( () => "" );

        //     Assert.Equal( 4 , generated.Count() );
        // }
    }
}
