using System;
using Xunit;
using Vektis.Tests.Mock;

namespace Vektis.Tests {
    public class VektisInstantieTests {
        [Fact]
        public void NaarBestandTest() {
            var zh308Def = new VektisDefinitie{Standaard="ZH308", Versie="9.0"};
            zh308Def.LaadSpecificatie();

            var zh308Inst = new VektisInstantie{Definitie=zh308Def};
            dynamic bundel = new  {
                Notas = new dynamic[] {
                    new { Nummer = "1", Datum = "2017-07-27", Bedrag = 90087 }
                }
            };
            zh308Inst.NieuwRecord("VOORLOOPRECORD", data: new Voorlooprecord_9_0(item: bundel));

            foreach(var nota in bundel.Notas) {
                
            }
        }
    }
}