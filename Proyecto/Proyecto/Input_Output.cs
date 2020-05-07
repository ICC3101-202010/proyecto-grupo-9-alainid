using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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

            
            string accion = null;
            while (accion != "3")
            {
                Console.WriteLine("Seleccione una opción: \n");
                Console.WriteLine("1. Registrarse \n");
                Console.WriteLine("2. Ingresar a la app \n");
                Console.WriteLine("3. Salir del programa\n");
                accion = Console.ReadLine();
                switch (accion)
                {
                    case "1":
                        Console.Clear();
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
                        Console.Clear();
                        bool bol = false;
                        string email2 = "";
                        string password2 = "";
                        Console.WriteLine("Ingrese email:");
                        email2 = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña");
                        password2 = Console.ReadLine();
                        bol = r.Ingresaralaapp(email2, password2);
                        if (bol == true)
                        {
                            string accion2 = null;
                            while (accion2 != "8")
                            {
                                Console.Clear();
                                Console.WriteLine("========================");
                                Console.WriteLine(" ");
                                //METODOS QUE LE MUESTREN AL USUARIO COSAS DE SU CUENTA
                                //MENU DE OPCIONES
                                Console.WriteLine("Seleccione una opción: \n");
                                Console.WriteLine("========================");
                                Console.WriteLine("1. BUSCAR ");
                                Console.WriteLine("2. PLAYLISTS");
                                Console.WriteLine("3. FAVORITOS");
                                Console.WriteLine("4. KARAOKE");
                                Console.WriteLine("5. SOCIAL");
                                Console.WriteLine("6. TU HISTORIAL");
                                Console.WriteLine("7. PREMIUM");
                                Console.WriteLine("8. CERRAR SESION\n");
                                accion2 = Console.ReadLine();
                                switch (accion2)
                                {
                                    case "1":
                                        string accion3 = null;
                                        while (accion3 != "3")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("========================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. BUSQUEDA SIMPLE ");
                                            Console.WriteLine("2. BUSQUEDA FILTRADA");
                                            Console.WriteLine("3. ATRAS");
                                            accion3 = Console.ReadLine();
                                            switch (accion3)
                                            {
                                                case "1":
                                                    //METODO BUSQUEDA SIMPLE
                                                    break;
                                                case "2":
                                                    //METODO BUSQUEDA FILTRADA
                                                    break;
                                                case "3":
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                                    Thread.Sleep(2000);
                                                    break;
                                            }
                                        }
                                        break;


                                    case "2":
                                        string accion4 = null;
                                        while (accion4 != "5")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("=================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. VER TUS PLAYLISTS DE CANCIONES");
                                            Console.WriteLine("2. VER TUS PLAYLISTS DE VIDEOS");
                                            Console.WriteLine("3. CREAR PLAYLIST DE CANCIONES");
                                            Console.WriteLine("4. CREAR PLAYLIST DE VIDEOS");
                                            Console.WriteLine("5. ATRAS");
                                            accion4 = Console.ReadLine();
                                            switch (accion4)
                                            {
                                                case "1":
                                                    //METODO VER PLAYLIST CANCIONES
                                                    break;
                                                case "2":
                                                    //METODO VER PLAYLIST VIDEOS
                                                    break;
                                                case "3":
                                                    //METODO CREAR PLAYLIST CANCIONES
                                                    break;
                                                case "4":
                                                    //METODO CREAR PLAYLIST CANCIONES
                                                    break;
                                                case "5":
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                                    Thread.Sleep(2000);
                                                    break;
                                            }
                                        }
                                        break;
                                    case "3":
                                        string accion5 = null;
                                        while (accion5 != "3")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("==================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. VER TUS CANCIONES FAVORITAS");
                                            Console.WriteLine("2. VER TUS VIDEOS FAVORITOS");
                                            Console.WriteLine("3. ATRAS");

                                            accion5 = Console.ReadLine();
                                            switch (accion5)
                                            {
                                                case "1":
                                                    //METODO VER CANCIONES FAVORITAS
                                                    break;
                                                case "2":
                                                    //METODO VER CANCIONES VIDEOS
                                                    break;
                                                case "3":
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                                    Thread.Sleep(2000);
                                                    break;

                                            }
                                        }
                                        break;


                                }
                            }
                        }
                        break;
                    case "1h3hdjs83hr8d7dtwisos":
                        Console.Clear();
                        Console.WriteLine("Ingresando como admin....");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Has salido del programa");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No se ha seleccionado ninguna opción válida");
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
        
//holacomoestas
        
   
