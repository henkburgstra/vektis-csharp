using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        public static readonly Regex reDdmmjjjj = new Regex(@"^(\d{1,2})-(\d{1,2})-(\d{4})$");
        public static readonly Regex reJjjjmmdd = new Regex(@"^(\d{4})-(\d{1,2})-(\d{1,2})$");
        public static int Datum(string input) {
            var match = reDdmmjjjj.Match(input);
            if (match.Success) {
                return Int32.Parse($"{match.Groups[3].ToString()}{match.Groups[2].ToString().PadLeft(2, '0')}{match.Groups[1].ToString().PadLeft(2, '0')}");
            }
            match = reJjjjmmdd.Match(input);
            if (match.Success) {
                return Int32.Parse($"{match.Groups[1].ToString()}{match.Groups[2].ToString().PadLeft(2, '0')}{match.Groups[3].ToString().PadLeft(2, '0')}");
            }
            return 0;
        }
    }
}