using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Forms
{
    public partial class APP : Form
    {
        public APP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NO BORRAR
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            panel_Registrarse.Visible = true;
          

        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {

            panel_Iniciar_Sesion.Visible = true;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Registro
        private void panel_Registrarse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_completo_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crear_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                User u1 = new User(nombre_completo.Text, nombre_usuario.Text, mail.Text, password.Text);
                ALAINID.Activarlista();
                ALAINID.Agregarusuarioalalista(u1);
            }
            catch
            {
                User u1 = new User(nombre_completo.Text, nombre_usuario.Text, mail.Text, password.Text);
                ALAINID.Agregarusuarioalalista(u1);
            } 
        }

        private void Atras_registro_Click(object sender, EventArgs e)
        {
            panel_Registrarse.Visible = false;
        }


        //Inico de sesion


        private void panel_Iniciar_Sesion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mail_inicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_inicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_de_Sesion_Click(object sender, EventArgs e)
        {

            bool bol = ALAINID.Ingresaralaapp(mail_inicio.Text, password_inicio.Text);
            if (bol == true)
            {
                //panel_interfaz_alainid = true;
            }
            else if (bol == false)
            {
                Error error = new Error();
                error.ShowDialog();
                
            }
            
        }

        private void Atras_Inicio_Click_1(object sender, EventArgs e)
        {
            panel_Iniciar_Sesion.Visible = false;
        }
    }
}
