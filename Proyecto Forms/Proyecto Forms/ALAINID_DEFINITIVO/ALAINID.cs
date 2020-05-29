using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Proyecto_Forms
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
        public static List<Song> lista_filtrada_final = new List<Song>();
        public static List<Video> lista_filtrada_finalv = new List<Video>();
        public static List<String> lista_disqueravideo = new List<String>();



        //===============================================TODO LO QUE ES SERIALIZATION================================================================
        //===============================================TODO LO QUE ES SERIALIZATION================================================================
        //===============================================TODO LO QUE ES SERIALIZATION================================================================
        //===============================================TODO LO QUE ES SERIALIZATION================================================================
        //===============================================TODO LO QUE ES SERIALIZATION================================================================
        public static void Activarlistacantantes()
        {
            lista_cantantes = CargarCantantes();
        }
        public static void Partirkaraoke()
        {
            AlmacenarKaraoke(todas_las_cancioneskaraoke);
        }
        public static void activark()
        {
            todas_las_cancioneskaraoke = CargarKaraoke();
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
        public static void AlmacenarCompositores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Compositores.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Artista> CargarCompositores()
        {
            try
            {
                IFormatter formatter6 = new BinaryFormatter();
                Stream stream6 = new FileStream("Compositores.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Artista> v = new List<Artista>();
                return v;
            }
        }
        public static void Partirlistacompositores()
        {
            lista_compositores = CargarCompositores();
        }
        public static void AlmacenarDirectores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Directores.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Artista> CargarDirectores()
        {
            try
            {
                IFormatter formatter6 = new BinaryFormatter();
                Stream stream6 = new FileStream("Directores.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Artista> v = new List<Artista>();
                return v;
            }
        }
        public static void Partirlistadirectores()
        {
            lista_directores = CargarDirectores();
        }
        public static void AlmacenarActores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Actores.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Artista> CargarActores()
        {
            try
            { 
                IFormatter formatter6 = new BinaryFormatter();
                Stream stream6 = new FileStream("Actores.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Artista> v = new List<Artista>();
                return v;
            }
        }
        public static void Partirlistaactores()
        {
            lista_actores = CargarActores();
        }
        public static void AlmacenarAlbum(List<PlaylistSong> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Albums.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<PlaylistSong> CargarAlbum()
        {
            try
            {
                IFormatter formatter6 = new BinaryFormatter();
                Stream stream6 = new FileStream("Albums.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<PlaylistSong> v = (List<PlaylistSong>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<PlaylistSong> v = new List<PlaylistSong>();
                return v;
            }
        }
        public static void Partirlistaalbumes()
        {
            todos_los_albumes = CargarAlbum();
        }
        static void AlmacenarCanciones(List<Song> s)      //Serializamos
        {
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("Canciones.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter3.Serialize(stream3, s);
            stream3.Close();
        }
        static List<Song> CargarCancion()
        {
            if (File.Exists("Canciones.bin"))
            {
                IFormatter formatter4 = new BinaryFormatter();
                Stream stream4 = new FileStream("Canciones.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                List<Song> s2 = (List<Song>)formatter4.Deserialize(stream4);
                stream4.Close();

                return s2;
            }
            else
            {
                Console.WriteLine("El archivo Canciones.bin no existe");
                List<Song> s2 = new List<Song>();
                Thread.Sleep(5000);

                return s2;
            }
        }

        public static void AlmacenarVideos(List<Video> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("Videos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static List<Video> CargarVideos()
        {
            try
            {
                IFormatter formatter6 = new BinaryFormatter();
                Stream stream6 = new FileStream("Videos.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<Video> v = (List<Video>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Video> v = new List<Video>();
                return v;
            }
        }
        //======================================================BINARIOCANTANTES=====================================================================================0000
        public static void AlmacenarCantante(List<Artista> a)      //Serializamos
        {
            IFormatter formatter7 = new BinaryFormatter();
            Stream stream7 = new FileStream("Cantantes.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter7.Serialize(stream7, a);
            stream7.Close();
        }
        public static List<Artista> CargarCantantes()
        {
            try
            {
                IFormatter formatter8 = new BinaryFormatter();
                Stream stream8 = new FileStream("Cantantes.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<Artista> ar = (List<Artista>)formatter8.Deserialize(stream8);
                stream8.Close();
                return ar;
            }
            catch
            {
                List<Artista> ar = new List<Artista>();
                return ar;
            }
        }

        public static void Almacenar(List<User> u)      //Serializamos
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Usuarios2.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, u);
            stream.Close();
        }
        public static List<User> Cargar()
        {
            try
            {
                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("Usuarios2.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<User> p = (List<User>)formatter2.Deserialize(stream2);
                stream2.Close();
                return p;
            }
            catch
            {
                List<User> p = new List<User>();
                return p;
            }
        }
        public static void AlmacenarKaraoke(List<Song> k)      //Serializamos
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Cancioneskaraoke.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, k);
            stream.Close();
        }
        public static List<Song> CargarKaraoke()
        {
            try
            {
                IFormatter formatter2 = new BinaryFormatter();
                Stream stream2 = new FileStream("Cancioneskaraoke.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                List<Song> k3 = (List<Song>)formatter2.Deserialize(stream2);
                stream2.Close();
                return k3;
            }
            catch
            {
                List<Song> k3 = new List<Song>();
                return k3;
            }
        }
        //===============================================HASTA AQUI ES TODO LO QUE ES SERIALIZATION================================================================
        //===============================================HASTA AQUI ES TODO LO QUE ES SERIALIZATION================================================================
        //===============================================HASTA AQUI ES TODO LO QUE ES SERIALIZATION================================================================
        //===============================================HASTA AQUI ES TODO LO QUE ES SERIALIZATION================================================================
        //===============================================HASTA AQUI ES TODO LO QUE ES SERIALIZATION================================================================

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



        public static bool Hacerplaylistsong(string mail, string nombrepl)
        {
            string funkaa = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email_ == mail)
                {
                    PlaylistSong plysu = new PlaylistSong(nombrepl);
                    listausuarios[i].Lista_playlistusuario_.Add(plysu);
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
                if (listausuarios[i].Email_ == mail)
                {
                    PlaylistVideo playlist2 = new PlaylistVideo(nombrepl);
                    listausuarios[i].Lista_playlistvideousuario_.Add(playlist2);
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistusuario_[i].NombrePlaylist == nombreply)
                            {
                                listafiltrada2 = listausuarios[j].Lista_playlistusuario_[i].Listplay;
                                if (listausuarios[j].Lista_playlistusuario_[i].Listplay.Count > 0)
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario_[i].NombrePlaylist == nombreply)
                            {
                                listafiltrada3 = listausuarios[j].Lista_playlistvideousuario_[i].Listplayvideo;
                                if (listausuarios[j].Lista_playlistvideousuario_[i].Listplayvideo.Count > 0)
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        info = "Nombres de tus playlist: \n";
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario_.Count; i++)
                        {
                            //lplaylist.Add(listausuarios[j].Lista_playlistusuario[i].NombrePlaylist);
                            info += i + 1 + ". " + listausuarios[j].Lista_playlistusuario_[i].NombrePlaylist + "\n";
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > 0)
                    {
                        info = "Nombres de tus playlist: \n";
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario_.Count; i++)
                        {
                            //lplaylist.Add(listausuarios[j].Lista_playlistvideousuario[i].NombrePlaylist);
                            info += i + 1 + ". " + listausuarios[j].Lista_playlistvideousuario_[i].NombrePlaylist + "\n";
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistusuario_[numerolista - 1].NombrePlaylist;

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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistusuario_.Count;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_songs_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_songs_.Count;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Descargas_.Count > 0)
                    {
                        info = listausuarios[j].Descargas_.Count;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_canciones_.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones_.Count;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_videos_.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos_.Count;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_videos_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_videos_.Count;
                    }
                }
            }
            return info;
        }
        public static void Cancionbuscada(string archivo)
        {
            for (int j = 0; j < todas_las_canciones.Count; j++)
            {
                if (todas_las_canciones[j].Nombrearchivo == archivo)
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
                if (todos_los_videos[j].Nombrearchivovideo == archivo)
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistvideousuario_.Count;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > 0)
                    {
                        info = listausuarios[j].Lista_playlistvideousuario_[numerolista - 1].NombrePlaylist;

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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > int.Parse(posicion) - 1)
                    {
                        listausuarios[j].Lista_playlistusuario_[int.Parse(posicion) - 1].Listplay.Add(cancion);
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > int.Parse(posicion) - 1)
                    {
                        listausuarios[j].Lista_playlistvideousuario_[int.Parse(posicion) - 1].Listplayvideo.Add(video);
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistusuario_[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistusuario_[i].InformationPLL();
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario_[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistvideousuario_[i].InformationPLL();
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistusuario_[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistusuario_[i].Listplay[posicion - 1].Nombrearchivo;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_songs_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_songs_[posicion - 1].Nombrearchivo;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_canciones_.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones_[posicion - 1].Nombrearchivo;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_videos_.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos_[posicion - 1].Nombrearchivovideo;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_videos_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_videos_[posicion - 1].Nombrearchivovideo;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario_[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistvideousuario_[i].Listplayvideo[posicion - 1].Nombrearchivovideo;
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
                if ((ui.Email_ == "")||(u1.Nombreusuario == "")||(u1.Password_ == "" )|| (u1.Nombre_ == ""))
                {
                    MessageBox.Show("No Puede Dejar Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return false;
                }else if (ui.Email_ == u1.Email_ || ui.Nombreusuario == u1.Nombreusuario)
                {
                    MessageBox.Show("El Correo o Nombre de Usuario Ingresado ya Existen ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            listausuarios.Add(u1);
            Almacenar(listausuarios);
            MessageBox.Show("REGISTRO EXITOSO", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.None);
            return true;
        }
        public static bool Ingresaralaapp(string email, string password)
        {
            bool usuarioencontrado = false;
            User ui = null;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                ui = listausuarios[j];
                if (ui.Email_ == email)
                {
                    usuarioencontrado = true;
                    break;
                }
            }
            if (usuarioencontrado == true)
            {
                if (ui.Password_ != password)
                {
                    MessageBox.Show("CONTRASEÑA INVALIDA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
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


        public static bool Cambiarcontrasena(string email, string contrasena, string nuevacontrasena)
        {
            string funko = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Password_ == contrasena)
                    {
                        listausuarios[i].Password_ = nuevacontrasena;
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
                if (listausuarios[i].Email_ == email)
                {
                    listausuarios[i].Ultimareproduccion_ = ultimareproduccion;
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
                if (listausuarios[i].Email_ == email)
                {
                    funko = listausuarios[i].Ultimareproduccion_;
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
                if (listausuarios[j].Email_ == email)
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
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Password_ == contrasena)
                    {
                        listausuarios[i].Nombreusuario = nuevonombre;
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
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Password_ == contrasena)
                    {
                        listausuarios[i].Nombre_ = nuevonombre;
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

        //============================================================================================================================================================
        public static List<string> Lista_nombres_cantantes()
        {
            List<string> nombr = new List<string>();
            foreach (Artista cantante in lista_cantantes)
            {
                nombr.Add(cantante.Name);
            }
            return nombr;
        }
        public static List<string> Lista_nombres_canciones()
        {
            List<string> canc = new List<string>();
            foreach (Song cancion in todas_las_canciones)
            {
                canc.Add(cancion.Nombrecancion);
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
                nombrc.Add(compositor.Name);
            }
            return nombrc;
        }

        public static List<string> Lista_nombres_diectores()
        {
            List<string> nom_dir = new List<string>();
            foreach (Artista director in lista_directores)
            {
                nom_dir.Add(director.Name);
            }
            return nom_dir;
        }

        public static List<string> Lista_nombres_actores()
        {
            List<string> nom_act = new List<string>();
            foreach (Artista actor in lista_actores)
            {
                nom_act.Add(actor.Name);
            }
            return nom_act;
        }

        public static List<Artista> Lista_personas_jovenes() // menores de 25
        {
            List<Artista> per_jov = new List<Artista>();
            foreach (Artista actor in lista_actores)
            {
                if (actor.Age < 25)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.Age < 25)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.Age < 25)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.Age < 25)
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
                if (actor.Age >= 25 && actor.Age < 40)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.Age >= 25 && director.Age < 40)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.Age >= 25 && cantante.Age < 40)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.Age >= 25 && compositor.Age < 40)
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
                if (actor.Age >= 40 && actor.Age < 60)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.Age >= 40 && director.Age < 60)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.Age >= 40 && cantante.Age < 60)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.Age >= 40 && compositor.Age < 60)
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
                if (actor.Age >= 60)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.Age >= 60)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.Age >= 60)
                {
                    per_jov.Add(cantante);
                }
            }
            foreach (Artista compositor in lista_compositores)
            {
                if (compositor.Age >= 60)
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
                if (actor.Sexo == _valor)
                {
                    per_jov.Add(actor);
                }
            }
            foreach (Artista director in lista_directores)
            {
                if (director.Sexo == _valor)
                {
                    per_jov.Add(director);
                }
            }
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.Sexo == _valor)
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
                if (ca.Calidad == calidad)
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
                if (v.Calidad == calidad)
                {
                    cali_v.Add(v.Nombre_video);
                }

            }
            return cali_v;
        }

        public static List<string> Lista_por_categoria_video(string categoria)
        {
            List<string> cat_v = new List<string>();
            foreach (Video v in todos_los_videos)
            {
                if (v.Categoria == categoria)
                {
                    cat_v.Add(v.Nombre_video);
                }
            }
            return cat_v;
        }

        public static List<string> Lista_genero_video(string genero)
        {
            List<string> gen_v = new List<string>();
            foreach (Video v in todos_los_videos)
            {
                if (v.Genero == genero)
                {
                    gen_v.Add(v.Nombre_video);
                }
            }
            return gen_v;
        }

        public static List<string> Lista_genero_cancion(string genero)
        {
            List<string> gen_c = new List<string>();
            foreach (Song s in todas_las_canciones)
            {
                if (s.Genero == genero)
                {
                    gen_c.Add(s.Nombrecancion);
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
        public static List<Song> lista_filtrando2 = new List<Song>();        //    



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
                if (can.Genero == _valor)
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
                if (canc.Disquera == _valor)
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
                if (int.Parse(canc.Anopublicacion) == int.Parse(_valor))
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
                if (can.Sexo == _valor)
                {
                    foreach (Song canc in interna3)
                    {
                        if (canc.Cantante.Name == can.Name)
                        {
                            listafiltrada.Add(canc);
                            lista_canciones_filtromiltiple.Remove(canc);
                            lista_artistas_filtromiltiple.Remove(can);

                        }
                    }
                }
                else
                {
                    Console.WriteLine("");
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
                        if (can.Age <= 25)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
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
                        if (can.Age > 25 && can.Age <= 40)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
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
                        if (can.Age > 40 && can.Age <= 60)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
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
                        if (can.Age > 60)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
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
            foreach (Song ca in interna5)
            {
                if (ca.Calidad == _valor)
                {
                    listafiltrada.Add(ca);
                    lista_canciones_filtromiltiple.Remove(ca);

                }

            }
            return listafiltrada;
        }
        public static List<Song> cancionporevaluacion()
        {
            Console.WriteLine("Ingrese una nota del 1 al 10, se le mostraran todos los Videos que tengan una nota superior");
            float _valor = float.Parse(Console.ReadLine());
            foreach (Song canc in todas_las_canciones)
            {
                if (canc.Calificacionpromedio >= _valor)
                {
                    listafiltrada.Add(canc);
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
                    lista_filtrando = CancionesporGenero();
                    break;
                case "Disquera":
                    lista_filtrando = Cancionespordisquera();
                    break;
                case "Año Publicacion":
                    lista_filtrando = Cancionesporaniopublicacion();
                    break;
                case "Sexo del Artista":
                    lista_filtrando = Cancionesporsexodelcantante();
                    break;
                case "Edad del Artista":
                    lista_filtrando = Cancionesporedaddelcantante();
                    break;
                case "Calidad/Resolucion":
                    lista_filtrando = Cancionesporcalidadcancion();
                    break;
                case "Evaluacion":
                    lista_filtrando = cancionporevaluacion();
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

                lista_filtrando2.Clear();
                foreach (Song ss in filtocriteriomultiple(crit))
                {

                    lista_filtrando2.Add(ss);
                }
                foreach (Song ccc in lista_filtrando2)
                {
                    int si = 0;
                    foreach (Song canc in canciones_filtradas)
                    {
                        if (ccc.Nombrecancion == canc.Nombrecancion)
                        {
                            si++;
                        }
                    }
                    if (si == 0)
                    {
                        canciones_filtradas.Add(ccc);
                    }
                }
            }
            return canciones_filtradas;
        }


        public static List<Song> CancionesporGeneroand()
        {
            listafiltrada.Clear();
            string _valor = ShowOptions(lista_generos_canciones);

            List<Song> interna = new List<Song>();
            foreach (Song cc in canciones_filtradas)
            {
                interna.Add(cc);
            }
            foreach (Song can in interna)
            {
                if (can.Genero == _valor)
                {

                    listafiltrada.Add(can);
                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionespordisqueraand()
        {
            listafiltrada.Clear();
            string _valor = ShowOptions(lista_disquera);
            List<Song> interna1 = new List<Song>();
            foreach (Song cc in canciones_filtradas)
            {
                interna1.Add(cc);
            }
            foreach (Song canc in interna1)
            {
                if (canc.Disquera == _valor)
                {
                    listafiltrada.Add(canc);

                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporaniopublicacionand()
        {
            listafiltrada.Clear();
            List<Song> interna2 = new List<Song>();
            foreach (Song cc in canciones_filtradas)
            {
                interna2.Add(cc);
            }
            Console.WriteLine("Ingrese el año:");
            string _valor = Console.ReadLine();
            foreach (Song canc in interna2)
            {
                if (int.Parse(canc.Anopublicacion) == int.Parse(_valor))
                {
                    listafiltrada.Add(canc);// ver 

                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporsexodelcantanteand()
        {
            listafiltrada.Clear();
            List<Song> interna3 = new List<Song>();
            foreach (Song cc in canciones_filtradas)
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
                if (can.Sexo == _valor)
                {
                    foreach (Song canc in interna3)
                    {
                        if (canc.Cantante.Name == can.Name)
                        {
                            listafiltrada.Add(canc);
                            lista_artistas_filtromiltiple.Remove(can);

                        }
                    }
                }
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporedaddelcantanteand()
        {
            List<Song> interna4 = new List<Song>();
            foreach (Song cc in canciones_filtradas)
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
                        if (can.Age <= 25)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
                                {
                                    listafiltrada.Add(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }

                    break;
                case "De 25 a 40 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 25 && can.Age <= 40)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
                                {
                                    listafiltrada.Add(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "De 40 a 60 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 40 && can.Age <= 60)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
                                {
                                    listafiltrada.Add(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "Mayores de 60":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 60)
                        {
                            foreach (Song canc in interna4)
                            {
                                if (canc.Cantante.Name == can.Name)
                                {
                                    listafiltrada.Add(canc);
                                    lista_artistas_filtromiltiple.Remove(can);
                                }
                            }
                        }
                    }
                    break;
            }
            return listafiltrada;
        }

        public static List<Song> Cancionesporcalidadcancionand()
        {
            listafiltrada.Clear();
            List<Song> interna5 = new List<Song>();
            foreach (Song cc in canciones_filtradas)
            {
                interna5.Add(cc);
            }
            string _valor = ShowOptions(lista_calidad_cancion);
            foreach (Song ca in interna5)
            {
                if (ca.Calidad == _valor)
                {
                    listafiltrada.Add(ca);

                }

            }
            return listafiltrada;
        }


        public static List<Song> filtocriteriomultipleand(string criterio)
        {
            lista_filtrando.Clear();
            switch (criterio)
            {
                case "Genero":

                    lista_filtrando = CancionesporGeneroand();
                    break;
                case "Disquera":

                    lista_filtrando = Cancionespordisqueraand();

                    break;
                case "Año Publicacion":

                    lista_filtrando = Cancionesporaniopublicacionand();

                    break;
                case "Sexo del Artista":

                    lista_filtrando = Cancionesporsexodelcantanteand();

                    break;
                case "Edad del Artista":

                    lista_filtrando = Cancionesporedaddelcantanteand();

                    break;
                case "Calidad/Resolucion":
                    lista_filtrando = Cancionesporcalidadcancionand();

                    break;
                case "Evaluacion":

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
        public static List<Song> Buqueda_multiple_cancionesand()
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
            foreach (string c in criterios_seleccionados)
            {
                Console.WriteLine(" - " + c);
            }
            lista_filtrando2.Clear();
            foreach (Song ss in filtocriteriomultiple(criterios_seleccionados[0]))
            {
                lista_filtrando2.Add(ss);
            }
            foreach (Song ccc in lista_filtrando2)
            {
                canciones_filtradas.Add(ccc);
            }
            int count2 = 1;
            while (count2 < num)
            {
                lista_filtrando2.Clear();
                foreach (Song ss in filtocriteriomultipleand(criterios_seleccionados[count2]))
                {
                    canciones_filtradas.Clear();
                    canciones_filtradas.Add(ss);
                }
                count2++;
            }
            if (lista_filtrada_final.Count == 0)
            {
                Console.WriteLine("");


            }
            int si;
            foreach (Song ccc in canciones_filtradas)
            {
                si = 0;
                foreach (Song canc in lista_filtrada_final)
                {

                    if ((ccc.Nombrecancion == canc.Nombrecancion) && (ccc.Cantante.Name == canc.Cantante.Name))
                    {
                        si++;
                    }
                }
                if (si == 0)
                {
                    lista_filtrada_final.Add(ccc);
                }
            }
            return lista_filtrada_final;
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
                        if (can.Genero == _valor)
                        {
                            listafiltrada.Add(can);
                        }
                    }
                    break;
                case "Cantante":
                    foreach (Artista art in lista_cantantes)
                    {
                        if (art.Name == _valor)
                        {
                            foreach (Song can in art.Lista_canciones)
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
                                if (canc.Album == alb.NombrePlaylist)
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
                        if (canc.Nombrecancion == _valor)
                        {
                            listafiltrada.Add(canc);
                        }
                    }
                    break;
                case "Disquera":
                    foreach (Song canc in todas_las_canciones)
                    {
                        if (canc.Disquera == _valor)
                        {
                            listafiltrada.Add(canc);
                        }
                    }
                    break;
                case "Compositor":
                    foreach (Artista art in lista_compositores)
                    {
                        if (art.Name == _valor)
                        {
                            foreach (Song can in art.Lista_canciones)
                            {
                                listafiltrada.Add(can);
                            }
                        }
                    }
                    break;
                case "Año Publicacion":
                    foreach (Song canc in todas_las_canciones)
                    {
                        if (int.Parse(canc.Anopublicacion) == int.Parse(_valor))
                        {
                            listafiltrada.Add(canc);// ver 
                        }
                    }
                    break;
                case "Sexo del Artista":
                    foreach (Artista art in lista_cantantes)
                    {
                        if (art.Sexo == _valor)
                        {
                            foreach (Song canc in todas_las_canciones)
                            {
                                if (canc.Cantante.Name == art.Name)
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
                                if (can.Age <= 25)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.Cantante.Name == can.Name)
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
                                if (can.Age > 25 && can.Age <= 40)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.Cantante.Name == can.Name)
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
                                if (can.Age > 40 && can.Age <= 60)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.Cantante.Name == can.Name)
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
                                if (can.Age > 60)
                                {
                                    foreach (Song canc in todas_las_canciones)
                                    {
                                        if (canc.Cantante.Name == can.Name)
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
                    listafiltrada = cancionporevaluacion();
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
                    Console.WriteLine(s[i].Nombrecancion);
                    Console.WriteLine(s[i].Cantante.Name);
                    Console.WriteLine(" ");


                }
            }
        }
        public static void Vervideosparareproduccion(List<Video> s)
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
                    Console.WriteLine(i + 1 + "-" + "Video" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(s[i].Nombre_video);
                    Console.WriteLine(s[i].Director);
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
                        if ((_filtro.Nombre_ == _valor) && (_filtro.Perfipublico_ == "publico"))
                        {
                            listafiltradausuarios.Add(_filtro);
                        }
                    }
                    break;
                case "Email":
                    foreach (User _filtro in listausuarios)
                    {
                        if ((_filtro.Email_ == _valor) && (_filtro.Perfipublico_ == "publico"))
                        {
                            listafiltradausuarios.Add(_filtro);
                        }
                    }
                    break;
                case "Id":
                    foreach (User _filtro in listausuarios)
                    {
                        if ((_filtro.Nombreusuario == _valor) && (_filtro.Perfipublico_ == "publico"))
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
                    Console.WriteLine(s[i].Nombreusuario);
                    Console.WriteLine(s[i].Nombre_);
                    Console.WriteLine(" ");
                }
            }
        }
        public static bool Cambiarprivacidadaprivado(string email, string contrasena)
        {
            string funko = "correcto";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Password_ == contrasena)
                    {
                        if (listausuarios[i].Perfipublico_ == "privado")
                        {
                            Console.Clear();
                            Console.WriteLine("Ya eras privado anteriormente");
                            Thread.Sleep(2000);
                            funko = "noup";
                            break;
                        }
                        else
                        {
                            listausuarios[i].Perfipublico_ = "privado";
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
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Password_ == contrasena)
                    {
                        if (listausuarios[i].Perfipublico_ == "publico")
                        {
                            Console.Clear();
                            Console.WriteLine("Ya eras publico anteriormente");
                            Thread.Sleep(2000);
                            funko = "noup";
                            break;
                        }
                        else
                        {
                            listausuarios[i].Perfipublico_ = "publico";
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

        public static void Crear_cantante(Artista cantante)
        {
            /*int h = 0;
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
            }*/
            lista_cantantes.Add(cantante);
            AlmacenarCantante(lista_cantantes);

        }

        public static bool Verificar_existencia_cantante(ref Artista cantante)
        {
            int h = 0, n2;
            foreach (Artista art in lista_cantantes)
            {
                if (art.Name == cantante.Name)
                {
                    h = 1;
                    Console.WriteLine("El cantante ya existe en nuestra base de datos");
                    Thread.Sleep(2000);
                    cantante = art;
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
                    Crear_cantante(cantante);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static void Crear_compositor(Artista compositor)
        {

            lista_compositores.Add(compositor);
            AlmacenarCompositores(lista_compositores);
            Console.WriteLine("Perfil del Compositor fue creado exitosamente.\n");

        }

        public static bool Verificar_existencia_compositor(ref Artista compositor)
        {
            int h = 0, n2;
            foreach (Artista comp in lista_compositores)
            {
                if (comp.Name == compositor.Name)
                {
                    h = 1;
                    Console.WriteLine("El compositor ya existe en nuestra base de datos");
                    Thread.Sleep(2000);
                    compositor = comp;
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
                    Crear_compositor(compositor);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static void Crear_director(Artista director)
        {
            lista_directores.Add(director);
            AlmacenarDirectores(lista_directores);
            Console.WriteLine("Perfil del Director fue creado exitosamente.\n");
        }


        public static bool Verificar_existencia_director(ref Artista director)
        {
            int h = 0, n2;
            foreach (Artista dire in lista_directores)
            {
                if (dire.Name == director.Name)
                {
                    h = 1;
                    Console.WriteLine("El director ya existe en nuestra base de datos");
                    Thread.Sleep(2000);
                    director = dire;
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
                    Crear_director(director);
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
                if (ac.Name == actor)
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
                    Crear_actor();
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

        public static bool Verificar_exisitencia_Album(string nombre_album, ref Artista cantante2)
        {
            int h = 0, n2;
            foreach (Artista cantante in lista_cantantes)
            {
                if (cantante.Name == cantante2.Name)
                {
                    cantante2 = cantante;
                    foreach (PlaylistSong album in cantante.Lista_album)
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
                                  "1--> Crear un Album\n" +
                                  "2--> No Agregar la cancion\n");
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
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Password_ == contrasena)
                    {
                        if (listausuarios[i].Premium_ == "premium")
                        {
                            
                            MessageBox.Show("YA ERAS PREMIUM ANTERIORMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            funko = "noupo";
                            break;
                        }
                        else
                        {
                            listausuarios[i].Premium_ = "premium";
                            MessageBox.Show("FELICIDADES "+email+" AHORA ERES UN USUARIO PREMIUM", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            if (funko =="noupo")
            {
                
                
                return false;
            }
            else
            {
                MessageBox.Show("EMAIL O CONTRASEÑA INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        public static void Agregar_a_favoritos(string email, Song s)
        {
            string funka = "";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email_ == email)
                {
                    listausuarios[i].Favorite_songs_.Add(s);
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
                if (listausuarios[i].Email_ == email)
                {
                    listausuarios[i].Favorite_videos_.Add(s);
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


        public static bool Aumentarreproduccionkaraoke(string nombrecancion, int reproduccion)
        {

            for (int i = 0; i < todas_las_canciones.Count; i++)
            {
                if (todas_las_cancioneskaraoke[i].Nombrecancion == nombrecancion)
                {
                    todas_las_cancioneskaraoke[i].Reproducciones += 0;
                    AlmacenarCanciones(todas_las_cancioneskaraoke);
                    return true;
                }
            }
            return false;
        }
        public static bool Aumentarreproduccionvideo(string nombrevideo, int reproduccion)
        {

            for (int i = 0; i < todas_las_canciones.Count; i++)
            {
                if (todos_los_videos[i].Nombre_video == nombrevideo)
                {
                    todos_los_videos[i].Reproduccion += 0;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistusuario_[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistusuario_[i].Listplay[posicion - 1].Nombrecancion;
                            }
                        }
                    }
                }
            }
            return info;



        }
        public static string Nombrereproducirfavoritoscancion(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_songs_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_songs_[posicion - 1].Nombrecancion;


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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_canciones_.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones_[posicion - 1].Nombrecancion;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_videos_.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos_[posicion - 1].Nombre_video;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_videos_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_videos_[posicion - 1].Nombre_video;


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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_songs_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_songs_[posicion - 1].Reproducciones;


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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_canciones_.Count > 0)
                    {
                        info = listausuarios[j].Historial_canciones_[posicion - 1].Reproducciones;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_videos_.Count > 0)
                    {
                        info = listausuarios[j].Historial_videos_[posicion - 1].Reproduccion;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_videos_.Count > 0)
                    {
                        info = listausuarios[j].Favorite_videos_[posicion - 1].Reproduccion;


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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistvideousuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistvideousuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistvideousuario_[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistvideousuario_[i].Listplayvideo[posicion - 1].Nombre_video;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_playlistusuario_.Count > 0)
                    {
                        for (int i = 0; i < listausuarios[j].Lista_playlistusuario_.Count; i++)
                        {
                            if (listausuarios[j].Lista_playlistusuario_[i].NombrePlaylist == nombreply)
                            {
                                info = listausuarios[j].Lista_playlistusuario_[i].Listplay[posicion - 1].Reproducciones;
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Descargas_.Count > 0)
                    {
                        info = listausuarios[j].Descargas_[posicion - 1].Nombrearchivo;
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
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Premium_ == "premium")
                    {
                        listausuarios[i].Descargas_.Add(s);
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
        public static bool Aumentarreproduccion(string nombrecancion, int reproduccion)
        {

            for (int i = 0; i < todas_las_canciones.Count; i++)
            {
                if (todas_las_canciones[i].Nombrecancion == nombrecancion)
                {
                    todas_las_canciones[i].Reproducciones += 0;
                    AlmacenarCanciones(todas_las_canciones);
                    return true;
                }
            }
            return false;
        }
        public static string Verinformaciondescargas(string email)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Descargas_.Count == 0)
                    {
                        info = "No hay canciones agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Descargas_.Count; i++)
                        {

                            Console.WriteLine("============");
                            Console.WriteLine("Canción" + " " + (i + 1));
                            Console.WriteLine("============");
                            Console.WriteLine(listausuarios[j].Descargas_[i].Informacioncancion());
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_songs_.Count == 0)
                    {
                        info = "No hay canciones agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Favorite_songs_.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Favorite_songs_[i].Informacioncancion() + " ";
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Favorite_videos_.Count == 0)
                    {
                        info = "No hay videos agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Favorite_videos_.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Favorite_videos_[i].Ver_informacion() + " ";
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_canciones_.Count == 0)
                    {
                        info = "No hay canciones agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Historial_canciones_.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Historial_canciones_[i].Informacioncancion() + " ";
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Historial_videos_.Count == 0)
                    {
                        info = "No hay videos agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Historial_videos_.Count; i++)
                        {
                            info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Historial_videos_[i].Ver_informacion() + " ";
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
                                info = listausuarios[j].Lista_playlistvideousuario[i].Listplayvideo[posicion - 1].reproducciones;
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
                if (listausuarios[i].Email_ == email)
                {
                    for (int j = 0; j < todas_las_canciones.Count; j++)
                        if (todas_las_canciones[j].Nombrearchivo == archivo)
                        {
                            listausuarios[i].Historial_canciones_.Add(todas_las_canciones[j]);
                        }
                }
            }
        }
        public static void Agregarvideoahistorial(string email, string archivo)
        {
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email_ == email)
                {
                    for (int j = 0; j < todos_los_videos.Count; j++)
                        if (todos_los_videos[j].Nombrearchivovideo == archivo)
                        {
                            listausuarios[i].Historial_videos_.Add(todos_los_videos[j]);
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
                if (listausuarios[i].Email_ == email)
                {
                    for (int j = 0; j < listausuarios[i].Usuarios_seguidos_.Count; j++)
                    {
                        if (listausuarios[i].Usuarios_seguidos_[j].Nombreusuario == u.Nombreusuario)
                        {
                            yalosigues = "si";
                        }
                    }
                    if (yalosigues != "si")
                    {
                        listausuarios[i].Usuarios_seguidos_.Add(u);
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
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Usuarios_seguidos_.Count == 0)
                    {
                        Console.WriteLine("No sigues a ningun usuario aún");
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Usuarios_seguidos_.Count; i++)
                        {

                            Console.WriteLine("============");
                            Console.WriteLine("Usuario" + " " + (i + 1));
                            Console.WriteLine("============");
                            Console.WriteLine(listausuarios[j].Usuarios_seguidos_[i].InformacionUsuario());
                            Console.WriteLine(" ");
                        }

                    }


                }

            }

        }
        public static void DarCalificacionCancion(int calificacion, string archivo)
        {
            for (int i = 0; i < todas_las_canciones.Count; i++)
            {
                if (todas_las_canciones[i].Nombrearchivo == archivo)
                {
                    todas_las_canciones[i].Todas_las_calificaciones.Add(calificacion);
                    AlmacenarCanciones(todas_las_canciones);
                }


            }
        }
        public static void DarCalificacionVideo(int calificacion, string archivo)
        {
            for (int i = 0; i < todos_los_videos.Count; i++)
            {
                if (todos_los_videos[i].Nombrearchivovideo == archivo)
                {
                    todos_los_videos[i].Todas_las_calificaciones.Add(calificacion);
                    AlmacenarVideos(todos_los_videos);
                }

            }
        }
        public static void Sacarpromediocalificacioncancion(string archivo)
        {
            int total = 0;
            for (int i = 0; i < todas_las_canciones.Count; i++)
            {
                if (todas_las_canciones[i].Nombrearchivo == archivo)
                {
                    for (int j = 0; j < todas_las_canciones[i].Todas_las_calificaciones.Count; j++)
                    {
                        total += todas_las_canciones[i].Todas_las_calificaciones[j];
                    }
                    todas_las_canciones[i].Calificacionpromedio = total / todas_las_canciones[i].Todas_las_calificaciones.Count;
                    AlmacenarCanciones(todas_las_canciones);
                }
            }
        }
        public static void Sacarpromediocalificacionvideo(string archivo)
        {
            int total = 0;
            for (int i = 0; i < todos_los_videos.Count; i++)
            {
                if (todos_los_videos[i].Nombrearchivovideo == archivo)
                {
                    for (int j = 0; j < todos_los_videos[i].Todas_las_calificaciones.Count; j++)
                    {
                        total += todos_los_videos[i].Todas_las_calificaciones[j];
                    }
                    todos_los_videos[i].Calificacion_promedio = total / todos_los_videos[i].Todas_las_calificaciones.Count;
                    AlmacenarVideos(todos_los_videos);
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
        public static bool Cambiarvalorcriterio(string email, string contrasena, string valorcriterio)
        {
            string funko = "correcto";
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Email_ == email)
                {
                    if (listausuarios[i].Password_ == contrasena)
                    {
                        listausuarios[i].Valorcriterio_ = valorcriterio;
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
        public static void Agregarcancioneslistainteligente(Song s)
        {
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (listausuarios[i].Valorcriterio_ == s.Nombrecancion)
                {
                    listausuarios[i].Lista_inteligente.Add(s);
                    Almacenar(listausuarios);


                }
                foreach (Artista c in lista_cantantes)
                {
                    if (c == s.Cantante)
                    {
                        if (listausuarios[i].Valorcriterio_ == c.Name)
                        {
                            listausuarios[i].Lista_inteligente.Add(s);

                            Almacenar(listausuarios);
                        }
                    }
                }
                if (listausuarios[i].Valorcriterio_ == s.Genero)
                {
                    listausuarios[i].Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                foreach (Artista c in lista_compositores)
                {
                    if (c == s.Compositor)
                    {
                        if (listausuarios[i].Valorcriterio_ == c.Name)
                        {
                            listausuarios[i].Lista_inteligente.Add(s);
                            Almacenar(listausuarios);
                        }
                    }
                }

                if (listausuarios[i].Valorcriterio_ == s.Anopublicacion)
                {
                    listausuarios[i].Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                if (listausuarios[i].Valorcriterio_ == s.Disquera)
                {
                    listausuarios[i].Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                if (listausuarios[i].Valorcriterio_ == s.Album)
                {
                    listausuarios[i].Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                else
                {
                    Console.WriteLine("NO SE AGREGÓ A NINGUNA LISTA INTELIGENTE");
                }



            }
        }
        public static void VerCancionesListainteligente(List<Song> lista)
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
        public static string Verinformacionlistainteligente(string email)
        {
            string info = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_inteligente.Count == 0)
                    {
                        info = "No hay canciones agregadas aún";
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Lista_inteligente.Count; i++)
                        {

                            Console.WriteLine("============");
                            Console.WriteLine("Canción" + " " + (i + 1));
                            Console.WriteLine("============");
                            Console.WriteLine(listausuarios[j].Lista_inteligente[i].Informacioncancion());
                            Console.WriteLine(" ");
                        }

                    }


                }

            }
            return info;
        }
        public static int Cuantaslistainteligente(string email)
        {
            int info = 0;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_inteligente.Count > 0)
                    {
                        info = listausuarios[j].Lista_inteligente.Count;
                    }
                }
            }
            return info;
        }
        public static string Archivolistainteligente(string email, int posicion)
        {
            string info = "No hay info";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email_ == email)
                {
                    if (listausuarios[j].Lista_inteligente.Count > 0)
                    {
                        info = listausuarios[j].Lista_inteligente[posicion - 1].Nombrearchivo;
                    }
                }
            }
            return info;
        }


        public static List<string> lista_criterios_filtro2v = new List<string>();       //    
        public static List<string> lista_criterios_filtro3v = new List<string>();       //      
        public static List<Video> lista_canciones_filtromiltiplev = new List<Video>();        //     
        public static List<Artista> lista_artistas_filtromiltiplev = new List<Artista>();        //     
        public static List<Video> lista_filtrandov = new List<Video>();        //    
        public static List<Video> canciones_filtradasv = new List<Video>();
        public static List<Video> lista_filtrando2v = new List<Video>();        //    
        public static List<Video> listafiltradav = new List<Video>();       // ?? ESTO NO SE Q ES????



        public static List<Video> VideosporGenero()
        {
            listafiltradav.Clear();
            string _valor = ShowOptions(lista_generos_peliculas);
            List<Video> interna = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna.Add(cc);
            }
            foreach (Video can in interna)
            {
                if (can.Genero == _valor)
                {
                    listafiltradav.Add(can);
                    lista_canciones_filtromiltiplev.Remove(can);
                }
            }
            return listafiltradav;
        }

        public static List<Video> Videosporfilmstudio()
        {
            listafiltradav.Clear();
            string _valor = ShowOptions(lista_disquera);
            List<Video> interna1 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna1.Add(cc);
            }
            foreach (Video canc in interna1)
            {
                if (canc.Film_studio == _valor)
                {
                    listafiltradav.Add(canc);
                    lista_canciones_filtromiltiplev.Remove(canc);

                }
            }
            return listafiltradav;
        }

        public static List<Video> Videosporaniopublicacion()
        {
            listafiltradav.Clear();
            List<Video> interna2 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna2.Add(cc);
            }
            Console.WriteLine("Ingrese el año:");
            string _valor = Console.ReadLine();
            foreach (Video canc in interna2)
            {
                if (int.Parse(canc.Anio_publicacion) == int.Parse(_valor))
                {
                    listafiltradav.Add(canc);// ver 
                    lista_canciones_filtromiltiplev.Remove(canc);

                }
            }
            return listafiltradav;
        }

        public static List<Video> Videosporcalidadvideo()
        {
            listafiltradav.Clear();
            List<Video> interna5 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna5.Add(cc);
            }
            string _valor = ShowOptions(lista_calidad_pelicula);
            foreach (Video ca in interna5)
            {
                if (ca.Calidad == _valor)
                {
                    listafiltradav.Add(ca);
                    lista_canciones_filtromiltiplev.Remove(ca);

                }

            }
            return listafiltradav;
        }


        public static List<Video> Videopornombre_actor()
        {
            string _valor = ShowOptions(Lista_nombres_actores());
            foreach (Artista art in lista_actores)
            {
                if (art.Name == _valor)
                {
                    foreach (Video can in art.Lista_peliculas)
                    {
                        listafiltradav.Add(can);
                    }
                }
            }
            return listafiltradav;
        }

        public static List<Video> Videopornombre_directores()
        {
            string _valor = ShowOptions(Lista_nombres_diectores());
            foreach (Artista art in lista_directores)
            {
                if (art.Name == _valor)
                {
                    foreach (Video can in art.Lista_peliculas)
                    {
                        listafiltradav.Add(can);
                    }
                }
            }
            return listafiltradav;
        }
        public static List<string> Lista_nombres_videos()
        {
            List<string> canc = new List<string>();
            foreach (Video cancion in todos_los_videos)
            {
                canc.Add(cancion.Nombre_video);
            }
            return canc;
        }


        public static List<Video> Videopornombrevideo()
        {
            string _valor = ShowOptions(Lista_nombres_videos());
            foreach (Video canc in todos_los_videos)
            {
                if (canc.Nombre_video == _valor)
                {
                    listafiltradav.Add(canc);
                }
            }
            return listafiltradav;
        }

        public static List<Video> Videoporcategoria()
        {
            string _valor = ShowOptions(lista_categoria);
            foreach (Video canc in todos_los_videos)
            {
                if (canc.Categoria == _valor)
                {
                    listafiltradav.Add(canc);
                }
            }
            return listafiltradav;
        }

        public static List<Video> Videoporevaluacion()
        {
            Console.WriteLine("Ingrese una nota del 1 al 10, se le mostraran todos los Videos que tengan una nota superior");
            float _valor = float.Parse(Console.ReadLine());
            foreach (Video canc in todos_los_videos)
            {
                if (canc.Calificacion_promedio >= _valor)
                {
                    listafiltradav.Add(canc);
                }
            }
            return listafiltradav;
        }




        public static List<Video> Filtroporcriteriovideo(string criterio)
        {
            lista_filtrandov.Clear();
            switch (criterio)
            {
                case "Genero":
                    lista_filtrandov = VideosporGenero();
                    break;
                case "Film Studio":

                    lista_filtrandov = Videosporfilmstudio();

                    break;
                case "Actores":
                    lista_filtrandov = Videopornombre_actor();
                    break;
                case "Director":
                    lista_filtrandov = Videopornombre_directores();
                    break;
                case "Categoria":
                    lista_filtrandov = Videoporcategoria();
                    break;
                case "Nombre":
                    lista_filtrandov = Videopornombrevideo();
                    break;
                case "Año Publicacion":
                    lista_filtrandov = Videosporaniopublicacion();

                    break;
                case "Calidad/Resolucion":
                    lista_filtrandov = Videosporcalidadvideo();

                    break;
                case "Evaluacion":

                    lista_filtrandov = Videoporevaluacion();

                    break;
                default:
                    Console.WriteLine("No existen canciones que cumplan con el criterio y valor seleccionado");
                    break;
            }
            return lista_filtrandov;
        }

        public static List<Video> Buqueda_simple_videos()
        {
            lista_canciones_filtromiltiplev.Clear();
            lista_artistas_filtromiltiplev.Clear();
            foreach (Video caca in todos_los_videos)
            {
                lista_canciones_filtromiltiplev.Add(caca);
            }
            foreach (Artista cancan in lista_actores)
            {
                lista_artistas_filtromiltiplev.Add(cancan);
            }
            foreach (Artista comcom in lista_directores)
            {
                lista_artistas_filtromiltiplev.Add(comcom);
            }

            Console.WriteLine("Seleccione uno de los siguientes Criterios de Busqueda:");
            string criterio;
            criterio = ShowOptions(lista_criterios_filtro2v);

            lista_filtrando2v.Clear();
            foreach (Video ss in Filtroporcriteriovideo(criterio))
            {
                lista_filtrando2v.Add(ss);
            }
            return lista_filtrando2v;
        }


        public static List<Video> filtro_multiple_video_or(string criterio)
        {
            lista_filtrando2v.Clear();

            switch (criterio)
            {
                case "Genero":
                    lista_filtrandov = VideosporGenero();
                    break;
                case "Film Studio":
                    lista_filtrandov = Videosporfilmstudio();
                    break;
                case "Actores":
                    lista_filtrandov = Videopornombre_actor();
                    break;
                case "Director":
                    lista_filtrandov = Videopornombre_directores();
                    break;
                case "Categoria":
                    lista_filtrandov = Videoporcategoria();
                    break;
                case "Nombre":
                    lista_filtrandov = Videopornombrevideo();
                    break;
                case "Año Publicacion":
                    lista_filtrandov = Videosporaniopublicacion();
                    break;
                case "Calidad/Resolucion":
                    lista_filtrandov = Videosporcalidadvideo();
                    break;
                case "Evaluacion":
                    lista_filtrandov = Videoporevaluacion();
                    break;
                default:
                    Console.WriteLine("No existen videos que cumplan con el criterio y valor seleccionado");
                    break;
            }
            return lista_filtrando2v;
        }

        public static List<Video> Buqueda_multiple_videos_or()
        {
            lista_canciones_filtromiltiplev.Clear();
            lista_artistas_filtromiltiplev.Clear();
            lista_criterios_filtro3v.Clear();
            foreach (Video caca in todos_los_videos)
            {
                lista_canciones_filtromiltiplev.Add(caca);
            }
            foreach (Artista cancan in lista_actores)
            {
                lista_artistas_filtromiltiplev.Add(cancan);
            }
            foreach (Artista comcom in lista_directores)
            {
                lista_artistas_filtromiltiplev.Add(comcom);
            }
            foreach (string cricri in lista_criterios_filtro2v)
            {
                lista_criterios_filtro3v.Add(cricri);
            }
            canciones_filtradasv.Clear();

            Console.WriteLine("Los criterios para busqueda multiple son los siguientes:");
            int num = 0, num_select = 1;
            foreach (string cri in lista_criterios_filtro3v)
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
                criterio = ShowOptions(lista_criterios_filtro3v);
                lista_criterios_filtro3v.Remove(criterio);
                criterios_seleccionados.Add(criterio);
                num_select++;
            }
            Console.Clear();
            Console.WriteLine("Usted selecciono buscar por:");
            foreach (string c in criterios_seleccionados)
            {
                Console.WriteLine(" - " + c);
            }
            foreach (string crit in criterios_seleccionados)
            {

                lista_filtrando2v.Clear();
                foreach (Video ss in filtro_multiple_video_or(crit))
                {

                    lista_filtrando2v.Add(ss);
                }
                foreach (Video ccc in lista_filtrando2v)
                {
                    int si = 0;
                    foreach (Video canc in canciones_filtradasv)
                    {
                        if (ccc.Nombre_video == canc.Nombre_video)
                        {
                            si++;
                        }
                    }
                    if (si == 0)
                    {
                        canciones_filtradasv.Add(ccc);
                    }
                }
            }
            return canciones_filtradasv;
        }


        public static List<Video> filtro_multiple_video_and(string criterio)
        {
            lista_filtrandov.Clear();
            switch (criterio)
            {
                case "Genero":
                    lista_filtrandov = VideosporGenero();
                    break;
                case "Film Studio":
                    lista_filtrandov = Videosporfilmstudio();
                    break;
                case "Actores":
                    lista_filtrandov = Videopornombre_actor();
                    break;
                case "Director":
                    lista_filtrandov = Videopornombre_directores();
                    break;
                case "Categoria":
                    lista_filtrandov = Videoporcategoria();
                    break;
                case "Nombre":
                    lista_filtrandov = Videopornombrevideo();
                    break;
                case "Año Publicacion":
                    lista_filtrandov = Videosporaniopublicacion();
                    break;
                case "Calidad/Resolucion":
                    lista_filtrandov = Videosporcalidadvideo();
                    break;
                case "Evaluacion":
                    lista_filtrandov = Videoporevaluacion();
                    break;
                default:
                    Console.WriteLine("No existen videos que cumplan con el criterio y valor seleccionado");
                    break;
            }
            return lista_filtrandov;
        }
        public static List<Video> Buqueda_multiple_videos_and()
        {
            lista_canciones_filtromiltiplev.Clear();
            lista_artistas_filtromiltiplev.Clear();
            lista_criterios_filtro3v.Clear();
            foreach (Video caca in todos_los_videos)
            {
                lista_canciones_filtromiltiplev.Add(caca);
            }
            foreach (Artista cancan in lista_actores)
            {
                lista_artistas_filtromiltiplev.Add(cancan);
            }
            foreach (Artista comcom in lista_directores)
            {
                lista_artistas_filtromiltiplev.Add(comcom);
            }
            foreach (string cricri in lista_criterios_filtro2v)
            {
                lista_criterios_filtro3v.Add(cricri);
            }
            canciones_filtradasv.Clear();

            Console.WriteLine("Los criterios para busqueda multiple son los siguientes:");
            int num = 0, num_select = 1;
            foreach (String cri in lista_criterios_filtro3v)
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
                criterio = ShowOptions(lista_criterios_filtro3v);
                lista_criterios_filtro3v.Remove(criterio);
                criterios_seleccionados.Add(criterio);
                num_select++;
            }
            Console.Clear();
            Console.WriteLine("Usted selecciono buscar por:");
            foreach (string c in criterios_seleccionados)
            {
                Console.WriteLine(" - " + c);
            }
            lista_filtrando2.Clear();
            foreach (Video ss in filtro_multiple_video_and(criterios_seleccionados[0]))
            {
                lista_filtrando2v.Add(ss);
            }
            foreach (Video ccc in lista_filtrando2v)
            {
                canciones_filtradasv.Add(ccc);
            }
            int count2 = 1;
            while (count2 < num)
            {
                lista_filtrando2v.Clear();
                foreach (Video ss in filtro_multiple_video_and(criterios_seleccionados[count2]))
                {
                    canciones_filtradasv.Clear();
                    canciones_filtradasv.Add(ss);
                }
                count2++;
            }
            if (lista_filtrada_finalv.Count == 0)
            {
                Console.WriteLine("");


            }
            int si;
            foreach (Video ccc in canciones_filtradasv)
            {
                si = 0;
                foreach (Video canc in lista_filtrada_finalv)
                {

                    if ((ccc.Nombre_video == canc.Nombre_video) && (ccc.Director.Name == canc.Director.Name))
                    {
                        si++;
                    }
                }
                if (si == 0)
                {
                    lista_filtrada_finalv.Add(ccc);
                }
            }
            return lista_filtrada_finalv;
        }
        
    }
}