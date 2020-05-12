using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto

{
    [Serializable]
    public class User
    {
        public string NombreUsuario;
        public string Email;
        public string Password;
        public string Nombre;
        public List<PlaylistSong> lista_playlistusuario = new List<PlaylistSong>();
        public List<PlaylistVideo> lista_playlistvideousuario = new List<PlaylistVideo>();
        public string Premium;
        public List<Song> favorite_songs = new List<Song>();        // LISTA FAVORITOS CANCIONES DE CADA USUARIO
        public List<Video> favorite_videos = new List<Video>();
        public List<Song> descargas = new List<Song>();// LISTA FAVORITOS VIDEOS DE CADA USUARIO
        public string PerfilPublico;
        public string Ultimareproduccion;
        
        public string nombreusuario { get { return NombreUsuario; } set { NombreUsuario = value; } }
        public string nombre { get { return Nombre; } set { Nombre = value; } }
        public string email { get { return Email; } set { Email = value; } }
        public string password { get { return Password; } set { Password = value; } }
        public string ultimareproduccion { get { return Ultimareproduccion; } set { Ultimareproduccion = value; } }
        public string perfipublico { get { return PerfilPublico; } set { PerfilPublico = value; } }
        public string premium { get { return Premium; } set { Premium = value; } }

        public List<Song> Favorite_songs { get => favorite_songs; set => favorite_songs = value; }
        public List<Video> Favorite_videos { get => favorite_videos; set => favorite_videos = value; }
        public List<Song> Descargas { get => descargas; set => descargas = value; }
        public List<PlaylistSong> Lista_playlistusuario { get => lista_playlistusuario; set => lista_playlistusuario = value; }
        public List<PlaylistVideo> Lista_playlistvideousuario { get => lista_playlistvideousuario; set => lista_playlistvideousuario = value; }
        public List<PlaylistSong> playlistcanciones_seguidas = new List<PlaylistSong>();
        public List<Song> Canciones_favoritas = new List<Song>();
        public List<Video> Videos_favoritos = new List<Video>();
        public List<Video> videos_seguidos = new List<Video>();
        public List<Artista> artistas_seguidas = new List<Artista>();
        public List<User> user_seguidas = new List<User>();


        public User(string _nombre_, string _nomusuario_, string _email_, string _password_, string _ultimareproduccion, string _privacidad, string _premium)
        {
            this.email = _email_;
            this.nombre = _nombre_;
            this.password = _password_;
            this.nombreusuario = _nomusuario_;
            this.ultimareproduccion = _ultimareproduccion;
            this.perfipublico = _privacidad;
            this.premium = _premium;
        }

        

        public string InformacionUsuario()
        {
            string informacion = ("ID USUARIO: " + NombreUsuario + "\n" + "- Nombre: " + Nombre + "\n" + "- Email: " + Email + "\n");
            return informacion;
        }
        public string InformacionUsuariopriv()
        {
            string informacion2 = ("ID USUARIO: " + NombreUsuario + "\n" + "- Nombre: " + Nombre + "\n" + "- Email: " + Email + "\n" + "- Password: " + Password + "\n" + "- Privacidad: " + PerfilPublico+"\n"+"- Privilegio: "+Premium);
            return informacion2;
        }
        //public void Crear_playlist(string nombre)
        //{
            //PlaylistSong playlistSong = new PlaylistSong(nombre);
            //Lista_playlistusuario.Add(playlistSong);
        //}

        public void Agregar_cancion_favoritos(Song song){
            favorite_songs.Add(song);
        }
        public void Agregar_video_favoritos(Video video){
            favorite_videos.Add(video);
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