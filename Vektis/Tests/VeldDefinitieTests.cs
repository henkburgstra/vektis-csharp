using System;
using Xunit;

namespace Vektis.Tests
{

    public class VeldDefinitieTests
    {
        [Fact]
        public void NaamSetterTest() {
            var d = new VeldDefinitie{Naam="Eerste (9)"};
            Assert.Equal("eerste_9_", d.Naam);
        }

        [Fact]
        public void FormatNTest() {
            var d = new VeldDefinitie{Lengte=6};
            Assert.Equal("000001", d.FormatN(1));
            Assert.Equal("004327", d.FormatN(4327));
        }

        [Fact]
        public void FormatANTest() {
            var d = new VeldDefinitie{Lengte=6};
            Assert.Equal("x     ", d.FormatAN("x"));
            Assert.Equal("test  ", d.FormatAN("test"));
        }
        
    }
}
