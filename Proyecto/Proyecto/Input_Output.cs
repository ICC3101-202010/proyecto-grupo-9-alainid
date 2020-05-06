using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    public class Input_Output : Control
    {
        public void Comenzar_app()
        {
            Singup_Singin r = new Singup_Singin();
            Admin a = new Admin();
            Console.WriteLine("Bienvendio a ALAINID");
            Console.WriteLine("========================");
            Console.WriteLine("Seleccione una opción: \n");
            Console.WriteLine("1. Registrarse \n");
            Console.WriteLine("2. Ingresar a la app \n");
            Console.WriteLine("3. Salir del programa\n");
            string accion = null;
            while (accion != "3")
            {
                accion = Console.ReadLine();
                switch (accion)
                {
                    case "1":
                        Console.WriteLine("=====================");
                        Console.WriteLine("Crear usuario");
                        Console.WriteLine("=====================");
                        string idusuario = "";
                        string nombre = "";
                        string email = "";
                        string password = "";
                        Console.WriteLine("Ingrese su nombre de usuario");
                        idusuario = Console.ReadLine();
                        Console.WriteLine("Ingrese su email");
                        email = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña");
                        password = Console.ReadLine();
                        Console.WriteLine("Ingrese su nombre completo");
                        nombre = Console.ReadLine();
                        User u1 = new User(nombre, idusuario, email, password);
                        r.Agregarusuarioalalista(u1);
                        break;
                    case "2":
                        string email2 = "";
                        string password2 = "";
                        Console.WriteLine("Ingrese email:");
                        email2 = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña");
                        password2 = Console.ReadLine();
                        r.Ingresaralaapp(email2, password2);
                        if (r.Ingresaralaapp(email2, password2) == true)
                        {
                            Console.WriteLine("Inicio de ession exitoso");
                            Console.WriteLine("========================");
                            Console.WriteLine("Seleccione una opción: \n");
                            Console.WriteLine("1. hacer busqueda \n");
                            Console.WriteLine("3. Salir del programa\n");
                            string accion2 = null;
                            while (accion2 != "3")
                            {
                                accion2 = Console.ReadLine();
                                switch (accion)
                                {
                                    case "1":
                                        break;
                                    case "3":
                                        Console.WriteLine("Has salido del programa");
                                        accion = "3";
                                        break;
                                }
                            }
                        }
                        break;
                    case "1h3hdjs83hr8d7dtwisos":
                        Console.WriteLine("Ingresando como admin....");
                        break;
                    case "3":
                        Console.WriteLine("Has salido del programa");
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción válida");
                        break;
                }
            }
        }
    }
}
        

        
   
