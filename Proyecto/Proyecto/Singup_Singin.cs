using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proyecto
{
    class Singup_Singin
    {
          
        public List<User> listausuarios = new List<User>();

        public bool Agregarusuarioalalista(User u1)
        {
            for (int i = 0; i < listausuarios.Count; i++)
            {

                User ui = listausuarios[i];

                if (ui.Email == u1.Email)
                {
                    Console.WriteLine("Ya existe una cuenta con este email");
                    return false;
                }
                if (ui.NombreUsuario == u1.NombreUsuario)
                {
                    Console.WriteLine("Ya existe este nombre de usuario, pruebe con otro");
                    return false;
                }

            }

            listausuarios.Add(u1);
            Console.WriteLine("Usuario correctamente registrado");
            Thread.Sleep(2000);
            return true;
        }

        public bool Ingresaralaapp(string email, string password)
        {
            bool usuarioencontrado = false;
            User ui = null;
            for (int j = 0; j < listausuarios.Count; j++)
            {
                ui = listausuarios[j];
                if (ui.Email == email)
                {
                    usuarioencontrado = true;
                    break;

                }



            }
            if (usuarioencontrado == true)
            {
                if (ui.Password != password)
                {
                    Console.WriteLine("Incorrect Password");

                    return false;

                }
                else
                {
                    Console.WriteLine("Ingresando a ALAINID...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Bievenido" + "\n" + ui.Nombre);
                    Thread.Sleep(3000);
                    return true;
                }

            }
            else
            {
                Console.WriteLine("Email not found");
                return false;
            }


        }
    }
}
