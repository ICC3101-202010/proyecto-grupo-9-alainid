﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            int n1  =  0, n2  =  0;
            foreach (Song si in ALAINID.todas_las_canciones){
                if ((si.nombrecancion == s.nombrecancion) && (si.cantante == s.cantante) && (si.calidad == s.calidad)){
                    Console.WriteLine("Cancion ya estaba antes agregada");
                    Thread.Sleep(2000);
                    return false;
                }
                foreach (Artista art in ALAINID.lista_cantantes){
                    if (s.cantante == art.name)
{
                        break;
                    }
                    else{
                        Console.WriteLine("El cantante ingresado no existe, que desea hacer:" +
                            "1--> Crear un perfil para el cantante" +
                            "2--> No Agregar la cancion");
                        n2 = funciones.Numero(2);
                        if (n2 == 1) { funciones.Crear_cantante(); }
                        else { return false; } 
                    }
                }
            }
            ALAINID.todas_las_canciones.Add(s);
            Console.WriteLine("Canción agregada");
            Console.WriteLine("================");
            ALAINID.Partir();
            VerCanciones(ALAINID.todas_las_canciones);
            Thread.Sleep(2000);
            return true;
        }

        public void Subir_video(string nombre_video, float duracion, string categoria, string director, string genero, int anio_publicacion, string tipo_archivo, string calidad, string film_studio, float tamanio)
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
                    Console.WriteLine("1-> Desea Ingresar otro actor" +" "+
                    "2-> Terminar");
                    n = funciones.Numero(2);
                } while (n == 1);
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
    }
}
