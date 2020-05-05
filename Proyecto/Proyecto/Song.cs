using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    public class Song
    {
        public string nombrecancion;
        public string categoria;
        public string cantante;
        public string genero;
        public string compositor;
        public string anopublicacion;
        public string disquera;
        public string album;
        public string letra;
        //public float calificacionpersonal;
        public float calificacionpromedio;
        public float duracion;
        public int reproducciones;
        public string tipoarchivo;
        public float tamano;
        public string calidad;

        public Song(string nombre,string categoria1,string cantante1, string genero1, string compositor1,
             string anopublicacion1, string disquera1, string album1, string letra1, float calificacionpromedio1, float duracion1,
             int reproducciones1, string tipodearchivo1, float tamano1, string calidad1)
        {
            nombrecancion = nombre;
            categoria = categoria1;
            cantante = cantante1;
            genero = genero1;
            compositor = compositor1;
            anopublicacion = anopublicacion1;
            disquera = disquera1;
            album = album1;
            letra = letra1;
            calificacionpromedio = calificacionpromedio1;
            duracion = duracion1;
            reproducciones = 0;
            duracion = duracion1;
            reproducciones = reproducciones1;
            tipoarchivo = tipodearchivo1;
            tamano = tamano1;
            calidad = calidad1;

        }
        public string Informacioncancion()
        {
            string info = (" Genero: " + genero + "," + " Artista: " + cantante + "," + " Album: " + album + "," + " Nombre: " +
                nombrecancion +"Categoria: " + categoria + "Compositor: " + compositor + "Año de publicacion: "+ anopublicacion +
                "Disquera: "+ disquera + "Calificacion promedio: " + calificacionpromedio + "Duracion: " + duracion + 
                "Cantidad de reproducciones:" + reproducciones + "\n") ;
            return info;
        }
        //public float Calificacion()
        //{
        //}
    }
}
