using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    [Serializable]
    public class Song
    {
        private string nombrecancion;
        private object cantante;
        private string genero; // este tiene q estar en la lista con los generos
        private object compositor;
        private string anopublicacion;
        private string disquera;
        private string album;
        private string letra;      //CAMBIE AQUI
        //public float calificacionpersonal;
        private float calificacionpromedio;
        private float duracion;
        private int reproducciones;            //CAMBIE AQU
        private string tipoarchivo;
        private float tamano;
        private string calidad;
        private string nombrearchivo;
        private List<int> todas_las_calificaciones = new List<int>();

        public Song(string nombrecancion, object cantante, string genero, object compositor, string anopublicacion, string disquera, string album, string letra, float duracion, string tipoarchivo, float tamano, string calidad, string nombrearchivo)
        {
            this.Nombrecancion = nombrecancion;
            this.Cantante = cantante;
            this.Genero = genero;
            this.Compositor = compositor;
            this.Anopublicacion = anopublicacion;
            this.Disquera = disquera;
            this.Album = album;
            this.Letra = letra;
            this.Duracion = duracion;
            this.Tipoarchivo = tipoarchivo;
            this.Tamano = tamano;
            this.Calidad = calidad;
            this.Nombrearchivo = nombrearchivo;
        }

        public string Nombrecancion { get => nombrecancion; set => nombrecancion = value; }
        public object Cantante { get => cantante; set => cantante = value; }
        public string Genero { get => genero; set => genero = value; }
        public object Compositor { get => compositor; set => compositor = value; }
        public string Anopublicacion { get => anopublicacion; set => anopublicacion = value; }
        public string Disquera { get => disquera; set => disquera = value; }
        public string Album { get => album; set => album = value; }
        public string Letra { get => letra; set => letra = value; }
        public float Calificacionpromedio { get => calificacionpromedio; set => calificacionpromedio = value; }
        public float Duracion { get => duracion; set => duracion = value; }
        public int Reproducciones { get => reproducciones; set => reproducciones = value; }
        public string Tipoarchivo { get => tipoarchivo; set => tipoarchivo = value; }
        public float Tamano { get => tamano; set => tamano = value; }
        public string Calidad { get => calidad; set => calidad = value; }
        public string Nombrearchivo { get => nombrearchivo; set => nombrearchivo = value; }
        public List<int> Todas_las_calificaciones { get => todas_las_calificaciones; set => todas_las_calificaciones = value; }




        // asumi que no todas las canciones seran subidas con su letra por lo tanto no es requisito par acerar cancion al igual que la calificacion
        //y el numero de reproducciones


        public string Informacioncancion()
        {
            string info = (" Nombre: " + nombrecancion + "\n" + " Genero: " + genero + "\n" + " Artista: " + cantante + "\n" + " Album: " + album + "\n" + "Compositor: " + compositor + "\n" + "Año de publicacion: " + anopublicacion + "\n" +
                "Disquera: " + disquera + "\n" + "Calificacion promedio: " + calificacionpromedio + "\n" + "Duracion: " + duracion + "\n" + "Tamaño Archivo: " + tamano + "MB \n" +
               "Cantidad de reproducciones:" + reproducciones + "\n");
            return info;
        }
        public string InformacioncancionKaraoke()
        {
            string info = (" Nombre: " + nombrecancion + "\n" + " Genero: " + genero + "\n" + " Artista: " + cantante + "\n" + " Album: " + album + "\n" + "Compositor: " + compositor + "\n" + "Año de publicacion: " + anopublicacion + "\n" +
                "Disquera: " + disquera + "\n" + "Calificacion promedio: " + calificacionpromedio + "\n" + "Duracion: " + duracion + "\n" + "Tamaño Archivo: " + tamano + "MB \n" +
                "Cantidad de reproducciones:" + reproducciones + "\n" + "Letra: " + "\n" + letra);
            return info;
        }
        //public float Calificacion()
        //{
        //}
    }
}
