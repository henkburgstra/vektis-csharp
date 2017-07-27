using System;

namespace Vektis {
    public class VektisReader: VektisData {
        public override dynamic Veld(VeldDefinitie velddefinitie) {
            if (Item is string) {
                return Item.Substring(velddefinitie.Eindpositie - velddefinitie.Lengte, velddefinitie.Lengte);
            }
            // TODO: eigen exception
            throw new Exception("VektisReader verwacht een string Item");
        }
    }
}