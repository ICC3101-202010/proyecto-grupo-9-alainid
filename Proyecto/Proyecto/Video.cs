using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    [Serializable]
    public class Video
    {
        private string nombre_video;
        private float duracion;
        private string categoria;  //tiene que estar en la lista de categorias
        private object director; // tiene que estar en la lista de directores
        private string genero; // tiene q estar en la lista de generos 
        private int anio_publicacion;
        private string descripcion;
        private string tipo_archivo;
        private string calidad;
        private string film_studio; // tiene que estar en la lista de estudios de pelicula
        private float tamanio;
        private float calificacion_promedio;
        public List<Artista> actores = new List<Artista>(); // ACTORES DE CADA PELICULA- VIDEO


        //public float calificacion_personal; 

        public string Nombre_video { get => nombre_video; set => nombre_video = value; }
        public float Duracion { get => duracion; set => duracion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public object Director { get => director; set => director = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Anio_publicacion { get => anio_publicacion; set => anio_publicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipo_archivo { get => tipo_archivo; set => tipo_archivo = value; }
        public string Calidad { get => calidad; set => calidad = value; }
        public string Film_studio { get => film_studio; set => film_studio = value; }
        public float Tamanio { get => tamanio; set => tamanio = value; }
        public float Calificacion_promedio { get => calificacion_promedio; set => calificacion_promedio = value; }


        // asumi que tanto la descripcion como la calificacion promedio, no son requisitos para subir una cancion

        public Video(string nombre_video, float duracion, string categoria, object director, string genero, int anio_publicacion, string tipo_archivo, string calidad, string film_studio, float tamanio)
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
        }

        // arreglar infromacion de actores

        public void Agregar_actores(Artista actor)
        {
            bool ver2 = true;
            foreach (Artista acto in ALAINID.lista_actores)
            {
                if (acto == actor) { ver2 = true; break; }
                else { ver2 = true; }
            }
            foreach (Artista ac in actores)
            {
                if (ac == actor) { ver2 = false; break; }
                else { ver2 = true; }
            }
            if (ver2 == true) { actores.Add(actor); }
            else
            {
                Console.WriteLine("El artista que intentas ingresar, ya fue ingresado o no existe");
            }

        }
        public string Ver_informacion()
        {
            string info = (" Genero: " + genero + "\n" + " Director: " + director + "\n" + " Actores: " + actores + "\n" + " Nombre: " + nombre_video + "\n" +
                " Categoria: " + categoria + "\n" + "Año de publicacion: " + anio_publicacion + "\n" + "Descripcion: " + descripcion + "\n" + "Tipo Archivo: " + tipo_archivo + "\n" +
                "Tamanio: " + tamanio + "\n" + "Calidad: " + calidad + "\n" + "Film Studio: " + film_studio + "\n" + "Calificacion Promedio: " + Calificacion_promedio + "\n" + "Duracion: " + duracion + "\n");
            return info;
        }

    }
}
