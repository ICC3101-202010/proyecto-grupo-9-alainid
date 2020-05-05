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
    }
}
    