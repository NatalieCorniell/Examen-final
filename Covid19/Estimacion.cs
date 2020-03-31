using System;
namespace Covid19
{
    public class Estimacion
    {

        public static void EstimacionGeneral()
        {

            var CasosAnteriores = CasoAnterior.Casos;
            Console.WriteLine("\t\t ##############################");
            Console.WriteLine("\t\t ## Estimación: " + casos + "##");
            Console.WriteLine("\t\t ##############################");


        }
        /* public static void EstimacionActual()
         {
              var dia = DateTime.Today;
              var yesterday = dia.AddDays(-1);

              int countCasos = 1;
              foreach (RegistroCasos casos in RegistroCasos.Informacion)
              {
                  Console.WriteLine(countCasos + " - Casos dia anterior" +
                                          " - Casos registardos:" + casos.CasosRegistrados + " .\n" +
                                          " - Dia: " + casos.Dia.AddDays(-1) + " .\n");


                  countCasos++;
                  double casosTotalRegistrados = casos.CasosRegistrados += casos.CasosRegistrados;


                  CRUD.GetElement(RegistroCasos.Informacion,);

              double Cantidad_Actual = CasosActuales._CasosActuales;// ;
              double Cantidad_Anterior = casosTotalRegistrados; //CasosRegistrados;
              double Factor_Contagio = 0;
              double Estimacion = 0;

              Factor_Contagio = Cantidad_Actual / Cantidad_Anterior;
              Estimacion = Factor_Contagio * Cantidad_Actual;
              var total = Math.Round(Estimacion);
         }

         }
         public static void EstimacionAnterior()
         {
             /*  var dia = DateTime.Today;
              var yesterday = dia.AddDays(-1);

              int countCasos = 1;
              foreach (RegistroCasos casos in RegistroCasos.Informacion)
              {
                  Console.WriteLine(countCasos + " - Casos dia anterior" +
                                          " - Casos registardos:" + casos.CasosRegistrados + " .\n" +
                                          " - Dia: " + casos.Dia.AddDays(-1) + " .\n");


                  countCasos++;
                  double casosTotalRegistrados = casos.CasosRegistrados += casos.CasosRegistrados;


                  CRUD.GetElement(RegistroCasos.Informacion,);

                  Console.WriteLine("\t\t ##############################");
                  Console.WriteLine("\t\t ## Estimación: " + casos + "##");
                  Console.WriteLine("\t\t ##############################");


              double Cantidad_Actual = CasosActuales._CasosActuales;// ;
              double Cantidad_Anterior = casosTotalRegistrados; //CasosRegistrados;
              double Factor_Contagio = 0;
              double Estimacion = 0;

              Factor_Contagio = Cantidad_Actual / Cantidad_Anterior;
              Estimacion = Factor_Contagio * Cantidad_Actual;
              var total = Math.Round(Estimacion);
         }

         }
        */
    }
}
