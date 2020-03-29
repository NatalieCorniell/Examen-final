using System;
using System.Collections.Generic;

namespace Covid19
{
    public class Datos
    {
        public string NombreProvinicia { get; set; }
        public double Casos { get; set; }
        public double Fallecidos { get; set; }
        public double Recuperados { get; set; }
        public double Variacion { get; set; }
        public DateTime Dia { get; set; }

    }
}
