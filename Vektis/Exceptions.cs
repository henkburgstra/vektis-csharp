using System;

namespace Vektis {
    public class GeenSpecificatieException : Exception {
        public GeenSpecificatieException(string standaard, string versie, VektisConfig config)
            : base($"Geen specificatiebestand voor Vektisstandaard '{standaard}' versie '{versie}' in map '{config.Map}' met patroon '{config.Regexp}'") {}
	}

    public class GeenDataException: Exception {
        public GeenDataException(string recordtype)
            : base($"Geen VektisData voor recordtype '{recordtype}'") {}
    }

    public class VerplichtVeldException: Exception {
        public VerplichtVeldException(string recordtype, VeldDefinitie d)
            :base($"Veld '{recordtype}.{d.Naam}' is verplicht - {d.Veldtype}({d.Lengte}) {d.Patroon}") {}
    }

    public class OngeldigTypeException: Exception {
        public OngeldigTypeException(VeldDefinitie d, string waarde)
            : base($"Veld '{d.Naam}' heeft type '{d.Veldtype}' maar de waarde is '{waarde}'") {}
    }

	public class OngeldigeLengteException : Exception
	{
		public OngeldigeLengteException(VeldDefinitie d, string waarde)
            : base($"Waarde '{waarde}' met lengte {waarde.Length} past niet in veld '{d.Naam}' met lengte {d.Lengte}") {}
	}

	public class OngeldigFormaatException : Exception
	{
		public OngeldigFormaatException(VeldDefinitie d, string waarde)
            : base($"Waarde '{waarde}' van veld '{d.Naam}' komt niet overeen met patroon '{d.Patroon}'") {}
	}
    
}