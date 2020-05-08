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

        public void Subir_cancion(string nombre, string categoria1, string cantante1, string genero1, string compositor1,
             string anopublicacion1, string disquera1, string album1, float duracion1, string tipodearchivo1, float tamano1, string calidad1)
        {
            bool ver1 = true;
            foreach (Song song in ALAINID.todas_las_canciones)
            {
                if (song.nombrecancion == nombre & song.cantante == cantante1 & song.calidad == calidad1)
                {
                    ver1 = false;
                    break;
                }

            }
            if (ver1 == true)
            {
                Song song1 = new Song(nombre, categoria1, cantante1, genero1, compositor1, anopublicacion1, disquera1, album1, duracion1, tipodearchivo1, tamano1, calidad1);
                ALAINID.todas_las_canciones.Add(song1);
            }
            else
            {
                Console.WriteLine("La cancion que intenta cargar ya existe");
            }


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
                    foreach (Artista art in ALAINID.lista_artistas)
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

    }
}