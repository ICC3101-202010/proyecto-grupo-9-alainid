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
    public partial class Bienvenido_alainid : Form
    {
        public Bienvenido_alainid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Iniciar_sesion iniciar_Sesion = new Iniciar_sesion();
            iniciar_Sesion.ShowDialog();
        }

        private void boton_registrarse_Click(object sender, EventArgs e)
        {
            Registrarme registrarme = new Registrarme();
            registrarme.ShowDialog();
        }
    }
}
