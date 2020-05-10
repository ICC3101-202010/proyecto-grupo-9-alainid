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
        public static List<User> listausuarios = new List<User>();       // TODOS LOS USUARIOS DE ALAINID
        public static List<Song> todas_las_canciones = new List<Song>();        // TODAS LAS CANCIONES EN ALAINID
        public static List<Video> todos_los_videos = new List<Video>();        // TODOS LOS VIDEOS EN ALAINID
        public static List<Artista> lista_actores = new List<Artista>();        // TODOS LOS ACTORES EN ALAINID
        public static List<Artista> lista_directores = new List<Artista>();        // TODOS LOS DIRECTORES EN ALAINID
        public static List<Artista> lista_cantantes = new List<Artista>();        // TODOS LOS CANTANTES EN ALAINID
        public static List<Artista> lista_compositores = new List<Artista>();        // TODOS LOS COMPOSITORES EN ALAINID
       
        public static List<Song> listafiltrada = new List<Song>();       // ?? ESTO NO SE Q ES????
        public static List<string> lista_generos_canciones = new List<string>();       // TODOS LOS GENEROS DE CANCIONES QUE EXISTEN DE ALAINID
        public static List<string> lista_generos_peliculas = new List<string>();       // TODOS LOS GENEROS DE VIDEOS QUE EXISTEN DE ALAINID
        public static List<string> lista_categoria = new List<string>();       // CATEGORIAS DE PELICULAS- VIDEOS EN ALAINID


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
        public static bool Hacerplaylist(string mail,string nombrepl)
        {
            string funkaa = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email == mail)
                {
                    PlaylistSong plysu = new PlaylistSong(nombrepl);
                    listausuarios[i].Lista_playlistusuario.Add(plysu);
                    Almacenar(listausuarios);
                    funkaa += "si";
                    
                }      
            }
            if (funkaa != "")
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public static string Vernombresplaylist(string email)
        {
            string info = "No hay Playlist";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    info = "Nombres de tus playlist: \n";
                    for (int i = 0; i < listausuarios[j].Lista_playlistusuario.Count; i++)
                    {
                        info += i + 1 + ". " + listausuarios[j].Lista_playlistusuario[i].NombrePlaylist + "\n";
                    }
                }
            }
            return info;
        }
        public static string VerinformacionPlaylist(string email, string nombreply)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistusuario.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistusuario[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistusuario[i].InformationPLL();
                            }

                        }
                    }
                }
            }
            return info;

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
        public static void VerPersonas(List<User> lista)
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
                    Console.WriteLine(lista[i].InformacionUsuariopriv());
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
        public static void Activarlistacanciones()
        {
            todas_las_canciones = CargarCancion();
        }
        public static void Activarlistavideos()
        {
            todos_los_videos = CargarVideos();
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
        public static bool GuardarUltimareproduccion(string email, string ultimareproduccion)
        {
            string funko = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    listausuarios[i].ultimareproduccion = ultimareproduccion;
                    Almacenar(listausuarios);
                    funko = "correcto";

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
        public static string UltimaReproduccion(string email)
        {
            string funko;
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    funko = listausuarios[i].ultimareproduccion;
                    return funko;
                }
                else
                {

                }

            }
            return "";


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
            Stream stream4 = new FileStream("Canciones.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            List<Song> s2 = (List<Song>)formatter4.Deserialize(stream4);
            stream4.Close();
            return s2;
        }

        public static void AlmacenarVideos(List<Video> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Videos.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Video> CargarVideos()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Videos.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Video> v = (List<Video>)formatter6.Deserialize(stream6);
            stream6.Close();
            return v;
        }
        public static void AlmacenarCantante(List<Artista> a)      //Serializamos
        {
            IFormatter formatter7 = new BinaryFormatter();
            Stream stream7 = new FileStream("Cantantes.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter7.Serialize(stream7, a);
            stream7.Close();
        }
        public static List<Artista> CargarCantantes()
        {
            IFormatter formatter8 = new BinaryFormatter();
            Stream stream8 = new FileStream("Cantantes.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Artista> ar = (List<Artista>)formatter8.Deserialize(stream8);
            stream8.Close();
            return ar;
        }
        public static List<Song> CancionesPorCriterio(string _criterio, string _valor)
        {
            listafiltrada.Clear();

            switch (_criterio)
            {
                case "Genero":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.genero == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "genero":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.genero == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Cantante":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.cantante == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "cantante":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.cantante == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Album":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.album == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "album":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.album == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Nombre":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.nombrecancion == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "nombre":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.nombrecancion == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Disquera":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.disquera == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "disquera":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.disquera == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Compositor":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.compositor == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "compositor":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.compositor == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "Año":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.anopublicacion == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;
                case "año":
                    foreach (Song _filtro in todas_las_canciones)
                    {
                        if (_filtro.anopublicacion == _valor)
                        {
                            listafiltrada.Add(_filtro);
                        }
                    }
                    break;


                default:
                    Console.WriteLine("No existen canciones que cumplan con el criterio y valor seleccionado");
                    break;
            }

            return listafiltrada;

        }
        public static void Vercancionesparareproduccion(List<Song> s)

        {

            if (s.Count == 0)
            {
                Console.WriteLine("No hay canciones agregadas aún");
            }

            else
            {
                for (int i = 0; i < s.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine(i+1+"-" + "Canción" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(s[i].nombrecancion);
                    Console.WriteLine(s[i].cantante);
                    Console.WriteLine(" ");
                    

                }
            }
        }
        


    }
}





