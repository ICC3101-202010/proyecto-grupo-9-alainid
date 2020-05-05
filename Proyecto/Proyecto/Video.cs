using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    public class Video
    {
        private string nombre_video;
        private float duracion;
        private string categoria;
        private string director;
        private string genero;
        private string actores;
        private string anio_publicacion;
        private string descripcion;
        private string tipo_archivo;
        private string calidad;
        private string film_studio;
        private float tamanio;
        private float calificacion_promedio;
        //public float calificacion_personal; 

        public string Nombre_video { get => nombre_video; set => nombre_video = value; }
        public float Duracion { get => duracion; set => duracion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Director { get => director; set => director = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Actores { get => actores; set => actores = value; }
        public string Anio_publicacion { get => anio_publicacion; set => anio_publicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipo_archivo { get => tipo_archivo; set => tipo_archivo = value; }
        public string Calidad { get => calidad; set => calidad = value; }
        public string Film_studio { get => film_studio; set => film_studio = value; }
        public float Tamanio { get => tamanio; set => tamanio = value; }
        public float Calificacion_promedio { get => calificacion_promedio; set => calificacion_promedio = value; }

        public Video(string nombre_video, float duracion, string categoria, string director, string genero, string actores, string anio_publicacion, string descripcion, string tipo_archivo, string calidad, string film_studio, float tamanio, float calificacion_promedio)
        {
            this.nombre_video = nombre_video;
            this.duracion = duracion;
            this.categoria = categoria;
            this.director = director;
            this.genero = genero;
            this.actores = actores;
            this.anio_publicacion = anio_publicacion;
            this.descripcion = descripcion;
            this.tipo_archivo = tipo_archivo;
            this.calidad = calidad;
            this.film_studio = film_studio;
            this.tamanio = tamanio;
            this.calificacion_promedio = calificacion_promedio;
        }
        
        

        public string Ver_informacion()
        {
            string info = (" Genero: " + genero + "," + " Director: " + director + "," + " Actores: " + actores + "," + " Nombre: " + nombre_video +
                " Categoria: " + categoria + "Año de publicacion: "+ anio_publicacion + "Descripcion: "+ descripcion + "Tipo Archivo: "+ tipo_archivo + 
                "Tamanio: "+ tamanio + "Calidad: "+ calidad + "Film Studio: "+ film_studio + "Calificacion Promedio: " + Calificacion_promedio + "Duracion: "+ duracion+    "\n") ;
            return info;
        }

    }
}
