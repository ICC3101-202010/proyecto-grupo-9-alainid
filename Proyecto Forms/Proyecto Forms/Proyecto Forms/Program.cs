using Proyecto_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALAINID_DEFINITIVO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ALAINID.lista_generos_canciones.Add("Electronica"); ALAINID.lista_generos_canciones.Add("Rock"); ALAINID.lista_generos_canciones.Add("Jazz");
            ALAINID.lista_generos_canciones.Add("Heavy Metal"); ALAINID.lista_generos_canciones.Add("Indie Rock");
            ALAINID.lista_generos_canciones.Add("House"); ALAINID.lista_generos_canciones.Add("Hip-Hop"); ALAINID.lista_generos_canciones.Add("R&B");
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

            ALAINID.lista_calidad_cancion.Add("96 kbps"); ALAINID.lista_calidad_cancion.Add("128 kbps"); ALAINID.lista_calidad_cancion.Add("160 kbps");
            ALAINID.lista_calidad_cancion.Add("256 kbps"); ALAINID.lista_calidad_cancion.Add("320 kbps");

            ALAINID.lista_calidad_pelicula.Add("144p"); ALAINID.lista_calidad_pelicula.Add("240p"); ALAINID.lista_calidad_pelicula.Add("360p");
            ALAINID.lista_calidad_pelicula.Add("480p"); ALAINID.lista_calidad_pelicula.Add("720p");

            ALAINID.lista_tipoarchivo_cancion.Add("WAV"); ALAINID.lista_tipoarchivo_cancion.Add("AIFF"); ALAINID.lista_tipoarchivo_cancion.Add("FLAC");
            ALAINID.lista_tipoarchivo_cancion.Add("MP3"); ALAINID.lista_tipoarchivo_cancion.Add("WavPack");

            ALAINID.lista_tipoarchivo_pelicula.Add("AVI"); ALAINID.lista_tipoarchivo_pelicula.Add("MP4"); ALAINID.lista_tipoarchivo_pelicula.Add("MKV");
            ALAINID.lista_tipoarchivo_pelicula.Add("FLV"); ALAINID.lista_tipoarchivo_pelicula.Add("MOV"); ALAINID.lista_tipoarchivo_pelicula.Add("WMV");


            //---------37 PA ABAJO
            ALAINID.lista_criterios_filtro.Add("Genero"); ALAINID.lista_criterios_filtro.Add("Cantante"); ALAINID.lista_criterios_filtro.Add("Album");
            ALAINID.lista_criterios_filtro.Add("Nombre"); ALAINID.lista_criterios_filtro.Add("Disquera"); ALAINID.lista_criterios_filtro.Add("Compositor");
            ALAINID.lista_criterios_filtro.Add("Año Publicacion"); ALAINID.lista_criterios_filtro.Add("Sexo del Artista"); ALAINID.lista_criterios_filtro.Add("Edad del Artista");
            ALAINID.lista_criterios_filtro.Add("Calidad/Resolucion"); ALAINID.lista_criterios_filtro.Add("Evaluacion");

            ALAINID.lista_criterios_usuarios.Add("Nombre"); ALAINID.lista_criterios_usuarios.Add("Email"); ALAINID.lista_criterios_usuarios.Add("Id");
            ALAINID.lista_disquera.Add("Sony Music"); ALAINID.lista_disquera.Add(" Universal Music"); ALAINID.lista_disquera.Add(" Warner Music ");
            ALAINID.lista_disquera.Add("YG Entertainment"); ALAINID.lista_disquera.Add("SM Entretainment");

            ALAINID.lista_disqueravideo.Add("Sony Pictures"); ALAINID.lista_disqueravideo.Add(" Universal Studio Pictures"); ALAINID.lista_disqueravideo.Add(" Warner Bos Pictures ");
            ALAINID.lista_disqueravideo.Add("YG Entertainment Pictures"); ALAINID.lista_disqueravideo.Add("SM Entretainment Pictures");

            ALAINID.sexo.Add("Masculino"); ALAINID.sexo.Add("Femenino");

            ALAINID.edades.Add("Menores de 25 años"); ALAINID.edades.Add("De 25 a 40 años"); ALAINID.edades.Add("De 40 a 60 años");
            ALAINID.edades.Add("Mayores de 60");

            ALAINID.lista_criterios_filtro2.Add("Genero");
            ALAINID.lista_criterios_filtro2.Add("Disquera");
            ALAINID.lista_criterios_filtro2.Add("Año Publicacion"); ALAINID.lista_criterios_filtro2.Add("Sexo del Artista"); ALAINID.lista_criterios_filtro2.Add("Edad del Artista");
            ALAINID.lista_criterios_filtro2.Add("Calidad/Resolucion"); ALAINID.lista_criterios_filtro2.Add("Evaluacion");

            ALAINID.lista_criterios_filtro2v.Add("Genero"); ALAINID.lista_criterios_filtro2v.Add("Film Studio"); ALAINID.lista_criterios_filtro2v.Add("Categoria"); ALAINID.lista_criterios_filtro2v.Add("Nombre");
            ALAINID.lista_criterios_filtro2v.Add("Año Publicacion"); ALAINID.lista_criterios_filtro2v.Add("Calidad/Resolucion"); ALAINID.lista_criterios_filtro2v.Add("Actores"); ALAINID.lista_criterios_filtro2v.Add("Director");
            ALAINID.lista_criterios_filtro2v.Add("Evaluacion");

            for (int i = 1900; i <= 2020; i++)
            {
                ALAINID.anios.Add(i.ToString());
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FORMS_INICIO());
        }
    }
}
