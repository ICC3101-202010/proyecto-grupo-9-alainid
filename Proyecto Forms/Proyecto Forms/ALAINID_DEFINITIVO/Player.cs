/*using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;
using System.Threading;



namespace Proyecto_Forms
{
    public class Player
    {
        
        WindowsMediaPlayer wmp;
        double currpos;
        WMPLib.IWMPPlaylist playlistcola;
        public Player()
        {
            wmp = new WindowsMediaPlayer();
            playlistcola = wmp.playlistCollection.newPlaylist("playliscola");
        }
        public void Playsong(string archivocancion)
        {
            wmp.URL = archivocancion;
            wmp.controls.play();
            currpos = 0;
            foreach (Song so in ALAINID.todas_las_canciones)
            {
                if (so.Nombrearchivo == archivocancion)
                {
                    so.Reproducciones++;
                }
            }
        }
        public void StopSong()
        {
            wmp.controls.stop();
        }
        public void PauseSong()
        {
            currpos = wmp.controls.currentPosition;
            wmp.controls.pause();
        }
        public void ResumeSong(string archivocancion)
        {
            wmp.URL = archivocancion;
            wmp.controls.currentPosition = currpos;
            wmp.controls.play();
        }
        public void Agregarcancionacola(string nombrearchivo)
        {
            WMPLib.IWMPMedia media;
            media = wmp.newMedia(nombrearchivo);
            playlistcola.appendItem(media);
            Console.WriteLine("Agregada a la cola");
            Thread.Sleep(2000);

        }
        public void playcola()
        {
            wmp.currentPlaylist = playlistcola;
            wmp.controls.play();
        }
        public void limpiacola()
        {
            playlistcola.clear();
            wmp.controls.play();
        }
        public void siguiente()
        {
            wmp.controls.next();
        }

        public void previa()
        {
            wmp.controls.previous();
        }
        
    }
}*/
