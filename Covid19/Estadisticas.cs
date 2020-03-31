using System;
namespace Covid19
{
    public class Estadisticas
    {
        public static void VerEstadisticaActual(bool IsWait = false)
        {
            _ = DateTime.Today;
            int count1 = 1;

            foreach (CasoActual Element in CasoActual._Pronvincias)
            {

                if (Element.Variacion <= 0)
                {
                    Console.WriteLine(count1 + " " + Element.NombreProvinicia + " .\n" +
                                        " - Casos registardos:" + Element.Casos + " .\n" +
                                        " - Fallecidos: " + Element.Fallecidos + " .\n" +
                                        " - Recuperados: " + Element.Recuperados + " .\n" +
                                        " - Variacion: No hubo variación .\n");
                }
                else
                {
                    Console.WriteLine(count1 + " " + Element.NombreProvinicia + " .\n" +
                                          " - Casos registardos:" + Element.Casos + " .\n" +
                                          " - Fallecidos: " + Element.Fallecidos + " .\n" +
                                          " - Recuperados: " + Element.Recuperados + " .\n" +
                                          " - Variacion: " + Element.Variacion + " .\n");
                }

                count1++;
            }
            //Estimacion();
            if (IsWait)
            {
                Console.ReadKey();
            }

        }
        public static void VerEstadisticaAnterior(bool IsWait = false)
        {
             int count1 = 1;

            foreach (CasoAnterior Element in CasoAnterior._Pronvincias)
            {
                Console.WriteLine(" Fecha de registro:  " + Element.Dia.Day + "/" + Element.Dia.Month + "/" + Element.Dia.Year + " .\n ");

                if (Element.Variacion <= 0)
                {
                    Console.WriteLine(count1 + " " + Element.NombreProvinicia + " .\n" +
                                        " - Casos registardos:" + Element.Casos + " .\n" +
                                        " - Fallecidos: " + Element.Fallecidos + " .\n" +
                                        " - Recuperados: " + Element.Recuperados + " .\n" +
                                        " - Variacion: No hubo variación .\n");
                }
                else
                {
                    Console.WriteLine(count1 + " " + Element.NombreProvinicia + " .\n" +
                                          " - Casos registardos:" + Element.Casos + " .\n" +
                                          " - Fallecidos: " + Element.Fallecidos + " .\n" +
                                          " - Recuperados: " + Element.Recuperados + " .\n" +
                                          " - Variacion: " + Element.Variacion + " .\n");
                }

                count1++;
            }
            //Estimacion();
            if (IsWait)
            {
                Console.ReadKey();
            }

        }
        public static void VerEstadisticaGeneral(bool IsWait = false)
        {
            Console.Clear();

            Console.WriteLine("\n\t ()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()() \n");
            Console.WriteLine("\n\t ()()()() ESTADÍSTICAS: -Listado dia de hoy y su fecha- ()()()() \n");
            Console.WriteLine("\n\t ()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()() \n");


            VerEstadisticaActual(true);


            Console.WriteLine("\n\t Click - para ver las del dia anterior \n");

            Console.WriteLine("\n\t ()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()() \n");
            Console.WriteLine("\n\t ()()()() ESTADÍSTICAS: -Listado dia Anterior y su fecha- ()()()() \n");
            Console.WriteLine("\n\t ()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()() \n");

            VerEstadisticaAnterior(true);

            Console.WriteLine("\n\tC lick - para Volver al menú principal \n");

        }
    }
}
