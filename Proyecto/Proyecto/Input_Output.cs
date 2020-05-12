
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proyecto
{
    public static class Input_Output
    {
        public static void Comenzar_app()
        {

            Admin a = new Admin();
            Player pla = new Player();
            

            Console.WriteLine("\t\t  Bienvendio a ALAINID");
            Console.WriteLine("\t\t========================");

            int accion = '\0';
            while (accion != 3)
            {
                Console.WriteLine("Seleccione una opción: \n");
                Console.WriteLine("1. Registrarse \n");
                Console.WriteLine("2. Ingresar a la app \n");
                Console.WriteLine("3. Salir del programa\n");
                accion = ALAINID.Acceso_inicial();
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
                        string ultimareproduccion = "";
                        string premium = "no premium";
                        string perfilpublico = "publico";
                        Console.WriteLine("Ingrese su nombre de usuario");
                        idusuario = Console.ReadLine();
                        Console.WriteLine("Ingrese su email");
                        email = Console.ReadLine();
                        Console.WriteLine("Ingrese contraseña");
                        password = Console.ReadLine();
                        Console.WriteLine("Ingrese su nombre completo");
                        nombre = Console.ReadLine();
                        User u1 = new User(nombre, idusuario, email, password, ultimareproduccion, perfilpublico, premium);
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
                        ALAINID.UltimaReproduccion(email2);
                        if (bol == true)
                        {
                            int accion2 = '\0';
                            while (accion2 != 10)
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
                                Console.WriteLine("9. CANCIONES DESCARGADAS");
                                
                                Console.WriteLine("10. CERRAR SESION\n\n");
                                Console.WriteLine("11. ESCUCHA TU ULTIMA REPRODUCCION");
                                Console.WriteLine("12. PAUSA");
                                Console.WriteLine("13. PLAY (ESCUCHAR DONDE HABIAS QUEDADO)");
                                Console.WriteLine("14. STOP");
                                accion2 = ALAINID.Numero(14);
                                switch (accion2)
                                {
                                    case 1:
                                        int accion3 = '\0';
                                        while (accion3 != 4)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("========================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. BUSQUEDA FILTRADA CANCION CON UN CRITERIO");
                                            Console.WriteLine("2. BUSQUEDA FILTRADA CANCION CON MÁS DE UN CRITERIO");
                                            Console.WriteLine("3. BUSQUEDA DE USUARIOS");
                                            Console.WriteLine("4. ATRAS");
                                            accion3 = ALAINID.Numero(4);
                                            switch (accion3)
                                            {
                                                case 1:
                                                    ALAINID.Activarlistacanciones();
                                                    ALAINID.Activarlistacantantes();
                                                    ALAINID.Partirlistacompositores();
                                                    ALAINID.Partirlistaalbumes();
                                                    Console.Clear();
                                                    string criterio;
                                                    string valor = "";
                                                    Console.WriteLine("Ingrese el criterio por el cual desea buscar una canción");
                                                    criterio = ALAINID.ShowOptions(ALAINID.lista_criterios_filtro);
                                                    Console.WriteLine("Ingrese el valor de ese criterio");
                                                    if ("Genero" == criterio) {
                                                        valor = ALAINID.ShowOptions(ALAINID.lista_generos_canciones);
                                                    }
                                                    else if ("Cantante" == criterio) {
                                                        valor = ALAINID.ShowOptions(ALAINID.Lista_nombres_cantantes());
                                                    }
                                                    else if ("Album" == criterio) {
                                                        valor = ALAINID.ShowOptions(ALAINID.Lista_nombres_albums());
                                                    }
                                                    else if ("Nombre" == criterio) {
                                                        valor = ALAINID.ShowOptions(ALAINID.Lista_nombres_canciones());
                                                    }
                                                    else if ("Disquera" == criterio) {
                                                        valor = ALAINID.ShowOptions(ALAINID.lista_disquera);
                                                    }
                                                    else if ("Compositor" == criterio) {
                                                        valor = ALAINID.ShowOptions(ALAINID.Lista_nombres_compositores());
                                                    }
                                                    else if ("Año Publicacion" == criterio) {
                                                        //bool si = true;
                                                        valor = Console.ReadLine();
                                                        /*while (si) {
                                                            foreach (string anio in ALAINID.anios) {
                                                                if (anio == v) {
                                                                    valor = anio;
                                                                    si = false;
                                                                    break;
                                                                }
                                                                else {
                                                                    Console.WriteLine("El año ingresado no es valido, vuelva a intentar");
                                                                }
                                                            }
                                                        }*/
                                                    }
                                                    else if ("Sexo del Artista" == criterio)
                                                    {
                                                        valor = ALAINID.ShowOptions(ALAINID.sexo);
                                                    }
                                                    else if ("Edad del Artista" == criterio)
                                                    {
                                                        valor = ALAINID.ShowOptions(ALAINID.edades);
                                                    }
                                                    else if ("Calidad/Resolucion" == criterio)
                                                    {
                                                        valor = ALAINID.ShowOptions(ALAINID.lista_calidad_cancion);
                                                    }
                                                    else if ("Evaluacion" == criterio)
                                                    {
                                                        //EVALUACION
                                                    }
                                                    int opcion = '\0';
                                                    while (opcion != 2)
                                                    {
                                                        Console.Clear();
                                                        ALAINID.CancionesPorCriterio(criterio, valor);
                                                        ALAINID.Vercancionesparareproduccion(ALAINID.listafiltrada);
                                                        Console.WriteLine("========================");
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine("INGRESE NUMERO DE LA CANCIÓN QUE DESEA ESCUCHAR");
                                                        Console.WriteLine("0 PARA SALIR");
                                                        int numerocancion = Convert.ToInt32(Console.ReadLine());
                                                        if ((numerocancion >= 1) && (numerocancion <= ALAINID.listafiltrada.Count))
                                                        {
                                                            string u = "";
                                                            string w = "";
                                                            int v;
                                                            u = ALAINID.listafiltrada[numerocancion - 1].nombrearchivo;
                                                            v = ALAINID.listafiltrada[numerocancion - 1].reproducciones;
                                                            w = ALAINID.listafiltrada[numerocancion - 1].nombrecancion;
                                                            int opcion10 = '\0';
                                                            while (opcion10 != 11)
                                                            {
                                                                Console.Clear();
                                                                //ALAINID.listafiltrada[numerocancion - 1].nombrearchivo;
                                                                Console.WriteLine("1. COMENZAR REPRODUCCION");
                                                                Console.WriteLine("2. PAUSAR REPRODUCCION");
                                                                Console.WriteLine("3. REANUDAR REPRODUCCIÓN");
                                                                Console.WriteLine("4. PARAR REPRODUCCIÓN");
                                                                Console.WriteLine("5. VER INFORMACIÓN DE LA CANCIÓN ");
                                                                Console.WriteLine("6. AGREGAR A PLAYLIST ");
                                                                Console.WriteLine("7. AGREGAR A FAVORITOS ");
                                                                Console.WriteLine("8. AGREGAR A LA COLA ");
                                                                Console.WriteLine("9. REPRODUCIR COLA");
                                                                Console.WriteLine("10. ELIMINAR COLA");
                                                                Console.WriteLine("11. SALIR");
                                                                Console.WriteLine("");
                                                                opcion10 = ALAINID.Numero(11);
                                                                switch (opcion10)
                                                                {
                                                                    case 1:
                                                                        pla.Playsong(u);
                                                                        ALAINID.GuardarUltimareproduccion(email2, u);
                                                                        ALAINID.Aumentarreproduccion(w, v);
                                                                        //CAMBIO

                                                                        break;
                                                                    case 2:
                                                                        pla.PauseSong();
                                                                        break;
                                                                    case 3:
                                                                        pla.ResumeSong(u);
                                                                        break;
                                                                    case 4:
                                                                        pla.StopSong();
                                                                        break;
                                                                    case 5:
                                                                        int opcion60 = '\0';
                                                                        while (opcion60 != 1)
                                                                        {
                                                                            Console.Clear();
                                                                            ALAINID.Verinfodeunacancion(ALAINID.listafiltrada[numerocancion - 1]);
                                                                            Console.WriteLine("======================================");
                                                                            Console.WriteLine("1. ATRAS");
                                                                            opcion60 = ALAINID.Numero(1);
                                                                            switch (opcion60)
                                                                            {
                                                                                case 1:
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case 6:
                                                                        Console.WriteLine("INGRESE EL NUMERO DE LA PLAYLIST A LA QUE DESEA AGREGAR");
                                                                        Console.WriteLine(ALAINID.Vernombresplaylistcancion(email2));
                                                                        string nply = Console.ReadLine();
                                                                        Console.WriteLine(ALAINID.Agregarcancionaply(email2, nply, ALAINID.listafiltrada[numerocancion - 1]));
                                                                        Thread.Sleep(2000);
                                                                        break;
                                                                    case 7:
                                                                        ALAINID.Agregar_a_favoritos(email2, ALAINID.listafiltrada[numerocancion - 1]);
                                                                        break;
                                                                    case 8:
                                                                        pla.Agregarcancionacola(u);

                                                                        //pla.limpiacola();
                                                                        break;
                                                                    case 9:
                                                                        int accion36 = '\0';
                                                                        while (accion36 != 6)
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("1. PLAY COLA");
                                                                            Console.WriteLine("2. PAUSAR COLA");
                                                                            Console.WriteLine("3. REANUDAR COLA");
                                                                            Console.WriteLine("4. SIGUIENTE CANCION");
                                                                            Console.WriteLine("5. CANCIÓN ANTERIOR");
                                                                            Console.WriteLine("6. ATRAS");
                                                                            accion36 = ALAINID.Numero(6);
                                                                            switch (accion36)
                                                                            {
                                                                                case 1:
                                                                                    pla.playcola();
                                                                                    ALAINID.GuardarUltimareproduccion(email2, u);
                                                                                    break;
                                                                                case 2:
                                                                                    pla.PauseSong();
                                                                                    break;
                                                                                    break;
                                                                                case 3:
                                                                                    pla.ResumeSong(u);
                                                                                    break;
                                                                                case 4:
                                                                                    pla.siguiente();
                                                                                    break;

                                                                                case 5:
                                                                                    pla.previa();
                                                                                    break;
                                                                                case 6:
                                                                                    break;
                                                                                default:
                                                                                    Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                    break;

                                                                            }

                                                                        }
                                                                        break;
                                                                    case 10:
                                                                        pla.limpiacola();
                                                                        break;
                                                                    case 11:// salir
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                        break;
                                                                }
                                                            }
                                                        }
                                                        else { if (numerocancion == 0) { break; } }
                                                    }
                                                    break;
                                                case 2:

                                                    break;
                                                case 3:
                                                    ALAINID.Activarlistacanciones();
                                                    ALAINID.Activarlistacantantes();
                                                    ALAINID.Partirlistacompositores();
                                                    ALAINID.Partirlistaalbumes();
                                                    ALAINID.Activarlista();
                                                    Console.Clear();
                                                    string criterio2 = "";
                                                    string valor2 = "";
                                                    Console.WriteLine("Ingrese el criterio por el cual desea buscar al usuario");
                                                    criterio2 = ALAINID.ShowOptions(ALAINID.lista_criterios_usuarios);      //-------37
                                                    Console.WriteLine("Ingrese el {0} que desea buscar", criterio2);
                                                    valor2 = Console.ReadLine();
                                                    int opcion56 = '\0';
                                                    while (opcion56 != 2)
                                                    {
                                                        Console.Clear();
                                                        ALAINID.UsuariosPorCriterio(criterio2, valor2);
                                                        ALAINID.VerUsuariosbusqueda(ALAINID.listafiltradausuarios);
                                                        Console.WriteLine("========================");
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine("INGRESE NUMERO DEL USUARIO QUE DESEA VER");
                                                        Console.WriteLine("0 PARA SALIR");
                                                        int numerousuario = Convert.ToInt32(Console.ReadLine());
                                                        if ((numerousuario >= 1) && (numerousuario <= ALAINID.listafiltradausuarios.Count))
                                                        {
                                                            int opcion57 = '\0';
                                                            while (opcion57 != 3)
                                                            {
                                                                Console.Clear();
                                                                //ALAINID.listafiltrada[numerocancion - 1].nombrearchivo;
                                                                Console.WriteLine("1. VER INFORMACIÓN DEL USUARIO ");
                                                                Console.WriteLine("2. SEGUIR");
                                                                Console.WriteLine("3. SALIR");
                                                                Console.WriteLine("");
                                                                opcion57 = ALAINID.Numero(3);
                                                                switch (opcion57)
                                                                {
                                                                    case 1:
                                                                        int opcion59 = '\0';
                                                                        while (opcion59 != 1)
                                                                        {
                                                                            Console.Clear();

                                                                            ALAINID.Verinfodeunusuario(ALAINID.listafiltradausuarios[numerousuario - 1]);
                                                                            Console.WriteLine("======================================");
                                                                            Console.WriteLine("1. ATRAS");
                                                                            opcion59 = ALAINID.Numero(1);
                                                                            switch (opcion59)
                                                                            {
                                                                                case 1:
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        Console.WriteLine(ALAINID.Seguirusuario(email2, ALAINID.listafiltradausuarios[numerousuario - 1]));
                                                                        Thread.Sleep(2000);
                                                                        break;
                                                                    case 3:
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                        break;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (numerousuario == 0)
                                                            {
                                                                break;
                                                            }
                                                        }
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
                                    case 2:
                                        ALAINID.Activarlistacanciones();
                                        ALAINID.Activarlistacantantes();
                                        ALAINID.Partirlistacompositores();
                                        ALAINID.Partirlistaalbumes();
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
                                            accion4 = ALAINID.Numero(5);
                                            switch (accion4)
                                            {
                                                case 1:
                                                    //METODO VER PLAYLIST CANCIONES

                                                    string accion34 = "2";
                                                    if (ALAINID.Vernombresplaylistcancion(email2) != "No hay Playlist")
                                                    {
                                                        Console.WriteLine("\nINGRESE EL NUMERO DE LA PLAYLIST QUE QUIERE VER");
                                                        Console.WriteLine(ALAINID.Vernombresplaylistcancion(email2));
                                                        int numero = ALAINID.Numero(ALAINID.Cuantasplaylistcancion(email2));
                                                        string nombreply = ALAINID.Numeroplaylistcancion(email2, numero);
                                                        ALAINID.Retornaplaylistusuario(email2, nombreply);
                                                        if (ALAINID.cachativa != "") {
                                                            while (accion34 != "0")
                                                            {
                                                                Console.WriteLine(ALAINID.VerinformacionPlaylist(email2, nombreply));
                                                                Thread.Sleep(2000);
                                                                if (ALAINID.VerinformacionPlaylist(email2, nombreply) != "No hay canciones en la playlist")
                                                                {
                                                                    Console.WriteLine("\nINGRESE El NUMERO DE LA CANCION QUE DESEA REPRODUCIR");
                                                                    Console.WriteLine("\n0 PARA VOLVER ATRÁS");

                                                                    accion34 = Console.ReadLine();
                                                                    switch (accion34)
                                                                    {
                                                                        case "0":
                                                                            break;
                                                                        default:
                                                                            string archivo = ALAINID.Archivoreproducirply(email2, nombreply, int.Parse(accion34));
                                                                            string nombrecancion = ALAINID.Nombrereproducirply(email2, nombreply, int.Parse(accion34));
                                                                            int reproduccion = ALAINID.Reproduccionreproducirply(email2, nombreply, int.Parse(accion34));
                                                                            if (archivo != "No hay info")
                                                                            {
                                                                                int opcion10 = '\0';
                                                                                while (opcion10 != 11)
                                                                                {
                                                                                    Console.Clear();
                                                                                    //ALAINID.listafiltrada[numerocancion - 1].nombrearchivo;
                                                                                    Console.WriteLine("1. COMENZAR REPRODUCCION");
                                                                                    Console.WriteLine("2. PAUSAR REPRODUCCION");
                                                                                    Console.WriteLine("3. REANUDAR REPRODUCCIÓN");
                                                                                    Console.WriteLine("4. PARAR REPRODUCCIÓN");
                                                                                    Console.WriteLine("5. VER INFORMACIÓN DE LA CANCIÓN ");
                                                                                    Console.WriteLine("6. AGREGAR A PLAYLIST ");
                                                                                    Console.WriteLine("7. AGREGAR A FAVORITOS ");
                                                                                    Console.WriteLine("8. AGREGAR A LA COLA ");
                                                                                    Console.WriteLine("9. REPRODUCIR COLA");
                                                                                    Console.WriteLine("10. ELIMINAR COLA");
                                                                                    Console.WriteLine("11. SALIR");
                                                                                    Console.WriteLine("");
                                                                                    opcion10 = ALAINID.Numero(11);
                                                                                    switch (opcion10)
                                                                                    {

                                                                                        case 1:
                                                                                            pla.Playsong(archivo);
                                                                                            ALAINID.GuardarUltimareproduccion(email2, archivo);
                                                                                            ALAINID.Aumentarreproduccion(nombrecancion, reproduccion);
                                                                                            //CAMBIO
                                                                                            break;
                                                                                        case 2:
                                                                                            pla.PauseSong();
                                                                                            break;
                                                                                        case 3:
                                                                                            pla.ResumeSong(archivo);
                                                                                            break;
                                                                                        case 4:
                                                                                            pla.StopSong();
                                                                                            break;
                                                                                        case 5:
                                                                                            int opcion60 = '\0';
                                                                                            while (opcion60 != 1)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                ALAINID.Verinfodeunacancion(ALAINID.listafiltrada2[int.Parse(accion34) - 1]);
                                                                                                Console.WriteLine("======================================");
                                                                                                Console.WriteLine("1. ATRAS");
                                                                                                opcion60 = ALAINID.Numero(1);
                                                                                                switch (opcion60)
                                                                                                {
                                                                                                    case 1:
                                                                                                        break;
                                                                                                }
                                                                                            }
                                                                                            break;
                                                                                        case 6:
                                                                                            Console.WriteLine("INGRESE EL NUMERO DE LA PLAYLIST QUE A LA QUE DESEA AGREGAR");
                                                                                            Console.WriteLine(ALAINID.Vernombresplaylistcancion(email2));
                                                                                            string nply = Console.ReadLine();
                                                                                            Console.WriteLine(ALAINID.Agregarcancionaply(email2, nply, ALAINID.listafiltrada2[int.Parse(accion34) - 1]));
                                                                                            break;
                                                                                        case 7:
                                                                                            ALAINID.Agregar_a_favoritos(email2, ALAINID.listafiltrada2[int.Parse(accion34) - 1]);
                                                                                            //AQUI HAGO EL FAVORITO

                                                                                            break;
                                                                                        case 8:
                                                                                            pla.Agregarcancionacola(archivo);

                                                                                            //pla.limpiacola();
                                                                                            break;
                                                                                        case 9:
                                                                                            int accion86 = '\0';
                                                                                            while (accion86 != 6)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("1. PLAY COLA");
                                                                                                Console.WriteLine("2. PAUSAR COLA");
                                                                                                Console.WriteLine("3. REANUDAR COLA");
                                                                                                Console.WriteLine("4. SIGUIENTE CANCION");
                                                                                                Console.WriteLine("5. CANCIÓN ANTERIOR");
                                                                                                Console.WriteLine("6. ATRAS");
                                                                                                accion86 = ALAINID.Numero(6);
                                                                                                switch (accion86)
                                                                                                {
                                                                                                    case 1:
                                                                                                        pla.playcola();
                                                                                                        ALAINID.GuardarUltimareproduccion(email2, archivo);
                                                                                                        break;
                                                                                                    case 2:
                                                                                                        pla.PauseSong();
                                                                                                        break;
                                                                                                    case 3:
                                                                                                        pla.ResumeSong(archivo);
                                                                                                        break;
                                                                                                    case 4:
                                                                                                        pla.siguiente();
                                                                                                        break;

                                                                                                    case 5:
                                                                                                        pla.previa();
                                                                                                        break;
                                                                                                    case 6:
                                                                                                        break;
                                                                                                    default:
                                                                                                        Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                                        break;

                                                                                                }

                                                                                            }
                                                                                            break;
                                                                                        case 10:
                                                                                            pla.limpiacola();
                                                                                            break;
                                                                                        case 11:// salir
                                                                                            break;
                                                                                        default:
                                                                                            Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                            break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            break;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    accion34 = "0";
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("ESA PLAYLIST ESTA VACIA");
                                                            Thread.Sleep(2000);
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Aun no tienes Playlist");
                                                        Thread.Sleep(2000);
                                                    }
                                                    break;
                                                case 2:
                                                    //METODO VER PLAYLIST VIDEOS
                                                    string accion35;
                                                    accion35 = "2";
                                                    if (ALAINID.Vernombresplaylistvideo(email2) != "No hay Playlist")
                                                    {
                                                        Console.WriteLine("\nINGRESE EL NUMERO DE LA PLAYLIST QUE QUIERE VER");
                                                        Console.WriteLine(ALAINID.Vernombresplaylistvideo(email2));
                                                        int numero = ALAINID.Numero(ALAINID.Cuantasplaylistvideo(email2));

                                                        string nombreply2 = ALAINID.Numeroplaylistvideo(email2, numero);
                                                        ALAINID.Retornaplaylistvideousuario(email2, nombreply2);
                                                        if (ALAINID.cachativa != "")
                                                        {
                                                            while (accion35 != "0")
                                                            {
                                                                Console.WriteLine(ALAINID.VerinformacionPlaylistVideo(email2, nombreply2));
                                                                Thread.Sleep(2000);
                                                                if (ALAINID.VerinformacionPlaylistVideo(email2, nombreply2) != "No hay videos en la playlist")
                                                                {
                                                                    Console.WriteLine("\nINGRESE El NUMERO DE EL VIDEO QUE DESEA REPRODUCIR");
                                                                    Console.WriteLine("\n0 PARA VOLVER ATRÁS");

                                                                    accion35 = Console.ReadLine();
                                                                    switch (accion35)
                                                                    {
                                                                        case "0":
                                                                            break;
                                                                        default:
                                                                            string archivo2 = ALAINID.Archivoreproducirplyvideo(email2, nombreply2, int.Parse(accion35));
                                                                            string nombrevideo = ALAINID.Nombrereproducirplyvideo(email2, nombreply2, int.Parse(accion35));
                                                                            int reproduccion = ALAINID.Reproduccionreproducirply(email2, nombreply2, int.Parse(accion35));
                                                                            //EL QUE HIZO REPROCUCCION, QUE LO HAGA CON VIDEO
                                                                            if (archivo2 != "No hay info")
                                                                            {
                                                                                int opcion10 = '\0';
                                                                                while (opcion10 != 11)
                                                                                {
                                                                                    Console.Clear();
                                                                                    //ALAINID.listafiltrada[numerocancion - 1].nombrearchivo;
                                                                                    Console.WriteLine("1. COMENZAR REPRODUCCION");
                                                                                    Console.WriteLine("2. PAUSAR REPRODUCCION");
                                                                                    Console.WriteLine("3. REANUDAR REPRODUCCIÓN");
                                                                                    Console.WriteLine("4. PARAR REPRODUCCIÓN");
                                                                                    Console.WriteLine("5. VER INFORMACIÓN DEL VIDEO");
                                                                                    Console.WriteLine("6. AGREGAR A PLAYLIST ");
                                                                                    Console.WriteLine("7. AGREGAR A FAVORITOS ");
                                                                                    Console.WriteLine("8. AGREGAR A LA COLA ");
                                                                                    Console.WriteLine("9. REPRODUCIR COLA");
                                                                                    Console.WriteLine("10. ELIMINAR COLA");
                                                                                    Console.WriteLine("11. SALIR");
                                                                                    Console.WriteLine("");
                                                                                    opcion10 = ALAINID.Numero(11);
                                                                                    switch (opcion10)
                                                                                    {

                                                                                        case 1:
                                                                                            //HACER PLAY VIDEO
                                                                                            pla.Playsong(archivo2);
                                                                                            ALAINID.GuardarUltimareproduccion(email2, archivo2);
                                                                                            ALAINID.Aumentarreproduccion(nombrevideo, reproduccion);
                                                                                            //EL QUE HIZO REPROCUCCION, QUE LO HAGA CON VIDEO
                                                                                            break;
                                                                                        case 2:
                                                                                            pla.PauseSong();
                                                                                            break;
                                                                                        case 3:
                                                                                            pla.ResumeSong(archivo2);
                                                                                            break;
                                                                                        case 4:
                                                                                            pla.StopSong();
                                                                                            break;
                                                                                        case 5:
                                                                                            int opcion60 = '\0';
                                                                                            while (opcion60 != 1)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                ALAINID.Verinfodeunvideo(ALAINID.listafiltrada3[int.Parse(accion35) - 1]);
                                                                                                Console.WriteLine("======================================");
                                                                                                Console.WriteLine("1. ATRAS");
                                                                                                opcion60 = ALAINID.Numero(1);
                                                                                                switch (opcion60)
                                                                                                {
                                                                                                    case 1:
                                                                                                        break;
                                                                                                }
                                                                                            }
                                                                                            break;
                                                                                        case 6:
                                                                                            Console.WriteLine("INGRESE EL NUMERO DE LA PLAYLIST QUE A LA QUE DESEA AGREGAR");
                                                                                            Console.WriteLine(ALAINID.Vernombresplaylistvideo(email2));
                                                                                            string nply = Console.ReadLine();
                                                                                            Console.WriteLine(ALAINID.Agregarvideoaply(email2, nply, ALAINID.listafiltrada3[int.Parse(accion35) - 1]));
                                                                                            break;
                                                                                        case 7:
                                                                                            ALAINID.Agregar_video_a_favoritos(email2, ALAINID.listafiltrada3[int.Parse(accion35) - 1]);
                                                                                            //AQUI HAGO EL FAVORITO

                                                                                            break;
                                                                                        case 8:
                                                                                            pla.Agregarcancionacola(archivo2);

                                                                                            //pla.limpiacola();
                                                                                            break;
                                                                                        case 9:
                                                                                            int accion36 = '\0';
                                                                                            while (accion36 != 6)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("1. PLAY COLA");
                                                                                                Console.WriteLine("2. PAUSAR COLA");
                                                                                                Console.WriteLine("3. REANUDAR COLA");
                                                                                                Console.WriteLine("4. SIGUIENTE CANCION");
                                                                                                Console.WriteLine("5. CANCIÓN ANTERIOR");
                                                                                                Console.WriteLine("6. ATRAS");
                                                                                                accion36 = ALAINID.Numero(6);
                                                                                                switch (accion36)
                                                                                                {
                                                                                                    case 1:
                                                                                                        pla.playcola();
                                                                                                        ALAINID.GuardarUltimareproduccion(email2, archivo2);
                                                                                                        break;
                                                                                                    case 2:
                                                                                                        pla.PauseSong();
                                                                                                        break;
                                                                                                    case 3:
                                                                                                        pla.ResumeSong(archivo2);
                                                                                                        break;
                                                                                                    case 4:
                                                                                                        pla.siguiente();
                                                                                                        break;

                                                                                                    case 5:
                                                                                                        pla.previa();
                                                                                                        break;
                                                                                                    case 6:
                                                                                                        break;
                                                                                                    default:
                                                                                                        Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                                        break;

                                                                                                }

                                                                                            }
                                                                                            break;
                                                                                        case 10:
                                                                                            pla.limpiacola();
                                                                                            break;
                                                                                        case 11:// salir
                                                                                            break;
                                                                                        default:
                                                                                            Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                            break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            break;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    accion35 = "0";
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("ESA PLAYLIST ESTA VACIA");
                                                            Thread.Sleep(2000);
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Aun no tienes Playlist");
                                                        Thread.Sleep(2000);
                                                    }
                                                    break;
                                                case 3:
                                                    Console.WriteLine("INGRESE UN NOMBRE PARA SU NUEVA PLAYLIST");
                                                    string nombreply1 = Console.ReadLine();
                                                    if (ALAINID.Hacerplaylistsong(email2, nombreply1) == true)
                                                    {
                                                        Console.WriteLine("PLAYLIST HECHA DE FORMA CORRECTA");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("PLAYLIST NO SE PUDO CREAR");
                                                    }
                                                    Thread.Sleep(2000);

                                                    //METODO CREAR PLAYLIST CANCIONES
                                                    break;
                                                case 4:
                                                    Console.WriteLine("INGRESE UN NOMBRE PARA SU NUEVA PLAYLIST");
                                                    string nombreply4 = Console.ReadLine();
                                                    if (ALAINID.Hacerplaylistvideo(email2, nombreply4) == true)
                                                    {
                                                        Console.WriteLine("PLAYLIST HECHA DE FORMA CORRECTA");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("PLAYLIST NO SE PUDO CREAR");
                                                    }
                                                    Thread.Sleep(2000);
                                                    //METODO CREAR PLAYLIST VIDEO
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
                                        ALAINID.Activarlistacanciones();
                                        ALAINID.Activarlistacantantes();
                                        ALAINID.Partirlistacompositores();
                                        ALAINID.Partirlistaalbumes();
                                        int accion5 = '\0';
                                        while (accion5 != 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("==================================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. VER TUS CANCIONES FAVORITAS");
                                            Console.WriteLine("2. VER TUS VIDEOS FAVORITOS");
                                            Console.WriteLine("3. ATRAS");

                                            accion5 = ALAINID.Numero(3);
                                            switch (accion5)
                                            {
                                                case 1:
                                                    string accion38;
                                                    Console.WriteLine(ALAINID.Verinformacionfavoritoscancion(email2));
                                                    Thread.Sleep(2000);
                                                    
                                                    if(ALAINID.Verinformacionfavoritoscancion(email2)!= "No hay canciones agregadas aún")
                                                    {
                                                        Console.WriteLine("\n0 PARA VOLVER ATRÁS\nCUALQUIER VALOR PARA IR A SELECIONAR UNA CANCION");
                                                        accion38 = Console.ReadLine();
                                                        while (accion38 !="0")
                                                        {
                                                            Console.WriteLine("\nINGRESE El NUMERO DE LA CANCION QUE DESEA SELECCIONAR");
                                                            int numero = ALAINID.Numero(ALAINID.Cuantasfavoritascancion(email2));

                                                            Console.WriteLine("\n0 PARA VOLVER ATRÁS");
                                                            accion38 = Console.ReadLine();
                                                            switch (accion38)
                                                            {
                                                                case "0":
                                                                    break;
                                                                default:
                                                                    string archivo3 = ALAINID.ArchivoreproducirfavoritosCancion(email2,numero);
                                                                    ALAINID.Cancionbuscada(archivo3);
                                                                    if (archivo3 != "No hay info")
                                                                    {
                                                                        int opcion19 = '\0';
                                                                        while (opcion19 != 10)
                                                                        {
                                                                            Console.Clear();
                                                                            //ALAINID.listafiltrada[numerocancion - 1].nombrearchivo;
                                                                            Console.WriteLine("1. COMENZAR REPRODUCCION");
                                                                            Console.WriteLine("2. PAUSAR REPRODUCCION");
                                                                            Console.WriteLine("3. REANUDAR REPRODUCCIÓN");
                                                                            Console.WriteLine("4. PARAR REPRODUCCIÓN");
                                                                            Console.WriteLine("5. VER INFORMACIÓN DE LA CANCIÓN ");
                                                                            Console.WriteLine("6. AGREGAR A PLAYLIST ");
                                                                            Console.WriteLine("7. AGREGAR A LA COLA ");
                                                                            Console.WriteLine("8. REPRODUCIR COLA");
                                                                            Console.WriteLine("9. ELIMINAR COLA");
                                                                            Console.WriteLine("10. SALIR");
                                                                            Console.WriteLine("");
                                                                            opcion19 = ALAINID.Numero(10);
                                                                            switch (opcion19)
                                                                            {

                                                                                case 1:
                                                                                    pla.Playsong(archivo3);
                                                                                    ALAINID.GuardarUltimareproduccion(email2, archivo3);
                                                                                    //CAMBIO
                                                                                    break;
                                                                                case 2:
                                                                                    pla.PauseSong();
                                                                                    break;
                                                                                case 3:
                                                                                    pla.ResumeSong(archivo3);
                                                                                    break;
                                                                                case 4:
                                                                                    pla.StopSong();
                                                                                    break;
                                                                                case 5:
                                                                                    int opcion60 = '\0';
                                                                                    while (opcion60 != 1)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        
                                                                                        ALAINID.Verinfodeunacancion(ALAINID.cancionfavoritabuscada[0]);
                                                                                        Console.WriteLine("======================================");
                                                                                        Console.WriteLine("1. ATRAS");
                                                                                        opcion60 = ALAINID.Numero(1);
                                                                                        switch (opcion60)
                                                                                        {
                                                                                            case 1:
                                                                                                break;
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                                case 6:
                                                                                    Console.WriteLine("INGRESE EL NUMERO DE LA PLAYLIST QUE A LA QUE DESEA AGREGAR");
                                                                                    Console.WriteLine(ALAINID.Vernombresplaylistcancion(email2));
                                                                                    string nply = Console.ReadLine();
                                                                                    Console.WriteLine(ALAINID.Agregarcancionaply(email2, nply, ALAINID.cancionfavoritabuscada[0]));
                                                                                    break;
                                                                                case 7:
                                                                                    pla.Agregarcancionacola(archivo3);

                                                                                    //pla.limpiacola();
                                                                                    break;
                                                                                case 8:
                                                                                    int accion36 = '\0';
                                                                                    while (accion36 != 6)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.WriteLine("1. PLAY COLA");
                                                                                        Console.WriteLine("2. PAUSAR COLA");
                                                                                        Console.WriteLine("3. REANUDAR COLA");
                                                                                        Console.WriteLine("4. SIGUIENTE CANCION");
                                                                                        Console.WriteLine("5. CANCIÓN ANTERIOR");
                                                                                        Console.WriteLine("6. ATRAS");
                                                                                        accion36 = ALAINID.Numero(6);
                                                                                        switch (accion36)
                                                                                        {
                                                                                            case 1:
                                                                                                pla.playcola();
                                                                                                ALAINID.GuardarUltimareproduccion(email2, archivo3);
                                                                                                break;
                                                                                            case 2:
                                                                                                pla.PauseSong();
                                                                                                break;
                                                                                                
                                                                                            case 3:
                                                                                                pla.ResumeSong(archivo3);
                                                                                                break;
                                                                                            case 4:
                                                                                                pla.siguiente();
                                                                                                break;

                                                                                            case 5:
                                                                                                pla.previa();
                                                                                                break;
                                                                                            case 6:
                                                                                                break;
                                                                                            default:
                                                                                                Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                                break;

                                                                                        }

                                                                                    }
                                                                                    break;
                                                                                case 9:
                                                                                    pla.limpiacola();
                                                                                    break;
                                                                                case 10:// salir
                                                                                    break;
                                                                                default:
                                                                                    Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                    break;
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                                
                                                            
                                                    }
                                                    break;
                                                case 2:
                                                    string accion55;
                                                    Console.WriteLine(ALAINID.Verinformacionfavoritosvideo(email2));
                                                    Thread.Sleep(2000);

                                                    if (ALAINID.Verinformacionfavoritosvideo(email2) != "No hay videos agregadas aún")
                                                    {
                                                        Console.WriteLine("\n0 PARA VOLVER ATRÁS\nCUALQUIER VALOR PARA IR A SELECIONAR UNA CANCION");
                                                        accion55 = Console.ReadLine();
                                                        while (accion55 != "0")
                                                        {
                                                            Console.WriteLine("\nINGRESE El NUMERO DEL VIDEO QUE DESEA SELECCIONAR");
                                                            int numero = ALAINID.Numero(ALAINID.Cuantasfavoritasvideo(email2));

                                                            Console.WriteLine("\n0 PARA VOLVER ATRÁS");
                                                            accion55 = Console.ReadLine();
                                                            switch (accion55)
                                                            {
                                                                case "0":
                                                                    break;
                                                                default:
                                                                    string archivo6 = ALAINID.ArchivoreproducirfavoritosVideo(email2, numero);
                                                                    ALAINID.Videobuscado(archivo6);
                                                                    if (archivo6 != "No hay info")
                                                                    {
                                                                        int opcion17 = '\0';
                                                                        while (opcion17 != 10)
                                                                        {
                                                                            Console.Clear();
                                                                            //ALAINID.listafiltrada[numerocancion - 1].nombrearchivo;
                                                                            Console.WriteLine("1. COMENZAR REPRODUCCION");
                                                                            Console.WriteLine("2. PAUSAR REPRODUCCION");
                                                                            Console.WriteLine("3. REANUDAR REPRODUCCIÓN");
                                                                            Console.WriteLine("4. PARAR REPRODUCCIÓN");
                                                                            Console.WriteLine("5. VER INFORMACIÓN DE LA CANCIÓN ");
                                                                            Console.WriteLine("6. AGREGAR A PLAYLIST ");
                                                                            Console.WriteLine("7. AGREGAR A LA COLA ");
                                                                            Console.WriteLine("8. REPRODUCIR COLA");
                                                                            Console.WriteLine("9. ELIMINAR COLA");
                                                                            Console.WriteLine("10. SALIR");
                                                                            Console.WriteLine("");
                                                                            opcion17 = ALAINID.Numero(10);
                                                                            switch (opcion17)
                                                                            {

                                                                                case 1:
                                                                                    pla.Playsong(archivo6);
                                                                                    ALAINID.GuardarUltimareproduccion(email2, archivo6);
                                                                                    //CAMBIO
                                                                                    break;
                                                                                case 2:
                                                                                    pla.PauseSong();
                                                                                    break;
                                                                                case 3:
                                                                                    pla.ResumeSong(archivo6);
                                                                                    break;
                                                                                case 4:
                                                                                    pla.StopSong();
                                                                                    break;
                                                                                case 5:
                                                                                    int opcion60 = '\0';
                                                                                    while (opcion60 != 1)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        ALAINID.Verinfodeunvideo(ALAINID.videofavoritobuscado[0]);
                                                                                        Console.WriteLine("======================================");
                                                                                        Console.WriteLine("1. ATRAS");
                                                                                        opcion60 = ALAINID.Numero(1);
                                                                                        switch (opcion60)
                                                                                        {
                                                                                            case 1:
                                                                                                break;
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                                case 6:
                                                                                    Console.WriteLine("INGRESE EL NUMERO DE LA PLAYLIST QUE A LA QUE DESEA AGREGAR");
                                                                                    Console.WriteLine(ALAINID.Vernombresplaylistvideo(email2));
                                                                                    string nply = Console.ReadLine();
                                                                                    Console.WriteLine(ALAINID.Agregarvideoaply(email2, nply, ALAINID.videofavoritobuscado[0]));
                                                                                    break;
                                                                                case 7:
                                                                                    pla.Agregarcancionacola(archivo6);

                                                                                    //pla.limpiacola();
                                                                                    break;
                                                                                case 8:
                                                                                    int accion43 = '\0';
                                                                                    while (accion43 != 6)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.WriteLine("1. PLAY COLA");
                                                                                        Console.WriteLine("2. PAUSAR COLA");
                                                                                        Console.WriteLine("3. REANUDAR COLA");
                                                                                        Console.WriteLine("4. SIGUIENTE CANCION");
                                                                                        Console.WriteLine("5. CANCIÓN ANTERIOR");
                                                                                        Console.WriteLine("6. ATRAS");
                                                                                        accion43 = ALAINID.Numero(6);
                                                                                        switch (accion43)
                                                                                        {
                                                                                            case 1:
                                                                                                pla.playcola();
                                                                                                ALAINID.GuardarUltimareproduccion(email2, archivo6);
                                                                                                break;
                                                                                            case 2:
                                                                                                pla.PauseSong();
                                                                                                break;
                                                                                            case 3:
                                                                                                pla.ResumeSong(archivo6);
                                                                                                break;
                                                                                            case 4:
                                                                                                pla.siguiente();
                                                                                                break;
                                                                                            case 5:
                                                                                                pla.previa();
                                                                                                break;
                                                                                            case 6:
                                                                                                break;
                                                                                            default:
                                                                                                Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                                break;

                                                                                        }

                                                                                    }
                                                                                    break;
                                                                                case 9:
                                                                                    pla.limpiacola();
                                                                                    break;
                                                                                case 10:// salir
                                                                                    break;
                                                                                default:
                                                                                    Console.WriteLine("SELECCIONA UNA OPCION VALIDA");
                                                                                    break;
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                            }
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
                                    case 8:
                                        ALAINID.Activarlistacantantes();
                                        ALAINID.Partirlistacompositores();
                                        ALAINID.Partirlistaalbumes();
                                        ALAINID.Activarlista();
                                        int accion8 = '\0';
                                        while (accion8 != 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("========================");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("1. VER PERIL ");
                                            Console.WriteLine("2. EDITAR PERFIL");
                                            Console.WriteLine("3. ATRAS");
                                            accion8 = ALAINID.Numero(3);
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
                                                        accion10 = ALAINID.Numero(1);
                                                        switch (accion10)
                                                        {
                                                            case 1:
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    int accion9 = '\0';
                                                    while (accion9 != 7)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("========================");
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine("1. CAMBIAR CONTRASEÑA ");
                                                        Console.WriteLine("2. CAMBIAR NOMBRE DE USUARIO");
                                                        Console.WriteLine("3. CAMBIAR NOMBRE");
                                                        Console.WriteLine("4. VOLVERTE PRIVADO");
                                                        Console.WriteLine("5. VOLVERTE PÚBLICO");
                                                        Console.WriteLine("6. CONVIERTETE EN PREMIUM");
                                                        Console.WriteLine("7. ATRAS");
                                                        accion9 = ALAINID.Numero(7);
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
                                                                Console.Clear();
                                                                Console.WriteLine("Escriba su email: ");
                                                                email = Console.ReadLine();
                                                                Console.WriteLine("Escriba su contrasena actual: ");
                                                                contrasena = Console.ReadLine();
                                                                bool bol3 = ALAINID.Cambiarprivacidadaprivado(email, contrasena);
                                                                if (bol3 == true)
                                                                {
                                                                    Console.WriteLine("Privacidad exitosamente cambiada, ahora eres un perfil privado");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                break;
                                                            case 5:
                                                                Console.Clear();
                                                                Console.WriteLine("Escriba su email: ");
                                                                email = Console.ReadLine();
                                                                Console.WriteLine("Escriba su contrasena actual: ");
                                                                contrasena = Console.ReadLine();
                                                                bool bol4 = ALAINID.Cambiarprivacidapublico(email, contrasena);
                                                                if (bol4 == true)
                                                                {
                                                                    Console.WriteLine("Privacidad exitosamente cambiada, ahora eres un perfil publico");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                break;
                                                            case 6:
                                                                Console.Clear();
                                                                Console.WriteLine("Escriba su email: ");
                                                                email = Console.ReadLine();
                                                                Console.WriteLine("Escriba su contrasena actual: ");
                                                                contrasena = Console.ReadLine();
                                                                bool bol5 = ALAINID.VolversePremium(email, contrasena);
                                                                if (bol5 == true)
                                                                {
                                                                    Console.WriteLine("Proceso exitoso hora eres un perfil PREMIUM!!!");
                                                                    Thread.Sleep(2000);
                                                                }
                                                                break;
                                                            case 7:
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
                                    case 9:
                                        ALAINID.Verinformaciondescargas(email2);
                                        break;


                                       
                                    case 10:
                                        Console.WriteLine("=================================");
                                        Console.WriteLine("CERRANDO SESION....");
                                        pla.PauseSong();
                                        Console.WriteLine("=================================");
                                        break;
                                    case 11:
                                        pla.Playsong(ALAINID.UltimaReproduccion(email2));

                                        break;
                                    case 12:
                                        pla.PauseSong();
                                        break;
                                    case 13:
                                        pla.ResumeSong(ALAINID.UltimaReproduccion(email2));
                                        break;
                                    case 14:
                                        pla.StopSong();
                                        break;
                                }
                            }
                        } 
                        break;
                    case 202023:
                        Console.Clear();
                        Console.WriteLine("Ingresando como admin....");
                        Thread.Sleep(2000);
                        int accion20 = '\0';
                        while (accion20 != 14)
                        {
                            Console.Clear();
                            Console.WriteLine("SELECCIONE UNA OPCION:");
                            Console.WriteLine("======================");
                            Console.WriteLine("1. AGREGAR CANCION");
                            Console.WriteLine("2. VER CANCIONES DE LA APP");
                            Console.WriteLine("3. VER LISTA DE USUARIOS DE LA APP");
                            Console.WriteLine("4. AGREGAR VIDEO/PELICULA");
                            Console.WriteLine("5. VER LISTA VIDEOS/PELICULAS DE LA APP");
                            Console.WriteLine("6. CREAR PERFIL DE CANTANTE");
                            Console.WriteLine("7. CREAR PERFIL DE COMPOSITOR");
                            Console.WriteLine("8. CREAR PERFIL DE DIRECTOR");
                            Console.WriteLine("9. CREAR PERFIL DE ACTOR");
                            Console.WriteLine("10. VER LISTA DE ACTORES");
                            Console.WriteLine("11. VER LISTA DE COMPOSITORES");
                            Console.WriteLine("12. VER LISTA DE DIRECTORES");
                            Console.WriteLine("13. VER LISTA DE ACTORES");

                            Console.WriteLine("14. CERRAR SESION");
                            accion20 = ALAINID.Numero(14);
                            switch (accion20)
                            {
                                case 1:
                                    bool ver1 = false, ver2 = false, ver3 = false;
                                    Console.Clear();
                                    string nombrecan = "";
                                    string cantante = "";
                                    string genero = "";
                                    string compositor = "";
                                    string anopublicacion = "";
                                    string disquera = "";
                                    string album = "";
                                    float duracion = 0;
                                    string tipoarchivo = "";
                                    float tamano = 0;
                                    string calidad = "";
                                    string nombrearchivo = "";
                                    string letra =  "";
                                    int reproducciones = 0;
                                    Console.WriteLine("Ingrese nombre de la cancion:");
                                    nombrecan = Console.ReadLine();
                                    Console.WriteLine("Ingrese cantante o grupo de la canción:");
                                    cantante = Console.ReadLine();
                                    Console.WriteLine("Ingrese genero de la canción:");
                                    genero = ALAINID.ShowOptions(ALAINID.lista_generos_canciones);  // -------------------37
                                    Console.WriteLine("Ingrese el compositor de la cancion:");
                                    compositor = Console.ReadLine();
                                    Console.WriteLine("Ingrese letra de la cancion");
                                    letra = Console.ReadLine();
                                    Console.WriteLine("Ingrese año de la publicación de la canción");
                                    anopublicacion = Console.ReadLine();
                                    Console.WriteLine("Ingrese disquera de la canción");
                                    disquera = ALAINID.ShowOptions(ALAINID.lista_disquera);
                                    Console.WriteLine("Ingrese album al que pertenece la cancion");
                                    album = Console.ReadLine();
                                    Console.WriteLine("Ingrese duracion de la canción");
                                    duracion = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese tipo archivo de la canción");
                                    tipoarchivo = ALAINID.ShowOptions(ALAINID.lista_tipoarchivo_cancion);       // -------------------37
                                    Console.WriteLine("Ingrese tamaño del archivo de la canción");
                                    tamano = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la calidad del archivo de la canción");
                                    calidad = ALAINID.ShowOptions(ALAINID.lista_calidad_cancion);       // -------------------37
                                    Console.WriteLine("Igrese el nombre exacto como esta guardao (El archivo debera estar guardado en la carpeta CANCIONES)");
                                    string nom = Console.ReadLine();
                                    nombrearchivo = "Canciones/"  +  nom  +  "."  +  ALAINID.Todo_a_minuscula(tipoarchivo);
                                    Console.Clear();
                                    ver1 = ALAINID.Verificar_existencia_cantante(cantante);
                                    ver2 = ALAINID.Verificar_existencia_compositor(compositor);
                                    ver3 = ALAINID.Verificar_exisitencia_Album(album, cantante);
                                    if (ver1 && ver2 && ver3){

                                        a.AgregarSong(nombrecan, cantante, genero, compositor, anopublicacion, disquera, album, duracion, tipoarchivo, tamano, calidad, nombrearchivo,reproducciones, letra);
                                        ALAINID.Activarlistacanciones();
                                        ALAINID.Activarlistacantantes();
                                        ALAINID.Partirlistacompositores();
                                        ALAINID.Partirlistaalbumes();

                                    } else{
                                        Console.WriteLine("No fue Posible agregar la cancion, verifique los datos y el archivo ingresado e intente nuevamente");
                                    }
                                    break;
                                case 2:
                                    int accion21 = '\0';
                                    while (accion21 != 1)
                                    {
                                        Console.Clear();
                                        ALAINID.Activarlistacanciones();
                                        ALAINID.Activarlistacantantes();
                                        ALAINID.Partirlistacompositores();
                                        ALAINID.Partirlistaalbumes();
                                        a.VerCanciones(ALAINID.todas_las_canciones);
                                        Console.WriteLine("=================================");
                                        Console.WriteLine("1. ATRAS");
                                        Console.WriteLine("=================================");
                                        accion21 = ALAINID.Numero(1);
                                        switch (accion21)
                                        {
                                            case 1:
                                                break;
                                        }
                                    }
                                    break;
                                case 3:
                                    int accion22 = '\0';
                                    while (accion22 != 1)
                                    {
                                        Console.Clear();
                                        ALAINID.Activarlista();
                                        ALAINID.VerPersonas(ALAINID.listausuarios);
                                        Console.WriteLine("=================================");
                                        Console.WriteLine("1. ATRAS");
                                        Console.WriteLine("=================================");
                                        accion22 = ALAINID.Numero(1);
                                        switch (accion22)
                                        {
                                            case 1:
                                                break;
                                        }
                                    }
                                    break;
                                case 4:
                                    bool ver4 = false;
                                    string nombre_video = "";
                                    float duracion2 = 0;
                                    string categoria = "";
                                    string director = "";
                                    string genero2 = "";
                                    string anio_publicacion = "";
                                    string tipo_archivo = "";
                                    string calidad2 = "";
                                    string film_studio = "";
                                    float tamanio = 0;
                                    string nombrearchivovideo = "";
                                    
                                    Console.WriteLine("Ingrese nombre del video:");
                                    nombre_video = Console.ReadLine();
                                    Console.WriteLine("Ingrese duracion del video:");
                                    duracion2 = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese genero del video:");
                                    genero2 = ALAINID.ShowOptions(ALAINID.lista_calidad_pelicula);      // -------------------37
                                    Console.WriteLine("Ingrese la categoria del video");
                                    categoria = ALAINID.ShowOptions(ALAINID.lista_categoria);      // -------------------37
                                    Console.WriteLine("Ingrese el director del video:");
                                    director = Console.ReadLine();
                                    Console.WriteLine("Ingrese el Film Studio del video:");
                                    film_studio = Console.ReadLine();
                                    Console.WriteLine("Ingrese año de la publicación del video");
                                    anio_publicacion = Console.ReadLine();
                                    Console.WriteLine("Ingrese la ubicacion exacta del archivo  (Videos/nombrearchivo.mp4");
                                    nombrearchivovideo = Console.ReadLine();
                                    Console.WriteLine("Ingrese el tipo de archivo del video");
                                    tipo_archivo = Console.ReadLine();
                                    Console.WriteLine("Ingrese el tamaño de archivo del video");
                                    tamanio = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la calidad del archivo de video");
                                    calidad2 = ALAINID.ShowOptions(ALAINID.lista_tipoarchivo_pelicula);      // -------------------37
                                    Console.Clear();
                                    ver4 = ALAINID.Verificar_existencia_director(director);
                                    if (ver4){
                                        a.Subir_video(nombre_video, duracion2, categoria, director, genero2, anio_publicacion, tipo_archivo, calidad2, film_studio, tamanio, nombrearchivovideo);
                                    }else{
                                        Console.WriteLine("No fue Posible agregar la cancion, verifique los datos y el archivo ingresado e intente nuevamente");
                                    }
                                    ALAINID.Activarlistavideos();
                                    ALAINID.Partirlistadirectores();
                                    ALAINID.Partirlistaactores();
                                    break;
                                case 5:
                                    ALAINID.Activarlistavideos();
                                    ALAINID.Partirlistadirectores();
                                    ALAINID.Partirlistaactores();
                                    int accion25 = '\0';
                                    while (accion25 != 1)
                                    {
                                        Console.Clear();
                                        ALAINID.Activarlistavideos();
                                        a.VerVideos(ALAINID.todos_los_videos);
                                        Console.WriteLine("=================================");
                                        Console.WriteLine("1. ATRAS");
                                        Console.WriteLine("=================================");
                                        accion25 = ALAINID.Numero(1);
                                        switch (accion25)
                                        {
                                            case 1:
                                                break;
                                        }
                                    }
                                    break;
                                case 6:
                                    ALAINID.Crear_cantante();
                                    break;
                                case 7:
                                    ALAINID.Crear_compositor();
                                    break;
                                case 8:
                                    ALAINID.Crear_director();
                                    break;
                                case 9:
                                    ALAINID.Crear_actor();
                                    break;
                                case 10:
                                    //VER CANTANTES
                                    break;
                                case 11:
                                    //VER COMPOSITORES
                                    break;
                                case 12:
                                    //VER DIRECTORES
                                    break;
                                case 13:
                                    //VER ACTORES
                                    break;
                                case 14:
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("CERRANDO SESION....");
                                    Console.WriteLine("=================================");
                                    Thread.Sleep(2000);
                                    break;
                                default:
                                    Console.WriteLine("No se ha seleccionado ninguna opción válida");
                                    break;
                            }
                        }
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