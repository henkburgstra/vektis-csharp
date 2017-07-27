using System;
using System.Collections.Generic;

namespace Vektis {
	public class VektisConfig {
        public static readonly string RECORDTYPE = "RECORDTYPE";
        public static readonly string RECORDCODE = "RECORDCODE";
        public static readonly string VOLGNUMMER= "VOLGNUMMER";
        public static readonly string NAAM = "NAAM";
        public static readonly string VELDTYPE = "VELDTYPE";
        public static readonly string LENGTE = "LENGTE";
        public static readonly string VERPLICHTING = "VERPLICHTING";
        public static readonly string BEGINPOSITIE = "BEGINPOSITIE";
        public static readonly string EINDPOSITIE = "EINDPOSITIE";
        public static readonly string PATROON = "PATROON";
        public static readonly string BESCHRIJVING = "BESCHRIJVING";
        public string Map { get; set; } = "";
        public string Regexp { get; set; } = "";
        public int Sheet { get; set; } = 1;
        public int StartRow { get; set; } = 11;
        public Dictionary<string, int> Colspec { get; set; } = new Dictionary<string, int>{
            {RECORDTYPE, 1},
            {RECORDCODE, 2},
            {VOLGNUMMER, 3},
            {NAAM, 4},
            {VELDTYPE, 5},
            {LENGTE, 6},
            {VERPLICHTING, 9},
            {BEGINPOSITIE, 0}, // normaal niet in gebruik bij Vektis
            {EINDPOSITIE, 8},
            {PATROON, 7},
            {BESCHRIJVING, 15}    
        };

    }
    
}