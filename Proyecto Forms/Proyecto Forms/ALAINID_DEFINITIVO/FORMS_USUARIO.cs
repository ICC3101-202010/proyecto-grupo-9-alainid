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
    public partial class ALAINID : Form
    {
        public ALAINID()
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
            panel_buscar.Visible = true;
            panel_buscar.Dock = DockStyle.Fill;
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
            btn_guardar_cambios_perfil_usuario.Visible = true;
        }

        private void btn_guardar_cambios_perfil_usuario_Click(object sender, EventArgs e)
        {
            pass_txt_perfil_usuario.ReadOnly = true;
            nombrecompleto_txt_perfil_usuario.ReadOnly = true;
            nombredeusuario_txt_perfil_usuario.ReadOnly = true;
            btn_guardar_cambios_perfil_usuario.Visible = false;
            Proyecto_Forms.ALAINID.Cambiarcontrasena(Program.usuario_activo.Email_, Program.usuario_activo.Password_, pass_txt_perfil_usuario.Text);
            bool name = Proyecto_Forms.ALAINID.Cambiarnombreusuario(Program.usuario_activo.Email_, Program.usuario_activo.Password_, nombredeusuario_txt_perfil_usuario.Text);
            Proyecto_Forms.ALAINID.Cambiarnombre(Program.usuario_activo.Email_, Program.usuario_activo.Password_, nombrecompleto_txt_perfil_usuario.Text);
            Program.usuario_activo.Password_ = pass_txt_perfil_usuario.Text;
            Program.usuario_activo.Nombre_ = nombrecompleto_txt_perfil_usuario.Text;
            if (name == true)
            {
                Program.usuario_activo.Nombreusuario = nombredeusuario_txt_perfil_usuario.Text;
            }
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
        //PREMIUM Y PRIVACIDAD////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7
        private void btn_premium_Click(object sender, EventArgs e)
        {
            Panel_premium.Visible = true;
            Panel_premium.Dock = DockStyle.Fill;
        }

        private void Panel_premium_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_premium_listo_Click(object sender, EventArgs e)
        {
            Proyecto_Forms.ALAINID.VolversePremium(emialpremiumtextbox.Text, contraseñapremiumtextbox.Text);
        }

        private void contraseñapremiumtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emialpremiumtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnatraspremium_Click(object sender, EventArgs e)
        {
            Panel_premium.Visible = false;
            contraseñapremiumtextbox.Text = "";
            emialpremiumtextbox.Text = "";
        }

        private void checkBox_contraseña_premium_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_contraseña_premium.Checked == true)
            {
                contraseñapremiumtextbox.UseSystemPasswordChar = false;
            }
            if (checkBox_contraseña_premium.Checked == false)
            {
                contraseñapremiumtextbox.UseSystemPasswordChar = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void privacidad_tvt_editar_perfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_privado_editar_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_privado_editar_usuario .Checked == true)
            {
                Proyecto_Forms.ALAINID.Cambiarprivacidadaprivado(Program.usuario_activo.Email_, Program.usuario_activo.Password_);
            }
            if (checkbox_privado_editar_usuario.Checked == false)
            {
                Proyecto_Forms.ALAINID.Cambiarprivacidapublico(Program.usuario_activo.Email_, Program.usuario_activo.Password_);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //////////////////////////////BUSQUEDA///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_busqueda_simple_Click(object sender, EventArgs e)
        {
            panel_busqueda_simple.Visible = true;
            panel_busqueda_simple.Dock = DockStyle.Fill;
        }

        private void btn_busqueda_multiple_Click(object sender, EventArgs e)
        {
            panel_busqueda_multiple.Visible = true;
            panel_busqueda_multiple.Dock = DockStyle.Fill;
        }

        private void btn_atras_de_inicio_sesion_Click(object sender, EventArgs e)
        {
            panel_buscar.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void busquedasimple_criterio_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busquedasimple_criterio_text.Text == "Genero")
            {
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Rock");
                busquedasimple_valor_criterio_desplegable.Items.Add("Country");
                busquedasimple_valor_criterio_desplegable.Items.Add("K-POP");
                busquedasimple_valor_criterio_desplegable.Items.Add("Electrónica");
                busquedasimple_valor_criterio_desplegable.Items.Add("Heavy Metal");
                busquedasimple_valor_criterio_desplegable.Items.Add("House");
                busquedasimple_valor_criterio_desplegable.Items.Add("Disco");
                busquedasimple_valor_criterio_desplegable.Items.Add("Urban");
                busquedasimple_valor_criterio_desplegable.Items.Add("Folklorica");
                busquedasimple_valor_criterio_desplegable.Items.Add("Hip Hop");
                busquedasimple_valor_criterio_desplegable.Items.Add("POP");
                busquedasimple_valor_criterio_desplegable.Items.Add("Jazz");
                busquedasimple_valor_criterio_desplegable.Items.Add("Indie Rock");
                busquedasimple_valor_criterio_desplegable.Items.Add("Punk");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");
            }
            if (busquedasimple_criterio_text.Text == "Disquera")
            {
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Sony Music");
                busquedasimple_valor_criterio_desplegable.Items.Add("Universal Music");
                busquedasimple_valor_criterio_desplegable.Items.Add("YG Entertainment");
                busquedasimple_valor_criterio_desplegable.Items.Add("SM Entretainment");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");

            }
            if (busquedasimple_criterio_text.Text == "Sexo")
            {
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Femenino");
                busquedasimple_valor_criterio_desplegable.Items.Add("Masculino");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");

            }
            if (busquedasimple_criterio_text.Text == "Edad")
            {
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Menores de 25 años");
                busquedasimple_valor_criterio_desplegable.Items.Add("De 25 a 40 años");
                busquedasimple_valor_criterio_desplegable.Items.Add("De 40 a 60 años");
                busquedasimple_valor_criterio_desplegable.Items.Add("Mayores de 60");

            }
            if (busquedasimple_criterio_text.Text == "Film Studio")
            {
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Universal Studio Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("Sony Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("YG Entertainment Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("SM Entretainment Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("Warner Bros Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");

            }
            if (busquedasimple_criterio_text.Text == "Categoria Pelicula")
            {

            }
            if (busquedasimple_criterio_text.Text == "Film Studio")
            {
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Universal Studio Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("Sony Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("YG Entertainment Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("SM Entretainment Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("Warner Bros Pictures");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");
            }
            if (busquedasimple_criterio_text.Text == "Cantante")
            {
            busquedasimple_valor_criterio_desplegable.Visible = false; 
                

            }
            if (busquedasimple_criterio_text.Text == "Compositor")
            {
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Director")
            {
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Actor")
            {
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Album")
            {
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Evaluacion")
            {
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Resolucion")
            {
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }


        }

        private void busaquedasimple_valor_criterio_text_TextChanged(object sender, EventArgs e)
        {
            //aqui estoy
        }

        private void btn_buscar_busqueda_simple_Click(object sender, EventArgs e)
        {
            //LLAMA AL METODO BUSCADOR busquedasimple_valor_criterio_desplegable.Text
        }

        private void btn_atras_busquedasimple_Click(object sender, EventArgs e)
        {
            panel_busqueda_simple.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter_2(object sender, EventArgs e)
        {

        }

        private void busquedasimple_valor_criterio_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_busqueda_multiple_Click(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void criterio_txt_combobox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox6_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void criterio_txt_combobox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox5_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //botonatras_busquedamultiple
            panel_busqueda_multiple.Visible = false;
        }

        private void busquedasimple_criterio_text_SelectedValueChanged(object sender, EventArgs e)
        {
            //en vola en este
        }
    }
}
