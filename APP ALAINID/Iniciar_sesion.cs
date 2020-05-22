using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_ALAINID
{
    public partial class Iniciar_sesion : Form
    {
        public Iniciar_sesion()
        {
            InitializeComponent();
        }

        private void boton_iniciosesion_Click(object sender, EventArgs e)
        {
            bool bol = false;
            ALAINID.Activarlista();
            bol = ALAINID.Ingresaralaapp(iniciosesion_correo.Text, iniciosesion_pass.Text);
            ALAINID.UltimaReproduccion(iniciosesion_correo.Text);
            if (bol == true)
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
