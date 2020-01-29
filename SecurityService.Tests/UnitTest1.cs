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
        [Fact]
        public void Test2()
        {
	    SecurityData sd = new SecurityData();
	    sd.Ticker = "GOOG";
	    Assert.Equal("GOOG",sd.Ticker);
	    sd.Ticker = "APPL";
	    Assert.Equal("APPL",sd.Ticker);
	}

    }
}
