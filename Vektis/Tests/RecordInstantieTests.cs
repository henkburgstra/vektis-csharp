using System;
using Xunit;
using Vektis.Tests.Mock;

namespace Vektis.Tests {
   
    public class RecordInstantieTests {
        [Fact]
        public void DataSetterTest() {
            var d = new VektisDataTest();
            var r = new RecordInstantie(new RecordDefinitie(), d);
            r.Data = d;
            var x = r.Data.Call("test");
            Assert.Equal(1, x);
        }
    }
}