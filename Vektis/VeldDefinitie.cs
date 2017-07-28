using System;
using System.Text.RegularExpressions;

namespace Vektis {
    public class VeldDefinitie {

        private readonly Regex reNotWord = new Regex(@"\W");
        private readonly Regex reMultipleUnderscore = new Regex("_+");
        public int Volgnummer { get; set; }
        private string _naam = "";
        public string Naam { 
            get { return _naam; } 
            set {
                _naam = reMultipleUnderscore.Replace(reNotWord.Replace(value.ToLower(), "_"), "_");
            } 
        }
        private string _veldtype = "";
        public string Veldtype {
            get { return _veldtype; }
            set {
                switch(value) {
                    case "Numeriek":
                        _veldtype = "N";
                        break;
                    case "Alfanumeriek":
                        _veldtype = "AN";
                        break;
                    default:
                        _veldtype = value;
                        break;
                }
            }
        }
        public int Lengte { get; set; }
        public string Verplichting { get; set; } = "";
        public int Eindpositie { get; set; }
        public string Patroon { get; set; } = "";
        public string Beschrijving { get; set; } = "";

        public override string ToString()
        {
            return $"[VeldDefinitie: Volgnummer={Volgnummer}, Naam={Naam}, Veldtype={Veldtype}, Lengte={Lengte}, Verplichting={Verplichting}, Eindpositie={Eindpositie}, Patroon={Patroon}, Beschrijving={Beschrijving}]";
        }

        public string FormatN(int waarde) {
            return waarde.ToString($"D{Lengte}");
            //return waarde.ToString().PadLeft(Lengte).Replace(' ', '0');
        }

        public string FormatAN(string waarde) {
            if (waarde == null) return "";
            return waarde.PadRight(Lengte);
        }

        public string Format(dynamic waarde) {
            if (Veldtype == "N") {
                if (Patroon == "EEJJMMDD") {
                    if (waarde is String) {
                        return FormatN(Vektis.Datum(waarde));
                    }
                }
                return FormatN(waarde);
            }
            else {
                return FormatAN(waarde.ToString());
            }
        }
        
        public string CSharpDatatype() {
            if (Veldtype == "N") {
                if (Patroon == "EEJJMMDD") {
                    return "string";
                }
                else {
                    return "int";
                }
            }
            return "string";
        }
    }
    
}