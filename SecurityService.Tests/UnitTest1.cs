using System;
using Xunit;
using SecurityService;

namespace SecurityService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
	    SecurityData sd = new SecurityData();
	    sd.Ticker = "GOOG";
	    Assert.Equal("GOOG",sd.Ticker);
        }
    }
}
