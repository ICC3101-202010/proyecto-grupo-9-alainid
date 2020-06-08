using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Forms

{
    [Serializable]
    public class User
    {
        private string nombreUsuario;
        private string email_;
        private string password_;
        private string nombre_;
        private string premium_ = "no premium";
        private string perfilpublico_ = "publico";
        private string ultimareproduccion_ = "null";
        private string valorcriterio_ = "null";
        private List<PlaylistSong> lista_playlistusuario_ = new List<PlaylistSong>();
        private List<PlaylistVideo> lista_playlistvideousuario_ = new List<PlaylistVideo>();
        private List<Song> favorite_songs_ = new List<Song>();        // LISTA FAVORITOS CANCIONES DE CADA USUARIO
        private List<Video> favorite_videos_ = new List<Video>();
        private List<Song> descargas_ = new List<Song>();
        //private List<PlaylistSong> playlistcanciones_seguidas = new List<PlaylistSong>();
        private List<User> usuarios_seguidos_ = new List<User>();
        private List<Artista> artistas_seguidos_ = new List<Artista>();
        private List<Song> historial_canciones_ = new List<Song>();
        private List<Video> historial_videos_ = new List<Video>();
        private List<Song> lista_inteligente = new List<Song>();

        public string Nombreusuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string Nombre_ { get { return nombre_; } set { nombre_ = value; } }
        public string Email_ { get { return email_; } set { email_ = value; } }
        public string Password_ { get { return password_; } set { password_ = value; } }
        public string Ultimareproduccion_ { get { return ultimareproduccion_; } set { ultimareproduccion_ = value; } }
        public string Perfipublico_ { get { return perfilpublico_; } set { perfilpublico_ = value; } }
        public string Premium_ { get { return premium_; } set { premium_ = value; } }
        public string Valorcriterio_ { get { return valorcriterio_; } set { valorcriterio_ = value; } }
        public List<Song> Historial_canciones_ { get => historial_canciones_; set => historial_canciones_ = value; }
        public List<Video> Historial_videos_ { get => historial_videos_; set => historial_videos_ = value; }
        public List<Song> Favorite_songs_ { get => favorite_songs_; set => favorite_songs_ = value; }
        public List<Video> Favorite_videos_ { get => favorite_videos_; set => favorite_videos_ = value; }
        public List<Song> Descargas_ { get => descargas_; set => descargas_ = value; }
        public List<PlaylistSong> Lista_playlistusuario_ { get => lista_playlistusuario_; set => lista_playlistusuario_ = value; }
        public List<PlaylistVideo> Lista_playlistvideousuario_ { get => lista_playlistvideousuario_; set => lista_playlistvideousuario_ = value; }
        public List<User> Usuarios_seguidos_ { get => usuarios_seguidos_; set => usuarios_seguidos_ = value; }
        public List<Song> Lista_inteligente { get => lista_inteligente; set => lista_inteligente = value; }
        public List<Artista> Artistas_seguidos_ { get => artistas_seguidos_; set => artistas_seguidos_ = value; }







        public User(string _nombre_, string _nomusuario_, string _email_, string _password_)
        {
            this.Email_ = _email_;
            this.Nombre_ = _nombre_;
            this.Password_ = _password_;
            this.Nombreusuario = _nomusuario_;
        }



        public string InformacionUsuario()
        {
            string informacion = ("ID USUARIO: " + nombreUsuario + "\n" + "- Nombre: " + nombre_ + "\n" + "- Email: " + email_ + "\n");
            return informacion;
        }
        public string InformacionUsuariopriv()
        {
            string informacion2 = ("ID USUARIO: " + nombreUsuario  + " NOMBRE: " + nombre_  + " EMAIL: " + email_  + " PASSWORD: " + password_  + " PRIVACIDAD: " + perfilpublico_  + " PRIVILEGIO: " + premium_);
            return informacion2;
        }
       
        public void Agregar_cancion_favoritos(Song song)
        {
            Favorite_songs_.Add(song);
        }
        public void Agregar_video_favoritos(Video video)
        {
            Favorite_videos_.Add(video);
        }



        /*
        public List<Song> Busqueda_filtrada(string _criterio, string _valor)
        {
            listafiltrada = new List<Song>();


        public bool crear_Playlist(string criterio, string valorCriterio, string nombrePlaylist)
        {

            List<Song> listplay = Busqueda_filtrada(criterio, valorCriterio);
            if (listplay.Count == 0)
            {
                Console.WriteLine("Por ende, no ha sido posible  crear la playlist");
                return false;
            }

            for (int i = 0; i < listplay2.Count; i++)
            {
                if (listplay2[i].NombrePlaylist == nombrePlaylist)
                {
                    Console.WriteLine("La playlist ya existe");
                    return false;
                }
            }
        }

        Playlist listplay3 = new Playlist(nombrePlaylist, listplay);
        listplay2.Add(listplay3);
        Console.WriteLine("===============================");
        Console.WriteLine("Playlist exitosamente agregada");
        Console.WriteLine("===============================");
        Console.WriteLine(listplay3.informationPLN());
        Console.WriteLine(listplay3.informationPLL());
        Console.WriteLine("===============================");
        return true;







        public List<Cancion> Busqueda_filtrada(string _criterio, string _valor)
        {
        listafiltrada = new List<Cancion>();


        return listafiltrada;*/


    }
}
