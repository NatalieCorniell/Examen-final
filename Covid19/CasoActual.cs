using System;
using System.Collections.Generic;

namespace Covid19
{
    public class CasoActual
    {
        public static List<string> _ListadoPronvincias = new List<string>();
        public static List<CasoActual> _Pronvincias = new List<CasoActual>();
        public static List<string> _PronvinciasValidation = new List<string>();
        public static List<string> _Dias = new List<string>();

        public string NombreProvinicia { get; set; }
        public double Casos { get; set; }
        public double Fallecidos { get; set; }
        public double Recuperados { get; set; }
        public double Variacion { get; set; }
        public DateTime Dia { get; set; }
    }
}
