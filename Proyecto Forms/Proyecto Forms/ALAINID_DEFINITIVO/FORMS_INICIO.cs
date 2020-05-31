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
        private void label10_Click(object sender, EventArgs e)
        {
            //LOGO ALAINID DE INICIO
        }
        private void label_todo_lo_que_necesitas_Click(object sender, EventArgs e)
        {
            //LOGO ALAINID INICIO2
        }

        private void btn_ingresar_a_Registrarse_Click(object sender, EventArgs e)
        {
            panel1_registrarse.Visible = true;
            panel1_registrarse.Dock = DockStyle.Fill;
        }

        private void btn_ingresar_a_Iniciarsesion_Click(object sender, EventArgs e)
        {
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
                Proyecto_Forms.ALAINID.Activarlista();
                Proyecto_Forms.ALAINID.Agregarusuarioalalista(u1);

                panel1_registrarse.Visible = false;
                nombre_completo_text_de_registrarse.Text = "";
                nombre_usuario_text_de_registrarse.Text = "";
                mail_text_de_registrarse.Text = "";
                pass_text_de_registrarse.Text = "";
            }
            catch
            {
                User u1 = new User(nombre_completo_text_de_registrarse.Text, nombre_usuario_text_de_registrarse.Text, mail_text_de_registrarse.Text, pass_text_de_registrarse.Text);
                Proyecto_Forms.ALAINID.Agregarusuarioalalista(u1);
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
            Proyecto_Forms.ALAINID.Activarlista();
            if ((nombre_completo_txt_inicio_sesion.Text != "") && (pass_txt_inicio_sesion.Text != "202023"))
            {
                bool bol = Proyecto_Forms.ALAINID.Ingresaralaapp(nombre_completo_txt_inicio_sesion.Text, pass_txt_inicio_sesion.Text);
                if (bol == true)
                {
                    foreach (User usuario in Proyecto_Forms.ALAINID.listausuarios)
                    {
                        if (usuario.Email_ == nombre_completo_txt_inicio_sesion.Text && usuario.Password_== pass_txt_inicio_sesion.Text)
                        {
                            Program.usuario_activo = usuario;
                        }
                    }
                    ALAINID fORMS_USUARIO = new ALAINID();
                    fORMS_USUARIO.Show();// hacer evento
                    panel2_inicio_sesion.Visible = false;
                    Program.forms_inicio.Visible = false;
                    nombre_completo_txt_inicio_sesion.Text = "";
                    pass_txt_inicio_sesion.Text = "";
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
                panel2_inicio_sesion.Visible = false;
                Program.forms_inicio.Visible = false;
                nombre_completo_txt_inicio_sesion.Text = "";
                pass_txt_inicio_sesion.Text = "";
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

        private void panel2_inicio_sesion_Resize(object sender, EventArgs e)
        {
            
        }

        private void FORMS_INICIO_Resize(object sender, EventArgs e)
        {
            label10.Left = this.Width - 940;
            label10.Top = this.Height - 750;
            label_todo_lo_que_necesitas.Left = this.Width - 920;
            label_todo_lo_que_necesitas.Top = this.Height - 635;
            btn_ingresar_a_Iniciarsesion.Left = this.Width - 900;
            btn_ingresar_a_Iniciarsesion.Top = this.Height -420;

            btn_ingresar_a_Registrarse.Left = this.Width -900;
            btn_ingresar_a_Registrarse.Top = this.Height-520 ;

            btn_primero_Salir.Left = this.Width -900;
            btn_primero_Salir.Top = this.Height- 320;


        }
    }
}
