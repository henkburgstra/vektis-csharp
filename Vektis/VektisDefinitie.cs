using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Vektis {
	/// <summary>
	/// Definitie van een Vektis-standaard.
	/// Een definitie bestaat uit de standaardnaam, versie en een verzameling recorddefinities.
	/// </summary>
	public class VektisDefinitie {
        public string Standaard { get; set; } = "";
        public string Versie { get; set; } = "";
        public VektisConfig Config { get; set; } = new VektisConfig();
        public Dictionary<string, RecordDefinitie> Recorddefinities { get; set; } = new Dictionary<string, RecordDefinitie>(); 

        public override string ToString() {
            return String.Join("\r\n", 
                from recorddefinitie
                in Recorddefinities.Values
                select recorddefinitie.ToString());
        }

        public RecordDefinitie GetRecordefinitie(string naam) {
            Recorddefinities.TryGetValue(naam, out RecordDefinitie value);
            return value;
        }

        public string GetBestandsnaam() {
            // TODO: implementatie
            return "/Users/henkburgstra/projecten/Vektis/ZH308v9.0_BERu2.xls";
        }

        public void LaadSpecificatie() {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var skipSheets = 0;
            var skipRows = 0;
            var colspec = Config.Colspec;

            using (var stream = File.Open(GetBestandsnaam(), FileMode.Open, FileAccess.Read)) {

                using (var reader = ExcelReaderFactory.CreateReader(stream)) {

                    // Ga naar de juiste sheet
                    while (skipSheets < Config.Sheet) {
                        reader.NextResult();
                        skipSheets++;
                    }
                    while (reader.Read()) {
                        // Ga naar de juiste rij
                        if (skipRows < Config.StartRow) {
                            skipRows++;
                            continue;
                        }
                        var recordtype = reader.GetString(colspec[VektisConfig.RECORDTYPE]);
                        if (recordtype == null || recordtype == "") break;
                        var recordcode = reader.GetString(colspec[VektisConfig.RECORDCODE]);
                        var recordlengte = Convert.ToInt32(reader.GetDouble(colspec[VektisConfig.LENGTE]));
                        var recorddefinitie = GetRecordefinitie(recordtype);
                        if (recorddefinitie == null) {
                            recorddefinitie = new RecordDefinitie{Recordtype=recordtype, Recordcode=recordcode};
                            Recorddefinities[recordtype] = recorddefinitie;
                        }
                        var eindpos = 0;
                        if (colspec[VektisConfig.EINDPOSITIE] >= 0) {
                            eindpos = Convert.ToInt32(reader.GetDouble(colspec[VektisConfig.EINDPOSITIE])); 
                        }                        
                        else {
                            eindpos = Convert.ToInt32(reader.GetDouble(colspec[VektisConfig.BEGINPOSITIE])) + recordlengte - 1;
                        }

                        recorddefinitie.Velddefinities.Add(
                            new VeldDefinitie {
                                Volgnummer = Convert.ToInt32(reader.GetDouble(colspec[VektisConfig.VOLGNUMMER])),
                                Naam = reader.GetString(colspec[VektisConfig.NAAM]),
                                Veldtype = reader.GetString(colspec[VektisConfig.VELDTYPE]),
                                Lengte = Convert.ToInt32(reader.GetDouble(colspec[VektisConfig.LENGTE])),
                                Verplichting = reader.GetString(colspec[VektisConfig.VERPLICHTING]),
                                Eindpositie = eindpos,
                                Patroon = reader.GetString(colspec[VektisConfig.PATROON]),
                                Beschrijving = reader.GetString(colspec[VektisConfig.BESCHRIJVING])
                            }
                        );
                    }                
                }
            }            

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordtype"></param>
        /// <returns></returns>
        protected string ClassnameFromRecordtype(string recordtype) {
            var className = recordtype.ToLower();
            return $"{Char.ToUpper(className[0])}{className.Substring(1)}_{Versie.Replace(".", "_")}";
        }
        protected string GenereerClassBroncode(RecordDefinitie recorddefinitie, string srcNamespace, string dataClass) {
            var regels = new List<string>();
            regels.Add("using System;");
            if (srcNamespace != "Vektis") {
                regels.Add("using Vektis;");
            }
            regels.Add("");
            regels.Add($"namespace {srcNamespace} {{");
            var classname = ClassnameFromRecordtype(recorddefinitie.Recordtype);
            regels.Add($"\tpublic class {classname}: VektisData {{");
            foreach(VeldDefinitie d in recorddefinitie.Velddefinities) {
                regels.Add("\t\t/// <summary>");
                regels.Add($"\t\t/// {d.Beschrijving}");  // TODO: opsplitsen in regels
                regels.Add("\t\t/// </summary>");
                var dt = d.CSharpDatatype();
                var ret = "\"\"";
                if (dt == "int") {
                    ret = "0";
                }
                regels.Add($"\t\tpublic {dt} {d.Naam}() {{");
                regels.Add($"\t\t\treturn {ret};");
                regels.Add("\t\t}");
            }
            regels.Add("\t}");
            regels.Add("}");

            return String.Join("\r\n", regels);
        }

        protected void SchrijfClass(string map, string className, string source) {
            var bestandsnaam = Path.Combine(map, $"{className}.cs");
            System.IO.File.WriteAllText(bestandsnaam, source);
        }

        public void Scaffold(string map, string srcNamespace, Dictionary<string, string> dataClasses) {
            if (Recorddefinities.Count == 0) {
                LaadSpecificatie();
            }
            dataClasses.TryGetValue("DEFAULT", out string defaultDataClass);
            if (defaultDataClass == null || defaultDataClass == "") {
                defaultDataClass = "Nota";
            }
            foreach (string recordtype in Recorddefinities.Keys) {
                var recorddefinitie = Recorddefinities[recordtype];
                dataClasses.TryGetValue(recordtype, out string dataClass);
                if (dataClass == null || dataClass == "") {
                    dataClass = defaultDataClass;
                }
                var source = GenereerClassBroncode(recorddefinitie, srcNamespace, dataClass);
                SchrijfClass(map, ClassnameFromRecordtype(recorddefinitie.Recordtype), source);
            }

        }


    }
    
}