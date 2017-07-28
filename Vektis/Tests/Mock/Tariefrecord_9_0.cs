using System;
using Vektis;

namespace Vektis.Tests.Mock {
	public class Tariefrecord_9_0: VektisData {
		public Tariefrecord_9_0(dynamic item = null) {
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
		///  Code die aangeeft welke prestatiecodelijst gebruikt is, met aanduiding van de oorsprong van
		/// de codes en/of de beheerder ervan.
		/// </summary>
		public int aanduiding_prestatiecodelijst_01_() {
			return 0;
		}
		/// <summary>
		///  Code die aangeeft welke prestatiecodelijst gebruikt is, met aanduiding van de oorsprong van
		/// de codes en/of de beheerder ervan.
		/// </summary>
		public int aanduiding_prestatiecodelijst_02_() {
			return 0;
		}
		/// <summary>
		///  Code die de prestatie (zorg/product/middel) van een zorgverlener/instelling identificeert.
		/// </summary>
		public string prestatiecode_dbc_declaratiecode() {
			return "";
		}
		/// <summary>
		///  Datum waarop de prestatie feitelijk is of wordt uitgevoerd. Als de uitgevoerde prestatie
		/// betrekking heeft op meerdere dagen dan is het de begindatum.
		/// </summary>
		public string begindatum_prestatie() {
			return "";
		}
		/// <summary>
		///  Nummer dat prestaties met gelijke identificatie (prestatiecode, begindatum prestatie en
		/// verzekerde) uniek maakt per (declaratie)bestand.
		/// </summary>
		public int prestatievolgnummer() {
			return 0;
		}
		/// <summary>
		///  Code die soort prestatie of soort tarief weergeeft.
		/// </summary>
		public int soort_prestatie_tarief() {
			return 0;
		}
		/// <summary>
		///  De identificatiecode van de zorgverlener (natuurlijk persoon of instelling).
		/// </summary>
		public int zorgverlenerscode_behandelaar_uitvoerder() {
			return 0;
		}
		/// <summary>
		///  Bestaat uit ZORGVERLENERSSOORT (COD008) en ZORGVERLENER SPECIFICATIENUMMER (COD007).
		/// </summary>
		public int zorgverlenersspecificatie_behandelaar_uitvoerder_subberoepsgroep_() {
			return 0;
		}
		/// <summary>
		///  Tarief van de individuele prestatie, ongeacht wie (kunnen meerdere partijen zijn) dit
		/// betaalt.
		/// </summary>
		public int tarief_prestatie_incl_btw_() {
			return 0;
		}
		/// <summary>
		///  Berekeningsfactor over het normtarief voor het feitelijk gebruikte aandeel (event. in tijd)
		/// aan te geven in de declaratie van kosten, honorarium of verrichting.
		/// </summary>
		public int verrekenpercentage() {
			return 0;
		}
		/// <summary>
		///  Code die de soort toeslag weergeeft die geldt bij de uitvoering van een handeling door een
		/// medisch specialist.
		/// </summary>
		public int soort_toeslag() {
			return 0;
		}
		/// <summary>
		///  Het berekend bedrag is het bedrag dat de zorgverlener wil ontvangen, ongeacht wie het betaalt
		/// (verzekeraar, verzekerde, ...).
		/// </summary>
		public int berekend_bedrag_incl_btw_() {
			return 0;
		}
		/// <summary>
		///  Indicatie of een bedrag/aantal debet (positief) of credit (negatief) is.
		/// </summary>
		public string indicatie_debet_credit_01_() {
			return "";
		}
		/// <summary>
		///  BTW-percentage dat van toepassing is.
		/// </summary>
		public int btw_percentage_declaratiebedrag() {
			return 0;
		}
		/// <summary>
		///  Het bedrag dat gedeclareerd wordt.
		/// </summary>
		public int declaratiebedrag_incl_btw_() {
			return 0;
		}
		/// <summary>
		///  Indicatie of een bedrag/aantal debet (positief) of credit (negatief) is.
		/// </summary>
		public string indicatie_debet_credit_02_() {
			return "";
		}
		/// <summary>
		///  Uniek referentienummer die de zorgverlener heeft toegekend aan deze declaratie voor (een deel
		/// van) de prestatie.
		/// </summary>
		public string referentienummer_dit_tariefrecord() {
			return "";
		}
		/// <summary>
		///  Uniek referentienummer die de zorgverlener heeft toegekend aan een voorgaand tariefrecord,
		/// dat gerelateerd is aan deze prestatie.
		/// </summary>
		public string referentienummer_voorgaande_gerelateerde_tariefrecord() {
			return "";
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