using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    [Serializable]
    public class PlaylistVideo
    {

        private string nombrePlaylist;
        private List<Video> listplayvideo = new List<Video>();

        public string NombrePlaylist { get => nombrePlaylist; set => nombrePlaylist = value; }
        public List<Video> Listplayvideo { get => listplayvideo; set => listplayvideo = value; }

        public PlaylistVideo(string _nombreplv)
        {
            this.NombrePlaylist = _nombreplv;
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
                    stringaux1 += Listplayvideo[i].Ver_informacion() + "\n";

                    stringaux1 += " ";


                }
                return stringaux1;
            }
        }
    }
}
