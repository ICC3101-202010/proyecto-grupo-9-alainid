using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    [Serializable]
    public class Artista
    {
        public string name;
        public string last;
        public int age;
        public string nacionality;
        public string sexo;
        public bool seguir= false;
        public List<PlaylistSong> lista_album = new List<PlaylistSong>();


        public Artista(string name, string last, int age, string sexo, string nacionality)
        {
            this.name = name;
            this.last = last;
            this.age = age;
            this.sexo = sexo;
            this.nacionality = nacionality;
        }
    }
}
