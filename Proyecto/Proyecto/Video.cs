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
        private string anio_publicacion;
        private string descripcion;
        private string tipo_archivo;
        private string calidad;
        private string film_studio; // tiene que estar en la lista de estudios de pelicula
        private float tamanio;
        private float calificacion_promedio;
        private string nombrearchivovideo;
        private int reproduccion;
        private List<int> todas_las_calificaciones = new List<int>();
        private List<Artista> actores = new List<Artista>(); // ACTORES DE CADA PELICULA- VIDEO

        public string Nombre_video { get => nombre_video; set => nombre_video = value; }
        public float Duracion { get => duracion; set => duracion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public object Director { get => director; set => director = value; }
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


        //public float calificacion_personal; 



        // asumi que tanto la descripcion como la calificacion promedio, no son requisitos para subir una cancion

        public Video(string nombre_video, float duracion, string categoria, object director, string genero, string anio_publicacion, string tipo_archivo, string calidad, string film_studio, float tamanio, string nombrearchivovideo,int _reproduccion)
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
            this.reproduccion = _reproduccion;
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
                " Categoria: " + categoria + "\n" + "Año de publicacion: " + anio_publicacion + "\n" + "Descripcion: " + descripcion + "\n" + "Tipo Archivo: " + tipo_archivo + "\n" + "Tamaño Archivo: " + tamanio + "MB \n" + "Calidad: " + calidad + "\n" + "Film Studio: " + film_studio + "\n" + "Calificacion Promedio: " + calificacion_promedio + "\n" + "Duracion: " + duracion + "\n");
            return info;
        }

    }
}
