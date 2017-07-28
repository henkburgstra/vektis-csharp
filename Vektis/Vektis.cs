using System;
using System.Collections.Generic;
using System.Linq;

namespace Vektis {
    public static class Extensions {
        public static List<string> Splits(this String s, int maxRegelLen) {
            var woorden = s.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            var regels = new List<string>();
            var woord = 0;
            var regel = "";
            while (woord < woorden.Length) {
                if (regel.Length + 1 + woorden[woord].Length < maxRegelLen) {
                    regel = $"{regel} {woorden[woord]}";
                }
                else {
                    regels.Add(regel);
                    regel = woorden[woord];
                }
                woord++;
            }
            if (regel != "") {
                regels.Add(regel);    
            }
            return regels;
        }
    }
    class Vektis {
        public static string Datum(string input) {
            return input;
        }
    }
}