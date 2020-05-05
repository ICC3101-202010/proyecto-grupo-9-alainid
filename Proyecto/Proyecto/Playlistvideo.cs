using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    class PlaylistVideo
    {
          
        public string NombrePlaylist;
        public List<Video> listplayvideo = new List<Video>();

        public PlaylistVideo(string _nombreplv, List<Video> listavideo)
        {

            this.NombrePlaylist = _nombreplv;
            this.listplayvideo = listavideo;

        }
        public string InformationPLL()
        {
            string stringaux1 = " ";
            if (listplayvideo.Count == 0)
            {
                return "No hay videos en la playlist";

            }

            else
            {
                for (int i = 0; i < listplayvideo.Count; i++)
                {
                    stringaux1 += "Video" + " " + (i + 1) + "\n";
                    stringaux1 += "============ \n";
                    stringaux1 += listplayvideo[i].Ver_informacion() + "\n";

                    stringaux1 += " ";


                }
                return stringaux1;
            }
        }
    }
}
