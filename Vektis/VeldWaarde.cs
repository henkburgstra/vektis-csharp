using System;

namespace Vektis {
    public class VeldWaarde {
        public static readonly int TIJDELIJK = 1000000;
        public VeldDefinitie Definitie { get; set; }
        public dynamic Waarde { get; set; }

        public VeldWaarde(VeldDefinitie definitie, dynamic waarde) {
            Definitie = definitie;
            Waarde = waarde;
            Valideer();
        }

        public override string ToString() {
            return Definitie.Format(Waarde);
        }

        public void Valideer() {
            // TODO: implementatie
        }
    }
}