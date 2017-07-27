using System;
using Vektis;

namespace Vektis.Tests.Mock {
	public class Prestatierecord_9_0: VektisData {
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
		/// Identificatie van een afgegeven machtiging/toestemming.
		/// </summary>
		public string machtigingsnummer() {
			return "";
		}
		/// <summary>
		/// Code die aangeeft of het doorsturen van de desbetreffende prestatie met daaraan verbonden declaratie naar de zorgverzekeraar is toegestaan.
		/// </summary>
		public int doorsturen_toegestaan() {
			return 0;
		}
		/// <summary>
		/// Datum waarop de verzekerde geboren is.
		/// </summary>
		public string datum_geboorte_verzekerde() {
			return "";
		}
		/// <summary>
		/// Code die aangeeft welke prestatiecodelijst gebruikt is, met aanduiding van de oorsprong van de codes en/of de beheerder ervan.
		/// </summary>
		public int aanduiding_prestatiecodelijst() {
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
		/// Datum waarop de prestatie is beëindigd, als de prestatie betrekking heeft op meerdere dagen.
		/// </summary>
		public string einddatum_prestatie() {
			return "";
		}
		/// <summary>
		/// Nummer dat prestaties met gelijke identificatie (prestatiecode, begindatum prestatie en verzekerde) uniek maakt per (declaratie)bestand.
		/// </summary>
		public int prestatievolgnummer() {
			return 0;
		}
		/// <summary>
		/// Een (DBC)zorgproduct is het declarabele product dat door de Grouper wordt afgeleid uit de declaratiedataset, met ingang van de nieuwe DBC declaratiesystematiek gebaseerd op DOT.
		/// </summary>
		public string zorgproductcode() {
			return "";
		}
		/// <summary>
		/// Identificatie van het zorgtraject waartoe deze prestatie behoort.
		/// </summary>
		public string zorgtrajectnummer() {
			return "";
		}
		/// <summary>
		/// Datum waarop het zorgtraject begint.
		/// </summary>
		public string begindatum_zorgtraject() {
			return "";
		}
		/// <summary>
		/// Datum waarop het zorgtraject eindigt.
		/// </summary>
		public string einddatum_zorgtraject() {
			return "";
		}
		/// <summary>
		/// Reden waarom het zorgtraject of subtraject afgesloten is.
		/// </summary>
		public string afsluitreden_zorgtraject_subtraject() {
			return "";
		}
		/// <summary>
		/// Subtrajectidentificatie binnen een zorgtraject.
		/// </summary>
		public string subtrajectnummer() {
			return "";
		}
		/// <summary>
		/// Datum waarop de verwijzing naar de specialist of paramedicus plaats heeft gevonden.
		/// </summary>
		public string verwijsdatum() {
			return "";
		}
		/// <summary>
		/// Aanduiding van de aard van de (zelf)verwijzer.
		/// </summary>
		public int code_zelf_verwijzer() {
			return 0;
		}
		/// <summary>
		/// De identificatiecode van de zorgverlener (natuurlijk persoon).
		/// </summary>
		public int zorgverlenerscode_voorschrijver_verwijzer() {
			return 0;
		}
		/// <summary>
		/// Nadere verbijzondering van de zorgverlener per soort/beroepsgroep. Nadere identificatie van de categorie waartoe een voorschrijvende of verwijzende zorgverlener behoort.
		/// </summary>
		public int specialisme_voorschrijver_verwijzer() {
			return 0;
		}
		/// <summary>
		/// De identificatiecode van de voorschrijvende/verwijzende instelling of praktijk.
		/// </summary>
		public int instellingscode_of_praktijkcode_voorschrijver_verwijzer() {
			return 0;
		}
		/// <summary>
		/// Identificatie van het zorgtraject dat naar het zorgtraject van deze prestatie verwijst.
		/// </summary>
		public string verwijzend_zorgtrajectnummer() {
			return "";
		}
		/// <summary>
		/// Hoeveelheid verrichte prestaties in de prestatieperiode.
		/// </summary>
		public int aantal_uitgevoerde_prestaties() {
			return 0;
		}
		/// <summary>
		/// Het zorgtype is een component waarmee op het niveau van het declaratietraject de geleverde (en te declareren) zorg wordt getypeerd.
		/// </summary>
		public string zorgtypecode() {
			return "";
		}
		/// <summary>
		/// Identificatie van het codestelsel waarmee de zorgvraag gecodeerd wordt.
		/// </summary>
		public int soort_zorgvraag() {
			return 0;
		}
		/// <summary>
		/// De typerende zorgvraag dat in DBC kader is gedefinieerd voor een aantal specialismen.
		/// </summary>
		public string zorgvraagcode() {
			return "";
		}
		/// <summary>
		/// Code die aangeeft welke diagnosecodelijst gebruikt is, met aanduiding van de oorsprong van de codes en/of de beheerder ervan.
		/// </summary>
		public int aanduiding_diagnosecodelijst_01_() {
			return 0;
		}
		/// <summary>
		/// Code die de diagnose van een zorgverlener/instelling identificeert.
		/// </summary>
		public string diagnosecode() {
			return "";
		}
		/// <summary>
		/// Code die aangeeft welke diagnosecodelijst gebruikt is, met aanduiding van de oorsprong van de codes en/of de beheerder ervan.
		/// </summary>
		public int aanduiding_diagnosecodelijst_02_() {
			return 0;
		}
		/// <summary>
		/// De primaire medische diagnose geeft de reden aan van het in behandeling nemen of zijn van een persoon.
		/// </summary>
		public string primaire_medische_diagnose_icd_10_() {
			return "";
		}
		/// <summary>
		/// Indicatie die aangeeft of er volgens de behandelaar sprake is van een aanspraak op de zorgverzekeringswet.
		/// </summary>
		public string indicatie_aanspraak_zorgverzekeringswet_toegepast() {
			return "";
		}
		/// <summary>
		/// Aanduiding van een bijzonder aspect van de prestatie.
		/// </summary>
		public int toelichting_prestatie() {
			return 0;
		}
		/// <summary>
		/// Code die de soort herdeclaratie weergeeft.
		/// </summary>
		public int code_herdeclaratie() {
			return 0;
		}
		/// <summary>
		/// De indicatie machtiging geeft aan dat er in het profiel van het zorgproduct minstens één "oranje" zorgactiviteit voorkomt waarvoor een machtiging vereist is.
		/// </summary>
		public string indicatie_machtiging() {
			return "";
		}
		/// <summary>
		/// De indicatie producttyperende oranje zorgactiviteit geeft aan dat er in het profiel van een zorgproduct een oranje zorgactiviteit voorkomt die bepalend is voor de afleiding van dit zorgproduct.
		/// </summary>
		public string indicatie_producttyperende_oranje_verrichting_in_het_profiel() {
			return "";
		}
		/// <summary>
		/// Bestaat uit ZORGVERLENERSSOORT (COD008) en ZORGVERLENER SPECIFICATIENUMMER (COD007).
		/// </summary>
		public int zorgverlenersspecificatie_behandelaar_uitvoerder_subberoepsgroep_() {
			return 0;
		}
		/// <summary>
		/// Identificerende code van een instelling.
		/// </summary>
		public int instellingscode() {
			return 0;
		}
		/// <summary>
		/// Het Hashtotaal zorgverzekeraar is de versleutelde Hashwaarde.
		/// </summary>
		public string hashtotaal_zv() {
			return "";
		}
		/// <summary>
		/// Versie Hashcodeberekening zorgproduct of zorgactiviteit voor zorgverzekeraar.
		/// </summary>
		public string hashversie_zv() {
			return "";
		}
		/// <summary>
		/// Versie certificaat voor hashbepaling.
		/// </summary>
		public string certificaatversie_hash() {
			return "";
		}
		/// <summary>
		/// Identificatie van de Grouper die gebruikt wordt voor het afleiden van prestaties.
		/// </summary>
		public string grouperidentificatie() {
			return "";
		}
		/// <summary>
		/// Versie van de Grouper.
		/// </summary>
		public string grouperversie() {
			return "";
		}
		/// <summary>
		/// Versie van de tabel van de Grouper.
		/// </summary>
		public string tabelsetversie_grouper() {
			return "";
		}
		/// <summary>
		/// Aanduiding van de werkomgeving van de Grouper.
		/// </summary>
		public string grouperwerkomgeving() {
			return "";
		}
		/// <summary>
		/// Een zorgactiviteit is een verrichting die is uitgevoerd bij het leveren van zorg aan de patiënt
		/// </summary>
		public string zorgactiviteitcode() {
			return "";
		}
		/// <summary>
		/// Dit is een uniek nummer dat binnen een zorginstelling wordt toegekend aan een uitgevoerde zorgactiviteit.
		/// </summary>
		public string zorgactiviteitnummer() {
			return "";
		}
		/// <summary>
		/// Code die het zorgpad identificeert.
		/// </summary>
		public int zorgpadcode() {
			return 0;
		}
		/// <summary>
		/// Code die aangeeft welke diagnosecodelijst gebruikt is, met aanduiding van de oorsprong van de codes en/of de beheerder ervan.
		/// </summary>
		public int aanduiding_diagnosecodelijst() {
			return 0;
		}
		/// <summary>
		/// Door paramedicus gecodeerde verwijsdiagnose (opgesteld/omschreven door verwijzend huisarts, specialist, enz.).
		/// </summary>
		public int verwijsdiagnosecode_paramedische_hulp() {
			return 0;
		}
		/// <summary>
		/// Code die aangeeft van welke soort indicatie paramedische hulp sprake is, n.a.v. de Regeling Paramedische Hulp.
		/// </summary>
		public int code_soort_indicatie_paramedische_hulp() {
			return 0;
		}
		/// <summary>
		/// Indicatie die aangeeft of er sprake is van een tweede operatie bij dezelfde aandoening.
		/// </summary>
		public string indicatie_tweede_operatie_zelfde_aandoening_paramedische_hulp() {
			return "";
		}
		/// <summary>
		/// Reden waarom de zorg beeindigd is.
		/// </summary>
		public int reden_einde_zorg() {
			return 0;
		}
		/// <summary>
		/// Aanduiding over een patiënt die als gevolg van een ongeval (noodzakelijk) een prestatie (zorg) ondergaat.
		/// </summary>
		public string indicatie_ongeval_ongevalsgevolg_() {
			return "";
		}
		/// <summary>
		/// Indicatie of een bedrag/aantal debet (positief) of credit (negatief) is.
		/// </summary>
		public string indicatie_debet_credit() {
			return "";
		}
		/// <summary>
		/// Uniek referentienummer dat de zorgverlener heeft toegekend aan deze declaratie voor (een deel van) de prestatie.
		/// </summary>
		public string referentienummer_dit_prestatierecord() {
			return "";
		}
		/// <summary>
		/// Uniek referentienummer dat de zorgverlener heeft toegekend aan een voorgaande prestatie, die gerelateerd is aan deze prestatie.
		/// </summary>
		public string referentienummer_voorgaande_gerelateerde_prestatierecord() {
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