using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    class User
    {
        public string NombreUsuario;
        public string Email;
        public string Password;
        public string Nombre;


        public string nombreusuario
        {
            get
            {
                return NombreUsuario;
            }
            set
            {
                NombreUsuario = value;
            }
        }

        public string nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public bool Premium
        {
            get
            {
                return Premium;
            }
            set
            {
                Premium = false;
            }
        }
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public List<PlaylistSong> lista_playlistusuario = new List<PlaylistSong>();

        public User(string _nombre_, string _nomusuario_, string _email_, string _password_)
        {
            this.email = _email_;
            this.nombre = _nombre_;
            this.password = _password_;
            this.nombreusuario = _nomusuario_;
        }
        public string InformacionUsuario()
        {
            string informacion = ("ID USUARIO: " + NombreUsuario + "\n" + "- Nombre: " + Nombre + "\n" + "- Email: " + Email + "\n");
            return informacion;
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