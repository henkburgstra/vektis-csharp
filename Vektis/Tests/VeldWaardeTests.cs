using System;
using Xunit;

namespace Vektis.Tests {
    public class VeldWaardeTests {
        /// <summary>
        /// Test setter dynamic veld VeldWaarde.Waarde
        /// </summary>
        [Fact]
        public void WaardeSetterTest() {
            var w = new VeldWaarde(null, 0);
            var fout = false;
            try {
                w.Waarde = 0;
                w.Waarde = "test";
            }
            catch (Exception) {
                fout = true;
            }
            Assert.False(fout);
        }
    }
}