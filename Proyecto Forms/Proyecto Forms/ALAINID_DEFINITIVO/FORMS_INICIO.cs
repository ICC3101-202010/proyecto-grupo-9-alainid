using Proyecto_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALAINID_DEFINITIVO
{
    public partial class FORMS_INICIO : Form
    {
        public FORMS_INICIO()
        {
            InitializeComponent();
        }

        private void btn_ingresar_a_Registrarse_Click(object sender, EventArgs e)
        {
            panel1_registrarse.Visible = true;
            panel1_registrarse.Dock = DockStyle.Fill;
        }

        private void btn_ingresar_a_Iniciarsesion_Click(object sender, EventArgs e)
        {
            panel1_registrarse.Visible = false;
            panel2_inicio_sesion.Visible = true;
            panel2_inicio_sesion.Dock = DockStyle.Fill;
        }

        private void btn_primero_Salir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btn_registrar_de_registrarse_Click(object sender, EventArgs e)
        {
            try
            {
                User u1 = new User(nombre_completo_text_de_registrarse.Text, nombre_usuario_text_de_registrarse.Text, mail_text_de_registrarse.Text, pass_text_de_registrarse.Text);
                ALAINID.Activarlista();
                ALAINID.Agregarusuarioalalista(u1);

                panel1_registrarse.Visible = false;
                nombre_completo_text_de_registrarse.Text = "";
                nombre_usuario_text_de_registrarse.Text = "";
                mail_text_de_registrarse.Text = "";
                pass_text_de_registrarse.Text = "";
            }
            catch
            {
                User u1 = new User(nombre_completo_text_de_registrarse.Text, nombre_usuario_text_de_registrarse.Text, mail_text_de_registrarse.Text, pass_text_de_registrarse.Text);
                ALAINID.Agregarusuarioalalista(u1);
                panel1_registrarse.Visible = false;
                panel1_registrarse.Visible = false;
                nombre_completo_text_de_registrarse.Text = "";
                nombre_usuario_text_de_registrarse.Text = "";
                mail_text_de_registrarse.Text = "";
                pass_text_de_registrarse.Text = "";
            }
        }

        private void btn_atras_de_registrarse_Click(object sender, EventArgs e)
        {
            panel1_registrarse.Visible = false;
        }

        private void mail_text_de_registrarse_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_usuario_text_de_registrarse_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_completo_text_de_registrarse_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_text_de_registrarse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_atras_de_inicio_sesion_Click(object sender, EventArgs e)
        {
            panel2_inicio_sesion.Visible = false;
        }

        private void btn_ingresar_inicio_sesion_Click(object sender, EventArgs e)
        {
            ALAINID.Activarlista();
            if ((nombre_completo_txt_inicio_sesion.Text != "") && (pass_txt_inicio_sesion.Text != "202023"))
            {
                bool bol = ALAINID.Ingresaralaapp(nombre_completo_txt_inicio_sesion.Text, pass_txt_inicio_sesion.Text);
                if (bol == true)
                {
                    FORMS_USUARIO fORMS_USUARIO = new FORMS_USUARIO();
                    fORMS_USUARIO.Show();// hacer evento

                }
                else if (bol == false)
                {
                    MessageBox.Show("Usuario Invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                FORMS_ADMIN fORMS_ADMIN = new FORMS_ADMIN();
                fORMS_ADMIN.Show();//evento
            }
        }

        private void nombre_completo_txt_inicio_sesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_txt_inicio_sesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_inicio_sesion_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
