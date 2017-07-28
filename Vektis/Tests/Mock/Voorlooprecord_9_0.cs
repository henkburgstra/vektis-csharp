using System;
using Vektis;

namespace Vektis.Tests.Mock {
	public class Voorlooprecord_9_0: VektisData {

		public Voorlooprecord_9_0(dynamic item = null) {
			Item = item;
		}
		/// <summary>
		/// Identificatie van het soort record in een externe-integratiebericht.
		/// </summary>
		public int kenmerk_record() {
			return 0;
		}
		/// <summary>
		/// Code ter identificatie van een (soort) (externe-integratie)bericht.
		/// </summary>
		public int code_externe_integratiebericht() {
			return 0;
		}
		/// <summary>
		/// Volgnummer van de formele uitgifte van een versie van een (externe-integratie)berichtstandaard.
		/// </summary>
		public int versienummer_berichtstandaard() {
			return 0;
		}
		/// <summary>
		/// Volgnummer binnen het versienummer van een (externe-integratie) berichtstandaard. Volgnummer van de formele uitgifte van een subversie van een (Externe Integratie) berichtstandaard.
		/// </summary>
		public int subversienummer_berichtstandaard() {
			return 0;
		}
		/// <summary>
		/// Aanduiding van het doel van het bestand.
		/// </summary>
		public string soort_bericht() {
			return "";
		}
		/// <summary>
		/// Identificatie van het informatiesysteem van een softwareleverancier
		/// </summary>
		public int code_informatiesysteem_softwareleverancier() {
			return 0;
		}
		/// <summary>
		/// Aanduiding van een versie van een informatiesysteem.
		/// </summary>
		public string versieaanduiding_informatiesysteem_softwareleverancier() {
			return "";
		}
		/// <summary>
		/// Identificatie van een (zorg)verzekeraar die betrokken is bij de uitvoering van de Basisverzekering en/of de Algemene Wet Bijzondere Ziektekosten.
		/// </summary>
		public int uzovi_nummer() {
			return 0;
		}
		/// <summary>
		/// Identificerende code van een servicebureau. Een servicebureau is een dienstverlenende organisatie (eenheid), die een (elektronische) schakel vormt tussen zorgverleners (vrijgevestigde beroepsbeoefenaren en zorginstellingen) en zorgverzekeraars.
		/// </summary>
		public int code_servicebureau() {
			return 0;
		}
		/// <summary>
		/// Identificerende code van de zorgverlener (natuurlijk persoon).
		/// </summary>
		public int zorgverlenerscode() {
			return 0;
		}
		/// <summary>
		/// Identificerende code van een praktijk, waartoe een individuele zorgverlener behoort.
		/// </summary>
		public int praktijkcode() {
			return 0;
		}
		/// <summary>
		/// Identificerende code van een instelling.
		/// </summary>
		public int instellingscode() {
			return 0;
		}
		/// <summary>
		/// Verwijzing naar degene, die de betaling dient te ontvangen.
		/// </summary>
		public int identificatiecode_betaling_aan() {
			return 0;
		}
		/// <summary>
		/// Datumveld.
		/// </summary>
		public string begindatum_declaratieperiode() {
			return "";
		}
		/// <summary>
		/// Laatste dag van een administratieve periode waarop de gegevensuitwisseling betrekking heeft. Dit betreft niet per definitie de einddatum van de laatste behandeling.
		/// </summary>
		public string einddatum_declaratieperiode() {
			return "";
		}
		/// <summary>
		/// Unieke aanduiding van een factuur, toegekend door de opsteller van een factuur.
		/// </summary>
		public string factuurnummer_declarant() {
			return "";
		}
		/// <summary>
		/// Datum van ondertekening van een declaratie door de declarant.
		/// </summary>
		public string dagtekening_factuur() {
			return "";
		}
		/// <summary>
		/// Identificatienummer voor een zorgverlener in het kader van de omzetbelasting.
		/// </summary>
		public string btw_identificatienummer() {
			return "";
		}
		/// <summary>
		/// Valuta waarin alle bedragen zijn uitgedrukt.
		/// </summary>
		public string valutacode() {
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