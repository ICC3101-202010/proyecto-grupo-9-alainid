using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Forms
{
    [Serializable]
    public class Video
    {
        private string nombre_video;
        private float duracion;
        private string categoria;     //tiene que estar en la lista de categorias
        private Artista director;     // tiene que estar en la lista de directores
        private string genero;          // tiene q estar en la lista de generos 
        private string anio_publicacion;
        private string descripcion;
        private string tipo_archivo;
        private string calidad;
        private string film_studio;     // tiene que estar en la lista de estudios de pelicula
        private float tamanio;
        private float calificacion_promedio;
        private string nombrearchivovideo;
        private int reproduccion;
        private List<int> todas_las_calificaciones = new List<int>();
        private List<Artista> actores = new List<Artista>();     // ACTORES DE CADA PELICULA- VIDEO
        private int tipo = 1;

        public string Nombre_video { get => nombre_video; set => nombre_video = value; }
        public float Duracion { get => duracion; set => duracion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public Artista Director { get => director; set => director = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Anio_publicacion { get => anio_publicacion; set => anio_publicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipo_archivo { get => tipo_archivo; set => tipo_archivo = value; }
        public string Calidad { get => calidad; set => calidad = value; }
        public string Film_studio { get => film_studio; set => film_studio = value; }
        public float Tamanio { get => tamanio; set => tamanio = value; }
        public float Calificacion_promedio { get => calificacion_promedio; set => calificacion_promedio = value; }
        public string Nombrearchivovideo { get => nombrearchivovideo; set => nombrearchivovideo = value; }
        public int Reproduccion { get => reproduccion; set => reproduccion = value; }
        public List<int> Todas_las_calificaciones { get => todas_las_calificaciones; set => todas_las_calificaciones = value; }
        public List<Artista> Actores { get => actores; set => actores = value; }
        public int Tipo { get => tipo; set => tipo = value; }


        //public float calificacion_personal; 



        // asumi que tanto la descripcion como la calificacion promedio, no son requisitos para subir una cancion

        public Video(string nombre_video, string categoria, Artista director, string genero, string anio_publicacion , string film_studio, float tamanio, string nombrearchivovideo)
        {
            this.nombre_video = nombre_video;
            this.categoria = categoria;
            this.director = director;
            this.genero = genero;
            this.anio_publicacion = anio_publicacion;
            this.film_studio = film_studio;
            this.tamanio = tamanio;
            this.nombrearchivovideo = nombrearchivovideo;
        }

        public void Agregar_actores(Artista act)
        {
            Actores.Add(act);
            ALAINID.AlmacenarActores(Actores);
        }
    }
}


