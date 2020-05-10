using System;
using System.Threading;

namespace Proyecto
{
    class Program
    {

        static void Main()
        {
            ALAINID.lista_generos_canciones.Add("Electronica");ALAINID.lista_generos_canciones.Add("Rock");ALAINID.lista_generos_canciones.Add("Jazz");
            ALAINID.lista_generos_canciones.Add("Heavy Metal"); ALAINID.lista_generos_canciones.Add("Indie Rock");
            ALAINID.lista_generos_canciones.Add("House");ALAINID.lista_generos_canciones.Add("Hip-Hop");ALAINID.lista_generos_canciones.Add("R&B");
            ALAINID.lista_generos_canciones.Add("Techno"); ALAINID.lista_generos_canciones.Add("Country"); ALAINID.lista_generos_canciones.Add("Pop");
            ALAINID.lista_generos_canciones.Add("Disco"); ALAINID.lista_generos_canciones.Add("Blues"); ALAINID.lista_generos_canciones.Add("K-Pop");
            ALAINID.lista_generos_canciones.Add("Folklorica"); ALAINID.lista_generos_canciones.Add("Urban"); ALAINID.lista_generos_canciones.Add("Punk");

            ALAINID.lista_generos_peliculas.Add("Accion"); ALAINID.lista_generos_peliculas.Add("Comedia"); ALAINID.lista_generos_peliculas.Add("Drama");
            ALAINID.lista_generos_peliculas.Add("Terror"); ALAINID.lista_generos_peliculas.Add("Musical"); ALAINID.lista_generos_peliculas.Add("Ciencia Ficcion");
            ALAINID.lista_generos_peliculas.Add("Crimen");

            ALAINID.lista_categoria.Add("Infantil (0 - 7 anios)");
            ALAINID.lista_categoria.Add("Infanto-Juvenil (7 - 16 anios)");
            ALAINID.lista_categoria.Add("Adolecente (16 - 18 anios)");
            ALAINID.lista_categoria.Add("Adulto (18+ anios)");
            ALAINID.lista_categoria.Add("XXX (18+ anios)");



            Input_Output.Comenzar_app();
            Thread.Sleep(1000);
        }
    }
}
