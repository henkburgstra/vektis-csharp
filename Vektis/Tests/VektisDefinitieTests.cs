using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Vektis.Tests {
    public class VektisDefinitieTests {
        [Fact]
        public void LaadSpecificatieTest() {
            var d = new VektisDefinitie();
            d.LaadSpecificatie();
            Assert.False(d.Recorddefinities.Count == 0);
        }
        
        [Fact]
        public void ScaffoldTest() {
            var d = new VektisDefinitie{Versie="9.0"};
            var map = "./";
            d.Scaffold(map, "Vecozo", new Dictionary<string, string>());
            Assert.True(File.Exists(Path.Combine(map, "Voorlooprecord_9_0.cs")));
        }
    }
}