using ALAINID_DEFINITIVO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Forms
{
    [Serializable]
    public class PlaylistVideo
    {

        private string nombrePlaylist;
        private List<Video> listplayvideo = new List<Video>();
        private string creador;

        public string NombrePlaylist { get => nombrePlaylist; set => nombrePlaylist = value; }
        public List<Video> Listplayvideo { get => listplayvideo; set => listplayvideo = value; }
        public string Creador { get => creador; set => creador = value; }

        public PlaylistVideo(string _nombreplv, string nombre)
        {
            this.NombrePlaylist = _nombreplv;
            this.creador = nombre;
        }
        public void Agregar_video(Video video)
        {
            Listplayvideo.Add(video);
        }
        public string InformationPLL()
        {
            string stringaux1 = " ";
            if (Listplayvideo.Count == 0)
            {
                return "No hay videos en la playlist";

            }

            else
            {
                for (int i = 0; i < Listplayvideo.Count; i++)
                {
                    stringaux1 += "Video" + " " + (i + 1) + "\n";
                    stringaux1 += "============ \n";
                    //stringaux1 += Listplayvideo[i].Ver_informacion() + "\n";

                    stringaux1 += " ";


                }
                return stringaux1;
            }
        }
    }
}
