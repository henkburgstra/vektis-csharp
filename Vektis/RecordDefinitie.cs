using System;
using System.Collections.Generic;
using System.Linq;

namespace Vektis {
    public class RecordDefinitie {
        public string Recordtype { get; set; } = "";
        public string Recordcode { get; set; } = "";
        public List<VeldDefinitie> Velddefinities { get; set; } = new List<VeldDefinitie>();

        public override string ToString() {
            return String.Join("\r\n", from velddefinitie
            in Velddefinities
            select velddefinitie.ToString());
        }
    }
}