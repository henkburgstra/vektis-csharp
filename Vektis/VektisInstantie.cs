using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CSharp;

namespace Vektis {
    public class VektisInstantie {
        public VektisDefinitie Definitie { get; set; } = new VektisDefinitie();
        private int recordcounter = 0;
        public List<RecordInstantie> Records { get; set; } = new List<RecordInstantie>();
        public Dictionary<string, RecordInstantie> Groep { get; set; } = new Dictionary<string, RecordInstantie>();

        public override string ToString() {
            return String.Join("\r\n", from record in Records select record.ToString());
        }
        public RecordInstantie GetRecord(string recordtype) {
            Groep.TryGetValue(recordtype, out RecordInstantie record);
            return record;
        }

        public VeldWaarde GetVeldWaarde(string recordtype, string veldnaam) {
            var record = GetRecord(recordtype);
            if (record == null) {
                return null;
            }
            return record.GetVeldWaarde(veldnaam);
        }

        public int AantalDetailrecords(string recordtype = "") {
            if (recordtype == "") {
                return Math.Max(Records.Count - 1, 0);
            }
            return (from record in Records
                where record.Definitie.Recordtype == recordtype
                select 1).Sum();
        }

        public int Totaliseer(string recordtype, string veldnaam) {
            return (from record in Records
                where record.Definitie.Recordtype == recordtype
                && record.GetVeldWaarde(veldnaam) != null
                select (int)record.GetVeldWaarde(veldnaam).Waarde).Sum();
        }

        public RecordInstantie NieuwRecord(string recordtype, VektisData data = null) {
            var recorddefinitie = Definitie.GetRecordefinitie(recordtype);
            var record = new RecordInstantie(recorddefinitie, data);
            var identificatie = record.GetVeldWaarde("identificatie_detailrecord");
            if (identificatie != null && identificatie.Waarde == VeldWaarde.TIJDELIJK) {
                recordcounter++;
                identificatie.Waarde = recordcounter;
            }
            Records.Add(record);
            Groep[recordtype] = record;
            return record;
        }

        public void NaarBestand(string bestandsnaam) {
            File.WriteAllText(bestandsnaam, ToString());
        }
    }
}