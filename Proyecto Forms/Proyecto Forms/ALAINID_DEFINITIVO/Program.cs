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
        public static FORMS_INICIO forms_inicio;
        public static User usuario_activo;
        [STAThread]
        static void Main()
        {

            Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Electronica"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Rock"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Jazz");
            Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Heavy Metal"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Indie Rock");
            Proyecto_Forms.ALAINID.lista_generos_canciones.Add("House"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Hip-Hop"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("R&B");
            Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Techno"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Country"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Pop");
            Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Disco"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Blues"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("K-Pop");
            Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Folklorica"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Urban"); Proyecto_Forms.ALAINID.lista_generos_canciones.Add("Punk");

            Proyecto_Forms.ALAINID.lista_generos_peliculas.Add("Accion"); Proyecto_Forms.ALAINID.lista_generos_peliculas.Add("Comedia"); Proyecto_Forms.ALAINID.lista_generos_peliculas.Add("Drama");
            Proyecto_Forms.ALAINID.lista_generos_peliculas.Add("Terror"); Proyecto_Forms.ALAINID.lista_generos_peliculas.Add("Musical"); Proyecto_Forms.ALAINID.lista_generos_peliculas.Add("Ciencia Ficcion");
            Proyecto_Forms.ALAINID.lista_generos_peliculas.Add("Crimen");

            Proyecto_Forms.ALAINID.lista_categoria.Add("Infantil (0 - 7 años)");
            Proyecto_Forms.ALAINID.lista_categoria.Add("Infantil-Juvenil (7 - 16 años)");
            Proyecto_Forms.ALAINID.lista_categoria.Add("Adolecente (16 - 18 años)");
            Proyecto_Forms.ALAINID.lista_categoria.Add("Adulto (18+ años)");
            Proyecto_Forms.ALAINID.lista_categoria.Add("XXX (18+ años)");

            Proyecto_Forms.ALAINID.lista_calidad_cancion.Add("96 kbps"); Proyecto_Forms.ALAINID.lista_calidad_cancion.Add("128 kbps"); Proyecto_Forms.ALAINID.lista_calidad_cancion.Add("160 kbps");
            Proyecto_Forms.ALAINID.lista_calidad_cancion.Add("256 kbps"); Proyecto_Forms.ALAINID.lista_calidad_cancion.Add("320 kbps");

            Proyecto_Forms.ALAINID.lista_calidad_pelicula.Add("144p"); Proyecto_Forms.ALAINID.lista_calidad_pelicula.Add("240p"); Proyecto_Forms.ALAINID.lista_calidad_pelicula.Add("360p");
            Proyecto_Forms.ALAINID.lista_calidad_pelicula.Add("480p"); Proyecto_Forms.ALAINID.lista_calidad_pelicula.Add("720p");

            Proyecto_Forms.ALAINID.lista_tipoarchivo_cancion.Add("WAV"); Proyecto_Forms.ALAINID.lista_tipoarchivo_cancion.Add("AIFF"); Proyecto_Forms.ALAINID.lista_tipoarchivo_cancion.Add("FLAC");
            Proyecto_Forms.ALAINID.lista_tipoarchivo_cancion.Add("MP3"); Proyecto_Forms.ALAINID.lista_tipoarchivo_cancion.Add("WavPack");

            Proyecto_Forms.ALAINID.lista_tipoarchivo_pelicula.Add("AVI"); Proyecto_Forms.ALAINID.lista_tipoarchivo_pelicula.Add("MP4"); Proyecto_Forms.ALAINID.lista_tipoarchivo_pelicula.Add("MKV");
            Proyecto_Forms.ALAINID.lista_tipoarchivo_pelicula.Add("FLV"); Proyecto_Forms.ALAINID.lista_tipoarchivo_pelicula.Add("MOV"); Proyecto_Forms.ALAINID.lista_tipoarchivo_pelicula.Add("WMV");


            //---------37 PA ABAJO
            
            Proyecto_Forms.ALAINID.lista_criterios_usuarios.Add("Nombre"); Proyecto_Forms.ALAINID.lista_criterios_usuarios.Add("Email"); Proyecto_Forms.ALAINID.lista_criterios_usuarios.Add("Id");
            
            Proyecto_Forms.ALAINID.lista_disquera.Add("Sony Music"); Proyecto_Forms.ALAINID.lista_disquera.Add(" Universal Music"); Proyecto_Forms.ALAINID.lista_disquera.Add(" Warner Music ");
            Proyecto_Forms.ALAINID.lista_disquera.Add("YG Entertainment"); Proyecto_Forms.ALAINID.lista_disquera.Add("SM Entretainment");

            Proyecto_Forms.ALAINID.lista_disqueravideo.Add("Sony Pictures"); Proyecto_Forms.ALAINID.lista_disqueravideo.Add(" Universal Studio Pictures"); Proyecto_Forms.ALAINID.lista_disqueravideo.Add(" Warner Bos Pictures ");
            Proyecto_Forms.ALAINID.lista_disqueravideo.Add("YG Entertainment Pictures"); Proyecto_Forms.ALAINID.lista_disqueravideo.Add("SM Entretainment Pictures");

            Proyecto_Forms.ALAINID.sexo.Add("Masculino"); Proyecto_Forms.ALAINID.sexo.Add("Femenino");

            Proyecto_Forms.ALAINID.edades.Add("Menores de 25 años"); Proyecto_Forms.ALAINID.edades.Add("De 25 a 40 años"); Proyecto_Forms.ALAINID.edades.Add("De 40 a 60 años");
            Proyecto_Forms.ALAINID.edades.Add("Mayores de 60");

            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Categoria Pelicula");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Film Studio");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Disquera");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Album");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Actor");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Director");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Compositor");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Cantante");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Genero Video");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Genero Cancion");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Nombre Cancion");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Nombre Pelicula");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Año de Publicacion"); Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Sexo del Artista"); Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Edad del Artista");
            Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Calidad/Resolucion"); Proyecto_Forms.ALAINID.lista_criterios_filtro2.Add("Evaluacion");

            

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(forms_inicio=new FORMS_INICIO());


        }


    }
}
