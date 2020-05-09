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
        public static List<Song> todas_las_canciones = new List<Song>();
        public static List<Video> todos_los_videos = new List<Video>();
        public static List<Artista> lista_actores = new List<Artista>();
        public static List<Artista> lista_directores = new List<Artista>();
        public static List<Artista> lista_cantanes = new List<Artista>();
        public static List<Artista> lista_compositores = new List<Artista>();
        public static List<Song> favorite_songs = new List<Song>();
        public static List<Video> favorite_videos = new List<Video>();


        static void Almacenar(List<User> u)      //Serializamos
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Usuarios2.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, u);
            stream.Close();
        }
        static List<User> Cargar()
        {
            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("Usuarios2.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<User> p = (List<User>)formatter2.Deserialize(stream2);
            stream2.Close();
            return p;
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
            Almacenar(listausuarios);
            Console.WriteLine("Usuario correctamente registrado");
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
        public static void Partir()
        {
            AlmacenarCanciones(todas_las_canciones);
        }
        public static void Activarlista()
        {
            listausuarios = Cargar();
            
        }
        public static bool Cambiarcontrasena(string email, string contrasena, string nuevacontrasena)
        {
            string funko = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    if (listausuarios[i].password == contrasena)
                    {
                        listausuarios[i].password = nuevacontrasena;
                        Almacenar(listausuarios);
                        funko = "correcto";
                    }
                    else
                    {
                        funko = "noup";
                    }
                    break;
                }
                else
                {
                    funko = "noup";
                }
            }
            if (funko == "correcto")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Verinformacion(string email)
        {
            string funko = "";
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    info = listausuarios[j].InformacionUsuario();              
                    funko = "correcto";
                }               
            }
            if (funko == "correcto")
            {
                return info;
            }
            else
            {
                return info;
            }
        }
        public static bool Cambiarnombreusuario(string email, string contrasena, string nuevonombre)
        {
            string funko = "correcto";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    if (listausuarios[i].password == contrasena)
                    {
                        listausuarios[i].nombreusuario = nuevonombre;                    
                        Almacenar(listausuarios);
                        funko = "correcto";
                    }
                    else
                    {
                        funko = "noup";
                    }
                    break;
                }
                else
                {
                    funko = "noup";
                }
            }
            if (funko == "correcto")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Cambiarnombre(string email, string contrasena, string nuevonombre)
        {
            string funko = "correcto";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    if (listausuarios[i].password == contrasena)
                    {
                        listausuarios[i].nombre = nuevonombre;
                        funko = "correcto";
                        Almacenar(listausuarios);
                    }
                    else
                    {
                        funko = "noup";
                    }
                    break;
                }
                else
                {
                    funko = "noup";
                }
            }
            if (funko == "correcto")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void AlmacenarCanciones(List<Song> s)      //Serializamos
        {
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Canciones.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter3.Serialize(stream3, s);
            stream3.Close();
        }
        static List<Song> CargarCancion()
        {
            IFormatter formatter4 = new BinaryFormatter();
            Stream stream4 = new FileStream("Canciones.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Song> s = (List<Song>)formatter4.Deserialize(stream4);
            stream4.Close();
            return s;
        }
    }
}
