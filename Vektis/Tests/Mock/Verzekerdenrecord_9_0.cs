using System;
using Vektis;

namespace Vektis.Tests.Mock {
	public class Verzekerdenrecord_9_0: VektisData {
		public Verzekerdenrecord_9_0(dynamic item = null) {
			Item = item;
		}
		/// <summary>
		///  Identificatie van het soort record in een externe-integratiebericht.
		/// </summary>
		public int kenmerk_record() {
			return 0;
		}
		/// <summary>
		///  Unieke codering van een detailrecord.
		/// </summary>
		public int identificatie_detailrecord() {
			return 0;
		}
		/// <summary>
		///  Een door de overheid toegekend identificerend nummer in het kader van het vereenvoudigen van
		/// het contact tussen overheid en burgers en het verminderen van de administratieve lasten.
		/// </summary>
		public int burgerservicenummer_bsn_verzekerde() {
			return 0;
		}
		/// <summary>
		///  Identificatie van een (zorg)verzekeraar die betrokken is bij de uitvoering van de
		/// Basisverzekering en/of de Algemene Wet Bijzondere Ziektekosten.
		/// </summary>
		public int uzovi_nummer() {
			return 0;
		}
		/// <summary>
		///  Nummer waaronder een verzekerde bij de zorgverzekeraar is ingeschreven.
		/// </summary>
		public string verzekerdennummer_inschrijvingsnummer_relatienummer_() {
			return "";
		}
		/// <summary>
		///  Unieke identificerende aanduiding van een persoon per orgaan van gezondheidszorg, alwaar een
		/// behandeling plaatsvindt.
		/// </summary>
		public string patient_identificatie_nummer() {
			return "";
		}
		/// <summary>
		///  Datum waarop de verzekerde geboren is.
		/// </summary>
		public string datum_geboorte_verzekerde() {
			return "";
		}
		/// <summary>
		///  Unieke aanduiding van de sexe van een verzekerde, het niet bekend zijn daarvan, het ontbreken
		/// of niet gespecificeerd zijn.
		/// </summary>
		public int code_geslacht_verzekerde() {
			return 0;
		}
		/// <summary>
		///  Aanduiding naamgebruik (gecodeerd).
		/// </summary>
		public int naamcode_naamgebruik_01_() {
			return 0;
		}
		/// <summary>
		///  De achternaam van verzekerde, indien nodig verkort weergegeven (significant deel).
		/// </summary>
		public string naam_verzekerde_01_() {
			return "";
		}
		/// <summary>
		///  Verzameling van één of meer voorzetsels/lidwoorden, die aan het significante deel van de
		/// achternaam van de verzekerde vooraf gaat en daar een onderdeel van is.
		/// </summary>
		public string voorvoegsel_verzekerde_01_() {
			return "";
		}
		/// <summary>
		///  Aanduiding naamgebruik (gecodeerd).
		/// </summary>
		public int naamcode_naamgebruik_02_() {
			return 0;
		}
		/// <summary>
		///  De achternaam van verzekerde, indien nodig verkort weergegeven (significant deel).
		/// </summary>
		public string naam_verzekerde_02_() {
			return "";
		}
		/// <summary>
		///  Verzameling van één of meer voorzetsels/lidwoorden, die aan het significante deel van de
		/// achternaam van de verzekerde vooraf gaat en daar een onderdeel van is.
		/// </summary>
		public string voorvoegsel_verzekerde_02_() {
			return "";
		}
		/// <summary>
		///  De voorletters van verzekerde. De verzameling van letters die wordt gevormd door de eerste
		/// letter van alle in volgorde voorkomende voornamen.
		/// </summary>
		public string voorletters_verzekerde() {
			return "";
		}
		/// <summary>
		///  Aanduiding naamgebruik (gecodeerd).
		/// </summary>
		public int naamcode_naamgebruik_03_() {
			return 0;
		}
		/// <summary>
		///  De postcode van het huisadres van een verzekerde.
		/// </summary>
		public string postcode_huisadres_verzekerde() {
			return "";
		}
		/// <summary>
		///  Weergave van buitenlandse postcodes.
		/// </summary>
		public string postcode_buitenland() {
			return "";
		}
		/// <summary>
		///  De numerieke aanduiding bij het adres van een verzekerde, zoals de gemeente die heeft
		/// toegekend.
		/// </summary>
		public int huisnummer_huisadres_verzekerde() {
			return 0;
		}
		/// <summary>
		///  De alfanumerieke aanduiding achter het huisnummer van de verzekerde, zoals de gemeente die
		/// heeft toegekend.
		/// </summary>
		public string huisnummertoevoeging_huisadres_verzekerde() {
			return "";
		}
		/// <summary>
		///  Identificatie van een land of gebiedsdeel waar een verzekerde woonachtig is.
		/// </summary>
		public string code_land_verzekerde() {
			return "";
		}
		/// <summary>
		///  Unieke aanduiding van een debiteur.
		/// </summary>
		public string debiteurnummer() {
			return "";
		}
		/// <summary>
		///  Aanduiding of cliënt overleden is.
		/// </summary>
		public int indicatie_client_overleden() {
			return 0;
		}
		/// <summary>
		///  Loze posities in een bericht ten behoeve van het op gelijke lengte brengen van records dan
		/// wel ruimte gereserveerd voor toekomstig gebruik.
		/// </summary>
		public string reserve() {
			return "";
		}
	}
}