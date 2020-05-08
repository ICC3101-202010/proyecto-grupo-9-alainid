using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Collections.Generic;

namespace Proyecto
{
    
    public static class ALAINID
    {
        public static List<User> listausuarios = new List<User>();
        static void Almacenar(List<User> u)      //Serializamos
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Usuarios2.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, u);
            stream.Close();
        }
        static void Cargar(List<User> p)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Usuarios2.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
            p = (List<User>)formatter.Deserialize(stream);
            stream.Close();
        }
        public static bool Agregarusuarioalalista(User u1)
        {
            for (int i = 0; i < listausuarios.Count; i++)
            {

                User ui = listausuarios[i];

                if (ui.Email == u1.Email)
                {
                    Console.WriteLine("Ya existe una cuenta con este email");
                    return false;
                }
                if (ui.NombreUsuario == u1.NombreUsuario)
                {
                    Console.WriteLine("Ya existe este nombre de usuario, pruebe con otro");
                    return false;
                }

            }

            listausuarios.Add(u1);
            Console.WriteLine("Usuario correctamente registrado");
            Cargar(listausuarios);
            Almacenar(listausuarios);
            Thread.Sleep(2000);
            return true;
        }
        public static bool Ingresaralaapp(string email, string password)
        {
            bool usuarioencontrado = false;
            User ui = null;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                ui = listausuarios[j];
                if (ui.Email == email)
                {
                    usuarioencontrado = true;
                    break;

                }



            }
            if (usuarioencontrado == true)
            {
                if (ui.Password != password)
                {
                    Console.WriteLine("Incorrect Password");

                    return false;

                }
                else
                {
                    Console.WriteLine("Ingresando a ALAINID...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Bievenido" + "\n" + ui.Nombre);
                    Thread.Sleep(3000);
                    return true;
                }

            }
            else
            {
                Console.WriteLine("Email not found");
                return false;
            }


        }
        static void VerPersonas(List<User> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay personas agregadas aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Usuario" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].InformacionUsuario());
                    Console.WriteLine(" ");

                }
            }


        }
    }

}

