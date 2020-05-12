using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Collections.Generic;
using System.Linq;


namespace Proyecto
{
    public static class ALAINID
    {

        public static List<User> listausuarios = new List<User>();       // TODOS LOS USUARIOS DE ALAINID
        public static List<Song> todas_las_canciones = new List<Song>();        // TODAS LAS CANCIONES EN ALAINID
        public static List<Video> todos_los_videos = new List<Video>();
        public static List<Song> todas_las_cancioneskaraoke = new List<Song>();

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
        static void AlmacenarKaraoke(List<Song> k)      //Serializamos
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Cancioneskaraoke.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, k);
            stream.Close();
        }
        static List<Song> CargarKaraoke()
        {
            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("Cancioneskaraoke.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Song> k3 = (List<Song>)formatter2.Deserialize(stream2);
            stream2.Close();
            return k3;
        }
        public static void Partirkaraoke()
        {
            AlmacenarKaraoke(todas_las_cancioneskaraoke);
        }
        public static void activark()
        {
            todas_las_cancioneskaraoke = CargarKaraoke();
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
                                if (listausuarios[j].Lista_playlistusuario[i].listplay.Count > 0)
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
                                if (listausuarios[j].Lista_playlistvideousuario[i].listplayvideo.Count > 0)
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
                        info = listausuarios[j].Lista_playlistusuario[numerolista - 1].NombrePlaylist;

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

        
        public static int Cuantasfavoritadescargas(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Descargas.Count > 0)
                    {
                        info = listausuarios[j].Descargas.Count;
                    }
                }
            }
            return info;
        }
        public static int Cuantashistorialcancion(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_canciones.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones.Count;
                    }
                }
            }
            return info;
        }
        public static int Cuantashistorialvideo(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_videos.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos.Count;
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
                        info = listausuarios[j].Lista_playlistvideousuario[numerolista - 1].NombrePlaylist;

                    }
                }
           
            }
            return info;
        }

        public static string Agregarcancionaply(string email, string posicion, Song cancion)
        {
            string info = "No se pudo agregar la cancion a la playlist";
            string funko = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
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
        public static string ArchivoreproducirHistorialCancion(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_canciones.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones[posicion - 1].nombrearchivo;
                    }
                }
            }
            return info;
        }
        public static string ArchivoreproducirHistorialVideo(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_videos.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos[posicion - 1].nombrearchivovideo;
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
        public static List<string> Lista_nombres_cantantes()
        {
            List<string> nombr = new List<string>();
            foreach (Artista cantante in lista_cantantes)
            {
                nombr.Add(cantante.name);
            }
            return nombr;
        }
        public static List<string> Lista_nombres_canciones()
        {
            List<string> canc = new List<string>();
            foreach (Song cancion in todas_las_canciones)
            {
                canc.Add(cancion.nombrecancion);
            }
            return canc;
        }

        public static List<string> Lista_nombres_albums()
        {
            List<string> alb = new List<string>();
            foreach (PlaylistSong album in todos_los_albumes)
            {
                alb.Add(album.NombrePlaylist);
            }
            return alb;
        }
        public static List<string> Lista_nombres_compositores()
        {
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
            foreach (Artista actor in lista_actores)
            {
                if (actor.age < 25)
                {
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
                if (actor.age >= 25 && actor.age < 40)
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

        public static List<Artista> Lista_artistas_genero(string _valor)
        {
            List<Artista> per_jov = new List<Artista>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.sexo == _valor)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.sexo == _valor)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.sexo == _valor)
                {
                    per_jov.Add(cantante);
                }
            }
            /*foreach (Artista compositor in lista_compositores)
            {
                if (compositor.sexo == _valor)
                {
                    per_jov.Add(compositor);
                }
            }*/
            return per_jov;
        }


        public static List<Song> Lista_por_calidad_cancion(string calidad)
        { // busca todas las canciones de una calidad x
            List<Song> cali_ca = new List<Song>();
            foreach (Song ca in todas_las_canciones)
            {
                if (ca.calidad == calidad)
                {
                    cali_ca.Add(ca);
                }

            }
            return cali_ca;
        }

        public static List<string> Lista_por_calidad_video(string calidad)
        { // busca todos los videos de una calidad x
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
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================
        //========================================================AQUI=====================================================================================


        public static List<string> lista_criterios_filtro2 = new List<string>();       //    
        public static List<string> lista_criterios_filtro3 = new List<string>();       //      
        public static List<Song> lista_canciones_filtromiltiple = new List<Song>();        //     
        public static List<Artista> lista_artistas_filtromiltiple = new List<Artista>();        //     
        public static List<Song> lista_filtrando = new List<Song>();        //    
        public static List<Song> canciones_filtradas = new List<Song>();



        public static List<Song> CancionesporGenero()
        {
            listafiltrada.Clear();
            string _valor = ShowOptions(lista_generos_canciones);
            List<Song> interna = new List<Song>();
            foreach (Song cc in lista_canciones_filtromiltiple)
            {
                interna.Add(cc);
            }
            foreach (Song can in interna)
            {
                if (can.genero == _valor)
                {
                    listafiltrada.Add(can);
                    lista_canciones_filtromiltiple.Remove(can);
                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionespordisquera()
        {
            listafiltrada.Clear();
            string _valor = ShowOptions(lista_disquera);
            List<Song> interna1 = new List<Song>();
            foreach (Song cc in lista_canciones_filtromiltiple)
            {
                interna1.Add(cc);
            }
            foreach (Song canc in interna1)
            {
                if (canc.disquera == _valor)
                {
                    listafiltrada.Add(canc);
                    lista_canciones_filtromiltiple.Remove(canc);

                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporaniopublicacion()
        {
            listafiltrada.Clear();
            List<Song> interna2 = new List<Song>();
            foreach (Song cc in lista_canciones_filtromiltiple)
            {
                interna2.Add(cc);
            }
            Console.WriteLine("Ingrese el año:");
            string _valor = Console.ReadLine();
            foreach (Song canc in interna2)
            {
                if (int.Parse(canc.anopublicacion) == int.Parse(_valor))
                {
                    listafiltrada.Add(canc);// ver 
                    lista_canciones_filtromiltiple.Remove(canc);

                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporsexodelcantante()
        {
            listafiltrada.Clear();
            List<Song> interna3 = new List<Song>();
            foreach (Song cc in lista_canciones_filtromiltiple)
            {
                interna3.Add(cc);
            }
            List<Artista> interna33 = new List<Artista>();
            foreach (Artista aa in lista_artistas_filtromiltiple)
            {
                interna33.Add(aa);
            }
            string _valor = ShowOptions(sexo);

            foreach (Artista can in interna33)
            {
                if (can.sexo == _valor)
                {
                    foreach (Song canc in interna3)
                    {
                        if (canc.cantante == can)
                        {
                            listafiltrada.Add(canc);
                            lista_canciones_filtromiltiple.Remove(canc);
                            lista_artistas_filtromiltiple.Remove(can);

                        }
                    }
                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporedaddelcantante()
        {
            List<Song> interna4 = new List<Song>();
            foreach (Song cc in lista_canciones_filtromiltiple)
            {
                interna4.Add(cc);
            }
            List<Artista> interna44 = new List<Artista>();
            foreach (Artista aa in lista_artistas_filtromiltiple)
            {
                interna44.Add(aa);
            }
            listafiltrada.Clear();
            string _valor = ShowOptions(edades);
            switch (_valor)
            {
                case "Menores de 25 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.age <= 25)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.cantante == can)
                                {
                                    listafiltrada.Add(canc);
                                    lista_canciones_filtromiltiple.Remove(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }

                    break;
                case "De 25 a 40 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.age > 25 && can.age <= 40)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.cantante == can)
                                {
                                    listafiltrada.Add(canc);
                                    lista_canciones_filtromiltiple.Remove(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "De 40 a 60 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.age > 40 && can.age <= 60)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.cantante == can)
                                {
                                    listafiltrada.Add(canc);
                                    lista_canciones_filtromiltiple.Remove(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "Mayores de 60":
                    foreach (Artista can in interna44)
                    {
                        if (can.age > 60)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.cantante == can)
                                {
                                    listafiltrada.Add(canc);
                                    lista_canciones_filtromiltiple.Remove(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }
                    break;
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporcalidadcancion()
        {
            listafiltrada.Clear();
            List<Song> interna5 = new List<Song>();
            foreach (Song cc in lista_canciones_filtromiltiple)
            {
                interna5.Add(cc);
            }
            string _valor = ShowOptions(lista_calidad_cancion);
            listafiltrada = Lista_por_calidad_cancion(_valor);
            foreach (Song ca in interna5)
            {
                if (ca.calidad == _valor)
                {
                    listafiltrada.Add(ca);
                    lista_canciones_filtromiltiple.Remove(ca);

                }

            }
            return listafiltrada;
        }

        public static List<Song> filtocriteriomultiple(string criterio)
        {
            lista_filtrando.Clear();
            switch (criterio)
            {
                case "Genero":
                    Console.WriteLine("ENTRE A GENERO");
                    Thread.Sleep(2000);

                    lista_filtrando = CancionesporGenero();
                    break;
                case "Disquera":
                    Console.WriteLine("ENTRE A DISQUERA");
                    Thread.Sleep(2000);

                    lista_filtrando = Cancionespordisquera();

                    break;
                case "Año Publicacion":
                    Console.WriteLine("ENTRE A AÑO PUBLICACION");
                    Thread.Sleep(2000);

                    lista_filtrando = Cancionesporaniopublicacion();

                    break;
                case "Sexo del Artista":
                    Console.WriteLine("ENTRE A SEXO ARTISTA");
                    Thread.Sleep(2000);
                    lista_filtrando = Cancionesporsexodelcantante();

                    break;
                case "Edad del Artista":
                    Console.WriteLine("ENTRE A EDAD ARTISTA");
                    Thread.Sleep(2000);
                    lista_filtrando = Cancionesporedaddelcantante();

                    break;
                case "Calidad/Resolucion":
                    Console.WriteLine("ENTRE A RESOLUCION");
                    lista_filtrando = Cancionesporcalidadcancion();
                    Thread.Sleep(2000);

                    break;
                case "Evaluacion":
                    Console.WriteLine("ENTRE A EVALUACION");

                    Console.WriteLine("Lo sentimos pero este metodo aun esta en construccion");
                    Thread.Sleep(2000);

                    //TERMINAR
                    break;
                default:
                    Console.WriteLine("No existen canciones que cumplan con el criterio y valor seleccionado");
                    break;
            }
            return lista_filtrando;
        }

        public static List<Song> Buqueda_multiple_canciones()
        {
            lista_canciones_filtromiltiple.Clear();
            lista_artistas_filtromiltiple.Clear();
            lista_criterios_filtro3.Clear();
            foreach (Song caca in todas_las_canciones)
            {
                lista_canciones_filtromiltiple.Add(caca);
            }
            foreach (Artista cancan in lista_cantantes)
            {
                lista_artistas_filtromiltiple.Add(cancan);
            }
            foreach (Artista comcom in lista_compositores)
            {
                lista_artistas_filtromiltiple.Add(comcom);
            }
            foreach (String cricri in lista_criterios_filtro2)
            {
                lista_criterios_filtro3.Add(cricri);
            }
            canciones_filtradas.Clear();

            Console.WriteLine("Los criterios para busqueda multiple son los siguientes:");
            int num = 0, num_select = 1;
            foreach (String cri in lista_criterios_filtro3)
            {
                Console.WriteLine(" - " + cri);

            }
            Console.WriteLine("Ingrese el numero de Criterios desea usar para la busca multiple:");
            num = Numero(7);
            string criterio;
            List<string> criterios_seleccionados = new List<string>();
            while (num_select <= num)
            {
                criterio = "\0";
                Console.WriteLine("Seleccione el criterio N° " + num_select + " para su busqueda");
                criterio = ShowOptions(lista_criterios_filtro3);
                lista_criterios_filtro3.Remove(criterio);
                criterios_seleccionados.Add(criterio);
                num_select++;
            }
            Console.Clear();
            Console.WriteLine("Usted selecciono buscar por:");
            foreach (String c in criterios_seleccionados)
            {
                Console.WriteLine(" - " + c);
            }
            foreach (String crit in criterios_seleccionados)
            {
                filtocriteriomultiple(crit);
                foreach (Song ccc in lista_filtrando)
                {
                    canciones_filtradas.Add(ccc);

                }
            }
            return canciones_filtradas;
        }


        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================
        //==============================================HASTA AQUI====================================================================================


        public static List<Song> CancionesPorCriterio(string _criterio, string _valor)
        {
            listafiltrada.Clear();
            switch (_criterio)
            {
                case "Genero":
                    foreach (Song can in todas_las_canciones)
                    {
                        if (can.genero == _valor)
                        {
                            listafiltrada.Add(can);
                        }
                    }
                    break;
                case "Cantante":
                    foreach (Artista art in lista_cantantes)
                    {
                        if (art.name == _valor)
                        {
                            foreach (Song can in art.lista_canciones)
                            {
                                listafiltrada.Add(can);
                            }
                        }
                    }
                    break;
                case "Album":
                    foreach (PlaylistSong alb in todos_los_albumes)
                    {
                        if (alb.NombrePlaylist == _valor)
                        {
                            foreach (Song canc in todas_las_canciones)
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
                    foreach (Song canc in todas_las_canciones)
                    {
                        if (canc.nombrecancion == _valor)
                        {
                            listafiltrada.Add(canc);
                        }
                    }
                    break;
                case "Disquera":
                    foreach (Song canc in todas_las_canciones)
                    {
                        if (canc.disquera == _valor)
                        {
                            listafiltrada.Add(canc);
                        }
                    }
                    break;
                case "Compositor":
                    foreach (Artista art in lista_compositores)
                    {
                        if (art.name == _valor)
                        {
                            foreach (Song can in art.lista_canciones)
                            {
                                listafiltrada.Add(can);
                            }
                        }
                    }
                    break;
                case "Año Publicacion":
                    foreach (Song canc in todas_las_canciones)
                    {
                        if (int.Parse(canc.anopublicacion) == int.Parse(_valor))
                        {
                            listafiltrada.Add(canc);// ver 
                        }
                    }
                    break;
                case "Sexo del Artista":
                    foreach (Artista can in lista_cantantes)
                    {
                        if (can.sexo == _valor)
                        {
                            foreach (Song canc in todas_las_canciones)
                            {
                                if (canc.cantante == can)
                                {
                                    listafiltrada.Add(canc);
                                }
                            }
                        }
                    }
                    break;
                case "Edad del Artista":
                    switch (_valor)
                    {
                        case "Menores de 25 años":
                            foreach (Artista can in lista_cantantes)
                            {
                                if (can.age <= 25)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.cantante == can)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                    }
                                }
                            }
                            
                            break;
                        case "De 25 a 40 años":
                            foreach (Artista can in lista_cantantes)
                            {
                                if (can.age > 25 && can.age<=40)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.cantante == can)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                    }
                                }
                            }
                            break;
                        case "De 40 a 60 años":
                            foreach (Artista can in lista_cantantes)
                            {
                                if (can.age > 40 && can.age <= 60)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.cantante == can)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                    }
                                }
                            }
                            break;
                        case "Mayores de 60":
                            foreach (Artista can in lista_cantantes)
                            {
                                if (can.age > 60)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.cantante == can)
                                        {
                                            listafiltrada.Add(canc);
                                        }
                                    }
                                }
                            }
                            break;
                    }
                    break;
                case "Calidad/Resolucion":
                    listafiltrada = Lista_por_calidad_cancion(_valor);
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
        public static void Verinfodeunacancionkarake(Song s1)
        {
            Console.WriteLine(s1.InformacioncancionKaraoke());
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
        public static bool Aumentarreproduccionvideo(string nombrevideo, int reproduccion)
        {

            for (int i = 0; i < todas_las_canciones.Count; i++)
            {
                if (todos_los_videos[i].nombre_video == nombrevideo)
                {
                    todos_los_videos[i].reproduccion += 1;
                    AlmacenarVideos(todos_los_videos);
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
        public static string Nombrereproducirfavoritoscancion(string email,int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Favorite_songs.Count > 0)
                    {
                        info = listausuarios[j].Favorite_songs[posicion - 1].nombrecancion;
                            
                        
                    }
                }
            }
            return info;
        }
        public static string Nombrereproducirhistorialcancion(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_canciones.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones[posicion - 1].nombrecancion;
                    }
                }
            }
            return info;
        }
        public static string Nombrereproducirhistorialvideo(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_videos.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos[posicion - 1].nombre_video;
                    }
                }
            }
            return info;
        }
        public static string Nombrereproducirfavoritosvideo(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Favorite_videos.Count > 0)
                    {
                        info = listausuarios[j].Favorite_videos[posicion - 1].nombre_video;


                    }
                }
            }
            return info;



        }
        public static int Reproduccionreproducirfavcancion(string email, int posicion)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Favorite_songs.Count > 0)
                    {
                        info = listausuarios[j].Favorite_songs[posicion - 1].reproducciones;


                    }
                }
            }
            return info;
            //========================================================================================================================================
        }
        public static int Reproduccionreproducirhistorialcancion(string email, int posicion)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_canciones.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones[posicion - 1].reproducciones;
                    }
                }
            }
            return info;
            //========================================================================================================================================
        }
        public static int Reproduccionreproducirhistorialvideo(string email, int posicion)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Historial_videos.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos[posicion - 1].reproduccion;
                    }
                }
            }
            return info;
            //========================================================================================================================================
        }

        public static int Reproduccionreproducirfavvideo(string email, int posicion)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Favorite_videos.Count > 0)
                    {
                        info = listausuarios[j].Favorite_videos[posicion - 1].reproduccion;


                    }




                }
            }
            return info;
            //========================================================================================================================================
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
        public static string ArchivoreproducirDescargas(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email == email)
                {
                    if (listausuarios[j].Descargas.Count > 0)
                    {
                        info = listausuarios[j].Descargas[posicion - 1].nombrearchivo;
                    }
                }
            }
            return info;
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
                        Thread.Sleep(2000);
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
        public static string Verinformaciondescargas(string email)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].email == email)
                {
                    if (listausuarios[j].Descargas.Count == 0)
                    {
                        info = "No hay canciones agregadas aún";
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
            return info;
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
        public static string Verinformacionhistorialcancion(string email)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].email == email)
                {
                    if (listausuarios[j].Historial_canciones.Count == 0)
                    {
                        info = "No hay canciones agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Historial_canciones.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Historial_canciones[i].Informacioncancion() + " ";
                        }
                    }
                }
            }
            return info;
        }
        public static string Verinformacionhistorialvideo(string email)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].email == email)
                {
                    if (listausuarios[j].Historial_videos.Count == 0)
                    {
                        info = "No hay videos agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Historial_videos.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Historial_videos[i].Ver_informacion() + " ";
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
        public static void Agregarcancionahistorial(string email, String archivo)
        {
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email==email)
                {
                    for (int j = 0; j < todas_las_canciones.Count; j++)
                        if (todas_las_canciones[j].nombrearchivo == archivo)
                        {
                            listausuarios[i].Historial_canciones.Add(todas_las_canciones[j]);
                        }
                }
            }
        }
        public static void Agregarvideoahistorial(string email, string archivo)
        {
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email == email)
                {
                    for (int j = 0; j < todos_los_videos.Count; j++)
                        if (todos_los_videos[j].nombrearchivovideo==archivo)
                        {
                            listausuarios[i].Historial_videos.Add(todos_los_videos[j]);
                        }
                }
            }
        }
        public static void Agregarausuariosseguidos(string email, User u)
        {
            string funka = "";
            string yalosigues = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].email == email)
                {
                    for (int j=0; j< listausuarios[i].Usuarios_seguidos.Count;j++)
                    {
                        if (listausuarios[i].Usuarios_seguidos[j].NombreUsuario== u.NombreUsuario)
                        {
                            yalosigues = "si";
                        } 
                    }
                    if (yalosigues!="si")
                    {
                        listausuarios[i].Usuarios_seguidos.Add(u);
                        Almacenar(listausuarios);
                        funka += "si";
                    }
                }
            }
            if (funka != "")
            {
                Console.WriteLine("USUARIO SEGUIDO EXIOSAMENTE");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("FALLA AL SEGUIR AL USUARIO");
                Thread.Sleep(2000);
            }
        }
        public static void Verinformacionusuariosseguidos(string email)
        {
            
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].email == email)
                {
                    if (listausuarios[j].Usuarios_seguidos.Count == 0)
                    {
                        Console.WriteLine("No sigues a ningun usuario aún");
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Usuarios_seguidos.Count; i++)
                        {

                            Console.WriteLine("============");
                            Console.WriteLine("Usuario" + " " + (i + 1));
                            Console.WriteLine("============");
                            Console.WriteLine(listausuarios[j].Usuarios_seguidos[i].InformacionUsuario());
                            Console.WriteLine(" ");
                        }

                    }


                }

            }
            
        }
        public static void VerCancionesKaraoke(List<Song> lista)
        {
            
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay canciones agregadas aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Canción" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].InformacioncancionKaraoke());
                    Console.WriteLine(" ");

                }
            }
        }
    }
}