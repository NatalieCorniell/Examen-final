using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace Covid19
{
    public class Menu
    {
        //public static double CasosRegistrados { get; set; }


                            
    public static readonly SerializeController serializeController = new SerializeController();

        public Menu()
        {
        }
        public static void Menu_Admin()
        {
            Datos datos = new Datos();


            if (File.Exists("DATABASE.dat"))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("DATABASE.dat", FileMode.Open, FileAccess.Read);

                datos = (Datos)formatter.Deserialize(stream);

                stream.Close();
            }


            try
            {
                //FileStream streamD = new FileStream("DATABASE.dat", FileMode.Open);
                // BinaryFormatter formatterD = new BinaryFormatter();
                //datos = (Datos)(formatterD.Deserialize(streamD));
               // datos = (Datos)serializeController.DesSerialize("DATABASE.dat");
                //datos = D_Datos ?? new Datos();

                // streamD.Close();
               
            }
            catch (Exception)
            {

                /* if (!Directory.Exists("DATABASE.dat"))
                 {
                     Directory.CreateDirectory("DATABASE.dat");

                 FileStream stream = new FileStream("DATABASE.dat", FileMode.Create);
                 ///BinaryFormatter formatter = new BinaryFormatter();

                 // datos = (Datos)serializeController.Serialize(datos, "DATABASE.dat");

               // serializeController.Serialize(datos, "DATABASE.dat");

                 //formatter.Serialize(stream, datos);
                 //stream.Close();



             }*/
               
            }
            /*
                        var D_ListadoPronvincias = (List<string>)serializeController.DesSerialize("D_ListadoPronvincias", "D_ListadoPronvincias.dat");
                        var D_PronvinciasValidation = (List<string>)serializeController.DesSerialize("D_PronvinciasValidation", "D_PronvinciasValidation.dat");
                        var D_Pronvincias = (List<Datos>)serializeController.DesSerialize("D_Pronvincias", "D_Pronvincias.dat");
                        var D_Dias = (List<string>)serializeController.DesSerialize("D_Dias", "D_Dias.dat");

                        Datos._ListadoPronvincias = D_ListadoPronvincias ?? new List<string>();
                        Datos._PronvinciasValidation = D_PronvinciasValidation ?? new List<string>();
                        Datos._Pronvincias = D_Pronvincias ?? new List<Datos>();
                        Datos._Dias = D_Dias ?? new List<string>();


                        CasosRegistrados = (double)serializeController.DesSerialize("CasosRegistrados", "CasosRegistrados.dat");
                         SerializeController();*/


            //  var D_Datos = (Datos)serializeController.DesSerialize("D_Datos", "D_Datos.dat");
            //  datos = D_Datos ?? new Datos();
            //var S_Datos = (Datos)serializeController.Serialize(datos, "D_Datos", "D_Datos.dat");
            //datos = S_Datos ?? new Datos();

            bool EXIT = true;

            while (EXIT)
            {
                Console.Clear();
                Console.WriteLine("\t\t Menu Principal \n");
                Console.WriteLine("\t\t 1. Registrar día.");
                Console.WriteLine("\t\t 2. Ver estadística. ");
                Console.WriteLine("\t\t 3. Finalizar Agendamiento. \n");

                try
                {
                    Console.Write("\t Ingrese el número segun la opcion deseada: ");
                    int Menu = Convert.ToInt32(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:

                            Datos.RegistrarDia();
                            break;
                        case 2:
                            Datos.VerEstadisticas(true);
                            break;
                        case 3:
                            IFormatter formatter = new BinaryFormatter();
                            Stream stream = new FileStream("DATABASE.dat", FileMode.Create, FileAccess.Write);

                            formatter.Serialize(stream, datos);
                            stream.Close();
                            EXIT = true;

                            break;
                        default:
                            Menu_Admin();
                            break;
                    }
                    if (EXIT)
                    {
                        break;
                    }
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("\n\n\t\t Gracias por utilizar este sistema");

                }
                catch (Exception) { Menu_Admin(); }

            }
        }
    }
}
