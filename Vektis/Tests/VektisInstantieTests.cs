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
            
            zh308Inst.NieuwRecord("VOORLOOPRECORD", new Voorlooprecord_9_0(bundel));

            foreach(var nota in bundel.Notas) {
                zh308Inst.NieuwRecord("VERZEKERDENRECORD", new Verzekerdenrecord_9_0(nota));
                zh308Inst.NieuwRecord("PRESTATIERECORD", new Prestatierecord_9_0(nota));
                zh308Inst.NieuwRecord("TARIEFRECORD", new Tariefrecord_9_0(nota));   
            }

            zh308Inst.NieuwRecord("SLUITRECORD", new Sluitrecord_9_0(bundel));
            zh308Inst.NaarBestand("./vektis.edd");
        }
    }
}