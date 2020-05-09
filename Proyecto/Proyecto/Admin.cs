using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    class Admin    // todo es nuevo
    {
        Funciones funciones = new Funciones();

        public void Ver_info_usuarios()
        {
            foreach (User user in ALAINID.listausuarios)
            {
                Console.WriteLine(user.InformacionUsuario());

            }
        }

        public bool AgregarSong(Song s)
        {
            for (int i = 0; i < ALAINID.todas_las_canciones.Count; i++)
            {
                Song si = ALAINID.todas_las_canciones[i];
                if ((si.nombrecancion == s.nombrecancion) && (si.cantante == s.cantante) && (si.calidad == s.calidad))

                {
                    Console.WriteLine("Cancion ya estaba antes agregada");
                    return false;
                }

            }

            ALAINID.todas_las_canciones.Add(s);
            Console.WriteLine("Canción agregada");
            Console.WriteLine("================");
            ALAINID.Partir();
            VerCanciones(ALAINID.todas_las_canciones);
            return true;
        }

        public void Subir_video(string nombre_video, float duracion, string categoria, string director, string genero, string anio_publicacion, string tipo_archivo, string calidad, string film_studio, float tamanio)
        {
            bool ver2 = true;
            foreach (Video video in ALAINID.todos_los_videos)
            {
                if (video.Nombre_video == nombre_video & video.Director == director & video.Calidad == calidad)
                {
                    ver2 = false;
                    break;
                }
            }

            if (ver2 == true)
            {
                Video video1 = new Video(nombre_video, duracion, categoria, director, genero, anio_publicacion, tipo_archivo, calidad, film_studio, tamanio);

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
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El Artista ingresado no existe");
                            break;
                        }
                    }
                    Console.WriteLine("1-> Desea Ingresar otro actor" +
                    "2-> Terminar");
                    n = funciones.Numero(2);
                } while (n == 1);
                ALAINID.todos_los_videos.Add(video1);
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
    }
}
