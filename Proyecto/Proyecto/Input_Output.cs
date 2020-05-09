﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proyecto
{
    public static class Input_Output
    {

        public static void Comenzar_app()
        {
            Funciones funciones = new Funciones();
            Admin a = new Admin();
            Player pla = new Player();
            Console.WriteLine("Bienvendio a ALAINID");
            Console.WriteLine("========================");


            int accion = '\0';
            while (accion != 3)
            {
                Console.WriteLine("Seleccione una opción: \n");
                Console.WriteLine("1. Registrarse \n");
                Console.WriteLine("2. Ingresar a la app \n");
                Console.WriteLine("3. Salir del programa\n");
                accion = funciones.Numero(3);
                switch (accion)
                {
                    case 1:
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
                        ALAINID.Activarlista();
                        ALAINID.Agregarusuarioalalista(u1);
                        break;
                    case 2:
                        Console.Clear();
                        bool bol = false;
                        string email2 = "";
                        string password2 = "";
                        Console.WriteLine("Ingrese email:");
                        email2 = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña");
                        password2 = Console.ReadLine();
                        ALAINID.Activarlista();
                        bol = ALAINID.Ingresaralaapp(email2, password2);
                        
                        if (bol == true)
                        {
                            int accion2 = '\0';
                            while (accion2 != 9)
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
                                Console.WriteLine("8. PERFIL");
                                Console.WriteLine("9. CERRAR SESION\n");
                                accion2 = funciones.Numero(9);
                                switch (accion2)
                                {
                                    case 1:
                                        int accion3 = '\0';
                                        while (accion3 != 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("========================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. BUSQUEDA SIMPLE ");
                                            Console.WriteLine("2. BUSQUEDA FILTRADA");
                                            Console.WriteLine("3. ATRAS");
                                            accion3 = funciones.Numero(3);
                                            switch (accion3)
                                            {
                                                case 1:
                                                    int swbus = '\0';
                                                    while (swbus!=3)
                                                    {
                                                        Console.WriteLine("1.BUSCAR CANCION POR NOMBRE");
                                                        Console.WriteLine("2.BUSCAR VIDEO POR NOMBRE");
                                                        Console.WriteLine("3.SALIR");
                                                        int opcion = funciones.Numero(3);
                                                        switch (opcion)
                                                        {
                                                            case 1:
                                                                Console.WriteLine("1.INGRESE NOMBRE CANCION");
                                                                string nombrecancion = Console.ReadLine();
                                                                pla.Playsong("Canciones/" + nombrecancion + ".mp3");
                                                                break;
                                                            case 2:
                                                                break;
                                                            case 3:
                                                                break;

                                                        }
                                                        
                                                        
                                                    }
                                                    break;
                                                    
                                                case 2:
                                                    //METODO BUSQUEDA FILTRADA
                                                    break;
                                                case 3:
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                                    Thread.Sleep(2000);
                                                    break;
                                            }
                                        }
                                        break;


                                    case 2:
                                        int accion4 = '\0';
                                        while (accion4 != 5)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("=================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. VER TUS PLAYLISTS DE CANCIONES");
                                            Console.WriteLine("2. VER TUS PLAYLISTS DE VIDEOS");
                                            Console.WriteLine("3. CREAR PLAYLIST DE CANCIONES");
                                            Console.WriteLine("4. CREAR PLAYLIST DE VIDEOS");
                                            Console.WriteLine("5. ATRAS");
                                            accion4 = funciones.Numero(5);
                                            switch (accion4)
                                            {
                                                case 1:
                                                    //METODO VER PLAYLIST CANCIONES
                                                    break;
                                                case 2:
                                                    //METODO VER PLAYLIST VIDEOS
                                                    break;
                                                case 3:
                                                    //METODO CREAR PLAYLIST CANCIONES
                                                    break;
                                                case 4:
                                                    //METODO CREAR PLAYLIST CANCIONES
                                                    break;
                                                case 5:
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                                    Thread.Sleep(2000);
                                                    break;
                                            }
                                        }
                                        break;
                                    case 3:
                                        int accion5 = '\0';
                                        while (accion5 != 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("==================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. VER TUS CANCIONES FAVORITAS");
                                            Console.WriteLine("2. VER TUS VIDEOS FAVORITOS");
                                            Console.WriteLine("3. ATRAS");

                                            accion5 = funciones.Numero(3);
                                            switch (accion5)
                                            {
                                                case 1:
                                                    //METODO VER CANCIONES FAVORITAS
                                                    break;
                                                case 2:
                                                    //METODO VER CANCIONES VIDEOS
                                                    break;
                                                case 3:
                                                    break;
                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                                    Thread.Sleep(2000);
                                                    break;

                                            }
                                        }
                                        break;
                                    case 8:
                                        int accion8 = '\0';
                                        while (accion8 != 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("========================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. VER PERIL ");
                                            Console.WriteLine("2. EDITAR PERFIL");
                                            Console.WriteLine("3. ATRAS");
                                            accion8 = funciones.Numero(3);
                                            switch (accion8)
                                            {
                                                case 1:
                                                    int accion10 = '\0';
                                                    while (accion10 != 1)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(ALAINID.Verinformacion(email2));
                                                        Console.WriteLine("========================");
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine("1.  ATRÁS");
                                                        accion10 = funciones.Numero(1);
                                                        switch (accion10)
                                                        {
                                                            case 1:
                                                                break;
                                                        }

                                                    }
                                                    break;

                                                case 2:
                                                    int accion9 = '\0';
                                                    while (accion9 != 4)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("========================");
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine("1. CAMBIAR CONTRASEÑA ");
                                                        Console.WriteLine("2. CAMBIAR NOMBRE DE USUARIO");
                                                        Console.WriteLine("3. CAMBIAR NOMBRE");
                                                        Console.WriteLine("4. ATRAS");
                                                        accion9 = funciones.Numero(4);
                                                        switch (accion9)
                                                        {
                                                            case 1:
                                                                Console.Clear();
                                                                Console.WriteLine("Escriba su email: ");
                                                                string emaile = Console.ReadLine();
                                                                Console.WriteLine("Escriba su contrasena actual: ");
                                                                string contrasena = Console.ReadLine();
                                                                Console.WriteLine("Escriba su nueva contrasena: ");
                                                                string nuevacontrasena = Console.ReadLine();
                                                                bool bol8 = ALAINID.Cambiarcontrasena(emaile, contrasena, nuevacontrasena);
                                                                if (bol8 == true)
                                                                {
                                                                    Console.WriteLine("Contrasena exitosamente cambiada");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Usuario o contrasena actual incorrecta");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                break;
                                                            case 2:
                                                                //cambiar nombre usuario
                                                                Console.Clear();
                                                                Console.WriteLine("Escriba su email: ");
                                                                email = Console.ReadLine();
                                                                Console.WriteLine("Escriba su contrasena actual: ");
                                                                contrasena = Console.ReadLine();
                                                                Console.WriteLine("Escriba su nuevo usuario: ");
                                                                string nuevonombre = Console.ReadLine();
                                                                bol = ALAINID.Cambiarnombreusuario(email, contrasena, nuevonombre);
                                                                if (bol == true)
                                                                {
                                                                    Console.WriteLine("Nombre de usuario exitosamente cambiado");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("email o contrasena actual incorrecta");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                break;
                                                            case 3:
                                                                //cambiar nombre
                                                                Console.Clear();
                                                                Console.WriteLine("Escriba su email: ");
                                                                email = Console.ReadLine();
                                                                Console.WriteLine("Escriba su contrasena actual: ");
                                                                contrasena = Console.ReadLine();
                                                                Console.WriteLine("Escriba su nuevo nombre: ");
                                                                nuevonombre = Console.ReadLine();
                                                                bol = ALAINID.Cambiarnombre(email, contrasena, nuevonombre);
                                                                if (bol == true)
                                                                {
                                                                    Console.WriteLine("Nombre exitosamente cambiado");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("email o contrasena actual incorrecta");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                break;


                                                            case 4:
                                                                break;
                                                            default:
                                                                Console.Clear();
                                                                Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                                                Thread.Sleep(2000);
                                                                break;
                                                        }
                                                    
                                                    }
                                                    break;
                                                case 3:
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
                    case 29846455:
                        Console.Clear();
                        Console.WriteLine("Ingresando como admin....");
                        break;
                    case 3:
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