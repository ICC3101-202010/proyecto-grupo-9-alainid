using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto
{
    [Serializable]
    public class Artista
    {
        public string name;
        public int age;
        public string nacionality;
        public string sexo;
        public bool seguir = false;
        public List<PlaylistSong> lista_album = new List<PlaylistSong>();
        public List<Video> lista_peliculas = new List<Video>();
        public List<Song> lista_canciones = new List<Song>();


        public Artista(string name, int age, string sexo, string nacionality)
        {
            this.name = name;
            this.age = age;
            this.sexo = sexo;
            this.nacionality = nacionality;
        }
        public string InformacionArtista()
        {
            string informacion = ("- Nombre: " + name + "\n" + "- Edad: " + age.ToString() + "\n" + "- Nacionalidad: " + nacionality + "\n" + "- Sexo: " + sexo + "\n");
            informacion += "Albums:\n";
            foreach (PlaylistSong alb in lista_album)
            {
                informacion += "-" + alb.NombrePlaylist + "\n";
            }
            foreach (Video v in lista_peliculas)
            {
                informacion += "-" + v.nombre_video + "\n";
            }
            foreach (Song s in lista_canciones)
            {
                informacion += "-" + s.nombrecancion + "\n";
            }
            return informacion;
        }
    }
}
