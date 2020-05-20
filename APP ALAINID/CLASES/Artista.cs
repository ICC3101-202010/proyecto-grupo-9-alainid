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
        private string name;
        private int age;
        private string nacionality;
        private string sexo;
        private bool seguir = false;
        private List<PlaylistSong> lista_album = new List<PlaylistSong>();
        private List<Video> lista_peliculas = new List<Video>();
        private List<Song> lista_canciones = new List<Song>();

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Nacionality { get => nacionality; set => nacionality = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public bool Seguir { get => seguir; set => seguir = value; }
        public List<PlaylistSong> Lista_album { get => lista_album; set => lista_album = value; }
        public List<Video> Lista_peliculas { get => lista_peliculas; set => lista_peliculas = value; }
        public List<Song> Lista_canciones { get => lista_canciones; set => lista_canciones = value; }

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
                informacion += "-" + v.Nombre_video + "\n";
            }
            foreach (Song s in lista_canciones)
            {
                informacion += "-" + s.Nombrecancion + "\n";
            }
            return informacion;
        }
    }
}
