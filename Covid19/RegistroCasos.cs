using System;
using System.Collections.Generic;
namespace Covid19
{
    public class RegistroCasos
    {

        public static List<double> TotalCasosAnterior = new List<double>();
        public static List<double> TotalCasosActual = new List<double>();

        public  double CasosAnterior { get; set; }
        public double CasosActual { get; set; }


        public static void Total()
        {

            double Total = 0;
            int count = 1;
            foreach (double Element in TotalCasosActual)
            {

                double suma = Element + Element;
                Console.WriteLine(count + "- Suma de casos-Actuales" + suma + ".\n");
                count++;
            }


            int count2  = 1;
            foreach (double Element in TotalCasosAnterior)
            {
                double suma = Element + Element;

                Console.WriteLine(count + "- Suma de casos-Anteriores" + suma +  ".\n");
                count2++;
            }

            

        }
        public static void AddCaso<T>(List<T> list, T item)
        {
            list.Add(item);
        }


    }

}
