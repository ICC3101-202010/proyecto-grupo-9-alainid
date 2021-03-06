﻿using System;
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
using ALAINID_DEFINITIVO;
using System.Text.RegularExpressions;

namespace Proyecto_Forms
{
    public static class ALAINID
    {
       
        public static List<User> listausuarios = new List<User>();          // TODOS LOS USUARIOS DE ALAINID
        public static List<Song> todas_las_canciones = new List<Song>();      // TODAS LAS CANCIONES EN ALAINID
        public static List<Video> todos_los_videos = new List<Video>();         // TODOS LOS VIDEOS DE ALAINID
        public static List<Song> todas_las_cancioneskaraoke = new List<Song>(); // TODAS LAS CANCIONES KARAOKE DE ALAINID
        public static List<Artista> lista_actores = new List<Artista>();        // TODOS LOS ACTORES EN ALAINID
        public static List<Artista> lista_directores = new List<Artista>();     // TODOS LOS DIRECTORES EN ALAINID
        public static List<Artista> lista_cantantes = new List<Artista>();     // TODOS LOS CANTANTES EN ALAINID
        public static List<Artista> lista_compositores = new List<Artista>();   // TODOS LOS COMPOSITORES EN ALAINID

        public static List<string> lista_generos_canciones = new List<string>();       // TODOS LOS GENEROS DE CANCIONES QUE EXISTEN DE ALAINID
        public static List<string> lista_disquera = new List<string>();             // TODAS LAS DISQUERAS DISPONIBLES EN ALAINID
        public static List<string> lista_generos_peliculas = new List<string>();     // TODOS LOS GENEROS DE VIDEOS QUE EXISTEN DE ALAINID
        public static List<string> lista_calidad_cancion = new List<string>();       // TODAS LAS CALIDADES DE CANCIONES QUE SOPORTA EN  ALAINID
        public static List<string> lista_tipoarchivo_cancion = new List<string>();    // TODOS TIPOS DE ARCHIVO DE CANCIONES QUE SOPORTA  ALAINID
        public static List<string> lista_calidad_pelicula = new List<string>();      // TODAS LAS CALIDADES DE VIEOS QUE SOPORTA EN  ALAINID
        public static List<string> lista_tipoarchivo_pelicula = new List<string>();    // TODOS TIPOS DE ARCHIVO DE VIDEOS QUE SOPORTA  ALAINID
        public static List<string> lista_categoria = new List<string>();            // CATEGORIAS DE PELICULAS- VIDEOS EN ALAINID
        public static List<string> lista_criterios_usuarios = new List<string>();     // CRITERIOS PARA BUSCAR USUARIOS
        public static List<PlaylistSong> todos_los_albumes = new List<PlaylistSong>();// TODOS LOS ALBUMES DE ALAINID
        public static List<string> sexo = new List<string>();                         // MASCULINO / FEMEMNINO
        public static List<string> edades = new List<string>();                      //INTERVALOS DE EDADES PARA LAS BUSQUEDAS

        public static List<Song> cancionfavoritabuscada = new List<Song>();
        public static List<Video> videofavoritobuscado = new List<Video>();

        public static List<Song> lista_filtrada_final = new List<Song>();            // LISTA UTILIZADA PARA LAS BUSQUEDAS MULTIPLES
        public static List<Video> lista_filtrada_finalv = new List<Video>();          // LISTA UTILIZADA PARA LAS BUSQUEDAS MULTIPLES
        public static List<String> lista_disqueravideo = new List<String>();          // LISTA UTILIZADA PARA LAS BUSQUEDAS MULTIPLES
        public static List<Video> listafiltrada3 = new List<Video>();            // LISTA UTILIZADA PARA LAS BUSQUEDAS MULTIPLES
        public static List<Song> listafiltrada = new List<Song>();                // LISTA UTILIZADA PARA LAS BUSQUEDAS MULTIPLES
        public static List<User> listafiltradausuarios = new List<User>();           // LISTA UTILIZADA PARA LAS BUSQUEDAS MULTIPLES
        public static List<Song> listafiltrada2 = new List<Song>();                 // LISTA UTILIZADA PARA LAS BUSQUEDAS MULTIPLES










        //======================TODO LO QUE ES SERIALIZATION=====================================
        //======================TODO LO QUE ES SERIALIZATION=====================================
        //======================TODO LO QUE ES SERIALIZATION=====================================
        //======================TODO LO QUE ES SERIALIZATION=====================================
        //======================TODO LO QUE ES SERIALIZATION=====================================
        //======================TODO LO QUE ES SERIALIZATION=====================================

        public static void Activar_todo()// implementa todos los metodos de activas o partir de una
        {
            todos_los_albumes = CargarAlbum();
            lista_actores = CargarActores();
            lista_directores = CargarDirectores();
            lista_compositores = CargarCompositores();
            todos_los_videos = CargarVideos();
            todas_las_canciones = CargarCancion();
            listausuarios = Cargar();
            todas_las_cancioneskaraoke = CargarKaraoke();
            lista_cantantes = CargarCantantes();
            
        }

    
        public static void Almacenar_todo() // imoplementa todos los metodos de almacenamiento de una
        {
            AlmacenarCompositores(lista_compositores);
            AlmacenarDirectores(lista_directores);
            AlmacenarActores(lista_actores);
            AlmacenarAlbum(todos_los_albumes);
            AlmacenarCanciones(todas_las_canciones);
            AlmacenarVideos(todos_los_videos);
            AlmacenarCantante(lista_cantantes);
            Almacenar(listausuarios);
            AlmacenarKaraoke(todas_las_cancioneskaraoke);
            
        }


        /// todo lo que es partir partiendo parti con gubbins
        // ESTAS CARGAN AL PROGRAMA LOS ARCHIUVOS GUARDADOS ANTERIORMENTE 

        public static void Activarlistacantantes()
        {
            lista_cantantes = CargarCantantes();
        }
        public static void activark()
        {
            todas_las_cancioneskaraoke = CargarKaraoke();
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
        public static void Partirlistacompositores()
        {
            lista_compositores = CargarCompositores();
        }
        public static void Partirlistadirectores()
        {
            lista_directores = CargarDirectores();
        }
        public static void Partirlistaactores()
        {
            lista_actores = CargarActores();
        }
        public static void Partirlistaalbumes()
        {
            todos_los_albumes = CargarAlbum();
        }




        //todo lo que es almacenar almacenando almacenamos con gubbins
        // ESTAS GUARDAN EN LOS ARCHIVOS LOS DATOS INGRESADOS EN CADA SESION 

        public static void Partirkaraoke()          // ESTAS ALMACENAN PERO TIENEN NOMBRE DE PARTIR
        {
            AlmacenarKaraoke(todas_las_cancioneskaraoke);
        }
        public static void Partir()             // ESTAS ALMACENAN PERO TIENEN NOMBRE DE PARTIR
        {
            AlmacenarCanciones(todas_las_canciones);
        }    
        public static void AlmacenarCompositores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("../../Compositores.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static void AlmacenarDirectores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("../../Directores.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static void AlmacenarActores(List<Artista> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("../../Actores.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static void AlmacenarAlbum(List<PlaylistSong> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("../../Albums.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static void AlmacenarCanciones(List<Song> s)      //Serializamos
        {
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("../../Canciones.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter3.Serialize(stream3, s);
            stream3.Close();
        }
        public static void AlmacenarVideos(List<Video> u)      //Serializamos
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("../../Videos.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter5.Serialize(stream5, u);
            stream5.Close();
        }
        public static void AlmacenarCantante(List<Artista> a)      //Serializamos
        {
            IFormatter formatter7 = new BinaryFormatter();
            Stream stream7 = new FileStream("../../Cantantes.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter7.Serialize(stream7, a);
            stream7.Close();
        }
        public static void Almacenar(List<User> u)      //Serializamos
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../Usuarios2.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, u);
            stream.Close();
        }
        public static void AlmacenarKaraoke(List<Song> k)      //Serializamos
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../Cancioneskaraoke.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, k);
            stream.Close();
        }



        // todo lo que es cargar con gubbins
        // ESTAS RETORNAN UNA LISTA PARA LUEGO SER ALMACENADAS EN ACTIVAR/PARTIR

        public static List<Artista> CargarCompositores()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("../../Compositores.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Artista> v = new List<Artista>();
                stream6.Close();
                return v;
            }
        }
        public static List<Artista> CargarDirectores()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("../../Directores.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            try
            {
                List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Artista> v = new List<Artista>();
                stream6.Close();
                return v;
            }
        }
        public static List<Artista> CargarActores()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("../../Actores.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            try
            {
                List<Artista> v = (List<Artista>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Artista> v = new List<Artista>();
                stream6.Close();
                return v;
            }
        }
        public static List<PlaylistSong> CargarAlbum()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("../../Albums.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            try
            {
                List<PlaylistSong> v = (List<PlaylistSong>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<PlaylistSong> v = new List<PlaylistSong>();
                stream6.Close();
                return v;
            }
        }
        static List<Song> CargarCancion()
        {
            IFormatter formatter4 = new BinaryFormatter();
            Stream stream4 = new FileStream("../../Canciones.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            try
            {
                List<Song> s2 = (List<Song>)formatter4.Deserialize(stream4);
                stream4.Close();
                return s2;
            }
            catch
            {
                List<Song> s2 = new List<Song>();
                Thread.Sleep(5000);
                stream4.Close();
                return s2;
            }
        }
        public static List<Video> CargarVideos()
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("../../Videos.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            try
            {
                List<Video> v = (List<Video>)formatter6.Deserialize(stream6);
                stream6.Close();
                return v;
            }
            catch
            {
                List<Video> v = new List<Video>();
                stream6.Close();
                return v;
            }
        }
        public static List<Artista> CargarCantantes()
        {
            IFormatter formatter8 = new BinaryFormatter();
            Stream stream8 = new FileStream("../../Cantantes.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                List<Artista> ar = (List<Artista>)formatter8.Deserialize(stream8);
                stream8.Close();
                return ar;
            }
            catch
            {
                List<Artista> ar = new List<Artista>();
                stream8.Close();
                return ar;
            }
        }
        public static List<User> Cargar()
        {
            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("../../Usuarios2.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                List<User> p = (List<User>)formatter2.Deserialize(stream2);
                stream2.Close();
                return p;
            }
            catch
            {
                List<User> p = new List<User>();
                stream2.Close();
                return p;
            }
        }
        public static List<Song> CargarKaraoke()
        {
            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("../../Cancioneskaraoke.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            try
            {
                List<Song> k3 = (List<Song>)formatter2.Deserialize(stream2);
                stream2.Close();
                return k3;
            }
            catch
            {
                List<Song> k3 = new List<Song>();
                stream2.Close();
                return k3;
            }
        }


        //======================HASTA AQUI ES TODO LO QUE ES SERIALIZATION===============================
        //======================HASTA AQUI ES TODO LO QUE ES SERIALIZATION===============================
        //======================HASTA AQUI ES TODO LO QUE ES SERIALIZATION===============================
        //======================HASTA AQUI ES TODO LO QUE ES SERIALIZATION===============================
        //======================HASTA AQUI ES TODO LO QUE ES SERIALIZATION===============================
        //======================HASTA AQUI ES TODO LO QUE ES SERIALIZATION===============================








        public static bool comprobar_mail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
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

        
        
        public static string cachativa;
        
       
       
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
       
        

        public static string Agregarcancionaply(string email, string nombreply, Song cancion)
        {
            string info = "No se pudo agregar la cancion a la playlist";
            string funko = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email_ == email)
                {
                    foreach(PlaylistSong ply in listausuarios[j].Lista_playlistusuario_)
                    if (ply.NombrePlaylist.ToLower()==nombreply.ToLower())
                    {
                        ply.Listplay.Add(cancion);
                        Almacenar(listausuarios);
                        
                        funko = "si";
                    }

                }
            }
            if (funko == "si")
            {
                MessageBox.Show("Cancion agregada a playlist de forma exitosa", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            return info;
        }
        public static string Agregarvideoaply(string email, string nombreply, Video video)
        {
            string info = "No se pudo agregar el video a la playlist";
            string funko = "";
            for (int j = 0; j < listausuarios.Count; j++)
            {
                if (listausuarios[j].Email_ == email)
                {
                    foreach (PlaylistVideo ply in listausuarios[j].Lista_playlistvideousuario_)
                        if (ply.NombrePlaylist.ToLower() == nombreply.ToLower())
                        {
                            ply.Listplayvideo.Add(video);
                            Almacenar(listausuarios);
                            funko = "si";
                        }
                }
            }
            if (funko == "si")
            {
                MessageBox.Show("Video agregado a playlist de forma exitosa", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Por favor eleccione una playlist valida", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                if ((ui.Email_ == "") || (u1.Nombreusuario == "") || (u1.Password_ == "") || (u1.Nombre_ == ""))
                {
                    MessageBox.Show("No Puede Dejar Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return false;
                } else if (ui.Email_ == u1.Email_ || ui.Nombreusuario == u1.Nombreusuario)
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
            int uno;
            foreach (User user in listausuarios)
            {
                uno = 0;
                if (user.Nombreusuario == Program.usuario_activo.Nombreusuario)
                {
                    uno = 1;
                }
                else
                {
                    uno = 2;
                }
                if (uno == 2)
                {
                    if (user.Nombreusuario == nuevonombre)
                    {
                        MessageBox.Show("El Nombre de Usuario Ya Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        funko = "noup";
                    }
                }


            }
            if (funko != "noup")
            {
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
                            MessageBox.Show(email + " YA ERAS PRIVADO ANTERIORMENTE", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        public static void Crear_cantante(Artista cantante)
        {
            lista_cantantes.Add(cantante);
            AlmacenarCantante(lista_cantantes);
        }

        public static bool Verificar_existencia_cantante(ref Artista cantante)
        {
            int h = 0;
            foreach (Artista art in lista_cantantes)
            {
                if (art.Name == cantante.Name)
                {
                    h = 1;


                    cantante = art;
                    return true;
                }
            }
            if (h == 0)
            {
                Crear_cantante(cantante);
                return true;
            }
            return false;
        }

        public static void Crear_compositor(Artista compositor)
        {

            lista_compositores.Add(compositor);
            AlmacenarCompositores(lista_compositores);


        }

        public static bool Verificar_existencia_compositor(ref Artista compositor)
        {
            int h = 0;
            foreach (Artista comp in lista_compositores)
            {
                if (comp.Name == compositor.Name)
                {
                    h = 1;


                    compositor = comp;
                    return true;
                }
            }
            if (h == 0)
            {
                Crear_compositor(compositor);
                return true;


            }
            return false;
        }

        public static void Crear_director(Artista director)
        {
            lista_directores.Add(director);
            AlmacenarDirectores(lista_directores);
            Console.WriteLine("Perfil del Director fue creado exitosamente.\n");
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

        public static void Crear_Album(string nombre)
        {
            int existe = 0;
            foreach (PlaylistSong alb in todos_los_albumes)
            {
                if (alb.NombrePlaylist.ToLower() == nombre.ToLower())
                {
                    existe = 1;
                }
            }
            if (existe != 1)
            {
                PlaylistSong album = new PlaylistSong(nombre, "admin");
                todos_los_albumes.Add(album);
                AlmacenarAlbum(todos_los_albumes);
            }
        }

        public static bool Verificar_exisitencia_Album(string nombre_album, ref Artista cantante2)
        {
            int h = 0;
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
                    Crear_Album(nombre_album);
                    return true;
                }
            }
            return false;
        }
        //=======================PREMIUM======================================================================0
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

                            MessageBox.Show("YA ERAS PREMIUM ANTERIORMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                            funko = "noupo";
                            break;
                        }
                        else
                        {
                            listausuarios[i].Premium_ = "premium";
                            MessageBox.Show("FELICIDADES " + email + " AHORA ERES UN USUARIO PREMIUM", "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            if (funko == "noupo")
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
            Activar_todo();
            int esta = 0;
            foreach(User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                if(email.ToLower() == user.Email_.ToLower())
                {
                    foreach(Song song in user.Favorite_songs_)
                    {
                        if(s.Nombrecancion==song.Nombrecancion && s.Cantante.Name== song.Cantante.Name)
                        {
                            esta = 1;
                            MessageBox.Show("LA CANCION YA ESTA EN TUS FAVORITOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                    }
                    if (esta == 0)
                    {
                        user.Favorite_songs_.Add(s);
                        Almacenar(listausuarios);
                        MessageBox.Show("CANCION AGREGADA CORRECTAMENTE A FAVORITOS", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
        }
        public static void Agregar_video_a_favoritos(string email, Video s)
        {
            Activar_todo();
            int esta = 0;
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                if (email.ToLower() == user.Email_.ToLower())
                {
                    foreach (Video video in user.Favorite_videos_)
                    {
                        if (s.Nombre_video == video.Nombre_video && s.Director.Name == video.Director.Name)
                        {
                            esta = 1;
                            MessageBox.Show("EL VIDEO YA ESTA EN TUS FAVORITOS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                    }
                    if (esta == 0)
                    {
                        user.Favorite_videos_.Add(s);
                        Almacenar(listausuarios);
                        MessageBox.Show("VIDEO AGREGADO CORRECTAMENTE A FAVORITOS", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
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
            Activar_todo();
            int esta = 0;
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                if (email.ToLower() == user.Email_.ToLower())
                {
                    if (user.Premium_ == "premium")
                    {
                        foreach (Song song in user.Descargas_)
                        {
                            if (s.Nombrecancion == song.Nombrecancion && s.Cantante.Name == song.Cantante.Name)
                            {
                                esta = 1;
                                MessageBox.Show("LA CANCION YA ESTA EN TUS DESCARGAS", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);

                            }
                        }
                        if (esta == 0)
                        {
                            user.Descargas_.Add(s);
                            Almacenar(listausuarios);
                            MessageBox.Show("CANCION AGREGADA CORRECTAMENTE A DESCARGAS", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        MessageBox.Show("DEBES SER PREMIUM PARA DESCARGAR CANCIONES", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                }
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

                            //arreglar aqui???
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
                            //info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Historial_canciones_[i].Informacioncancion() + " ";
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
                            //info += "============\nCanción" + " " + (i + 1) + "============" + listausuarios[j].Historial_videos_[i].Ver_informacion() + " ";
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

        public static void Aumentarreproduccionvideo(Video v)
        {

            Activar_todo();
            foreach (Video video in Proyecto_Forms.ALAINID.todos_los_videos)
            {
                if (video.Nombre_video == v.Nombre_video)
                {
                    video.Reproduccion += 1;
                    AlmacenarVideos(todos_los_videos);
                }

            }
        }
        public static void Aumentarreproduccion(Song s)
        {
            Activar_todo();
            foreach (Song song in Proyecto_Forms.ALAINID.todas_las_canciones)
            {
                if (song.Nombrecancion == s.Nombrecancion)
                {
                    song.Reproducciones += 1;
                    AlmacenarCanciones(todas_las_canciones);
                }

            }
        }



        public static void Agregarcancionahistorial(string email, Song s)
        {
            Activar_todo();
            int esta = 0;
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                if (email.ToLower() == user.Email_.ToLower())
                {

                    user.Historial_canciones_.Add(s);
                    Almacenar(listausuarios);
                   
                }
            }
        }
        public static void Agregarvideoahistorial(string email, Video v)
        {
            Activar_todo();
            int esta = 0;
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                if (email.ToLower() == user.Email_.ToLower())
                {

                    user.Historial_videos_.Add(v);
                    Almacenar(listausuarios);

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
                //Console.WriteLine("USUARIO SEGUIDO EXIOSAMENTE");
            }
            else
            {
                //Console.WriteLine("FALLA AL SEGUIR AL USUARIO");
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
                        //Console.WriteLine("No sigues a ningun usuario aún");
                    }
                    else
                    {
                        for (int i = 0; i < listausuarios[j].Usuarios_seguidos_.Count; i++)
                        {


                            //Console.WriteLine(listausuarios[j].Usuarios_seguidos_[i].InformacionUsuario());
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
                    if (todas_las_canciones[i].Todas_las_calificaciones.Count != 0)
                    {
                        todas_las_canciones[i].Calificacionpromedio = total / todas_las_canciones[i].Todas_las_calificaciones.Count;
                        AlmacenarCanciones(todas_las_canciones);
                    }
                   
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
                    if (todos_los_videos[i].Todas_las_calificaciones.Count != 0)
                    {
                        todos_los_videos[i].Calificacion_promedio = total / todos_los_videos[i].Todas_las_calificaciones.Count;
                        AlmacenarVideos(todos_los_videos);
                    }
                }
            }
        }
        
        public static void Cambiarvalorcriterio(string email, string valorcriterio)
        {
            Activar_todo();

            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                if (email.ToLower() == user.Email_.ToLower())
                {
                    user.Lista_inteligente.Clear();
                    user.Valorcriterio_ = valorcriterio;
                    MessageBox.Show("CRITERIO ACTUALIZADO, DESDE AHORA EN ADELANTE LAS CANCIONES QUE SE AGREGEN CON ESE CRITERIO SE AGREGARAN A TU LISTA", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Almacenar(listausuarios);

                }
            }
        }
        public static void Agregarcancioneslistainteligente(Song s)
        {
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {

                if (user.Valorcriterio_.ToLower() == s.Nombrecancion.ToLower())
                {
                    user.Lista_inteligente.Add(s);
                    Almacenar(listausuarios);


                }
                foreach (Artista c in lista_cantantes)
                {
                    if (c == s.Cantante)
                    {
                        if (user.Valorcriterio_.ToLower() == c.Name.ToLower())
                        {
                            user.Lista_inteligente.Add(s);

                            Almacenar(listausuarios);
                        }
                    }
                }
                if (user.Valorcriterio_.ToLower() == s.Genero.ToLower())
                {
                    user.Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                foreach (Artista c in lista_compositores)
                {
                    if (c == s.Compositor)
                    {
                        if (user.Valorcriterio_.ToLower() == c.Name.ToLower())
                        {
                            user.Lista_inteligente.Add(s);
                            Almacenar(listausuarios);
                        }
                    }
                }

                if (user.Valorcriterio_ == s.Anopublicacion)
                {
                    user.Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                if (user.Valorcriterio_.ToLower() == s.Disquera.ToLower())
                {
                    user.Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                if (user.Valorcriterio_.ToLower() == s.Album.ToLower())
                {
                    user.Lista_inteligente.Add(s);
                    Almacenar(listausuarios);
                }
                else
                {

                }



            }
        }
        public static void VerCancionesListainteligente(List<Song> lista)
        {

            if (lista.Count == 0)
            {
                //Console.WriteLine("No hay canciones agregadas aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    //Console.WriteLine(lista[i].InformacioncancionKaraoke());
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
                            //Console.WriteLine(listausuarios[j].Lista_inteligente[i].Informacioncancion());
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
        
        // METODOS FILTROS VIDEO=============================================================================
        // METODOS FILTROS VIDEO=============================================================================
        // METODOS FILTROS VIDEO=============================================================================
        // METODOS FILTROS VIDEO=============================================================================
        // METODOS FILTROS VIDEO=============================================================================
        // METODOS FILTROS VIDEO=============================================================================

        public static List<Video> lista_canciones_filtromiltiplev = new List<Video>();           
        public static List<Artista> lista_artistas_filtromiltiplev = new List<Artista>();          
        public static List<Video> lista_filtrandov = new List<Video>();          
        public static List<Video> canciones_filtradasv = new List<Video>();
        public static List<Video> lista_filtrando2v = new List<Video>();        
        public static List<Video> listafiltradav = new List<Video>(); 
        public static List<Video> vargas_filtrandovideo = new List<Video>();

        public static List<Video> VideosporGenero(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna.Add(cc);
            }
            foreach (Video can in interna)
            {
                if (can.Genero.ToLower() == _valor)
                {
                    listafiltradav.Add(can);
                    lista_canciones_filtromiltiplev.Remove(can);
                }
            }
            return listafiltradav;
        }
        public static List<Video> Videosporfilmstudio(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna1 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna1.Add(cc);
            }
            foreach (Video canc in interna1)
            {
                if (canc.Film_studio.ToLower() == _valor.ToLower())
                {
                    listafiltradav.Add(canc);
                    lista_canciones_filtromiltiplev.Remove(canc);

                }
            }
            return listafiltradav;
        }
        public static List<Video> Videosporaniopublicacion(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna2 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna2.Add(cc);
            }
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
        public static List<Video> Videosporcalidadvideo(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna5 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna5.Add(cc);
            }
            foreach (Video ca in interna5)
            {
                if (ca.Calidad.ToLower() == _valor.ToLower())
                {
                    listafiltradav.Add(ca);
                    lista_canciones_filtromiltiplev.Remove(ca);

                }

            }
            return listafiltradav;
        }

        public static List<Artista> artistas_busqueda = new List<Artista>();
        public static List<Video> Videopornombre_artista(string _valor)
        {
            artistas_busqueda.Clear();
            List<Video> videos_busq = new List<Video>();
            Proyecto_Forms.ALAINID.Activar_todo();
            if (_valor != "")
            {
                int esta = 0;
                foreach (Artista actor in Proyecto_Forms.ALAINID.lista_actores)
                {
                    var q = false;
                    q = actor.Name.ToLower().StartsWith(_valor.ToLower());
                   
                    if (q == true)
                    {
                        foreach (Artista artista in artistas_busqueda)
                        {
                            if (actor.Name == artista.Name)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            artistas_busqueda.Add(actor);
                        }
                    }
                }
                
                foreach (Artista director in Proyecto_Forms.ALAINID.lista_directores)
                {
                    
                    var q = false;
                    q = director.Name.ToLower().StartsWith(_valor.ToLower());
                    esta = 0;
                    if (q == true)
                    {
                        foreach (Artista artista in artistas_busqueda)
                        {
                            if (director.Name == artista.Name)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            artistas_busqueda.Add(director);
                        }
                    }
                }
                esta = 0;
                foreach(Video video in todos_los_videos)
                {

                    foreach (Artista ar in artistas_busqueda)
                    {
                        foreach(Video vid in videos_busq)
                        {
                            if (vid.Nombrearchivovideo == video.Nombrearchivovideo)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            if (video.Director.Name == ar.Name)
                            {
                                videos_busq.Add(video);
                            }
                        }
                        foreach (Video vid in videos_busq)
                        {
                            if (vid.Nombrearchivovideo == video.Nombrearchivovideo)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            foreach(Artista actor in video.Actores)
                            {
                                if (actor.Name == ar.Name)
                                {
                                    videos_busq.Add(video);
                                }
                            }
                        }
                    }
                }
            }
            return videos_busq;
        }
        public static List<Song> Cancionespornombre_artista(string _valor)
        {
            artistas_busqueda.Clear();
            List<Song> canciones_busq = new List<Song>();
            Proyecto_Forms.ALAINID.Activar_todo();
            if (_valor != "")
            {
                int esta = 0;
                foreach (Artista cantante in Proyecto_Forms.ALAINID.lista_cantantes)
                {
                    var q = false;
                    q = cantante.Name.ToLower().StartsWith(_valor.ToLower());
                    esta = 0;
                    if (q == true)
                    {
                        foreach (Artista artista in artistas_busqueda)
                        {
                            if (cantante.Name == artista.Name)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            artistas_busqueda.Add(cantante);
                        }
                    }
                }
                foreach (Artista compositor in Proyecto_Forms.ALAINID.lista_compositores)
                {
                    var q = false;
                    q = compositor.Name.ToLower().StartsWith(_valor.ToLower());
                    esta = 0;
                    if (q == true)
                    {
                        foreach (Artista artista in artistas_busqueda)
                        {
                            if (compositor.Name == artista.Name)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            artistas_busqueda.Add(compositor);
                        }
                    }
                }
                esta = 0;
                foreach (Song song in todas_las_canciones)
                {

                    foreach (Artista ar in artistas_busqueda)
                    {
                        foreach (Song son in canciones_busq)
                        {
                            if (son.Nombrearchivo == song.Nombrearchivo)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            if (song.Cantante.Name == ar.Name)
                            {
                                canciones_busq.Add(song);
                            }
                        }
                        foreach (Song son in canciones_busq)
                        {
                            if (son.Nombrearchivo == song.Nombrearchivo)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            if (song.Compositor.Name == ar.Name)
                            {
                                canciones_busq.Add(song);
                            }
                        }
                    }
                }
            }
            return canciones_busq;
        }
        
        public static List<Video> Videopornombrevideo(string _valor)
        {
            listafiltradav.Clear();
            int esta = 0;
            if (_valor != "")
            {
                foreach (Video vid in todos_los_videos)
                {
                    var q = false;
                    q = vid.Nombre_video.ToLower().StartsWith(_valor.ToLower());
                    if (q == true)
                    {
                        foreach(Video video in listafiltradav)
                        {
                            if (video.Nombrearchivovideo == vid.Nombrearchivovideo )
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            listafiltradav.Add(vid);
                        }
                       
                    }
                }
            }
            
            return listafiltradav;
        }
        public static List<Video> Videoporcategoria(string _valor)
        {
            foreach (Video canc in todos_los_videos)
            {
                string cat = canc.Categoria.ToLower();
                if (cat.ToLower() == _valor.ToLower())
                {
                    listafiltradav.Add(canc);
                }
            }
            return listafiltradav;
        }
        public static List<Video> Videoporedadartista(string _valor)
        {
            List<Video> interna4 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna4.Add(cc);
            }
            List<Artista> interna44 = new List<Artista>();
            foreach (Artista aa in lista_artistas_filtromiltiplev)
            {
                interna44.Add(aa);
            }
            listafiltradav.Clear();
            switch (_valor)
            {
                case "menores de 25 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age <= 25)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }

                    break;
                case "de 25 a 40 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 25 && can.Age <= 40)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "de 40 a 60 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 40 && can.Age <= 60)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "mayores de 60":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 60)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }
                    break;
            }

            return listafiltradav;
        }
        public static List<Video> Videoporevaluacion(string valor)
        {
            try
            {
                float _valor = float.Parse(valor);
                foreach (Video canc in todos_los_videos)
                {
                    if (canc.Calificacion_promedio >= _valor)
                    {
                        listafiltradav.Add(canc);
                    }
                }
                return listafiltradav;
            }
            catch
            {
                MessageBox.Show("NO PUEDE INGRESAR EVALUACIONES NULAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                return listafiltradav;
            }
        }
        public static List<Video> Videosporsexodelartista(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna3 = new List<Video>();
            foreach (Video cc in lista_canciones_filtromiltiplev)
            {
                interna3.Add(cc);
            }
            List<Artista> interna33 = new List<Artista>();
            foreach (Artista aa in lista_artistas_filtromiltiplev)
            {
                interna33.Add(aa);
            }


            foreach (Artista can in interna33)
            {
                if (can.Sexo.ToLower() == _valor)
                {
                    foreach (Video canc in interna3)
                    {
                        if (canc.Director.Name == can.Name)
                        {
                            listafiltradav.Add(canc);
                            lista_canciones_filtromiltiplev.Remove(canc);
                            lista_artistas_filtromiltiplev.Remove(can);

                        }
                    }
                }

            }
            return listafiltradav;
        }
        //==================METODOS AND VIDEO

        public static List<Video> VideosporGeneroand(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna = new List<Video>();
            foreach (Video cc in vargas_filtrandovideo)
            {
                interna.Add(cc);
            }
            foreach (Video can in interna)
            {
                if (can.Genero.ToLower() == _valor)
                {
                    listafiltradav.Add(can);
                    lista_canciones_filtromiltiplev.Remove(can);
                }
            }
            return listafiltradav;
        }
        public static List<Video> Videosporfilmstudioand(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna1 = new List<Video>();
            foreach (Video cc in vargas_filtrandovideo)
            {
                interna1.Add(cc);
            }
            foreach (Video canc in interna1)
            {
                if (canc.Film_studio.ToLower() == _valor.ToLower())
                {
                    listafiltradav.Add(canc);
                    lista_canciones_filtromiltiplev.Remove(canc);

                }
            }
            return listafiltradav;
        }
        public static List<Video> Videosporaniopublicacionand(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna2 = new List<Video>();
            foreach (Video cc in vargas_filtrandovideo)
            {
                interna2.Add(cc);
            }
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
        public static List<Video> Videosporcalidadvideoand(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna5 = new List<Video>();
            foreach (Video cc in vargas_filtrandovideo)
            {
                interna5.Add(cc);
            }
            foreach (Video ca in interna5)
            {
                if (ca.Calidad.ToLower() == _valor.ToLower())
                {
                    listafiltradav.Add(ca);
                    lista_canciones_filtromiltiplev.Remove(ca);

                }

            }
            return listafiltradav;
        }

        public static List<Artista> artistas_busquedaand = new List<Artista>();
        public static List<Video> Videopornombre_artistaand(string _valor)
        {
            artistas_busquedaand.Clear();
            List<Video> videos_busq = new List<Video>();
            Proyecto_Forms.ALAINID.Activar_todo();
            if (_valor != "")
            {
                int esta = 0;
                foreach (Artista actor in Proyecto_Forms.ALAINID.lista_actores)
                {
                    var q = false;
                    q = actor.Name.ToLower().StartsWith(_valor.ToLower());

                    if (q == true)
                    {
                        foreach (Artista artista in artistas_busqueda)
                        {
                            if (actor.Name == artista.Name)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            artistas_busqueda.Add(actor);
                        }
                    }
                }

                foreach (Artista director in Proyecto_Forms.ALAINID.lista_directores)
                {

                    var q = false;
                    q = director.Name.ToLower().StartsWith(_valor.ToLower());
                    esta = 0;
                    if (q == true)
                    {
                        foreach (Artista artista in artistas_busqueda)
                        {
                            if (director.Name == artista.Name)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            artistas_busqueda.Add(director);
                        }
                    }
                }
                esta = 0;
                foreach (Video video in vargas_filtrandovideo)
                {

                    foreach (Artista ar in artistas_busqueda)
                    {
                        foreach (Video vid in videos_busq)
                        {
                            if (vid.Nombrearchivovideo == video.Nombrearchivovideo)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            if (video.Director.Name == ar.Name)
                            {
                                videos_busq.Add(video);
                            }
                        }
                        foreach (Video vid in videos_busq)
                        {
                            if (vid.Nombrearchivovideo == video.Nombrearchivovideo)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            foreach (Artista actor in video.Actores)
                            {
                                if (actor.Name == ar.Name)
                                {
                                    videos_busq.Add(video);
                                }
                            }
                        }
                    }
                }
            }
            return videos_busq;
        }
       

        public static List<Video> Videopornombrevideoand(string _valor)
        {
            listafiltradav.Clear();
            int esta = 0;
            if (_valor != "")
            {
                foreach (Video vid in vargas_filtrandovideo)
                {
                    var q = false;
                    q = vid.Nombre_video.ToLower().StartsWith(_valor.ToLower());
                    if (q == true)
                    {
                        foreach (Video video in listafiltradav)
                        {
                            if (video.Nombrearchivovideo == vid.Nombrearchivovideo)
                            {
                                esta = 1;
                            }
                        }
                        if (esta == 0)
                        {
                            listafiltradav.Add(vid);
                        }

                    }
                }
            }

            return listafiltradav;
        }
        public static List<Video> Videoporcategoriaand(string _valor)
        {
            foreach (Video canc in vargas_filtrandovideo)
            {
                string cat = canc.Categoria.ToLower();
                if (cat.ToLower() == _valor.ToLower())
                {
                    listafiltradav.Add(canc);
                }
            }
            return listafiltradav;
        }
        public static List<Video> Videoporedadartistaand(string _valor)
        {
            List<Video> interna4 = new List<Video>();
            foreach (Video cc in vargas_filtrandovideo)
            {
                interna4.Add(cc);
            }
            List<Artista> interna44 = new List<Artista>();
            foreach (Artista aa in lista_artistas_filtromiltiplev)
            {
                interna44.Add(aa);
            }
            listafiltradav.Clear();
            switch (_valor)
            {
                case "menores de 25 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age <= 25)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }

                    break;
                case "de 25 a 40 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 25 && can.Age <= 40)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "de 40 a 60 años":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 40 && can.Age <= 60)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }
                    break;
                case "mayores de 60":
                    foreach (Artista can in interna44)
                    {
                        if (can.Age > 60)
                        {
                            foreach (Video canc in interna4)
                            {
                                if (canc.Director.Name.ToLower() == can.Name.ToLower())
                                {
                                    listafiltradav.Add(canc);
                                    lista_canciones_filtromiltiplev.Remove(canc);
                                    lista_artistas_filtromiltiplev.Remove(can);
                                }
                            }
                        }
                    }
                    break;
            }

            return listafiltradav;
        }
        public static List<Video> Videoporevaluacionand(string valor)
        {
            try
            {
                float _valor = float.Parse(valor);
                foreach (Video canc in vargas_filtrandovideo)
                {
                    if (canc.Calificacion_promedio >= _valor)
                    {
                        listafiltradav.Add(canc);
                    }
                }
                return listafiltradav;
            }
            catch
            {
                MessageBox.Show("NO PUEDE INGRESAR EVALUACIONES NULAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                return listafiltradav;
            }
        }
        public static List<Video> Videosporsexodelartistaand(string _valor)
        {
            listafiltradav.Clear();
            List<Video> interna3 = new List<Video>();
            foreach (Video cc in vargas_filtrandovideo)
            {
                interna3.Add(cc);
            }
            List<Artista> interna33 = new List<Artista>();
            foreach (Artista aa in lista_artistas_filtromiltiplev)
            {
                interna33.Add(aa);
            }


            foreach (Artista can in interna33)
            {
                if (can.Sexo.ToLower() == _valor)
                {
                    foreach (Video canc in interna3)
                    {
                        if (canc.Director.Name == can.Name)
                        {
                            listafiltradav.Add(canc);
                            lista_canciones_filtromiltiplev.Remove(canc);
                            lista_artistas_filtromiltiplev.Remove(can);

                        }
                    }
                }

            }
            return listafiltradav;
        }
        public static List<Video> Filtroporcriteriovideo(string criterio, string valor)
        {
            foreach(Video video in lista_filtrandov)
            {
                vargas_filtrandovideo.Add(video);
            }
            lista_filtrandov.Clear();
            switch (criterio)
            {
                case "Genero Video":
                    lista_filtrandov = VideosporGenero(valor.ToLower());
                    break;
                case "Film Studio":
                    lista_filtrandov = Videosporfilmstudio(valor.ToLower());
                    break;

                case "Artista":
                    lista_filtrandov = Videopornombre_artista(valor.ToLower());
                    
                    break;
                case "Categoria Video":
                    lista_filtrandov = Videoporcategoria(valor.ToLower());
                    break;
                case "Nombre Cancion/Video":
                    lista_filtrandov = Videopornombrevideo(valor.ToLower());
                    break;
                case "Año de Publicacion":
                    lista_filtrandov = Videosporaniopublicacion(valor.ToLower());
                    break;
                case "Calidad/Resolucion":
                    lista_filtrandov = Videosporcalidadvideo(valor.ToLower());
                    break;
                case "Evaluacion":
                    lista_filtrandov = Videoporevaluacion(valor.ToLower());
                    break;
                case "Edad del Artista":
                    lista_filtrandov = Videoporedadartista(valor.ToLower());
                    break;
                case "Sexo del Artista":
                    lista_filtrandov = Videosporsexodelartista(valor.ToLower());
                    break;

            }
            
            return lista_filtrandov;
        }

        public static List<Video> Filtroporcriteriovideoand(string criterio, string valor)
        {
            foreach (Video video in lista_filtrandov)
            {
                vargas_filtrandovideo.Add(video);
            }
            lista_filtrandov.Clear();
            switch (criterio)
            {
                case "Genero Video":
                    lista_filtrandov = VideosporGeneroand(valor.ToLower());
                    break;
                case "Film Studio":
                    lista_filtrandov = Videosporfilmstudioand(valor.ToLower());
                    break;

                case "Artista":
                    lista_filtrandov = Videopornombre_artistaand(valor.ToLower());

                    break;
                case "Categoria Video":
                    lista_filtrandov = Videoporcategoriaand(valor.ToLower());
                    break;
                case "Nombre Cancion/Video":
                    lista_filtrandov = Videopornombrevideoand(valor.ToLower());
                    break;
                case "Año de Publicacion":
                    lista_filtrandov = Videosporaniopublicacionand(valor.ToLower());
                    break;
                case "Calidad/Resolucion":
                    lista_filtrandov = Videosporcalidadvideoand(valor.ToLower());
                    break;
                case "Evaluacion":
                    lista_filtrandov = Videoporevaluacionand(valor.ToLower());
                    break;
                case "Edad del Artista":
                    lista_filtrandov = Videoporedadartistaand(valor.ToLower());
                    break;
                case "Sexo del Artista":
                    lista_filtrandov = Videosporsexodelartistaand(valor.ToLower());
                    break;

            }

            return lista_filtrandov;
        }
        //==================================================================================================
        public static List<Video> Buqueda_simple_videos(string criterio, string valor)
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
            lista_filtrando2v.Clear();

            foreach (Video ss in Filtroporcriteriovideo(criterio, valor))
            {
                lista_filtrando2v.Add(ss);
            }
            return lista_filtrando2v;
        }
        //====================================================================================================
        public static List<Video> Buqueda_multiple_videos_or(List<string> criterios_seleccionados, List<string> criterios_ingresados)
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
            
            canciones_filtradasv.Clear();
            List<string> criterios_seleccionados2 = new List<string>();
            foreach (string crit in criterios_seleccionados)
            {
                criterios_seleccionados2.Add(crit);
            }

            foreach (string crit in criterios_seleccionados2)
            {
                List<string> criterio2 = new List<string>();
                foreach (string palabra in criterios_ingresados)
                {
                    criterio2.Add(palabra);
                }
                foreach (string c in criterio2)
                {
                    lista_filtrando2v.Clear();
                    foreach (Video ss in Filtroporcriteriovideo(crit, c))
                    {
                        lista_filtrando2v.Add(ss);
                    }
                    criterios_ingresados.Remove(c);
                    foreach (Video ccc in lista_filtrando2v)
                    {
                        int si = 0;
                        foreach (Video canc in canciones_filtradasv)
                        {
                            if (ccc.Nombre_video.ToLower() == canc.Nombre_video.ToLower())
                            {
                                si++;
                            }
                        }
                        if (si == 0)
                        {
                            canciones_filtradasv.Add(ccc);
                        }
                    }
                    break;
                }
            }
            return canciones_filtradasv;
        }
        public static List<Video> Buqueda_multiple_videos_and(List<string> criterios_seleccionados, List<string> criterios_ingresados)
        {
            Activar_todo();
            lista_filtrada_finalv.Clear();
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
           
            canciones_filtradasv.Clear();
            lista_filtrando2.Clear();
            foreach (Video ss in Filtroporcriteriovideo(criterios_seleccionados[0], criterios_ingresados[0]))
            {
                lista_filtrando2v.Add(ss);
            }
            List<Video> gubbins_limpiando2 = new List<Video>();
            gubbins_limpiando2 = Filtroporcriteriovideoand(criterios_seleccionados[0], criterios_ingresados[0]);
            string continuar = "si";
            if (gubbins_limpiando2.Count == 0)
            {
                canciones_filtradasv.Clear();
                continuar = "no";
            }
            
            foreach (Video ccc in lista_filtrando2v)
                {
                    canciones_filtradasv.Add(ccc);
                }
            
            if (continuar=="si")
            {
                int count2 = 1;
                int num = criterios_seleccionados.Count();
                while (count2 < num)
                {
                    lista_filtrando2v.Clear();
                    List<Video> gubbins_limpiando = new List<Video>();
                    gubbins_limpiando = Filtroporcriteriovideoand(criterios_seleccionados[count2], criterios_ingresados[count2]);
                    if (gubbins_limpiando.Count() == 0)
                    {
                        canciones_filtradasv.Clear();
                        break;

                    }
                    foreach (Video ss in gubbins_limpiando)
                    {
                        canciones_filtradasv.Clear();
                        canciones_filtradasv.Add(ss);
                    }
                    count2++;
                }
                int si;
                foreach (Video ccc in canciones_filtradasv)
                {
                    si = 0;
                    foreach (Video canc in lista_filtrada_finalv)
                    {

                        if ((ccc.Nombre_video.ToLower() == canc.Nombre_video.ToLower()) && (ccc.Director.Name.ToLower() == canc.Director.Name.ToLower()))
                        {
                            si++;
                        }
                    }
                    if (si == 0)
                    {
                        lista_filtrada_finalv.Add(ccc);
                    }
                }
            }
            
            return lista_filtrada_finalv;
        }














        // METODOS DE FILTROS CANCIONES=============================================================
        // METODOS DE FILTROS CANCIONES=============================================================
        // METODOS DE FILTROS CANCIONES=============================================================
        // METODOS DE FILTROS CANCIONES=============================================================
        // METODOS DE FILTROS CANCIONES=============================================================
        // METODOS DE FILTROS CANCIONES=============================================================
        // METODOS DE FILTROS CANCIONES=============================================================

        public static List<string> lista_criterios_filtro2 = new List<string>();
        public static List<Song> lista_canciones_filtromiltiple = new List<Song>();
        public static List<Artista> lista_artistas_filtromiltiple = new List<Artista>();
        public static List<Song> canciones_filtradas = new List<Song>();
        public static List<Song> lista_filtrando2 = new List<Song>();

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
        public static List<Song> cancionporevaluacion(string valor)
        {

            try
            {
                float _valor = float.Parse(valor);
                foreach (Song canc in todas_las_canciones)
                {
                    if (canc.Calificacionpromedio >= _valor)
                    {
                        listafiltrada.Add(canc);
                    }
                }
                return listafiltrada;
            }
            catch
            {
                MessageBox.Show("NO PUEDE INGRESAR EVALUACIONES NULAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            return listafiltrada;
        }
        public static List<Song> CancionesPorCriterio(string _criterio, string _valor) // busqueda simple
        {
            //listafiltrada.Clear();
            List<Song> vargas_buscando = new List<Song>();
            foreach(Song song1 in listafiltrada)
            {
                vargas_buscando.Add(song1);
            }
            switch (_criterio)
            {
                case "Genero Cancion":
                    foreach (Song can in todas_las_canciones)
                    {
                        if (can.Genero.ToLower() == _valor.ToLower())
                        {
                            listafiltrada.Add(can);
                        }
                    }
                    break;
                case "Artista":
                    foreach(Song canc in Cancionespornombre_artista( _valor.ToLower()))
                    {
                        listafiltrada.Add(canc);
                    }
                    break;
                case "Album":
                    foreach (PlaylistSong alb in todos_los_albumes)
                    {
                        if (alb.NombrePlaylist.ToLower() == _valor.ToLower())
                        {
                            foreach (Song canc in todas_las_canciones)
                            {
                                if (canc.Album.ToLower() == alb.NombrePlaylist.ToLower())
                                {
                                    listafiltrada.Add(canc);
                                }
                            }

                        }
                    }

                    break;
                case "Nombre Cancion/Video":
                    int esta = 0;
                    if (_valor != "")
                    {
                        foreach (Song son in todas_las_canciones)
                        {
                            var q = false;
                            q = son.Nombrecancion.ToLower().StartsWith(_valor.ToLower());
                            if (q == true)
                            {
                                foreach (Song song in listafiltrada)
                                {
                                    if (song.Nombrearchivo == son.Nombrearchivo)
                                    {
                                        esta = 1;
                                    }
                                }
                                if (esta == 0)
                                {
                                    listafiltrada.Add(son);
                                }

                            }
                        }
                    }
                    break;
                case "Disquera":
                    foreach (Song canc in todas_las_canciones)
                    {
                        if (canc.Disquera.ToLower() == _valor.ToLower())
                        {
                            listafiltrada.Add(canc);
                        }
                    }
                    break;
                
                case "Año de Publicacion":
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
                        if (art.Sexo.ToLower() == _valor.ToLower())
                        {
                            foreach (Song canc in todas_las_canciones)
                            {
                                if (canc.Cantante.Name.ToLower() == art.Name.ToLower())
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
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                    listafiltrada = cancionporevaluacion(_valor);
                    break;

            }
            return listafiltrada;
        }

        public static List<Song> CancionesPorCriterioand(string _criterio, string _valor) // busqueda simple
        {
            
            List<Song> vargas_buscando = new List<Song>();
            foreach (Song song1 in listafiltrada)
            {
                vargas_buscando.Add(song1);
            }
            listafiltrada.Clear();
            int esta = 0;
            switch (_criterio)
            {

                case "Genero Cancion":
                    foreach (Song can in vargas_buscando)
                    {
                        if (can.Genero.ToLower() == _valor.ToLower())
                        {
                            listafiltrada.Add(can);
                        }
                    }
                    break;
                case "Artista":
                    artistas_busqueda.Clear();
                    List<Song> canciones_busq = new List<Song>();
                    Proyecto_Forms.ALAINID.Activar_todo();
                    if (_valor != "")
                    {
                        
                        foreach (Artista cantante in Proyecto_Forms.ALAINID.lista_cantantes)
                        {
                            var q = false;
                            q = cantante.Name.ToLower().StartsWith(_valor.ToLower());
                            esta = 0;
                            if (q == true)
                            {
                                foreach (Artista artista in artistas_busqueda)
                                {
                                    if (cantante.Name == artista.Name)
                                    {
                                        esta = 1;
                                    }
                                }
                                if (esta == 0)
                                {
                                    artistas_busqueda.Add(cantante);
                                }
                            }
                        }
                        foreach (Artista compositor in Proyecto_Forms.ALAINID.lista_compositores)
                        {
                            var q = false;
                            q = compositor.Name.ToLower().StartsWith(_valor.ToLower());
                            esta = 0;
                            if (q == true)
                            {
                                foreach (Artista artista in artistas_busqueda)
                                {
                                    if (compositor.Name == artista.Name)
                                    {
                                        esta = 1;
                                    }
                                }
                                if (esta == 0)
                                {
                                    artistas_busqueda.Add(compositor);
                                }
                            }
                        }
                        esta = 0;
                        foreach (Song song in vargas_buscando)
                        {

                            foreach (Artista ar in artistas_busqueda)
                            {
                                foreach (Song son in canciones_busq)
                                {
                                    if (son.Nombrearchivo == song.Nombrearchivo)
                                    {
                                        esta = 1;
                                    }
                                }
                                if (esta == 0)
                                {
                                    if (song.Cantante.Name == ar.Name)
                                    {
                                        canciones_busq.Add(song);
                                    }
                                }
                                foreach (Song son in canciones_busq)
                                {
                                    if (son.Nombrearchivo == song.Nombrearchivo)
                                    {
                                        esta = 1;
                                    }
                                }
                                if (esta == 0)
                                {
                                    if (song.Compositor.Name == ar.Name)
                                    {
                                        canciones_busq.Add(song);
                                    }
                                }
                            }
                        }
                    }
                    foreach(Song song1 in canciones_busq)
                    {
                        listafiltrada.Add(song1);
                    }
                     
                    break;
                case "Album":
                    foreach (PlaylistSong alb in todos_los_albumes)
                    {
                        if (alb.NombrePlaylist.ToLower() == _valor.ToLower())
                        {
                            foreach (Song canc in vargas_buscando)
                            {
                                if (canc.Album.ToLower() == alb.NombrePlaylist.ToLower())
                                {
                                    listafiltrada.Add(canc);
                                }
                            }

                        }
                    }

                    break;
                case "Nombre Cancion/Video":
                    esta = 0;
                    if (_valor != "")
                    {
                        foreach (Song son in vargas_buscando)
                        {
                            var q = false;
                            q = son.Nombrecancion.ToLower().StartsWith(_valor.ToLower());
                            if (q == true)
                            {
                                foreach (Song song in listafiltrada)
                                {
                                    if (song.Nombrearchivo == son.Nombrearchivo)
                                    {
                                        esta = 1;
                                    }
                                }
                                if (esta == 0)
                                {
                                    listafiltrada.Add(son);
                                }

                            }
                        }
                    }
                    break;
                case "Disquera":
                    foreach (Song canc in vargas_buscando)
                    {
                        if (canc.Disquera.ToLower() == _valor.ToLower())
                        {
                            listafiltrada.Add(canc);
                        }
                    }
                    break;

                case "Año de Publicacion":
                    foreach (Song canc in vargas_buscando)
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
                        if (art.Sexo.ToLower() == _valor.ToLower())
                        {
                            foreach (Song canc in vargas_buscando)
                            {
                                if (canc.Cantante.Name.ToLower() == art.Name.ToLower())
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
                                    foreach (Song canc in vargas_buscando)
                                    {
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                                    foreach (Song canc in vargas_buscando)
                                    {
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                                    foreach (Song canc in vargas_buscando)
                                    {
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                                    foreach (Song canc in vargas_buscando)
                                    {
                                        if (canc.Cantante.Name.ToLower() == can.Name.ToLower())
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
                    List<Song> cali_ca = new List<Song>();
                    foreach (Song ca in todas_las_canciones)
                    {
                        if (ca.Calidad == _valor)
                        {
                            cali_ca.Add(ca);
                        }

                    }
                    foreach(Song song in cali_ca)
                    {
                        listafiltrada.Add(song);
                    }
                    break;
                case "Evaluacion":
                    try
                    {
                        float valor = float.Parse(_valor);
                        foreach (Song canc in todas_las_canciones)
                        {
                            if (canc.Calificacionpromedio >= valor)
                            {
                                listafiltrada.Add(canc);
                            }
                        }
                        return listafiltrada;
                    }
                    catch
                    {
                        MessageBox.Show("NO PUEDE INGRESAR EVALUACIONES NULAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                   
                    break;

            }
            return listafiltrada;
        }
        //================================================================================================
        public static List<Song> Buqueda_multiple_cancionesand(List<string> criterios_seleccionados, List<string> criterio)
        {
            Activar_todo();
            lista_filtrada_final.Clear();
            lista_canciones_filtromiltiple.Clear();
            lista_artistas_filtromiltiple.Clear();
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
            canciones_filtradas.Clear();
            lista_filtrando2.Clear();
            List<Song> gubbins_limpiandola2 = new List<Song>();
            gubbins_limpiandola2 = CancionesPorCriterio(criterios_seleccionados[0], criterio[0]);
            foreach (Song ss in gubbins_limpiandola2)
            {
                lista_filtrando2.Add(ss);
            }
            string continuar = "si";
            if (gubbins_limpiandola2.Count() == 0)
            {
                canciones_filtradas.Clear();
                continuar = "no";
                
            }
            if (continuar == "si")
            {
                foreach (Song ccc in lista_filtrando2)
                {
                    canciones_filtradas.Add(ccc);
                }
                int count2 = 1;
                int num = criterios_seleccionados.Count();
                while (count2 < num)
                {
                    lista_filtrando2.Clear();
                    List<Song> gubbins_limpiandola = new List<Song>();
                    gubbins_limpiandola = CancionesPorCriterioand(criterios_seleccionados[count2], criterio[count2]);
                    if (gubbins_limpiandola.Count() == 0)
                    {
                        canciones_filtradas.Clear();
                    }
                    foreach (Song ss in gubbins_limpiandola)
                    {
                        canciones_filtradas.Clear();
                        canciones_filtradas.Add(ss);
                    }
                    count2++;
                }

                int si;
                foreach (Song ccc in canciones_filtradas)
                {
                    si = 0;
                    foreach (Song canc in lista_filtrada_final)
                    {

                        if ((ccc.Nombrecancion.ToLower() == canc.Nombrecancion.ToLower()) && (ccc.Cantante.Name.ToLower() == canc.Cantante.Name.ToLower()))
                        {
                            si++;
                        }
                    }
                    if (si == 0)
                    {
                        lista_filtrada_final.Add(ccc);
                    }
                }
            }
            return lista_filtrada_final;
        }
        public static List<Song> Buqueda_multiple_canciones(List<string> criterios_seleccionados, List<string> criterio)
        {
            lista_canciones_filtromiltiple.Clear();
            lista_artistas_filtromiltiple.Clear();
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
            canciones_filtradas.Clear();
            List<string> s2 = new List<string>();//revisar esta lista
            s2.Clear();
            int i = 1;
            int num = criterios_seleccionados.Count();
            while (i <= num)
            {
                s2.Clear();
                foreach (string select in criterios_seleccionados)
                {
                    
                    s2.Add(select);
                }
                foreach (String crit in s2)
                {

                    List<string> criterio2 = new List<string>();
                    criterio2.Clear();
                    foreach (string palabra in criterio)
                    {
                        criterio2.Add(palabra);
                        
                    }
                    foreach (string c in criterio2)
                    {
                        lista_filtrando2.Clear();
                        foreach (Song ss in CancionesPorCriterio(crit, c))
                        {
                            lista_filtrando2.Add(ss);
                        }
                        criterios_seleccionados.Remove(crit);
                        criterio.Remove(c);
                        break;
                    }
                    break;
                }
                i++;
            }

            foreach (Song ccc in lista_filtrando2)
            {
                int si = 0;
                foreach (Song canc in canciones_filtradas)
                {
                    if (ccc.Nombrecancion.ToLower() == canc.Nombrecancion.ToLower())
                    {
                        si++;
                    }
                }
                if (si == 0)
                {
                    canciones_filtradas.Add(ccc);
                }
            }
            
                
            
            return canciones_filtradas;
        }

    }
}