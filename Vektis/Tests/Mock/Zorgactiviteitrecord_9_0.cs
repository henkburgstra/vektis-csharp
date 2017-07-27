using System;
using Vektis;

namespace Vektis.Tests.Mock {
	public class Zorgactiviteitrecord_9_0: VektisData {
		/// <summary>
		/// Identificatie van het soort record in een externe-integratiebericht.
		/// </summary>
		public int kenmerk_record() {
			return 0;
		}
		/// <summary>
		/// Unieke codering van een detailrecord.
		/// </summary>
		public int identificatie_detailrecord() {
			return 0;
		}
		/// <summary>
		/// Een door de overheid toegekend identificerend nummer in het kader van het vereenvoudigen van het contact tussen overheid en burgers en het verminderen van de administratieve lasten.
		/// </summary>
		public int burgerservicenummer_bsn_verzekerde() {
			return 0;
		}
		/// <summary>
		/// Identificatie van een (zorg)verzekeraar die betrokken is bij de uitvoering van de Basisverzekering en/of de Algemene Wet Bijzondere Ziektekosten.
		/// </summary>
		public int uzovi_nummer() {
			return 0;
		}
		/// <summary>
		/// Nummer waaronder een verzekerde bij de zorgverzekeraar is ingeschreven.
		/// </summary>
		public string verzekerdennummer_inschrijvingsnummer_relatienummer_() {
			return "";
		}
		/// <summary>
		/// Code die aangeeft welke prestatiecodelijst gebruikt is, met aanduiding van de oorsprong van de codes en/of de beheerder ervan.
		/// </summary>
		public int aanduiding_prestatiecodelijst_01_() {
			return 0;
		}
		/// <summary>
		/// Code die de prestatie (zorg/product/middel) van een zorgverlener/instelling identificeert.
		/// </summary>
		public string prestatiecode_dbc_declaratiecode() {
			return "";
		}
		/// <summary>
		/// Datum waarop de prestatie feitelijk is of wordt uitgevoerd. Als de uitgevoerde prestatie betrekking heeft op meerdere dagen dan is het de begindatum.
		/// </summary>
		public string begindatum_prestatie() {
			return "";
		}
		/// <summary>
		/// Nummer dat prestaties met gelijke identificatie (prestatiecode, begindatum prestatie en verzekerde) uniek maakt per (declaratie)bestand.
		/// </summary>
		public int prestatievolgnummer() {
			return 0;
		}
		/// <summary>
		/// Dit is een uniek nummer dat binnen een zorginstelling wordt toegekend aan een uitgevoerde zorgactiviteit.
		/// </summary>
		public string zorgactiviteitnummer() {
			return "";
		}
		/// <summary>
		/// Een zorgactiviteit is een verrichting die is uitgevoerd bij het leveren van zorg aan de patiënt
		/// </summary>
		public string zorgactiviteitcode() {
			return "";
		}
		/// <summary>
		/// Datum waarop de zorgactiviteit feitelijk is of wordt uitgevoerd. Als de zorgactiviteit betrekking heeft op meerdere dagen dan is het de begindatum.
		/// </summary>
		public string begindatum_zorgactiviteit() {
			return "";
		}
		/// <summary>
		/// Datum waarop de zorgactiviteit is beëindigd, als de zorgactiviteit betrekking heeft op meerdere dagen.
		/// </summary>
		public string einddatum_zorgactiviteit() {
			return "";
		}
		/// <summary>
		/// Hoeveelheid verrichte prestaties in de prestatieperiode.
		/// </summary>
		public int aantal_uitgevoerde_prestaties() {
			return 0;
		}
		/// <summary>
		/// Code die aangeeft welke soort informatie is opgenomen.
		/// </summary>
		public int code_soort_declaratie_informatie() {
			return 0;
		}
		/// <summary>
		/// De code van de instelling waar de zorgactiviteit is uitgevoerd, afwijkend van de declarerende instelling.
		/// </summary>
		public int afwijkende_instellingscode_zorgactiviteit() {
			return 0;
		}
		/// <summary>
		/// De identificatiecode van de zorgverlener (natuurlijk persoon of instelling).
		/// </summary>
		public int zorgverlenerscode_behandelaar_uitvoerder() {
			return 0;
		}
		/// <summary>
		/// Bestaat uit ZORGVERLENERSSOORT (COD008) en ZORGVERLENER SPECIFICATIENUMMER (COD007).
		/// </summary>
		public int zorgverlenersspecificatie_behandelaar_uitvoerder_subberoepsgroep_() {
			return 0;
		}
		/// <summary>
		/// Indicatie of een bedrag/aantal debet (positief) of credit (negatief) is.
		/// </summary>
		public string indicatie_debet_credit() {
			return "";
		}
		/// <summary>
		/// Uniek referentienummer die de zorgverlener heeft toegekend aan dit zorgactiviteitrecord.
		/// </summary>
		public string referentienummer_dit_zorgactiviteitrecord() {
			return "";
		}
		/// <summary>
		/// Uniek referentienummer die de zorgverlener heeft toegekend aan een voorgaand zorgactiviteitrecord.
		/// </summary>
		public string referentienummer_voorgaande_gerelateerde_zorgactiviteitrecord() {
			return "";
		}
		/// <summary>
		/// Loze posities in een bericht ten behoeve van het op gelijke lengte brengen van records dan wel ruimte gereserveerd voor toekomstig gebruik.
		/// </summary>
		public string reserve() {
			return "";
		}
	}
}