using System;
using System.Collections.Generic;
using System.Linq;

namespace Covid19
{
    public class MainClass
    {
        public static List<string> _ListadoPronvincias = new List<string>();
        public static List<Datos> _Pronvincias = new List<Datos>();
        public static List<string> _PronvinciasValidation = new List<string>();
        public static List<string> _Dias = new List<string>();
        public static double CasosRegistrados { get; set; }

        public static readonly SerializeController serializeController = new SerializeController();

        public static void Main(string[] args)
        {
            Menu_Admin();
        }
        public static void Menu_Admin()
        {            

            _ListadoPronvincias = (List<string>)serializeController.DesSerialize("_ListadoPronvincias", "_ListadoPronvincias.dat");
            _PronvinciasValidation = (List<string>)serializeController.DesSerialize("_PronvinciasValidation", "_PronvinciasValidation.dat");
            _Pronvincias = (List<Datos>)serializeController.DesSerialize("_Pronvincias", "_Pronvincias.dat");
            _Dias = (List<string>)serializeController.DesSerialize("_Dias", "_Dias.dat");
            CasosRegistrados = (double)serializeController.DesSerialize("CasosRegistrados", "CasosRegistrados.dat");


            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t Menu Principal \n");
                Console.WriteLine("\t\t 1. Registrar día.");
                Console.WriteLine("\t\t 2. Ver estadística. \n");
                try
                {
                    Console.Write("\t Ingrese el número segun la opcion deseada: ");
                    int Menu = Convert.ToInt32(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:
                            RegistrarDia();
                            break;
                        case 2:
                            VerEstadisticas(true);
                            break;
                        default:
                            Menu_Admin();
                            break;
                    }
                }
                catch (Exception)
                {
                    Menu_Admin();
                }
            }
        }
        public static void RegistrarDia()
        {
            try
            {
                Console.Clear();

                var dia = DateTime.Today;
                Console.Write("\t\t  COVID-19: ");

                MostrarProvincias();
                Console.Write("\n\t\t Seleccione la provincia: ");
                int IndexNombreProvincia = Convert.ToInt32(Console.ReadLine());

                var indexx = IndexNombreProvincia;

                string NombreProvincia = CRUD.GetElement(_ListadoPronvincias, indexx - 1);

                Console.WriteLine("\n\n\t Llene los campos ");
                Console.Write("\t Casos: ");
                double casos = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t Fallecidos: ");
                double fallecidos = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t Recuperados: ");
                double recuperados = Convert.ToDouble(Console.ReadLine());

                string diaexacto = ("Dia:  " + dia.Day + " del mes " + dia.Month);
                Console.WriteLine("\n\n\t " + diaexacto);

                string DiaRegistrado = "Dia: " + diaexacto + "Provincia Registrada: " + NombreProvincia;

                if (NombreProvincia == "" || casos < 0 || fallecidos < 0 || recuperados == null)
                {
                    Console.WriteLine("\n\t Debe llenar todos los campos. \n ");
                    Console.ReadKey();
                    RegistrarDia();
                }
                else
                {

                    if (Validation(DiaRegistrado))
                    {
                        CRUD.Add(_Dias, DiaRegistrado);
                        CRUD.Add(_PronvinciasValidation, NombreProvincia);
                        Datos datos = new Datos
                        {
                            NombreProvinicia = NombreProvincia,
                            Casos = casos,
                            Fallecidos = fallecidos,
                            Recuperados = recuperados,
                            Dia = dia
                        };
                      CRUD.Add(_Pronvincias, datos);
                        CasosRegistrados =  datos.Casos;

                    }
                    else
                    {
                        Console.WriteLine("\t\t ERROR: Esta provincia ya ha sido registrada. \n");
                        Console.ReadKey();
                        Menu_Admin();
                    }

                }

                if (_Pronvincias.Count != 0)
                {
                    Console.WriteLine("\t\t REGISTRO ALMACENADO\n");

                    Console.Write("\n\t\t Desea agregar ptra provincia? S/N : ");
                    string seleccion = Console.ReadLine();
                    if (seleccion == "s")
                    {
                        RegistrarDia();
                    }
                    Console.ReadKey();
                    Menu_Admin();

                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("\n\n \t\t ERROR!! \n");
                Console.ReadKey();
                RegistrarDia();
            }
        }
        public static bool Validation(string Elements)
        {
            bool valid = true;
            foreach (string element in _Dias)
            {
                if (element == Elements)
                {
                    valid = false;
                }
            }

            return valid;
        }
        public static void MostrarProvincias(bool IsWait = false)
        {
            _ListadoPronvincias.Add("Azua");
            _ListadoPronvincias.Add(" Bahoruco");
            _ListadoPronvincias.Add(" Barahona");
            _ListadoPronvincias.Add(" Dajabón");
            _ListadoPronvincias.Add(" Distrito");
            _ListadoPronvincias.Add(" Duarte");
            _ListadoPronvincias.Add(" ElíasPiña");
            _ListadoPronvincias.Add(" ElSeiboo");
            _ListadoPronvincias.Add(" Espaillat");
            _ListadoPronvincias.Add(" HatoMayor");
            _ListadoPronvincias.Add(" HermanasMirabal");
            _ListadoPronvincias.Add(" Independencia");
            _ListadoPronvincias.Add(" LaAltagracia");
            _ListadoPronvincias.Add(" LaRomana");
            _ListadoPronvincias.Add(" LaVega");
            _ListadoPronvincias.Add(" MaríaTrinidadSánchez");
            _ListadoPronvincias.Add(" MonseñorNouel");
            _ListadoPronvincias.Add(" MonteCristi");
            _ListadoPronvincias.Add(" MontePlatata");
            _ListadoPronvincias.Add(" Pedernales");
            _ListadoPronvincias.Add(" Peravia");
            _ListadoPronvincias.Add(" PuertoPlata");
            _ListadoPronvincias.Add(" Samaná");
            _ListadoPronvincias.Add(" SanCristóbal");
            _ListadoPronvincias.Add(" SanJosédeOcoa");
            _ListadoPronvincias.Add(" SanJuan");
            _ListadoPronvincias.Add(" SanPedrodeMacorís");
            _ListadoPronvincias.Add(" SánchezRamírez");
            _ListadoPronvincias.Add(" Santiago");
            _ListadoPronvincias.Add(" SantiagoRodríguez");
            _ListadoPronvincias.Add(" SantoDomingo");
            _ListadoPronvincias.Add(" Valverde");

            Console.WriteLine("\n\t Listado de Provincias: ");
            int count = 1;
            foreach (string Element in _ListadoPronvincias)
            {
                Console.WriteLine(count + "-" + Element + ".\n");
                count++;
            }
            if (IsWait)
            {
                Console.ReadKey();
            }
        }
        public static void VerEstadisticas(bool IsWait = false)
        {
            Console.Clear();
            Console.WriteLine("\n\t ESTADÍSTICAS: -Listado de Provincias- \n");
            int count1 = 1;

            foreach (Datos Element in _Pronvincias)
            {
                Console.WriteLine(" Fecha de registro:  " + Element.Dia.Day + "/"+ Element.Dia.Month+ "/"+ Element.Dia.Year + " .\n ");

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
            Estimacion();
            if (IsWait)
            {
                Console.ReadKey();
            }

        }
        public static void Estimacion()
        {
                double Cantidad_Actual = CasosRegistrados;
                double Cantidad_Anterior = CasosRegistrados;
                double Factor_Contagio = 0;
                double Estimacion = 0;

                Factor_Contagio = Cantidad_Actual / Cantidad_Anterior;
                Estimacion = Factor_Contagio * Cantidad_Actual;
                var total = Math.Round(Estimacion);

                Console.WriteLine("\t\t ##############################");
                Console.WriteLine("\t\t ## Estimación: " + total + "##");
                Console.WriteLine("\t\t ##############################");
        }
    }
}

