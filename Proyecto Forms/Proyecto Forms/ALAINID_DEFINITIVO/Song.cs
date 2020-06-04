using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Forms
{
    [Serializable]
    public class Song
    {
        private string nombrecancion;
        private Artista cantante;
        private string genero;
        private Artista compositor;
        private string anopublicacion;
        private string disquera;
        private string album;
        private string letra;
        private float calificacionpromedio = 0;
        private float duracion;
        private int reproducciones = 0;
        private string tipoarchivo;
        private float tamano;
        private string calidad;
        private string nombrearchivo;
        private List<int> todas_las_calificaciones = new List<int>();
        private int tipo = 0;

        public Song(float tamano,string nombrecancion, Artista cantante, string genero, Artista compositor, string anopublicacion, string disquera, string album, string nombrearchivo)
        {
            this.Tamano = tamano;
            this.Nombrecancion = nombrecancion;
            this.Cantante = cantante;
            this.Genero = genero;
            this.Compositor = compositor;
            this.Anopublicacion = anopublicacion;
            this.Disquera = disquera;
            this.Album = album;
            this.Nombrearchivo = nombrearchivo;
        }

        public string Nombrecancion { get => nombrecancion; set => nombrecancion = value; }
        public string Genero { get => genero; set => genero = value; }
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
        public Artista Cantante { get => cantante; set => cantante = value; }
        public Artista Compositor { get => compositor; set => compositor = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
