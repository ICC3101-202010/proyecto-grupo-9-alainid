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
    public partial class FORMS_USUARIO : Form
    {
        public FORMS_USUARIO()
        {
            InitializeComponent();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Program.forms_inicio.Show();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }


        //Botones menu principal usuario
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {

        }

        private void btnSocial_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            panel_perfil_de_usuario.Visible = true;
            panel_perfil_de_usuario.Dock = DockStyle.Fill;
            nombrecompleto_txt_perfil_usuario.Text = Program.usuario_activo.Nombre_;
            nombredeusuario_txt_perfil_usuario.Text = Program.usuario_activo.Nombreusuario;
            mail_txt_perfil_usuario.Text = Program.usuario_activo.Email_;
            pass_txt_perfil_usuario.Text = Program.usuario_activo.Password_;

        }

        private void btnKaraoke_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargas_Click(object sender, EventArgs e)
        {

        }

        private void BtnListaInteligente_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
            Program.forms_inicio.Show();
        }



        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }


        // PERFIL USUARIO

        private void panel_perfil_de_usuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nombrecompleto_txt_perfil_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombredeusuario_txt_perfil_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void mail_txt_perfil_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_txt_perfil_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_para_ver_contraseña_perfil_usuraio_CheckedChanged(object sender, EventArgs e)
        {

            if (checkbox_para_ver_contraseña_perfil_usuraio.Checked == true)
            {
                pass_txt_perfil_usuario.UseSystemPasswordChar = false;
            }
            if (checkbox_para_ver_contraseña_perfil_usuraio.Checked == false)
            {
                pass_txt_perfil_usuario.UseSystemPasswordChar = true;
            }

        }

        private void btn_editar_perfil_usuario_Click(object sender, EventArgs e)
        {

            pass_txt_perfil_usuario.ReadOnly = false;
            nombrecompleto_txt_perfil_usuario.ReadOnly = false;
            nombredeusuario_txt_perfil_usuario.ReadOnly = false;
            mail_txt_perfil_usuario.ReadOnly = false;
            btn_guardar_cambios_perfil_usuario.Visible = true;

        }

        private void btn_guardar_cambios_perfil_usuario_Click(object sender, EventArgs e)
        {
            pass_txt_perfil_usuario.ReadOnly = true;
            nombrecompleto_txt_perfil_usuario.ReadOnly = true;
            nombredeusuario_txt_perfil_usuario.ReadOnly = true;
            mail_txt_perfil_usuario.ReadOnly = true;
            btn_guardar_cambios_perfil_usuario.Visible = false;
            foreach (User user in ALAINID.listausuarios)
            {
                if (user.Nombre_==Program.usuario_activo.Nombre_ && user.Nombreusuario== Program.usuario_activo.Nombreusuario && user.Email_ == Program.usuario_activo.Email_)
                {
                    user.Email_ = mail_txt_perfil_usuario.Text;
                    user.Password_ = pass_txt_perfil_usuario.Text;
                    user.Nombreusuario = nombredeusuario_txt_perfil_usuario.Text;
                    user.Nombre_ = nombrecompleto_txt_perfil_usuario.Text;
                    ALAINID.Almacenar(ALAINID.listausuarios);
                }
            }
            Program.usuario_activo.Email_ = mail_txt_perfil_usuario.Text;
            Program.usuario_activo.Password_ = pass_txt_perfil_usuario.Text;
            Program.usuario_activo.Nombreusuario = nombredeusuario_txt_perfil_usuario.Text;
            Program.usuario_activo.Nombre_ = nombrecompleto_txt_perfil_usuario.Text;
        }

        private void FORMS_USUARIO_Load(object sender, EventArgs e)
        {
            Program.forms_inicio.Visible = false;
        }

        private void btn_atras_de_registrarse_Click(object sender, EventArgs e)
        {
            panel_perfil_de_usuario.Visible = false;
            pass_txt_perfil_usuario.Text = "";
            nombrecompleto_txt_perfil_usuario.Text = "";
            nombredeusuario_txt_perfil_usuario.Text = "";
            mail_txt_perfil_usuario.Text = "";
            
        }

        private void cerrarSesionYSalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Program.forms_inicio.Show();
            Application.Exit();
        }
    }
}
