using System;
using Xunit;
using Vektis.Tests.Mock;

namespace Vektis.Tests {
    public class VektisDataTests {
        [Fact]
        public void CallTest() {
            var t = new VektisDataTest();
            var a = t.Call("test");
            Assert.Equal(1, a);    
        }
    }
}