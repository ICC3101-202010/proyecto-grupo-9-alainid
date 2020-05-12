using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proyecto
{
    class Admin
    {
        public void Ver_info_usuarios()
        {
            foreach (User user in ALAINID.listausuarios)
            {
                Console.WriteLine(user.InformacionUsuario());
            }
        }
        public bool AgregarSong(string nombrecan, string cantante, string genero, string compositor, string anopublicacion, string disquera, string album, float duracion, string tipoarchivo, float tamano, string calidad, string nombrearchivo, int reproduccion, string letra)
        {
            Song s = new Song(nombrecan, cantante, genero, compositor, anopublicacion, disquera, album, duracion, tipoarchivo, tamano, calidad, nombrearchivo, reproduccion, letra);
            foreach (Song si in ALAINID.todas_las_canciones)
            {
                if (si == s)
                {
                    Console.WriteLine("esta cancion ya existe en ALAINID");
                    Thread.Sleep(2000);
                    return false;
                }
            }
            foreach (Artista art in ALAINID.lista_cantantes)
            {
                if (art.name == cantante)
                {
                    art.lista_canciones.Add(s);
                    ALAINID.AlmacenarCantante(ALAINID.lista_cantantes);
                    break;
                }
            }
            foreach (Artista art in ALAINID.lista_cantantes)
            {
                if (art.name == cantante)
                {
                    foreach (PlaylistSong alb in art.lista_album)
                    {
                        if (alb.NombrePlaylist == album)
                        {
                            alb.listplay.Add(s);
                            ALAINID.AlmacenarAlbum(ALAINID.todos_los_albumes);

                        }
                    }
                }
            }
            foreach (Artista co in ALAINID.lista_compositores)
            {
                if (co.name == compositor)
                {
                    co.lista_canciones.Add(s);
                    ALAINID.AlmacenarCompositores(ALAINID.lista_compositores);
                    break;
                }
            }
            ALAINID.todas_las_canciones.Add(s);
            ALAINID.Partir();
            Console.WriteLine("================");
            Console.WriteLine("Canción agregada exitosamente");
            Console.WriteLine("================");
            ALAINID.Partir();
            VerCanciones(ALAINID.todas_las_canciones);
            Thread.Sleep(2000);
            return true;
        }

        public void Subir_video(string nombre_video, float duracion, string categoria, string director, string genero, string anio_publicacion, string tipo_archivo, string calidad, string film_studio, float tamanio, string nombrearchivovideo, int reproduccion1)
        {
            bool ver2 = true;
            Video video1 = new Video(nombre_video, duracion, categoria, director, genero, anio_publicacion, tipo_archivo, calidad, film_studio, tamanio, nombrearchivovideo, reproduccion1);

            foreach (Video video in ALAINID.todos_los_videos)
            {
                if (video == video1)
                {
                    ver2 = false;
                    break;
                }
            }
            if (ver2 == true)
            {
                int n;
                do
                {
                    Console.WriteLine("Ingrese el nombre del actor: ");
                    string nombre_actor = Console.ReadLine();
                    foreach (Artista art in ALAINID.lista_actores)
                    {
                        if (art.name == nombre_actor)
                        {
                            video1.Agregar_actores(art);
                            art.lista_peliculas.Add(video1);
                            ALAINID.AlmacenarActores(ALAINID.lista_actores);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El Actor ingresado no existe");
                            break;
                        }
                    }
                    Console.WriteLine("1-> Desea Ingresar otro actor" + " " +
                    "2-> Terminar");

                    n = ALAINID.Numero(2);
                } while (n == 1);
                ALAINID.AlmacenarActores(ALAINID.lista_actores);
                foreach (Artista dir in ALAINID.lista_directores)
                {
                    dir.lista_peliculas.Add(video1);
                    ALAINID.AlmacenarDirectores(ALAINID.lista_directores);
                }
                ALAINID.todos_los_videos.Add(video1);
                Console.WriteLine("=======================================");
                Console.WriteLine("Video Agregado existosamente");
                Console.WriteLine("=======================================");
                ALAINID.AlmacenarVideos(ALAINID.todos_los_videos);
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("El video que intenta cargar ya existe");
            }

        }
        public void VerCanciones(List<Song> lista)
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
                    Console.WriteLine(lista[i].Informacioncancion());
                    Console.WriteLine(" ");

                }
            }
        }
        public void VerVideos(List<Video> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay videos agregados aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Video" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].Ver_informacion());
                    Console.WriteLine(" ");

                }
            }
        }
        public bool AgregarSongKaraoke(string nombrecan2, string cantante2, string genero2, string compositor2, string anopublicacion2, string disquera2, string album2, float duracion2, string tipoarchivo2, float tamano2, string calidad2, string nombrearchivo2, int reproduccion2, string letra2)
        {
            Song s = new Song(nombrecan2, cantante2, genero2, compositor2, anopublicacion2, disquera2, album2, duracion2, tipoarchivo2, tamano2, calidad2, nombrearchivo2, reproduccion2, letra2);
            foreach (Song si in ALAINID.todas_las_cancioneskaraoke)
            {
                if (si == s)
                {
                    Console.WriteLine("esta cancion ya existe en ALAINID");
                    Thread.Sleep(2000);
                    return false;
                }
            }
            ALAINID.todas_las_cancioneskaraoke.Add(s);
            ALAINID.Partirkaraoke();
            Console.WriteLine("================");
            Console.WriteLine("Canción agregada exitosamente A CANTAAR!");
            Console.WriteLine("================");
            return true;
        }
    }
}
