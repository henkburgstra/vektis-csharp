using System;
using System.Collections.Generic;
using System.Linq;

namespace Vektis {
    public class RecordInstantie {
        public RecordDefinitie Definitie { get; set; } = new RecordDefinitie();
        public VektisData Data { get; set; } = new VektisData();
        public List<VeldWaarde> Veldwaarden { get; set; } = new List<VeldWaarde>();
        private Dictionary<string, int> veldwaardeKeys = new Dictionary<string, int>();
        private int veldwaardeCounter = 0;

        public RecordInstantie(RecordDefinitie definitie, VektisData data) {
            Definitie = definitie;
            Data = data;
            foreach(var velddefinitie in Definitie.Velddefinities) {
                dynamic waarde = null;
                if (velddefinitie.Naam == "kenmerk_record") {
                    waarde = Definitie.Recordcode;
                }
                else if (velddefinitie.Naam == "identificatie_detailrecord") {
                    waarde = VeldWaarde.TIJDELIJK;  // Krijgt later een waarde
                }
                else if (data.HasMethod(velddefinitie.Naam)) {
                    waarde = data.Call(velddefinitie.Naam);
                }
                else {
                    waarde = data.Veld(velddefinitie);
                }
                AddVeldWaarde(velddefinitie.Naam, new VeldWaarde(velddefinitie, waarde));
            }
        }

        public override string ToString() {
            return String.Join("", from veldwaarde in Veldwaarden select veldwaarde.ToString());
        }

        public void AddVeldWaarde(string naam, VeldWaarde veldwaarde) {
            Veldwaarden.Add(veldwaarde);
            veldwaardeKeys[naam] = veldwaardeCounter;
            veldwaardeCounter++;
        }

        public VeldWaarde GetVeldWaarde(string veldnaam) {
            if (veldwaardeKeys.ContainsKey(veldnaam)) {
                return Veldwaarden[veldwaardeKeys[veldnaam]];
            }
            return null;
        }

        public dynamic GetWaarde(string veldnaam) {
            var veldwaarde = GetVeldWaarde(veldnaam);
            if (veldwaarde == null) {
                return null;
            }
            return veldwaarde.Waarde;
        }
    }
}