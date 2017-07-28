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
            string v = Definitie.Format(Waarde);
            if (v.Length != Definitie.Lengte) {
                throw new OngeldigeLengteException(Definitie, v);
            }
            var patroon = Definitie.Patroon.Trim();
            if (patroon == "EEJJMMDD") {
                var jaar = Int32.Parse(v.Substring(0, 4));
                var maand = Int32.Parse(v.Substring(4, 2));
                var dag = Int32.Parse(v.Substring(6, 2));
                if (jaar < 1880 || maand < 1 || maand > 12 || dag < 1 || dag > 31) {
                    throw new OngeldigFormaatException(Definitie, v);
                }
            }
            else {
                for (var i = 0; i < patroon.Length; i++) {
                    var p = patroon[i];
                    var w = v[i];
                    if ((p == 'N' && !Char.IsDigit(w)) || (p == 'A' && !Char.IsLetterOrDigit(w))) {
                        throw new OngeldigFormaatException(Definitie, v);
                    }
                }
            }
        }
    }
}