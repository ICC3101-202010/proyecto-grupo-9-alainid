using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    [Serializable]
    public class Song
    {
        public string nombrecancion;
        public string cantante;
        public string genero;
        public string compositor;
        public string anopublicacion;
        public string disquera;
        public string album;
        public string letra = null;           //CAMBIE AQUI
        //public float calificacionpersonal;
        public float calificacionpromedio;
        public float duracion;
        public int reproducciones = 0;            //CAMBIE AQU
        public string tipoarchivo;
        public float tamano;
        public string calidad;
        public string nombrearchivo;

        // asumi que no todas las canciones seran subidas con su letra por lo tanto no es requisito par acerar cancion al igual que la calificacion
        //y el numero de reproducciones

        public Song(string nombre, string cantante1, string genero1, string compositor1,
             string anopublicacion1, string disquera1, string album1, float duracion1, string tipodearchivo1, float tamano1, string calidad1, string nombrearchivo1)
        {
            nombrecancion = nombre;
            
            cantante = cantante1;
            genero = genero1;
            compositor = compositor1;
            anopublicacion = anopublicacion1;
            disquera = disquera1;
            album = album1;
            duracion = duracion1;
            reproducciones = 0;
            duracion = duracion1;
            tipoarchivo = tipodearchivo1;
            tamano = tamano1;
            calidad = calidad1;
            nombrearchivo = nombrearchivo1;
           

        }
        public string Informacioncancion()
        {
            string info = (" Nombre: " + nombrecancion + "\n"+ " Genero: " + genero + "\n" + " Artista: " + cantante + "\n" + " Album: " + album + "\n" + "Compositor: " + compositor + "\n" + "Año de publicacion: " + anopublicacion + "\n" +
                "Disquera: " + disquera + "\n" + "Calificacion promedio: " + calificacionpromedio + "\n" + "Duracion: " + duracion + "\n" +
                "Cantidad de reproducciones:" + reproducciones + "\n");
            return info;
        }
        //public float Calificacion()
        //{
        //}
    }
}
