using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace Proyecto
{
    class Player
    {
        WindowsMediaPlayer wmp;
        double currpos;
        public Player()
        {
            wmp = new WindowsMediaPlayer();

        }
        public void Playsong(string archivocancion)
        {

            wmp.URL = archivocancion;
            wmp.controls.play();
            currpos = 0;
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

        public void ResumeSong()
        {
            wmp.controls.currentPosition = currpos;
            wmp.controls.play();
        }
    }
}
