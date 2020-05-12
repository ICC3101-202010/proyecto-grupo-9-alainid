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
        public static List<Song> listafiltrada2 = new List<Song>();
        public static List<Song> cancionfavoritabuscada = new List<Song>();
        public static List<Video> videofavoritobuscado = new List<Video>();
        public static List<Video> listafiltrada3 = new List<Video>();
        public static List<Song> listafiltrada = new List<Song>();       // ?? ESTO NO SE Q ES????
        public static List<User> listafiltradausuarios = new List<User>();
        public static List<string> lista_generos_canciones = new List<string>();// TODOS LOS GENEROS DE CANCIONES QUE EXISTEN DE ALAINID
        public static List<string> lista_disquera = new List<string>();
        public static List<string> lista_generos_peliculas = new List<string>();       // TODOS LOS GENEROS DE VIDEOS QUE EXISTEN DE ALAINID
        public static List<string> lista_calidad_cancion = new List<string>();       // TODAS LAS CALIDADES DE CANCIONES QUE SOPORTA EN  ALAINID
        public static List<string> lista_tipoarchivo_cancion = new List<string>();       // TODOS TIPOS DE ARCHIVO DE CANCIONES QUE SOPORTA  ALAINID
        public static List<string> lista_calidad_pelicula = new List<string>();      // TODAS LAS CALIDADES DE VIEOS QUE SOPORTA EN  ALAINID
        public static List<string> lista_tipoarchivo_pelicula = new List<string>();        // TODOS TIPOS DE ARCHIVO DE VIDEOS QUE SOPORTA  ALAINID
        public static List<string> lista_categoria = new List<string>();       // CATEGORIAS DE PELICULAS- VIDEOS EN ALAINID
        public static List<string> lista_criterios_filtro = new List<string>();       // CRITERIOS PARA FILTRAR LAS CANCIONES 
        public static List<string> lista_criterios_usuarios = new List<string>();       // CRITERIOS PARA BUSCAR USUARIOS
        public static List<PlaylistSong> todos_los_albumes = new List<PlaylistSong>();   // TODOS LOS ALBUMES DE ALAINID
        public static List<string> anios = new List<string>();
        public static List<string> sexo = new List<string>();
        public static List<string> edades = new List<string>();


        public static string Todo_a_minuscula(string pal)
        {
            string pal_minuscula;
            pal_minuscula = pal.ToLower();
            return pal_minuscula;
        }


        // Metodo para mostrar las opciones posibles
        public static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine(">Selecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }

        public static int Acceso_inicial()
        {  // verifica que el input  sea un numero dentro del rango requerido
            int n;
            bool aux1 = true;
            bool aux2 = true;
            do
            {
                aux2 = int.TryParse(Console.ReadLine(), out n);
                if (n == 1) { aux1 = false; }
                else if (n == 2) { aux1 = false; }
                else if (n == 3) { aux1 = false; }
                else if (n == 202023) { aux1 = false; }
                else { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS del 1 al {0}---", 3); }
            } while (aux1);
            return n;
        }
        public static int Numero(int o) // verifica que el input  sea un numero dentro del rango requerido
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
        public static bool Hacerplaylistsong(string mail, string nombrepl)
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
        public static bool Hacerplaylistvideo(string mail, string nombrepl)
        {
            string funkaa = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email == mail)
                {
                    PlaylistVideo playlist2 = new PlaylistVideo(nombrepl);
                    listausuarios[i].Lista_playlistvideousuario.Add(playlist2);
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
        public static string cachativa;
        public static void Retornaplaylistusuario(string email, string nombreply)
        {
            cachativa = "";
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
                                listafiltrada2 = listausuarios[j].Lista_playlistusuario[i].listplay;
                                if (listausuarios[j].Lista_playlistusuario[i].listplay.Count>0)
                                {
                                    cachativa = "si";
                                }
                                
                            }
                        }
                    }
                }
            }

        }
        public static void Retornaplaylistvideousuario(string email, string nombreply)
        {
            cachativa = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist == nombreply)
                            {
                                listafiltrada3 = listausuarios[j].Lista_playlistvideousuario[i].listplayvideo;
                                if (listausuarios[j].Lista_playlistvideousuario[i].listplayvideo.Count>0)
                                {
                                    cachativa = "si";
                                }
                            }
                        }
                    }
                }
            }

        }
        public static string Vernombresplaylistcancion(string email)
        {
            //List<String> lplaylist = new List<string>();
            string info = "No hay Playlist";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistusuario.Count > 0)
                    {
                        info = "Nombres de tus playlist: \n";
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario.Count; i++)
                        {
                            //lplaylist.Add(listausuarios[j].Lista_playlistusuario[i].NombrePlaylist);
                            info += i + 1 + ". " + listausuarios[j].Lista_playlistusuario[i].NombrePlaylist + "\n";
                        }
                    }

                }
            }
            return info;
        }
        public static string Vernombresplaylistvideo(string email)
        {
            //List<String> lplaylist = new List<string>();
            string info = "No hay Playlist";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        info = "Nombres de tus playlist: \n";
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario.Count; i++)
                        {
                            //lplaylist.Add(listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist);
                            info += i + 1 + ". " + listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist + "\n";
                        }
                    }

                }
            }
            return info;
        }
        public static string Numeroplaylistcancion(string email, int numerolista)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistusuario.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistusuario[numerolista-1].NombrePlaylist;

                    }

                }
            }
            return info;
        }
        public static int Cuantasplaylistcancion(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistusuario.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistusuario.Count;
                    }
                }
            }
            return info;
        }
        public static int Cuantasfavoritascancion(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].favorite_songs.Count > 0)
                    {
                        info = listausuarios[j].favorite_songs.Count;
                    }
                }
            }
            return info;
        }
        public static int Cuantasfavoritasvideo(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].favorite_videos.Count > 0)
                    {
                        info = listausuarios[j].favorite_videos.Count;
                    }
                }
            }
            return info;
        }
        public static void Cancionbuscada(string archivo)
        {
            for (int j = 0; j < todas_las_canciones.Count; j++)
            {
                if (todas_las_canciones[j].nombrearchivo == archivo)
                {
                    cancionfavoritabuscada.Clear();
                    cancionfavoritabuscada.Add(todas_las_canciones[j]);
                }
            }
        }
        public static void Videobuscado(string archivo)
        {
            for (int j = 0; j < todos_los_videos.Count; j++)
            {
                if (todos_los_videos[j].nombrearchivovideo == archivo)
                {
                    videofavoritobuscado.Clear();
                    videofavoritobuscado.Add(todos_los_videos[j]);
                }
            }
        }
        public static int Cuantasplaylistvideo(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistvideousuario.Count;
                    }
                }
            }
            return info;
        }
        public static string Numeroplaylistvideo(string email, int numerolista)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistvideousuario[numerolista-1].NombrePlaylist;
                       
                    }

                }
            }
            return info;
        }

        public static string Agregarcancionaply(string email, string posicion, Song cancion)
        {
            string info = "No se pudo agregar la cancion a la playlist";
            string funko = "";
            for (int j = 0; j < listausuarios.Count; j++){
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistusuario.Count > int.Parse(posicion) - 1)
                    {
                        listausuarios[j].Lista_playlistusuario[int.Parse(posicion) - 1].listplay.Add(cancion);
                        Almacenar(listausuarios);
                        funko = "si";
                    }

                }
            }
            if (funko == "si")
            {
                info = "Cancion correctamente agregada a la playlist";
            }
            return info;
        }
        public static string Agregarvideoaply(string email, string posicion, Video video)
        {
            string info = "No se pudo agregar el video a la playlist";
            string funko = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > int.Parse(posicion) - 1)
                    {
                        listausuarios[j].Lista_playlistvideousuario[int.Parse(posicion) - 1].listplayvideo.Add(video);
                        Almacenar(listausuarios);
                        funko = "si";
                    }
                }
            }
            if (funko == "si")
            {
                info = "Video correctamente agregado a la playlist";
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
        public static string VerinformacionPlaylistVideo(string email, string nombreply)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistvideousuario[i].InformationPLL();
                            }

                        }
                    }
                }
            }
            return info;

        }
        public static string Archivoreproducirply(string email, string nombreply, int posicion)
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
                                info = listausuarios[j].Lista_playlistusuario[i].listplay[posicion - 1].nombrearchivo;
                            }
                        }
                    }
                }
            }
            return info;
        }
        public static string ArchivoreproducirfavoritosCancion(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Favorite_songs.Count > 0)
                    {
                        info = listausuarios[j].Favorite_songs[posicion - 1].nombrearchivo;
                    }
                }
            }
            return info;
        }
        public static string ArchivoreproducirfavoritosVideo(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].favorite_videos.Count > 0)
                    {
                        info = listausuarios[j].favorite_videos[posicion - 1].nombrearchivovideo;
                    }
                }
            }
            return info;
        }
        public static string Archivoreproducirplyvideo(string email, string nombreply, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistvideousuario[i].listplayvideo[posicion - 1].nombrearchivovideo;
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
                if (ui.Email == "")
                {
                    Console.WriteLine("No se puede dejar vacio el mail");
                    return false;
                }
                if (u1.NombreUsuario == "")
                {
                    Console.WriteLine("No se puede dejar vacio el nombre de usuario");
                    return false;
                }
                if (u1.Password == "")
                {
                    Console.WriteLine("No se puede dejar vacia la contraseña");
                    return false;
                }
                if (u1.Nombre == "")
                {
                    Console.WriteLine("No se puede dejar vacio el nombre");
                    return false;
                }

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
                if (email == "")
                {
                    Console.WriteLine("No puede dejar el mail vacio");
                }
                if (password == "")
                {
                    Console.WriteLine("No puede dejar la contraseña vacia");
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
                    Console.WriteLine("\nIngresando a ALAINID...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Bievenido" + " " + ui.Nombre);
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
        //======================================================BINARIOCANTANTES=====================================================================================0000
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
        public static void Activarlistacantantes()
        {
            lista_cantantes = CargarCantantes();
        }
        //============================================================================================================================================================
        public static List<string> Lista_nombres_cantantes(){
            List<string> nombr = new List<string>();
            foreach (Artista cantante in lista_cantantes){
                nombr.Add(cantante.name);
            }
            return nombr;
        }
        public static List<string> Lista_nombres_canciones(){
            List<string> canc = new List<string>();
            foreach (Song cancion in todas_las_canciones){
                canc.Add(cancion.nombrecancion);
            }
            return canc;
        }

        public static List<string> Lista_nombres_albums(){
            List<string> alb = new List<string>();
            foreach (PlaylistSong album in todos_los_albumes){
                alb.Add(album.NombrePlaylist);
            }
            return alb;
        }
        public static List<string> Lista_nombres_compositores(){
            List<string> nombrc = new List<string>();
            foreach (Artista compositor in lista_compositores)
            {
                nombrc.Add(compositor.name);
            }
            return nombrc;
        }

        public static List<string> Lista_nombres_diectores()
        {
            List<string> nom_dir = new List<string>();
            foreach (Artista director in lista_directores)
            {
                nom_dir.Add(director.name);
            }
            return nom_dir;
        }

        public static List<string> Lista_nombres_actores()
        {
            List<string> nom_act = new List<string>();
            foreach (Artista actor in lista_actores)
            {
                nom_act.Add(actor.name);
            }
            return nom_act;
        }

        public static List<Artista> Lista_personas_jovenes() // menores de 25
        {
            List<Artista> per_jov = new List<Artista>();
            foreach (Artista actor in lista_actores){
                if (actor.age < 25){
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.age < 25)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.age < 25)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.age < 25)
                {
                    per_jov.Add(compositor);
                }
            }
            return per_jov;
        }

        public static List<Artista> Lista_personas_notan_jovenes() // 25 a 40
        {
            List<Artista> per_jov = new List<Artista>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.age >= 25 && actor.age<40)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.age >= 25 && director.age < 40)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.age >= 25 && cantante.age < 40)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.age >= 25 && compositor.age < 40)
                {
                    per_jov.Add(compositor);
                }
            }
            return per_jov;
        }

        public static List<Artista> Lista_personas_casiviejas() // 40 a 60
        {
            List<Artista> per_jov = new List<Artista>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.age >= 40 && actor.age < 60)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.age >= 40 && director.age < 60)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.age >= 40 && cantante.age < 60)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.age >= 40 && compositor.age < 60)
                {
                    per_jov.Add(compositor);
                }
            }
            return per_jov;
        }

        public static List<Artista> Lista_personas_viejas() // 60 o +
        {
            List<Artista> per_jov = new List<Artista>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.age >= 60)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.age >= 60)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.age >= 60)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.age >= 60)
                {
                    per_jov.Add(compositor);
                }
            }
            return per_jov;
        }

        public static List<Artista> Lista_artistas_mujeres()
        {
            List<Artista> per_jov = new List<Artista>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.sexo == "Femenino")
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.sexo == "Femenino")
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.sexo == "Femenino")
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.sexo == "Femenino")
                {
                    per_jov.Add(compositor);
                }
            }
            return per_jov;
        }

        public static List<string> Lista_nombre_hombres()
        {
            List<string> per_jov = new List<string>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.sexo == "Masculino")
                {
                    per_jov.Add(actor.name);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.sexo == "Masculino")
                {
                    per_jov.Add(director.name);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.sexo == "Masculino")
                {
                    per_jov.Add(cantante.name);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.sexo == "Masculino")
                {
                    per_jov.Add(compositor.name);
                }
            }
            return per_jov;
        }
        public static List<Artista> Lista_artistas_hombres()
        {
            List<Artista> artistas = new List<Artista>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.sexo == "Masculino")
                {
                    artistas.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.sexo == "Masculino")
                {
                    artistas.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.sexo == "Masculino")
                {
                    artistas.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.sexo == "Masculino")
                {
                    artistas.Add(compositor);
                }
            }
            return artistas;
        }

        public static List<Song> Lista_por_calidad_cancion(string calidad){ // busca todas las canciones de una calidad x
            List<Song> cali_ca = new List<Song>();
            foreach(Song ca in todas_las_canciones){
                if (ca.calidad == calidad){
                    cali_ca.Add(ca);
                }
             
            }
            return cali_ca;
        }

        public static List<string> Lista_por_calidad_video(string calidad){ // busca todos los videos de una calidad x
            List<string> cali_v = new List<string>();
            foreach (Video v in todos_los_videos)
            {
                if (v.calidad == calidad)
                {
                    cali_v.Add(v.nombre_video);
                }

            }
            return cali_v;
        }

        public static List<string> Lista_por_categoria_video(string categoria)
        {
            List<string> cat_v = new List<string>();
            foreach (Video v in todos_los_videos)
            {
                if (v.categoria == categoria)
                {
                    cat_v.Add(v.nombre_video);
                }
            }
            return cat_v;
        }

        public static List<string> Lista_genero_video(string genero)
        {
            List<string> gen_v = new List<string>();
            foreach (Video v in todos_los_videos)
            {
                if (v.genero == genero)
                {
                    gen_v.Add(v.nombre_video);
                }
            }
            return gen_v;
        }

        public static List<string> Lista_genero_cancion(string genero)
        {
            List<string> gen_c = new List<string>();
            foreach (Song s in todas_las_canciones)
            {
                if (s.genero == genero)
                {
                    gen_c.Add(s.nombrecancion);
                }
            }
            return gen_c;
        }


        public static List<Song> CancionesPorCriterio(string _criterio, string _valor)
        {     
            listafiltrada.Clear();
            switch (_criterio){
                case "Genero":
                    foreach (Song can in todas_las_canciones){
                        if (can.genero == _valor){
                            listafiltrada.Add(can);
                        }
                    }
                    break;
                case "Cantante":
                    foreach (Artista art in lista_cantantes){
                        if (art.name== _valor){
                            foreach  (Song can in art.lista_canciones){
                                listafiltrada.Add(can);
                            }
                        }
                    }
                    break;
                case "Album":
                    foreach(PlaylistSong alb in todos_los_albumes)
                    {
                        if(alb.NombrePlaylist == _valor)
                        {
                            foreach(Song canc in todas_las_canciones)
                            {
                                if (canc.album == alb.NombrePlaylist)
                                {
                                    listafiltrada.Add(canc);
                                }
                            }
                         
                        }
                    }
                    
                    break;
                case "Nombre":
                    foreach (Song canc in todas_las_canciones){
                        if (canc.nombrecancion == _valor){
                            listafiltrada.Add(canc);
                        }
                    }
                    break;
                case "Disquera":
                    foreach (Song canc in todas_las_canciones){
                        if (canc.disquera == _valor){
                            listafiltrada.Add(canc);
                        }
                    }
                    break;
                case "Compositor":
                    foreach (Artista art in lista_compositores){
                        if (art.name == _valor){
                            foreach (Song can in art.lista_canciones){
                                listafiltrada.Add(can);
                            }
                        }
                    }
                    break;
                case "Año Publicacion":
                    foreach (Song canc in todas_las_canciones){
                        if (int.Parse(canc.anopublicacion) == int.Parse(_valor)){
                            listafiltrada.Add(canc);// ver 
                        }
                    }
                    break;
                case "Sexo del Artista":
                    switch (_valor){
                        case "Masculino":
                            foreach (Song canc in todas_las_canciones)
                            {
                                foreach (Artista a in Lista_artistas_hombres())
                                {
                                    if (canc.cantante == a)
                                    {
                                        listafiltrada.Add(canc);
                                    }
                                }
                            }
                            break;
                        case "Femenino":
                            foreach (Song canc in todas_las_canciones)
                            {
                                foreach (Artista a in Lista_artistas_mujeres())
                                {
                                    if (canc.cantante == a)
                                    {
                                        listafiltrada.Add(canc);
                                    }
                                }
                            }
                            break;
                    }
                    break;
                    case "Edad del Artista":
                        switch (_valor){
                            case "Menores de 25 años":
                                foreach(Song canc in todas_las_canciones)
                                {
                                    foreach (Artista pp in Lista_personas_jovenes())
                                    {
                                        if (canc.cantante == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                        /*if (canc.compositor == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }*/
                                    }
                                }
                                break;
                            case "De 25 a 40 años":
                                foreach (Song canc in todas_las_canciones)
                                {
                                    foreach (Artista pp in Lista_personas_notan_jovenes())
                                    {
                                        if (canc.cantante == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                        /*if (canc.compositor == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }*/
                                    }
                                }
                                break;
                            case "De 40 a 60 años":
                                foreach (Song canc in todas_las_canciones)
                                {
                                    foreach (Artista pp in Lista_personas_casiviejas())
                                    {
                                        if (canc.cantante == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                        /*if (canc.compositor == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }*/
                                    }
                                }
                                break;
                            case "Mayores de 60":
                                foreach (Song canc in todas_las_canciones)
                                {
                                    foreach (Artista pp in Lista_personas_viejas())
                                    {
                                        if (canc.cantante == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                        /*if (canc.compositor == pp)
                                        {
                                            listafiltrada.Add(canc);
                                        }*/
                                    }
                                }
                                break;
                        }
                        break;
                    case "Calidad/Resolucion":
                        listafiltrada=Lista_por_calidad_cancion(_valor);
                        break;
                    case "Evaluacion":
                        //TERMINAR
                        break;
                    default:
                        Console.WriteLine("No existen canciones que cumplan con el criterio y valor seleccionado");
                        break;
            }
            return listafiltrada;
        }
        /*
        public static List<string> Criterios_multiples()
        {

        }
        */
        public static List<Song> Buqueda_multiple_canciones(string _criterio, string _valor)
        {
            List<Song> canciones_filtradas  = new List<Song>();


            //--------------------------------------------aqui arreglar
            return canciones_filtradas;
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
                    Console.WriteLine(i + 1 + "-" + "Canción" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(s[i].nombrecancion);
                    Console.WriteLine(s[i].cantante);
                    Console.WriteLine(" ");


                }
            }
        }
        public static string Seguirusuario(string email, User u)
        {
            string info = "error";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    listausuarios[i].user_seguidas.Add(u);
                    info = "Usuario seguido";
                    Almacenar(listausuarios);
                }
            }

            return info;
        }
        public static List<User> UsuariosPorCriterio(string _criterio, string _valor)
        {
            listafiltradausuarios.Clear();
            switch (_criterio)
            {
                case "Nombre":
                    foreach (User _filtro in listausuarios)
                    {
                        if ((_filtro.nombre == _valor) && (_filtro.perfipublico == "publico"))
                        {
                            listafiltradausuarios.Add(_filtro);
                        }
                    }
                    break;
                case "Email":
                    foreach (User _filtro in listausuarios)
                    {
                        if ((_filtro.email == _valor) && (_filtro.perfipublico == "publico"))
                        {
                            listafiltradausuarios.Add(_filtro);
                        }
                    }
                    break;
                case "Id":
                    foreach (User _filtro in listausuarios)
                    {
                        if ((_filtro.nombreusuario == _valor) && (_filtro.perfipublico == "publico"))
                        {
                            listafiltradausuarios.Add(_filtro);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("No existen Usuarioa PUBLICOS que cumplas con el criterio y valor seleccionado");
                    break;
            }
            return listafiltradausuarios;
        }
        public static void VerUsuariosbusqueda(List<User> s)
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Usuarios no encontrados ");
            }
            else
            {
                for (int i = 0; i < s.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine(i + 1 + "-" + "Usuario" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(s[i].nombreusuario);
                    Console.WriteLine(s[i].nombre);
                    Console.WriteLine(" ");
                }
            }
        }
        public static bool Cambiarprivacidadaprivado(string email, string contrasena)
        {
            string funko = "correcto";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    if (listausuarios[i].password == contrasena)
                    {
                        if (listausuarios[i].perfipublico == "privado")
                        {
                            Console.Clear();
                            Console.WriteLine("Ya eras privado anteriormente");
                            Thread.Sleep(2000);
                            funko = "noup";
                            break;
                        }
                        else
                        {
                            listausuarios[i].perfipublico = "privado";
                            funko = "correcto";
                            Almacenar(listausuarios);
                        }
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
        public static bool Cambiarprivacidapublico(string email, string contrasena)
        {
            string funko = "correcto";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    if (listausuarios[i].password == contrasena)
                    {
                        if (listausuarios[i].perfipublico == "publico")
                        {
                            Console.Clear();
                            Console.WriteLine("Ya eras publico anteriormente");
                            Thread.Sleep(2000);
                            funko = "noup";
                            break;
                        }
                        else
                        {
                            listausuarios[i].perfipublico = "publico";
                            funko = "correcto";
                            Almacenar(listausuarios);
                        }
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
        public static void Verinfodeunusuario(User u2)
        {
            Console.WriteLine(u2.InformacionUsuario());
        }
        public static void Verinfodeunacancion(Song s2)
        {
            Console.WriteLine(s2.Informacioncancion());
        }
        public static void Verinfodeunvideo(Video s2)
        {
            Console.WriteLine(s2.Ver_informacion());
        }

        public static void Crear_cantante()
        {
            int h = 0;
            Console.WriteLine("Ingrese el nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nacionalidad:");
            string nacion = Console.ReadLine();
            Console.WriteLine("Ingrese el Genero:\n" +
                 "1-> Masculino\n" +
                 "2-> Femenino\n");
            int gen = Numero(2); string genero = "";
            if (gen == 1) { genero = "Masculino"; }
            else if (gen == 2) { genero = "Femenino"; }
            Artista cantante = new Artista(nombre, edad, genero, nacion);
            foreach (Artista cant in lista_cantantes)
            {
                if (cant == cantante)
                {
                    Console.WriteLine("Este cantante ya existe\n");
                    h = 1;
                    break;
                }
            }
            if (h == 0)
            {
                lista_cantantes.Add(cantante);
                AlmacenarCantante(lista_cantantes);
                Console.WriteLine("Perfil del Cantante fue creado exitosamente.\n");
            }
        }

        public static bool Verificar_existencia_cantante(string cantante)
        {
            int h = 0, n2;
            foreach (Artista art in lista_cantantes)
            {
                if (art.name == cantante)
                {
                    h = 1;
                    return true;
                }
            }
            if (h == 0)
            {
                Console.WriteLine("El cantante ingresado no existe, que desea hacer:\n" +
                              "1--> Crear un perfil para el cantante\n" +
                              "2--> No Agregar la cancion\n");
                n2 = Numero(2);
                if (n2 == 1)
                {
                    Crear_cantante();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static void Crear_compositor()
        {
            int h = 0;
            Console.WriteLine("Ingrese el nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nacionalidad:");
            string nacion = Console.ReadLine();
            Console.WriteLine("Ingrese el Genero:\n" +
                "1-> Masculino\n" +
                "2-> Femenino\n");
            int gen = Numero(2); string genero = "";
            if (gen == 1) { genero = "Masculino"; }
            else if (gen == 2) { genero = "Femenino"; }
            Artista compositor = new Artista(nombre, edad, genero, nacion);
            foreach (Artista comp in lista_compositores)
            {
                if (comp == compositor)
                {
                    Console.WriteLine("Este compositor ya existe\n");
                    h = 1;
                    break;
                }
            }
            if (h == 0)
            {
                lista_compositores.Add(compositor);
                AlmacenarCompositores(lista_compositores);
                Console.WriteLine("Perfil del Compositor fue creado exitosamente.\n");
            }
        }

        public static bool Verificar_existencia_compositor(string compositor)
        {
            int h = 0, n2;
            foreach (Artista comp in lista_compositores)
            {
                if (comp.name == compositor)
                {
                    h = 1;
                    return true;
                }
            }
            if (h == 0)
            {
                Console.WriteLine("El compositor ingresado no existe, que desea hacer:\n" +
                              "1--> Crear un perfil para el Compositor\n" +
                              "2--> No Agregar la cancion\n");
                n2 = Numero(2);
                if (n2 == 1)
                {
                    Crear_compositor();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static void Crear_director()
        {
            int h = 0;
            Console.WriteLine("Ingrese el nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nacionalidad:");
            string nacion = Console.ReadLine();
            Console.WriteLine("Ingrese el Genero:\n" +
                "1-> Masculino\n" +
                "2-> Femenino\n");
            int gen = Numero(2); string genero = "";
            if (gen == 1) { genero = "Masculino"; }
            else if (gen == 2) { genero = "Femenino"; }
            Artista director = new Artista(nombre, edad, genero, nacion);
            foreach (Artista dir in lista_directores)
            {
                if (dir == director)
                {
                    Console.WriteLine("Este director ya existe\n");
                    h = 1;
                    break;
                }
            }
            if (h == 0)
            {
                lista_directores.Add(director);
                AlmacenarDirectores(lista_directores);
                Console.WriteLine("Perfil del Director fue creado exitosamente.\n");
            }
        }

        public static bool Verificar_existencia_director(string director)
        {
            int h = 0, n2;
            foreach (Artista dire in lista_directores)
            {
                if (dire.name == director)
                {
                    h = 1;
                    return true;
                }
            }
            if (h == 0)
            {
                Console.WriteLine("El Director ingresado no existe, que desea hacer:\n" +
                              "1--> Crear un perfil para el Director\n" +
                              "2--> No Agregar la cancion\n");
                n2 = Numero(2);
                if (n2 == 1)
                {
                    Crear_director();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static void Crear_actor()
        {
            int h = 0;
            Console.WriteLine("Ingrese el nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nacionalidad:");
            string nacion = Console.ReadLine();
            Console.WriteLine("Ingrese el Genero:\n" +
                 "1-> Masculino\n" +
                 "2-> Femenino\n");
            int gen = Numero(2); string genero = "";
            if (gen == 1) { genero = "Masculino"; }
            else if (gen == 2) { genero = "Femenino"; }
            Artista actor = new Artista(nombre, edad, genero, nacion);
            foreach (Artista act in lista_actores)
            {
                if (act == actor)
                {
                    Console.WriteLine("Este Actor ya existe");
                    h = 1;
                    break;
                }
            }
            if (h == 0)
            {
                lista_actores.Add(actor);
                AlmacenarActores(lista_actores);
                Console.WriteLine("Perfil del Actor fue creado exitosamente.\n");
            }
        }

        public static bool Verificar_existencia_actor(string actor)
        {
            int h = 0, n2;
            foreach (Artista ac in lista_actores)
            {
                if (ac.name == actor)
                {
                    h = 1;
                    return true;
                }
            }
            if (h == 0)
            {
                Console.WriteLine("El Actor ingresado no existe, que desea hacer:\n" +
                              "1--> Crear un perfil para el Actor\n" +
                              "2--> No Agregar la cancion\n");
                n2 = Numero(2);
                if (n2 == 1)
                {
                    Crear_director();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static void Crear_Album()
        {
            Console.WriteLine("Ingrese el nombre del Album:");
            string nombre = Console.ReadLine();
            PlaylistSong album = new PlaylistSong(nombre);
            todos_los_albumes.Add(album);
            AlmacenarAlbum(todos_los_albumes);
        }

        public static bool Verificar_exisitencia_Album(string nombre_album, string nombre_cantante)
        {
            int h = 0, n2;
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.name == nombre_cantante)
                {
                    foreach (PlaylistSong album in cantante.lista_album)
                    {
                        if (album.NombrePlaylist == nombre_album)
                        {
                            h = 1;
                            return true;
                        }
                    }
                }
                if (h == 0)
                {
                    Console.WriteLine("El Album ingresado no existe, que desea hacer:\n" +
                                  "1--> Crear un Album para {0}\n" +
                                  "2--> No Agregar la cancion\n", cantante.name);
                    n2 = Numero(2);
                    if (n2 == 1)
                    {
                        Crear_Album();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        //=======================PREMIUM======================================================================================================0
        public static bool VolversePremium(string email, string contrasena)
        {
            string funko = "correcto";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    if (listausuarios[i].password == contrasena)
                    {
                        if (listausuarios[i].premium == "premium")
                        {
                            Console.Clear();
                            Console.WriteLine("Ya estabas registrado como premium");
                            Thread.Sleep(2000);
                            funko = "noup";
                            break;
                        }
                        else
                        {
                            listausuarios[i].premium = "premium";
                            funko = "correcto";
                            Almacenar(listausuarios);
                        }

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
        public static void AlmacenarCompositores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Compositores.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Artista> CargarCompositores()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Compositores.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
            stream6.Close();
            return v;
        }
        public static void Partirlistacompositores()
        {
            lista_compositores = CargarCompositores();
        }
        public static void AlmacenarDirectores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Directores.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Artista> CargarDirectores()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Directores.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
            stream6.Close();
            return v;
        }
        public static void Partirlistadirectores()
        {
            lista_directores = CargarDirectores();
        }
        public static void AlmacenarActores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Actores.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Artista> CargarActores()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Actores.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
            stream6.Close();
            return v;
        }
        public static void Partirlistaactores()
        {
            lista_actores = CargarActores();
        }
        public static void AlmacenarAlbum(List<PlaylistSong> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Albums.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<PlaylistSong> CargarAlbum()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("Albums.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<PlaylistSong> v = (List<PlaylistSong>)formatter6.Deserialize(stream6);
            stream6.Close();
            return v;
        }
        public static void Partirlistaalbumes()
        {
            todos_los_albumes = CargarAlbum();
        }
        public static void Agregar_a_favoritos(string email, Song s)
        {
            string funka = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email == email)
                {
                    listausuarios[i].favorite_songs.Add(s);
                    Almacenar(listausuarios);
                    funka += "si";

                }
            }
            if (funka != "")
            {
                Console.WriteLine("CANCION AGREGADA CORRECTAMENTE A FAVORITOS");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("LA CANCION NO PUDO AGREGARSE A FAVORITOS");
                Thread.Sleep(2000);
            }
        }
        public static void Agregar_video_a_favoritos(string email, Video s)
        {
            string funka = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email == email)
                {
                    listausuarios[i].favorite_videos.Add(s);
                    Almacenar(listausuarios);
                    funka += "si";

                }
            }
            if (funka != "")
            {
                Console.WriteLine("CANCION AGREGADA CORRECTAMENTE A FAVORITOS");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("LA CANCION NO PUDO AGREGARSE A FAVORITOS");
                Thread.Sleep(2000);
            }
        }
        public static bool Aumentarreproduccion(string nombrecancion, int reproduccion)
        {

            for (int i = 0; i < todas_las_canciones.Count; i++)
            {
                if (todas_las_canciones[i].nombrecancion == nombrecancion)
                {
                    todas_las_canciones[i].reproducciones += 1;
                    AlmacenarCanciones(todas_las_canciones);
                    return true;
                }
            }
            return false;
        }
        public static string Nombrereproducirply(string email, string nombreply, int posicion)
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
                                info = listausuarios[j].Lista_playlistusuario[i].listplay[posicion - 1].nombrecancion;
                            }
                        }
                    }
                }
            }
            return info;



        }
        public static string Nombrereproducirplyvideo(string email, string nombreply, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistvideousuario[i].listplayvideo[posicion - 1].nombre_video;
                            }
                        }
                    }
                }
            }
            return info;



        }
        public static int Reproduccionreproducirply(string email, string nombreply, int posicion)
        {
            int info = 0;
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
                                info = listausuarios[j].Lista_playlistusuario[i].listplay[posicion - 1].reproducciones;
                                ;
                            }
                        }
                    }
                }
            }
            return info;
            //========================================================================================================================================
        }
        public static void Agregaradescargas(string email, Song s)
        {
            string funka = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    if (listausuarios[i].premium == "premium")
                    {
                        listausuarios[i].Descargas.Add(s);
                        Almacenar(listausuarios);
                        funka += "si";
                    }
                    else
                    {
                        Console.WriteLine("Debes ser premium para poder descargar canciones");
                    }
                    
                }
            }
            if (funka != "")
            {
                Console.WriteLine("CANCION DESCARGADA Y AGREGADA A LA LISTA DESCARGAS");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("LA CANCION NO SE DESCARGÓ");
                Thread.Sleep(2000);
            }
        }
        public static void Verinformaciondescargas(string email)
        {
            
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].email == email)
                {
                    if (listausuarios[j].Descargas.Count == 0)
                    {
                        Console.WriteLine("No hay canciones agregadas aún");
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Descargas.Count; i++)
                        {

                            Console.WriteLine("============");
                            Console.WriteLine("Canción" + " " + (i + 1));
                            Console.WriteLine("============");
                            Console.WriteLine(listausuarios[j].Descargas[i].Informacioncancion());
                            Console.WriteLine(" ");
                        }

                    }

                    
                }

            }

        }
        public static string Verinformacionfavoritoscancion(string email)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].email == email)
                {
                    if (listausuarios[j].Favorite_songs.Count == 0)
                    {
                        info = "No hay canciones agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Favorite_songs.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Favorite_songs[i].Informacioncancion() + " ";
                        }
                    }


                }

            }
            return info;

        }
        public static string Verinformacionfavoritosvideo(string email)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].email == email)
                {
                    if (listausuarios[j].favorite_videos.Count == 0)
                    {
                        info = "No hay videos agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].favorite_videos.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].favorite_videos[i].Ver_informacion() + " ";
                        }
                    }
                }
            }
            return info;
        }
        /*
        public static int Reproduccionreproducirplyvideo(string email, string nombreply, int posicion)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistvideousuario[i].listplayvideo[posicion - 1].reproducciones;
                                ;
                            }
                        }
                    }
                }
            }
            return info;
            //========================================================================================================================================
        }
        */
    }


}



    






