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
