using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    [Serializable]
    public class Video
    {
        public string nombre_video;
        public float duracion;
        public string categoria;  //tiene que estar en la lista de categorias
        public object director; // tiene que estar en la lista de directores
        public string genero; // tiene q estar en la lista de generos 
        public string anio_publicacion;
        public string descripcion;
        public string tipo_archivo;
        public string calidad;
        public string film_studio; // tiene que estar en la lista de estudios de pelicula
        public float tamanio;
        public float calificacion_promedio;
        public string nombrearchivovideo;
        public List<Artista> actores = new List<Artista>(); // ACTORES DE CADA PELICULA- VIDEO


        //public float calificacion_personal; 

        

        // asumi que tanto la descripcion como la calificacion promedio, no son requisitos para subir una cancion

        public Video(string nombre_video, float duracion, string categoria, object director, string genero, string anio_publicacion, string tipo_archivo, string calidad, string film_studio, float tamanio, string nombrearchivovideo)
        {
            this.nombre_video = nombre_video;
            this.duracion = duracion;
            this.categoria = categoria;
            this.director = director;
            this.genero = genero;
            this.anio_publicacion = anio_publicacion;
            this.tipo_archivo = tipo_archivo;
            this.calidad = calidad;
            this.film_studio = film_studio;
            this.tamanio = tamanio;
            this.nombrearchivovideo = nombrearchivovideo;
        }

        public void Agregar_actores(Artista actor){
            bool ver1  = true,  ver2 = true;
            int v = 0, n2=0;
            ver1= ALAINID.Verificar_existencia_actor(actor.name);
            if (ver1){
                foreach (Artista ac in actores){
                    if (ac == actor) { 
                        Console.WriteLine("El artista que intentas ingresar, ya fue ingresado");
                        ver2  =  false;
                        break;
                    }
                }
                if (ver2){
                    actores.Add(actor);
                }
            }
            else {Console.WriteLine("Lo sentimos, el artista que intentas ingresar no existe en ALAINID\n,"+
                " verifica los datos para intentar nuevamente.");
            }
        }
        public string Ver_informacion()
        {
            string info = (" Genero: " + genero + "\n" + " Director: " + director + "\n" + " Actores: " + actores + "\n" + " Nombre: " + nombre_video + "\n" +
                " Categoria: " + categoria + "\n" + "Año de publicacion: " + anio_publicacion + "\n" + "Descripcion: " + descripcion + "\n" + "Tipo Archivo: " + tipo_archivo + "\n" +
                "Tamanio: " + tamanio + "\n" + "Calidad: " + calidad + "\n" + "Film Studio: " + film_studio + "\n" + "Calificacion Promedio: " + calificacion_promedio + "\n" + "Duracion: " + duracion + "\n");
            return info;
        }

    }
}
