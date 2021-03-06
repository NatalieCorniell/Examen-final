﻿using System;
using System.Collections.Generic;


namespace Covid19
{
    [Serializable]
    public class Datos
    {
        //__________________________________AGENDAMIENTO ANTEORIOR______________________________________
        public static void RegistrarDiaAnterior()
        {
            try
            {
                Console.Clear();

                Console.Write("\t\t  COVID-19: ");

                MostrarProvincias();
                Console.Write("\n\t\t Seleccione la provincia: ");
                int IndexNombreProvincia = Convert.ToInt32(Console.ReadLine());

                var indexx = IndexNombreProvincia;

                string NombreProvincia = CRUD.GetElement(CasoAnterior._ListadoPronvincias, indexx - 1);

                Console.WriteLine("\n\n\t Llene los campos ");
                Console.Write("\t Casos: ");
                double casos = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t Fallecidos: ");
                double fallecidos = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t Recuperados: ");
                double recuperados = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t Dia -Nota:Favor utilizar este formato(mm/dd/yyyy) \n\t Ejemplo:(01/01/2020)  : ");
                DateTime dia = Convert.ToDateTime(Console.ReadLine());



                string diaexacto = ("Dia:  " + dia.Day + "/" + dia.Month + "/" + dia.Year);
                Console.WriteLine("\n\n\t " + diaexacto);

                string DiaRegistrado = "Dia: " + diaexacto + "Provincia Registrada: " + NombreProvincia;

                if (NombreProvincia == "" || casos < 0 || fallecidos < 0 || recuperados == null)
                {
                    Console.WriteLine("\n\t Debe llenar todos los campos. \n ");
                    Console.ReadKey();
                    RegistrarDiaAnterior();
                }
                else
                {

                    if (Validation(DiaRegistrado))
                    {
                        CRUD.Add(CasoAnterior._Dias, DiaRegistrado);
                        CRUD.Add(CasoAnterior._PronvinciasValidation, NombreProvincia);
                        CasoAnterior CA = new CasoAnterior
                        {
                            NombreProvinicia = NombreProvincia,
                            Casos = casos,
                            Fallecidos = fallecidos,
                            Recuperados = recuperados,
                            Dia = dia
                        };
                        CRUD.Add(CasoAnterior._Pronvincias, CA);

                        RegistroCasos registroCasos = new RegistroCasos
                        {
                            CasosAnterior = casos
                        };

                        RegistroCasos.TotalCasosAnterior.Add(casos);
                    }
                    else
                    {
                        Console.WriteLine("\t\t ERROR: Esta provincia ya ha sido registrada este dia. \n");
                        Console.ReadKey();
                        MenuAdmin.Menu_Admin();
                    }

                }

                if (CasoAnterior._Pronvincias.Count != 0)
                {
                    Console.WriteLine("\t\t REGISTRO ALMACENADO\n");

                    Console.Write("\n\t\t Desea agregar otra provincia? S/N : ");
                    string seleccion = Console.ReadLine();
                    if (seleccion == "s")
                    {
                        RegistrarDiaAnterior();
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
                RegistrarDiaAnterior();
            }
        }
        public static bool Validation(string Elements)
        {
            bool valid = true;
            foreach (string element in CasoAnterior._Dias)
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
            CasoAnterior._ListadoPronvincias.Add("Azua");
            CasoAnterior._ListadoPronvincias.Add(" Bahoruco");
            CasoAnterior._ListadoPronvincias.Add(" Barahona");
            CasoAnterior._ListadoPronvincias.Add(" Dajabón");
            CasoAnterior._ListadoPronvincias.Add(" Distrito");
            CasoAnterior._ListadoPronvincias.Add(" Duarte");
            CasoAnterior._ListadoPronvincias.Add(" ElíasPiña");
            CasoAnterior._ListadoPronvincias.Add(" ElSeiboo");
            CasoAnterior._ListadoPronvincias.Add(" Espaillat");
            CasoAnterior._ListadoPronvincias.Add(" HatoMayor");
            CasoAnterior._ListadoPronvincias.Add(" HermanasMirabal");
            CasoAnterior._ListadoPronvincias.Add(" Independencia");
            CasoAnterior._ListadoPronvincias.Add(" LaAltagracia");
            CasoAnterior._ListadoPronvincias.Add(" LaRomana");
            CasoAnterior._ListadoPronvincias.Add(" LaVega");
            CasoAnterior._ListadoPronvincias.Add(" MaríaTrinidadSánchez");
            CasoAnterior._ListadoPronvincias.Add(" MonseñorNouel");
            CasoAnterior._ListadoPronvincias.Add(" MonteCristi");
            CasoAnterior._ListadoPronvincias.Add(" MontePlatata");
            CasoAnterior._ListadoPronvincias.Add(" Pedernales");
            CasoAnterior._ListadoPronvincias.Add(" Peravia");
            CasoAnterior._ListadoPronvincias.Add(" PuertoPlata");
            CasoAnterior._ListadoPronvincias.Add(" Samaná");
            CasoAnterior._ListadoPronvincias.Add(" SanCristóbal");
            CasoAnterior._ListadoPronvincias.Add(" SanJosédeOcoa");
            CasoAnterior._ListadoPronvincias.Add(" SanJuan");
            CasoAnterior._ListadoPronvincias.Add(" SanPedrodeMacorís");
            CasoAnterior._ListadoPronvincias.Add(" SánchezRamírez");
            CasoAnterior._ListadoPronvincias.Add(" Santiago");
            CasoAnterior._ListadoPronvincias.Add(" SantiagoRodríguez");
            CasoAnterior._ListadoPronvincias.Add(" SantoDomingo");
            CasoAnterior._ListadoPronvincias.Add(" Valverde");

            Console.WriteLine("\n\t Listado de Provincias: ");
            int count = 1;
            foreach (string Element in CasoAnterior._ListadoPronvincias)
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
