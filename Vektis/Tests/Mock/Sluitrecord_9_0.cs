using System;
using Vektis;

namespace Vektis.Tests.Mock {
	public class Sluitrecord_9_0: VektisData {
		public Sluitrecord_9_0(dynamic item = null) {
			Item = item;
		}
		/// <summary>
		///  Identificatie van het soort record in een externe-integratiebericht.
		/// </summary>
		public int kenmerk_record() {
			return 0;
		}
		/// <summary>
		///  Het aantal voorafgaande verzekerdenrecords.
		/// </summary>
		public int aantal_verzekerdenrecords() {
			return 0;
		}
		/// <summary>
		///  Het aantal voorafgaande debiteurrecords.
		/// </summary>
		public int aantal_debiteurrecords() {
			return 0;
		}
		/// <summary>
		///  Het aantal voorafgaande prestatierecords.
		/// </summary>
		public int aantal_prestatierecords() {
			return 0;
		}
		/// <summary>
		///  Het aantal tariefrecords behorend bij het betreffende factuurnummer.
		/// </summary>
		public int aantal_tariefrecords() {
			return 0;
		}
		/// <summary>
		///  Het aantal zorgactiviteitrecords behorend bij het betreffende factuurnummer.
		/// </summary>
		public int aantal_zorgactiviteitrecords() {
			return 0;
		}
		/// <summary>
		///  Het totaal aantal voorafgaande commentaarrecords.
		/// </summary>
		public int aantal_commentaarrecords() {
			return 0;
		}
		/// <summary>
		///  Het totaal aantal voorafgaande detailrecords.
		/// </summary>
		public int totaal_aantal_detailrecords() {
			return 0;
		}
		/// <summary>
		///  Som van de te declareren bedragen.
		/// </summary>
		public int totaal_declaratiebedrag() {
			return 0;
		}
		/// <summary>
		///  Indicatie of een bedrag/aantal debet (positief) of credit (negatief) is.
		/// </summary>
		public string indicatie_debet_credit() {
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