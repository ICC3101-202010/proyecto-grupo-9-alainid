using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    public class Funciones
    {
        List<User> users = new List<User>();

        public int Numero(int o) // verifica que el input  sea un numero dentro del rango requerido
        {
            int n;
            bool aux0;
            do
            {
                string p;
                p = Console.ReadLine();
                aux0 = int.TryParse(p, out n);
                if (aux0 == false || n > o) { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS del 1 al {0}---", o); }
            } while (!aux0 || n > o);

            return n;
        }

        /*
        public string Palabra(string p)
        {
            List<char> abcdario = new List<char>{ 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            
            //string result = "";
            //char* abcdario =(33, 126);
            //char abcdario[26] = 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' ;

            for (int a = 0; a <= 25; a++)
            {
                for (int p = 0; p <= largo; p++)
                {
                    if (palabra[p] == abcdario[a])
                    {
                        t = t + 1;
                    }
                }
            }

            return algo;
        }*/


        /*
        public void Editar_datos(int c, int co)
        {
            switch (c)
            {
                case 1:
                    Console.WriteLine("Ingrese los datos personales del Cliente: \n");
                    Console.WriteLine("\nNombre: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nApellido: ");
                    string last = Console.ReadLine();
                    Console.WriteLine("\nId (Rut): ");
                    int id = Numero(999999999);
                    Console.WriteLine("\nFecha de Nacimiento (yyyy/MM/dd): ");
                    string formats = "yyyy/MM/dd";
                    string dateStrings = Console.ReadLine();
                    DateTime parsedDate; // duda con como funciona este comando
                    if (DateTime.TryParseExact(dateStrings, formats, null,
                                                System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                                System.Globalization.DateTimeStyles.AdjustToUniversal,
                                                out parsedDate))

                        Console.WriteLine("\nNacionalidad: ");
                    string nacion = Console.ReadLine();
                    clientes.Add(new Cliente(id, name, last, parsedDate, nacion));
                    break;

                case 2:
                    foreach (Cliente cl in clientes){
                        cl.Show_D();
                    }
                    break;

                case 3:
                    foreach (Producto produ in productos){
                        produ.Show_productos();

                    }
                    break;

                case 4: //HACER COMPRA, AGREGAR A HISTORIAL
                    

                case 5:
                    bool gg = true;
                    do
                    {
                        Console.WriteLine("\nIngrese el RUT del Cliente:\n");
                        int r = Numero(999999999);
                        foreach (Cliente cc in clientes)
                        {
                            if (cc.Id == r)
                            {
                                cc.Show_registro();
                            }
                            else
                            {
                                g = false;
                                Console.WriteLine("\n\nIngrese el RUT existente\n");

                            }

                        }
                    } while (!gg);
                    break;


            }
        }*/




    }
}


