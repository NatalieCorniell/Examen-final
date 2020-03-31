using System;
namespace Covid19
{
    public class DatosActual
    {
        public static void RegistrarDiaActual()
        {
            try
            {
                Console.Clear();

                DateTime dia = DateTime.Today;


                Console.Write("\t\t  COVID-19: ");

                MostrarProvincias();
                Console.Write("\n\t\t Seleccione la provincia: ");
                int IndexNombreProvincia = Convert.ToInt32(Console.ReadLine());

                var indexx = IndexNombreProvincia;

                string NombreProvincia = CRUD.GetElement(CasoActual._ListadoPronvincias, indexx - 1);

                Console.WriteLine("\n\n\t Llene los campos ");
                Console.Write("\t Casos: ");
                double casos = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t Fallecidos: ");
                double fallecidos = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t Recuperados: ");
                double recuperados = Convert.ToDouble(Console.ReadLine());
               

                string diaexacto = ("Dia:  " + dia.Day + "/" + dia.Month + "/" + dia.Year);
                Console.WriteLine("\n\n\t " + diaexacto);

                string DiaRegistrado = "Dia: " + diaexacto + "Provincia Registrada: " + NombreProvincia;

                if (NombreProvincia == "" || casos < 0 || fallecidos < 0 || recuperados == null)
                {
                    Console.WriteLine("\n\t Debe llenar todos los campos. \n ");
                    Console.ReadKey();
                    RegistrarDiaActual();
                }
                else
                {

                    if (Validation(DiaRegistrado))
                    {
                        CRUD.Add(CasoActual._Dias, DiaRegistrado);
                        CRUD.Add(CasoActual._PronvinciasValidation, NombreProvincia);
                        CasoActual CA = new CasoActual
                        {
                            NombreProvinicia = NombreProvincia,
                            Casos = casos,
                            Fallecidos = fallecidos,
                            Recuperados = recuperados,
                            Dia = dia
                        };
                        CRUD.Add(CasoActual._Pronvincias, CA);

                        RegistroCasos registroCasos = new RegistroCasos
                        {
                            CasosActual = casos 
                        };

                       RegistroCasos.TotalCasosActual.Add(casos);
                        //CRUD.GetElement(RegistroCasos.Informacion, registroCasos);
                    }
                    else
                    {
                        Console.WriteLine("\t\t ERROR: Esta provincia ya ha sido registrada este dia. \n");
                        Console.ReadKey();
                        MenuAdmin.Menu_Admin();
                    }

                }

                if (CasoActual._Pronvincias.Count != 0)
                {
                    Console.WriteLine("\t\t REGISTRO ALMACENADO\n");

                    Console.Write("\n\t\t Desea agregar otra provincia? S/N : ");
                    string seleccion = Console.ReadLine();
                    if (seleccion == "s")
                    {
                        RegistrarDiaActual();
                    }

                    Console.ReadKey();
                    MenuAdmin.Menu_Admin();

                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("\n\n \t\t ERROR!! \n");
                Console.ReadKey();
                RegistrarDiaActual();
            }
        }
        public static bool Validation(string Elements)
        {
            bool valid = true;
            foreach (string element in CasoActual._Dias)
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
            CasoActual._ListadoPronvincias.Add("Azua");
            CasoActual._ListadoPronvincias.Add(" Bahoruco");
            CasoActual._ListadoPronvincias.Add(" Barahona");
            CasoActual._ListadoPronvincias.Add(" Dajabón");
            CasoActual._ListadoPronvincias.Add(" Distrito");
            CasoActual._ListadoPronvincias.Add(" Duarte");
            CasoActual._ListadoPronvincias.Add(" ElíasPiña");
            CasoActual._ListadoPronvincias.Add(" ElSeiboo");
            CasoActual._ListadoPronvincias.Add(" Espaillat");
            CasoActual._ListadoPronvincias.Add(" HatoMayor");
            CasoActual._ListadoPronvincias.Add(" HermanasMirabal");
            CasoActual._ListadoPronvincias.Add(" Independencia");
            CasoActual._ListadoPronvincias.Add(" LaAltagracia");
            CasoActual._ListadoPronvincias.Add(" LaRomana");
            CasoActual._ListadoPronvincias.Add(" LaVega");
            CasoActual._ListadoPronvincias.Add(" MaríaTrinidadSánchez");
            CasoActual._ListadoPronvincias.Add(" MonseñorNouel");
            CasoActual._ListadoPronvincias.Add(" MonteCristi");
            CasoActual._ListadoPronvincias.Add(" MontePlatata");
            CasoActual._ListadoPronvincias.Add(" Pedernales");
            CasoActual._ListadoPronvincias.Add(" Peravia");
            CasoActual._ListadoPronvincias.Add(" PuertoPlata");
            CasoActual._ListadoPronvincias.Add(" Samaná");
            CasoActual._ListadoPronvincias.Add(" SanCristóbal");
            CasoActual._ListadoPronvincias.Add(" SanJosédeOcoa");
            CasoActual._ListadoPronvincias.Add(" SanJuan");
            CasoActual._ListadoPronvincias.Add(" SanPedrodeMacorís");
            CasoActual._ListadoPronvincias.Add(" SánchezRamírez");
            CasoActual._ListadoPronvincias.Add(" Santiago");
            CasoActual._ListadoPronvincias.Add(" SantiagoRodríguez");
            CasoActual._ListadoPronvincias.Add(" SantoDomingo");
            CasoActual._ListadoPronvincias.Add(" Valverde");

            Console.WriteLine("\n\t Listado de Provincias: ");
            int count = 1;
            foreach (string Element in CasoActual._ListadoPronvincias)
            {
                Console.WriteLine(count + "-" + Element + ".\n");
                count++;
            }
            if (IsWait)
            {
                Console.ReadKey();
            }
        }
     
    }
}
