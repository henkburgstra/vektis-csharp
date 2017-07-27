using System;
using Xunit;

namespace Vektis.Tests {
    public class VektisInstantieTests {
        [Fact]
        public void NaarBestandTest() {
            var zh308Def = new VektisDefinitie{Standaard="ZH308", Versie="9.0"};
            zh308Def.LaadSpecificatie();

            var zh308Inst = new VektisInstantie{Definitie=zh308Def};
            zh308Inst.NieuwRecord("VOORLOOPRECORD", data: null);
        }
    }
}