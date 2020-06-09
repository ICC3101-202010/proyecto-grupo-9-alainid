using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto_Forms
{
    class Admin
    {
        public bool AgregarSong(string nombrecan, Artista cantante, string genero, Artista compositor, string anopublicacion, string disquera, string album,string nombrearchivo)
        {
            bool ver1, ver2, ver3;
            FileInfo fileInfo = new FileInfo(nombrearchivo);
            float tamano = fileInfo.Length / 1000000;
            Song s = new Song(tamano, nombrecan, cantante, genero, compositor, anopublicacion, disquera, album,nombrearchivo);
            ver1 = ALAINID.Verificar_existencia_cantante(ref cantante);
            ver2 = ALAINID.Verificar_existencia_compositor(ref compositor);
            ver3 = ALAINID.Verificar_exisitencia_Album(album, ref cantante);
            foreach (Song si in ALAINID.todas_las_canciones)
            {
                if (si == s)
                {
                    MessageBox.Show("La cancion ya existe en ALAINID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (ver1 == true)
            {
                cantante.Lista_canciones.Add(s);
                ALAINID.AlmacenarCantante(ALAINID.lista_cantantes);
            }
            if (ver3 == true)
            {
                foreach (PlaylistSong alb in cantante.Lista_album)
                {
                    if (alb.NombrePlaylist == album)
                    {
                        alb.Listplay.Add(s);
                        cantante.Lista_album.Add(alb);
                        ALAINID.AlmacenarAlbum(ALAINID.todos_los_albumes);
                    }
                }
            }
            if (ver2 == true)
            {
                compositor.Lista_canciones.Add(s);
                ALAINID.AlmacenarCompositores(ALAINID.lista_compositores);
            }
            ALAINID.todas_las_canciones.Add(s);
            ALAINID.Agregarcancioneslistainteligente(s);
            ALAINID.Partir();
            MessageBox.Show("CANCION AGREGADA EXITOSAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public void Subir_video(List<Artista> actores, string nombre_video, string categoria,Artista director, string genero, string anio_publicacion, string film_studio, string nombrearchivovideo)
        {

            FileInfo fileInfo = new FileInfo(nombrearchivovideo);
            float tamanio = (fileInfo.Length) / 1000000;
            Video video1 = new Video(nombre_video, categoria, director, genero, anio_publicacion, film_studio, tamanio, nombrearchivovideo);
            foreach (Video video in ALAINID.todos_los_videos)
            {
                if (video == video1)
                {
                    MessageBox.Show("El Video ya existe en ALAINID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            int existe = 0;
            foreach (Artista dir in ALAINID.lista_directores)
            {
                if (dir.Name.ToLower()==director.Name.ToLower() && dir.Nacionality.ToLower() == director.Nacionality.ToLower())
                {
                    existe = 1;
                    director.Lista_peliculas.Add(video1);
                    ALAINID.AlmacenarDirectores(ALAINID.lista_directores);
                }
            }
            if (existe != 1)
            {
                ALAINID.lista_directores.Add(director);
                director.Lista_peliculas.Add(video1);
                ALAINID.AlmacenarDirectores(ALAINID.lista_directores);
            }
        
            foreach (Artista act in actores)
            {
                video1.Agregar_actores(act);
                act.Lista_peliculas.Add(video1);
            }
            ALAINID.todos_los_videos.Add(video1);
            ALAINID.AlmacenarVideos(ALAINID.todos_los_videos);
        }


        public bool AgregarSongKaraoke(string nombrecan2, Artista cantante2, string genero2, Artista compositor2, string anopublicacion2, string disquera2, string album2,string nombrearchivo2)
        {
            FileInfo fileInfo = new FileInfo(nombrearchivo2);
            float tamano = fileInfo.Length / 1000000;
            Song s = new Song(tamano, nombrecan2, cantante2, genero2, compositor2, anopublicacion2, disquera2, album2,nombrearchivo2);
            foreach (Song si in ALAINID.todas_las_cancioneskaraoke)
            {
                if (si == s)
                {
                    MessageBox.Show("Esta cancion ya existe en ALAINID", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                    
                    return false;
                }
            }
            ALAINID.todas_las_cancioneskaraoke.Add(s);
            ALAINID.Partirkaraoke();
            MessageBox.Show("Canción agregada exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.None);

            
            return true;
        }
    }
}