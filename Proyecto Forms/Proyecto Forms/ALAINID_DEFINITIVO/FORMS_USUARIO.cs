﻿using Proyecto_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;
using System.Resources;


namespace ALAINID_DEFINITIVO
{
    public partial class ALAINID : Form
    {
        public ALAINID()
        {
            lista_cri_canciones.Add("Nombre Cancion"); lista_cri_canciones.Add("Cantante"); lista_cri_canciones.Add("Album"); 
            lista_cri_canciones.Add("Genero Cancion"); lista_cri_canciones.Add("Compositor"); lista_cri_canciones.Add("Disquera");

            lista_cri_videos.Add("Nombre Pelicula"); lista_cri_videos.Add("Categoria Pelicula"); lista_cri_videos.Add("Actor");
            lista_cri_videos.Add("Genero Video"); lista_cri_videos.Add("Director"); lista_cri_videos.Add("Film Studio");
            InitializeComponent();
        }
        public int desplegable;
        public string ruta;
        public List<string> criterios = new List<string>();
        public List<string> criterios_seleccionados = new List<string>();
        public List<string> criterios_introducidos = new List<string>();
        public List<string> lista_cri_canciones = new List<string>();
        public List<string> lista_cri_videos = new List<string>();


        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
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
            panel_playlist_usuario.Visible = true;
            panel_playlist_usuario.Dock = DockStyle.Fill;
            foreach (PlaylistSong plys in Program.usuario_activo.Lista_playlistusuario_)
            {
                int n = tabla_playlist.Rows.Add();
                tabla_playlist.Rows[n].Cells[0].Value = plys.NombrePlaylist;
                tabla_playlist.Rows[n].Cells[1].Value = plys.Listplay.Count();
                tabla_playlist.Rows[n].Cells[1].Value = "Canciones";
            }
            foreach (PlaylistVideo plyv in Program.usuario_activo.Lista_playlistvideousuario_)
            {
                int n = tabla_playlist.Rows.Add();
                tabla_playlist.Rows[n].Cells[0].Value = plyv.NombrePlaylist;
                tabla_playlist.Rows[n].Cells[1].Value = plyv.Listplayvideo.Count();
                tabla_playlist.Rows[n].Cells[1].Value = "Videos";
            }
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            panel_favoritos_menu.Visible = true;
            panel_favoritos_menu.Dock = DockStyle.Fill;
            foreach(Song cancion in Program.usuario_activo.Favorite_songs_)
            {
                int n = tabla_favoritos_canciones.Rows.Add();
                tabla_favoritos_canciones.Rows[n].Cells[0].Value = cancion.Nombrecancion;
                tabla_favoritos_canciones.Rows[n].Cells[1].Value = cancion.Cantante.Name;
            }
            foreach (Video video in Program.usuario_activo.Favorite_videos_)
            {
                int n = tabla_favoritos_videos.Rows.Add();
                tabla_favoritos_videos.Rows[n].Cells[0].Value = video.Nombre_video;
                tabla_favoritos_videos.Rows[n].Cells[1].Value = video.Director.Name;
            }
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            panel_social_menu.Visible = true;
            panel_social_menu.Dock = DockStyle.Fill;
            foreach(User user in usuarios_busqueda_social)
            {
                int n = tabla_seguidos_social.Rows.Add();
                tabla_seguidos_social.Rows[n].Cells[0].Value = user.Nombre_;
                tabla_seguidos_social.Rows[n].Cells[1].Value = "Usuario";
                
            }
            foreach (Artista art in artistas_busqueda_social)
            {
                int n = tabla_seguidos_social.Rows.Add();
                tabla_seguidos_social.Rows[n].Cells[0].Value = art.Name;
                tabla_seguidos_social.Rows[n].Cells[1].Value = "Artista";

            }
            foreach(User user1 in Proyecto_Forms.ALAINID.listausuarios)
            {
                foreach(User seguido in user1.Usuarios_seguidos_)
                {
                    if (seguido.Email_ == Program.usuario_activo.Email_)
                    {
                        int n = tabla_seguidores_social.Rows.Add();
                        tabla_seguidores_social.Rows[n].Cells[0].Value = user1.Nombre_;
                        tabla_seguidores_social.Rows[n].Cells[1].Value = "Usuario";
                        
                    }
                }
            }

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
            panel_karaoke_menu.Visible = true;
            panel_karaoke_menu.Dock = DockStyle.Fill;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            panel_historial_menu.Visible = true;
            panel_historial_menu.Dock = DockStyle.Fill;
        }

        private void btnDescargas_Click(object sender, EventArgs e)
        {
            panel_descargas_menu.Visible = true;
            panel_descargas_menu.Dock = DockStyle.Fill;
        }

        private void BtnListaInteligente_Click(object sender, EventArgs e)
        {
            panel_listainteligente_menu.Visible = true;
            panel_listainteligente_menu.Dock = DockStyle.Fill;
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
            checkbox_privado_editar_usuario.Enabled = true;
        }

        private void btn_guardar_cambios_perfil_usuario_Click(object sender, EventArgs e)
        {
            checkbox_privado_editar_usuario.Enabled = false;
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
            checkBox_busqueda_OR.Checked = true;
            panel_busqueda_simple.Visible = true;
            panel_busqueda_simple.Dock = DockStyle.Fill;
        }

        private void btn_busqueda_multiple_Click(object sender, EventArgs e)
        {
            checkBox_busqueda_OR.Checked = true;
            checkBox_busqueda_AND.Checked = false;
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            panel_busqueda_multiple.Visible = true;
            panel_busqueda_multiple.Dock = DockStyle.Fill;
            criterio_txt_combobox1_desplegable.Items.Clear(); criterio_txt_combobox2_desplegable.Items.Clear();
            criterio_txt_combobox3_desplegable.Items.Clear(); criterio_txt_combobox4_desplegable.Items.Clear();
            criterio_txt_combobox5_desplegable.Items.Clear(); criterio_txt_combobox6_desplegable.Items.Clear();
            criterio_txt_combobox7_desplegable.Items.Clear(); criterio_txt_combobox8_desplegable.Items.Clear();
            criterio_txt_combobox2.Enabled = false; criterio_txt_combobox3.Enabled = false; criterio_txt_combobox4.Enabled = false;
            criterio_txt_combobox5.Enabled = false; criterio_txt_combobox6.Enabled = false; criterio_txt_combobox7.Enabled = false;
            criterio_txt_combobox8.Enabled = false;
            criterio_txt_combobox1_desplegable.Visible = false; criterio_txt_combobox2_desplegable.Visible = false; criterio_txt_combobox3_desplegable.Visible = false;
            criterio_txt_combobox4_desplegable.Visible = false; criterio_txt_combobox5_desplegable.Visible = false; criterio_txt_combobox6_desplegable.Visible = false;
            criterio_txt_combobox7_desplegable.Visible = false; criterio_txt_combobox8_desplegable.Visible = false;
            comboBox1_criterio.Enabled = true;
            comboBox1_criterio.Items.Clear(); comboBox2_criterio.Items.Clear(); comboBox3_criterio.Items.Clear(); comboBox4_criterio.Items.Clear();
            comboBox5_criterio.Items.Clear(); comboBox6_criterio.Items.Clear(); comboBox7_criterio.Items.Clear(); comboBox8_criterio.Items.Clear();
            comboBox1_criterio.Text = "";comboBox2_criterio.Text = "";comboBox3_criterio.Text = "";comboBox4_criterio.Text = "";
            comboBox5_criterio.Text = "";comboBox6_criterio.Text = "";comboBox7_criterio.Text = "";comboBox8_criterio.Text = "";
            criterio_txt_combobox1.Text = ""; criterio_txt_combobox2.Text = ""; criterio_txt_combobox3.Text = ""; criterio_txt_combobox4.Text = "";
            criterio_txt_combobox5.Text = ""; criterio_txt_combobox6.Text = ""; criterio_txt_combobox7.Text = ""; criterio_txt_combobox8.Text = "";
            criterio_txt_combobox1_desplegable.Text = ""; criterio_txt_combobox2_desplegable.Text = ""; criterio_txt_combobox3_desplegable.Text = "";
            criterio_txt_combobox4_desplegable.Text = ""; criterio_txt_combobox5_desplegable.Text = ""; criterio_txt_combobox6_desplegable.Text = "";
            criterio_txt_combobox7_desplegable.Text = ""; criterio_txt_combobox8_desplegable.Text = "";
            criterios.Clear();

            foreach (string criterio in Proyecto_Forms.ALAINID.lista_criterios_filtro2)
            {
                criterios.Add(criterio);
            }
            foreach (string criterio in criterios)
            {
                comboBox1_criterio.Items.Add(criterio);
            }
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
            if (busquedasimple_criterio_text.Text == "Genero Cancion")
            {
                desplegable =0;
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Rock");
                busquedasimple_valor_criterio_desplegable.Items.Add("Country");
                busquedasimple_valor_criterio_desplegable.Items.Add("K-Pop");
                busquedasimple_valor_criterio_desplegable.Items.Add("Electrónica");
                busquedasimple_valor_criterio_desplegable.Items.Add("Heavy Metal");
                busquedasimple_valor_criterio_desplegable.Items.Add("House");
                busquedasimple_valor_criterio_desplegable.Items.Add("Disco");
                busquedasimple_valor_criterio_desplegable.Items.Add("Urban");
                busquedasimple_valor_criterio_desplegable.Items.Add("Folklorica");
                busquedasimple_valor_criterio_desplegable.Items.Add("Hip Hop");
                busquedasimple_valor_criterio_desplegable.Items.Add("Pop");
                busquedasimple_valor_criterio_desplegable.Items.Add("Jazz");
                busquedasimple_valor_criterio_desplegable.Items.Add("Indie Rock");
                busquedasimple_valor_criterio_desplegable.Items.Add("Punk");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");

            }
            if (busquedasimple_criterio_text.Text == "Disquera")
            {
                desplegable = 0;
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Sony Music");
                busquedasimple_valor_criterio_desplegable.Items.Add("Universal Music");
                busquedasimple_valor_criterio_desplegable.Items.Add("YG Entertainment");
                busquedasimple_valor_criterio_desplegable.Items.Add("SM Entretainment");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");

            }
            if (busquedasimple_criterio_text.Text == "Sexo del Artista")
            {
                desplegable = 5;
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Femenino");
                busquedasimple_valor_criterio_desplegable.Items.Add("Masculino");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");

            }
            if (busquedasimple_criterio_text.Text == "Edad del Artista") 
            {
                desplegable = 5;
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Menores de 25 años");
                busquedasimple_valor_criterio_desplegable.Items.Add("De 25 a 40 años");
                busquedasimple_valor_criterio_desplegable.Items.Add("De 40 a 60 años");
                busquedasimple_valor_criterio_desplegable.Items.Add("Mayores de 60");

            }
            
            if (busquedasimple_criterio_text.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Infantil (0 - 7 años)");
                busquedasimple_valor_criterio_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                busquedasimple_valor_criterio_desplegable.Items.Add("Adolecente (16 - 18 años)");
                busquedasimple_valor_criterio_desplegable.Items.Add("Adulto (18+ años)");
                
            }
            if (busquedasimple_criterio_text.Text =="Genero Video")
            {
                desplegable = 3;
                busquedasimple_valor_criterio_desplegable.Visible = true;
                busquedasimple_valor_criterio_desplegable.Items.Clear();
                busquedasimple_valor_criterio_desplegable.Items.Add("Terror");
                busquedasimple_valor_criterio_desplegable.Items.Add("Crimen");
                busquedasimple_valor_criterio_desplegable.Items.Add("Accion");
                busquedasimple_valor_criterio_desplegable.Items.Add("Comedia");
                busquedasimple_valor_criterio_desplegable.Items.Add("Musical");
                busquedasimple_valor_criterio_desplegable.Items.Add("Drama");
                busquedasimple_valor_criterio_desplegable.Items.Add("Ciencia Ficcion");
                busquedasimple_valor_criterio_desplegable.Items.Add("Otra");
                
            } 
                

                
            if (busquedasimple_criterio_text.Text == "Film Studio")
            {
                desplegable = 3;
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
                desplegable = 1;
                busquedasimple_valor_criterio_desplegable.Visible = false;

                 
                

            }
            if (busquedasimple_criterio_text.Text == "Compositor")
            {
                desplegable = 1;
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Director")
            {
                desplegable = 4;
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Actor")
            {
                desplegable = 4;
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Album")
            {
                desplegable = 1;
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Evaluacion")
            {
                desplegable = 6;
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Nombre Cancion")
            {
                desplegable = 1;
                busquedasimple_valor_criterio_desplegable.Visible = false;



            }
            if (busquedasimple_criterio_text.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                busquedasimple_valor_criterio_desplegable.Visible = false;


            }
            if (busquedasimple_criterio_text.Text == "Año de Publicacion")
            {
                desplegable = 6;
                busquedasimple_valor_criterio_desplegable.Visible = false;
            }



        }

        private void busaquedasimple_valor_criterio_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_buscar_busqueda_simple_Click(object sender, EventArgs e)
        {
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            datagratview_busquedasimple.Rows.Clear();
            //Proyecto_Forms.ALAINID.CancionesPorCriterio(busquedasimple_criterio_text.Text, busquedasimple_valor_criterio_desplegable.Text);
            if (desplegable == 0)
            {//    DESPLEGABLE CANCIONES
                foreach (Song song in Proyecto_Forms.ALAINID.CancionesPorCriterio(busquedasimple_criterio_text.Text, busquedasimple_valor_criterio_desplegable.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = song.Nombrecancion;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = song.Cantante.Name;

                }
            }

            if (desplegable == 1)
            {//   NO DESPLEGABLE  CANCIONES
                foreach (Song song in Proyecto_Forms.ALAINID.CancionesPorCriterio(busquedasimple_criterio_text.Text, busaquedasimple_valor_criterio_text.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = song.Nombrecancion;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = song.Cantante.Name;

                }
            }
            if (desplegable == 3)
            {//   DESPLEGABLE VIDEO
                foreach (Video video in Proyecto_Forms.ALAINID.Buqueda_simple_videos(busquedasimple_criterio_text.Text, busquedasimple_valor_criterio_desplegable.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = video.Nombre_video;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = video.Director.Name;
                }
            }
            if (desplegable == 4)
            {//  NO  DESPLEGABLE VIDEO
                foreach (Video video in Proyecto_Forms.ALAINID.Buqueda_simple_videos(busquedasimple_criterio_text.Text, busaquedasimple_valor_criterio_text.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = video.Nombre_video;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = video.Director.Name;
                }
            }
            if (desplegable == 5)
            {
                foreach (Song song in Proyecto_Forms.ALAINID.CancionesPorCriterio(busquedasimple_criterio_text.Text, busquedasimple_valor_criterio_desplegable.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = song.Nombrecancion;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = song.Cantante.Name;
                }
                foreach (Video video in Proyecto_Forms.ALAINID.Buqueda_simple_videos(busquedasimple_criterio_text.Text, busquedasimple_valor_criterio_desplegable.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = video.Nombre_video;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = video.Director.Name;
                }
            }
            if (desplegable == 6)
            {
                foreach (Song song in Proyecto_Forms.ALAINID.CancionesPorCriterio(busquedasimple_criterio_text.Text, busaquedasimple_valor_criterio_text.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = song.Nombrecancion;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = song.Cantante.Name;
                }
                foreach (Video video in Proyecto_Forms.ALAINID.Buqueda_simple_videos(busquedasimple_criterio_text.Text, busaquedasimple_valor_criterio_text.Text))
                {
                    int n = datagratview_busquedasimple.Rows.Add();
                    datagratview_busquedasimple.Rows[n].Cells[0].Value = video.Nombre_video;
                    datagratview_busquedasimple.Rows[n].Cells[1].Value = video.Director.Name;
                }
            }
            busquedasimple_valor_criterio_desplegable.Text = "";
            busaquedasimple_valor_criterio_text.Text = "";
        }

        private void btn_atras_busquedasimple_Click(object sender, EventArgs e)
        {
            panel_busqueda_simple.Visible = false;
            busquedasimple_valor_criterio_desplegable.Text = "";
            busaquedasimple_valor_criterio_text.Text = "";
            datagratview_busquedasimple.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//datagreatview_busqeuda simple


        }

        private void axWindowsMediaPlayer1_Enter_2(object sender, EventArgs e)
        {//reproductor

        }

        private void busquedasimple_valor_criterio_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<Song> lista_canciones_filtradas = new List<Song>();
        public List<Video> lista_videos_filtrados = new List<Video>();
        private void btn_buscar_busqueda_multiple_Click(object sender, EventArgs e)
        {

            switch (criterios_seleccionados.Count())
            {
                case 1:
                    if (criterio_txt_combobox1.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox1.Text);
                    }
                    else if (criterio_txt_combobox1_desplegable.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox1_desplegable.Text);
                    }
                    break;
                case 2:
                    if (criterio_txt_combobox1.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox2.Text);
                    }
                    else if (criterio_txt_combobox1_desplegable.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox2_desplegable.Text);
                    }
                    break;
                case 3:
                    if (criterio_txt_combobox1.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox3.Text);
                    }
                    else if (criterio_txt_combobox1_desplegable.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox3_desplegable.Text);
                    }
                    break;
                case 4:
                    if (criterio_txt_combobox1.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox4.Text);
                    }
                    else if (criterio_txt_combobox1_desplegable.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox4_desplegable.Text);
                    }
                    break;
                case 5:
                    if (criterio_txt_combobox1.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox5.Text);
                    }
                    else if (criterio_txt_combobox1_desplegable.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox5_desplegable.Text);
                    }
                    break;
                case 6:
                    if (criterio_txt_combobox1.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox6.Text);
                    }
                    else if (criterio_txt_combobox1_desplegable.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox6_desplegable.Text);
                    }
                    break;
                case 7:
                    if (criterio_txt_combobox1.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox7.Text);
                    }
                    else if (criterio_txt_combobox1_desplegable.Text != "")
                    {
                        criterios_introducidos.Add(criterio_txt_combobox7_desplegable.Text);
                    }
                    break;

            }
            if (criterios_seleccionados.Count == 1)
            {
                if (criterio_txt_combobox1.Text != "")
                {
                    criterios_introducidos.Add(criterio_txt_combobox1.Text);
                }
                else if (criterio_txt_combobox1_desplegable.Text != "")
                {
                    criterios_introducidos.Add(criterio_txt_combobox1_desplegable.Text);
                }
            }
            if (criterio_txt_combobox8.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox8.Text);
            }
            else if (criterio_txt_combobox8_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox8_desplegable.Text);
            }

            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            int numero = criterios_seleccionados.Count();
            List<string> criterios_seleccionadosvideos = new List<string>();
            List<string> criterios_introducidosvideos = new List<string>();
            foreach (string crit in criterios_seleccionados)
            {
                criterios_seleccionadosvideos.Add(crit);
            }
            foreach (string crit in criterios_introducidos)
            {
                criterios_introducidosvideos.Add(crit);
            }
            if (checkBox_busqueda_AND.Checked == true)
            {
                lista_canciones_filtradas = Proyecto_Forms.ALAINID.Buqueda_multiple_cancionesand(criterios_seleccionados, criterios_introducidos);
                if (criterios_seleccionados != null)
                {
                    lista_videos_filtrados = Proyecto_Forms.ALAINID.Buqueda_multiple_videos_and(criterios_seleccionadosvideos, criterios_introducidosvideos);
                }
            }

            if (checkBox_busqueda_OR.Checked == true)
            {
                lista_canciones_filtradas = Proyecto_Forms.ALAINID.Buqueda_multiple_canciones(criterios_seleccionados, criterios_introducidos);
                if (criterios_seleccionados != null)
                {
                    lista_videos_filtrados = Proyecto_Forms.ALAINID.Buqueda_multiple_videos_or(criterios_seleccionadosvideos, criterios_introducidosvideos);
                }
            }
            panel_resultados_busqueda_multiple.Visible = true;
            panel_resultados_busqueda_multiple.Dock = DockStyle.Fill;
            
            foreach(Song canc in lista_canciones_filtradas)
            {
                int n = tabla_resultados_busqueda_multiple.Rows.Add();
                tabla_resultados_busqueda_multiple.Rows[n].Cells[0].Value = canc.Nombrecancion;
                tabla_resultados_busqueda_multiple.Rows[n].Cells[1].Value = canc.Cantante.Name;
                tabla_resultados_busqueda_multiple.Rows[n].Cells[2].Value = "Cancion";

            }
            foreach (Video vid in lista_videos_filtrados)
            {
                int n = tabla_resultados_busqueda_multiple.Rows.Add();
                tabla_resultados_busqueda_multiple.Rows[n].Cells[0].Value = vid.Nombre_video;
                tabla_resultados_busqueda_multiple.Rows[n].Cells[1].Value = vid.Director.Name;
                tabla_resultados_busqueda_multiple.Rows[n].Cells[2].Value = "Video";

            }
            criterio_txt_combobox1_desplegable.Items.Clear();criterio_txt_combobox2_desplegable.Items.Clear();
            criterio_txt_combobox3_desplegable.Items.Clear();criterio_txt_combobox4_desplegable.Items.Clear();
            criterio_txt_combobox5_desplegable.Items.Clear();criterio_txt_combobox6_desplegable.Items.Clear();
            criterio_txt_combobox7_desplegable.Items.Clear();criterio_txt_combobox8_desplegable.Items.Clear();
            criterio_txt_combobox2.Enabled = false;criterio_txt_combobox3.Enabled = false;criterio_txt_combobox4.Enabled = false;
            criterio_txt_combobox5.Enabled = false;criterio_txt_combobox6.Enabled = false;criterio_txt_combobox7.Enabled = false;
            criterio_txt_combobox8.Enabled = false;
            criterio_txt_combobox1_desplegable.Visible = false;criterio_txt_combobox2_desplegable.Visible = false;criterio_txt_combobox3_desplegable.Visible = false;
            criterio_txt_combobox4_desplegable.Visible = false;criterio_txt_combobox5_desplegable.Visible = false;criterio_txt_combobox6_desplegable.Visible = false;
            criterio_txt_combobox7_desplegable.Visible = false;criterio_txt_combobox8_desplegable.Visible = false;
            comboBox1_criterio.Enabled = true;
            comboBox1_criterio.Items.Clear();comboBox2_criterio.Items.Clear();comboBox3_criterio.Items.Clear();comboBox4_criterio.Items.Clear();
            comboBox5_criterio.Items.Clear();comboBox6_criterio.Items.Clear();comboBox7_criterio.Items.Clear();comboBox8_criterio.Items.Clear();
            criterio_txt_combobox1.Text = ""; criterio_txt_combobox2.Text = ""; criterio_txt_combobox3.Text = ""; criterio_txt_combobox4.Text = "";
            criterio_txt_combobox5.Text = ""; criterio_txt_combobox6.Text = ""; criterio_txt_combobox7.Text = ""; criterio_txt_combobox8.Text = "";
            criterio_txt_combobox1_desplegable.Text = ""; criterio_txt_combobox2_desplegable.Text = ""; criterio_txt_combobox3_desplegable.Text = "";
            criterio_txt_combobox4_desplegable.Text = ""; criterio_txt_combobox5_desplegable.Text = ""; criterio_txt_combobox6_desplegable.Text = "";
            criterio_txt_combobox7_desplegable.Text = ""; criterio_txt_combobox8_desplegable.Text = "";
            criterios.Clear();
            
            foreach (string criterio in Proyecto_Forms.ALAINID.lista_criterios_filtro2)
            {
                criterios.Add(criterio);
            }
            foreach (string criterio in criterios)
            {
                comboBox1_criterio.Items.Add(criterio);
            }

        }

        private void criterio_txt_combobox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("Rock");
                criterio_txt_combobox8_desplegable.Items.Add("Country");
                criterio_txt_combobox8_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox8_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox8_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox8_desplegable.Items.Add("House");
                criterio_txt_combobox8_desplegable.Items.Add("Disco");
                criterio_txt_combobox8_desplegable.Items.Add("Urban");
                criterio_txt_combobox8_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox8_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox8_desplegable.Items.Add("Pop");
                criterio_txt_combobox8_desplegable.Items.Add("Jazz");
                criterio_txt_combobox8_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox8_desplegable.Items.Add("Punk");
                criterio_txt_combobox8_desplegable.Items.Add("Otra");

            }
            if (comboBox8_criterio.Text == "Disquera")
            {

                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox8_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox8_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox8_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox8_desplegable.Items.Add("Otra");

            }
            if (comboBox8_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("Femenino");
                criterio_txt_combobox8_desplegable.Items.Add("Masculino");
                criterio_txt_combobox8_desplegable.Items.Add("Otra");

            }
            if (comboBox8_criterio.Text == "Edad del Artista")
            {

                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox8_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox8_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox8_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox8_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox8_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox8_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox8_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox8_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("Terror");
                criterio_txt_combobox8_desplegable.Items.Add("Crimen");
                criterio_txt_combobox8_desplegable.Items.Add("Accion");
                criterio_txt_combobox8_desplegable.Items.Add("Comedia");
                criterio_txt_combobox8_desplegable.Items.Add("Musical");
                criterio_txt_combobox8_desplegable.Items.Add("Drama");
                criterio_txt_combobox8_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox8_desplegable.Items.Add("Otra");

            }
            if (comboBox8_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox8_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox8_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox8_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox8_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox8_desplegable.Items.Add("Otra");
            }
            if (comboBox8_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox8_desplegable.Visible = false;

            }
            if (comboBox8_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox8_desplegable.Visible = false;


            }
            if (comboBox8_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox8_desplegable.Visible = false;


            }
            if (comboBox8_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox8_desplegable.Visible = false;


            }
            if (comboBox8_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox8_desplegable.Visible = false;


            }
            if (comboBox8_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox8_desplegable.Visible = false;


            }
            if (comboBox8_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox8_desplegable.Visible = true;
                criterio_txt_combobox8_desplegable.Items.Clear();
                criterio_txt_combobox8_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox8_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox8_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox8_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox8_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox8_desplegable.Items.Add("144p");
                criterio_txt_combobox8_desplegable.Items.Add("240p");
                criterio_txt_combobox8_desplegable.Items.Add("360p");
                criterio_txt_combobox8_desplegable.Items.Add("480p");
                criterio_txt_combobox8_desplegable.Items.Add("720p");
            }
            if (comboBox8_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox8_desplegable.Visible = false;



            }
            if (comboBox8_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox8_desplegable.Visible = false;


            }
            if (comboBox8_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox8_desplegable.Visible = false;

            }
            criterios.Remove(comboBox8_criterio.Text);
            criterios_seleccionados.Add(comboBox8_criterio.Text);
            comboBox8_criterio.Enabled = false;
            criterio_txt_combobox8.Enabled = true;
            if (criterio_txt_combobox7.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox7.Text);
            }
            else if (criterio_txt_combobox7_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox7_desplegable.Text);
            }
        }

        private void criterio_txt_combobox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox7_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("Rock");
                criterio_txt_combobox7_desplegable.Items.Add("Country");
                criterio_txt_combobox7_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox7_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox7_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox7_desplegable.Items.Add("House");
                criterio_txt_combobox7_desplegable.Items.Add("Disco");
                criterio_txt_combobox7_desplegable.Items.Add("Urban");
                criterio_txt_combobox7_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox7_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox7_desplegable.Items.Add("Pop");
                criterio_txt_combobox7_desplegable.Items.Add("Jazz");
                criterio_txt_combobox7_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox7_desplegable.Items.Add("Punk");
                criterio_txt_combobox7_desplegable.Items.Add("Otra");

            }
            if (comboBox7_criterio.Text == "Disquera")
            {

                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox7_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox7_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox7_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox7_desplegable.Items.Add("Otra");

            }
            if (comboBox7_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("Femenino");
                criterio_txt_combobox7_desplegable.Items.Add("Masculino");
                criterio_txt_combobox7_desplegable.Items.Add("Otra");

            }
            if (comboBox7_criterio.Text == "Edad del Artista")
            {

                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox7_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox7_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox7_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox7_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox7_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox7_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox7_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox7_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("Terror");
                criterio_txt_combobox7_desplegable.Items.Add("Crimen");
                criterio_txt_combobox7_desplegable.Items.Add("Accion");
                criterio_txt_combobox7_desplegable.Items.Add("Comedia");
                criterio_txt_combobox7_desplegable.Items.Add("Musical");
                criterio_txt_combobox7_desplegable.Items.Add("Drama");
                criterio_txt_combobox7_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox7_desplegable.Items.Add("Otra");

            }
            if (comboBox7_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox7_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox7_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox7_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox7_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox7_desplegable.Items.Add("Otra");
            }
            if (comboBox7_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox7_desplegable.Visible = false;

            }
            if (comboBox7_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox7_desplegable.Visible = false;


            }
            if (comboBox7_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox7_desplegable.Visible = false;


            }
            if (comboBox7_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox7_desplegable.Visible = false;


            }
            if (comboBox7_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox7_desplegable.Visible = false;


            }
            if (comboBox7_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox7_desplegable.Visible = false;


            }
            if (comboBox7_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox7_desplegable.Visible = true;
                criterio_txt_combobox7_desplegable.Items.Clear();
                criterio_txt_combobox7_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox7_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox7_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox7_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox7_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox7_desplegable.Items.Add("144p");
                criterio_txt_combobox7_desplegable.Items.Add("240p");
                criterio_txt_combobox7_desplegable.Items.Add("360p");
                criterio_txt_combobox7_desplegable.Items.Add("480p");
                criterio_txt_combobox7_desplegable.Items.Add("720p");
            }
            if (comboBox7_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox7_desplegable.Visible = false;



            }
            if (comboBox7_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox7_desplegable.Visible = false;


            }
            if (comboBox7_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox7_desplegable.Visible = false;

            }
            criterios.Remove(comboBox7_criterio.Text);
            criterios_seleccionados.Add(comboBox7_criterio.Text);
            foreach (string criterio in criterios)
            {
                comboBox8_criterio.Items.Add(criterio);
            }
            comboBox8_criterio.Enabled = true;
            comboBox7_criterio.Enabled = false;
            criterio_txt_combobox7.Enabled = true;
            if (criterio_txt_combobox6.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox6.Text);
            }
            else if (criterio_txt_combobox6_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox6_desplegable.Text);
            }
        }
        private void criterio_txt_combobox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox6_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("Rock");
                criterio_txt_combobox6_desplegable.Items.Add("Country");
                criterio_txt_combobox6_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox6_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox6_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox6_desplegable.Items.Add("House");
                criterio_txt_combobox6_desplegable.Items.Add("Disco");
                criterio_txt_combobox6_desplegable.Items.Add("Urban");
                criterio_txt_combobox6_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox6_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox6_desplegable.Items.Add("Pop");
                criterio_txt_combobox6_desplegable.Items.Add("Jazz");
                criterio_txt_combobox6_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox6_desplegable.Items.Add("Punk");
                criterio_txt_combobox6_desplegable.Items.Add("Otra");

            }
            if (comboBox6_criterio.Text == "Disquera")
            {

                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox6_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox6_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox6_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox6_desplegable.Items.Add("Otra");

            }
            if (comboBox6_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("Femenino");
                criterio_txt_combobox6_desplegable.Items.Add("Masculino");
                criterio_txt_combobox6_desplegable.Items.Add("Otra");

            }
            if (comboBox6_criterio.Text == "Edad del Artista")
            {

                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox6_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox6_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox6_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox6_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox6_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox6_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox6_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox6_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("Terror");
                criterio_txt_combobox6_desplegable.Items.Add("Crimen");
                criterio_txt_combobox6_desplegable.Items.Add("Accion");
                criterio_txt_combobox6_desplegable.Items.Add("Comedia");
                criterio_txt_combobox6_desplegable.Items.Add("Musical");
                criterio_txt_combobox6_desplegable.Items.Add("Drama");
                criterio_txt_combobox6_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox6_desplegable.Items.Add("Otra");

            }
            if (comboBox6_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox6_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox6_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox6_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox6_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox6_desplegable.Items.Add("Otra");
            }
            if (comboBox6_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox6_desplegable.Visible = false;

            }
            if (comboBox6_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox6_desplegable.Visible = false;


            }
            if (comboBox6_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox6_desplegable.Visible = false;


            }
            if (comboBox6_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox6_desplegable.Visible = false;


            }
            if (comboBox6_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox6_desplegable.Visible = false;


            }
            if (comboBox6_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox6_desplegable.Visible = false;


            }
            if (comboBox6_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox6_desplegable.Visible = true;
                criterio_txt_combobox6_desplegable.Items.Clear();
                criterio_txt_combobox6_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox6_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox6_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox6_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox6_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox6_desplegable.Items.Add("144p");
                criterio_txt_combobox6_desplegable.Items.Add("240p");
                criterio_txt_combobox6_desplegable.Items.Add("360p");
                criterio_txt_combobox6_desplegable.Items.Add("480p");
                criterio_txt_combobox6_desplegable.Items.Add("720p");
            }
            if (comboBox6_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox6_desplegable.Visible = false;



            }
            if (comboBox6_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox6_desplegable.Visible = false;


            }
            if (comboBox6_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox6_desplegable.Visible = false;

            }
            criterios.Remove(comboBox6_criterio.Text);
            criterios_seleccionados.Add(comboBox6_criterio.Text);
            foreach (string criterio in criterios)
            {
                comboBox7_criterio.Items.Add(criterio);
            }
            comboBox7_criterio.Enabled = true;
            comboBox6_criterio.Enabled = false;
            criterio_txt_combobox6.Enabled = true;
            if (criterio_txt_combobox5.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox5.Text);
            }
            else if (criterio_txt_combobox5_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox5_desplegable.Text);
            }
        }
        private void criterio_txt_combobox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox5_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox5_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("Rock");
                criterio_txt_combobox5_desplegable.Items.Add("Country");
                criterio_txt_combobox5_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox5_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox5_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox5_desplegable.Items.Add("House");
                criterio_txt_combobox5_desplegable.Items.Add("Disco");
                criterio_txt_combobox5_desplegable.Items.Add("Urban");
                criterio_txt_combobox5_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox5_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox5_desplegable.Items.Add("Pop");
                criterio_txt_combobox5_desplegable.Items.Add("Jazz");
                criterio_txt_combobox5_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox5_desplegable.Items.Add("Punk");
                criterio_txt_combobox5_desplegable.Items.Add("Otra");

            }
            if (comboBox5_criterio.Text == "Disquera")
            {

                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox5_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox5_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox5_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox5_desplegable.Items.Add("Otra");

            }
            if (comboBox5_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("Femenino");
                criterio_txt_combobox5_desplegable.Items.Add("Masculino");
                criterio_txt_combobox5_desplegable.Items.Add("Otra");

            }
            if (comboBox5_criterio.Text == "Edad del Artista")
            {

                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox5_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox5_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox5_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox5_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox5_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox5_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox5_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox5_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("Terror");
                criterio_txt_combobox5_desplegable.Items.Add("Crimen");
                criterio_txt_combobox5_desplegable.Items.Add("Accion");
                criterio_txt_combobox5_desplegable.Items.Add("Comedia");
                criterio_txt_combobox5_desplegable.Items.Add("Musical");
                criterio_txt_combobox5_desplegable.Items.Add("Drama");
                criterio_txt_combobox5_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox5_desplegable.Items.Add("Otra");

            }
            if (comboBox5_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox5_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox5_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox5_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox5_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox5_desplegable.Items.Add("Otra");
            }
            if (comboBox5_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox5_desplegable.Visible = false;

            }
            if (comboBox5_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox5_desplegable.Visible = false;


            }
            if (comboBox5_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox5_desplegable.Visible = false;


            }
            if (comboBox5_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox5_desplegable.Visible = false;


            }
            if (comboBox5_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox5_desplegable.Visible = false;


            }
            if (comboBox5_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox5_desplegable.Visible = false;


            }
            if (comboBox5_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox5_desplegable.Visible = true;
                criterio_txt_combobox5_desplegable.Items.Clear();
                criterio_txt_combobox5_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox5_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox5_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox5_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox5_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox5_desplegable.Items.Add("144p");
                criterio_txt_combobox5_desplegable.Items.Add("240p");
                criterio_txt_combobox5_desplegable.Items.Add("360p");
                criterio_txt_combobox5_desplegable.Items.Add("480p");
                criterio_txt_combobox5_desplegable.Items.Add("720p");
            }
            if (comboBox5_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox5_desplegable.Visible = false;



            }
            if (comboBox5_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox5_desplegable.Visible = false;


            }
            if (comboBox5_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox5_desplegable.Visible = false;

            }
            criterios.Remove(comboBox5_criterio.Text);
            criterios_seleccionados.Add(comboBox5_criterio.Text);
            foreach (string criterio in criterios)
            {
                comboBox6_criterio.Items.Add(criterio);
            }
            comboBox6_criterio.Enabled = true;
            comboBox5_criterio.Enabled = false;
            criterio_txt_combobox5.Enabled = true;
            if (criterio_txt_combobox4.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox4.Text);
            }
            else if (criterio_txt_combobox4_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox4_desplegable.Text);
            }
        }

        private void criterio_txt_combobox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("Rock");
                criterio_txt_combobox4_desplegable.Items.Add("Country");
                criterio_txt_combobox4_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox4_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox4_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox4_desplegable.Items.Add("House");
                criterio_txt_combobox4_desplegable.Items.Add("Disco");
                criterio_txt_combobox4_desplegable.Items.Add("Urban");
                criterio_txt_combobox4_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox4_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox4_desplegable.Items.Add("Pop");
                criterio_txt_combobox4_desplegable.Items.Add("Jazz");
                criterio_txt_combobox4_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox4_desplegable.Items.Add("Punk");
                criterio_txt_combobox4_desplegable.Items.Add("Otra");

            }
            if (comboBox4_criterio.Text == "Disquera")
            {

                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox4_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox4_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox4_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox4_desplegable.Items.Add("Otra");

            }
            if (comboBox4_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("Femenino");
                criterio_txt_combobox4_desplegable.Items.Add("Masculino");
                criterio_txt_combobox4_desplegable.Items.Add("Otra");

            }
            if (comboBox4_criterio.Text == "Edad del Artista")
            {

                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox4_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox4_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox4_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox4_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox4_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox4_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox4_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox4_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("Terror");
                criterio_txt_combobox4_desplegable.Items.Add("Crimen");
                criterio_txt_combobox4_desplegable.Items.Add("Accion");
                criterio_txt_combobox4_desplegable.Items.Add("Comedia");
                criterio_txt_combobox4_desplegable.Items.Add("Musical");
                criterio_txt_combobox4_desplegable.Items.Add("Drama");
                criterio_txt_combobox4_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox4_desplegable.Items.Add("Otra");

            }
            if (comboBox4_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox4_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox4_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox4_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox4_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox4_desplegable.Items.Add("Otra");
            }
            if (comboBox4_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox4_desplegable.Visible = false;

            }
            if (comboBox4_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox4_desplegable.Visible = false;


            }
            if (comboBox4_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox4_desplegable.Visible = false;


            }
            if (comboBox4_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox4_desplegable.Visible = false;


            }
            if (comboBox4_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox4_desplegable.Visible = false;


            }
            if (comboBox4_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox4_desplegable.Visible = false;


            }
            if (comboBox4_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox4_desplegable.Visible = true;
                criterio_txt_combobox4_desplegable.Items.Clear();
                criterio_txt_combobox4_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox4_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox4_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox4_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox4_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox4_desplegable.Items.Add("144p");
                criterio_txt_combobox4_desplegable.Items.Add("240p");
                criterio_txt_combobox4_desplegable.Items.Add("360p");
                criterio_txt_combobox4_desplegable.Items.Add("480p");
                criterio_txt_combobox4_desplegable.Items.Add("720p");
            }
            if (comboBox4_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox4_desplegable.Visible = false;



            }
            if (comboBox4_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox4_desplegable.Visible = false;


            }
            if (comboBox4_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox4_desplegable.Visible = false;

            }
            criterios.Remove(comboBox4_criterio.Text);
            criterios_seleccionados.Add(comboBox4_criterio.Text);
            foreach (string criterio in criterios)
            {
                comboBox5_criterio.Items.Add(criterio);
            }
            comboBox5_criterio.Enabled = true;
            comboBox4_criterio.Enabled = false;
            criterio_txt_combobox4.Enabled = true;
            if (criterio_txt_combobox3.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox3.Text);
            }
            else if (criterio_txt_combobox3_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox3_desplegable.Text);
            }
        }

        private void criterio_txt_combobox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("Rock");
                criterio_txt_combobox3_desplegable.Items.Add("Country");
                criterio_txt_combobox3_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox3_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox3_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox3_desplegable.Items.Add("House");
                criterio_txt_combobox3_desplegable.Items.Add("Disco");
                criterio_txt_combobox3_desplegable.Items.Add("Urban");
                criterio_txt_combobox3_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox3_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox3_desplegable.Items.Add("Pop");
                criterio_txt_combobox3_desplegable.Items.Add("Jazz");
                criterio_txt_combobox3_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox3_desplegable.Items.Add("Punk");
                criterio_txt_combobox3_desplegable.Items.Add("Otra");

            }
            if (comboBox3_criterio.Text == "Disquera")
            {

                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox3_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox3_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox3_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox3_desplegable.Items.Add("Otra");

            }
            if (comboBox3_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("Femenino");
                criterio_txt_combobox3_desplegable.Items.Add("Masculino");
                criterio_txt_combobox3_desplegable.Items.Add("Otra");

            }
            if (comboBox3_criterio.Text == "Edad del Artista")
            {

                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox3_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox3_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox3_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox3_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox3_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox3_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox3_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox3_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("Terror");
                criterio_txt_combobox3_desplegable.Items.Add("Crimen");
                criterio_txt_combobox3_desplegable.Items.Add("Accion");
                criterio_txt_combobox3_desplegable.Items.Add("Comedia");
                criterio_txt_combobox3_desplegable.Items.Add("Musical");
                criterio_txt_combobox3_desplegable.Items.Add("Drama");
                criterio_txt_combobox3_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox3_desplegable.Items.Add("Otra");

            }
            if (comboBox3_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox3_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox3_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox3_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox3_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox3_desplegable.Items.Add("Otra");
            }
            if (comboBox3_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox3_desplegable.Visible = false;

            }
            if (comboBox3_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox3_desplegable.Visible = false;


            }
            if (comboBox3_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox3_desplegable.Visible = false;


            }
            if (comboBox3_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox3_desplegable.Visible = false;


            }
            if (comboBox3_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox3_desplegable.Visible = false;


            }
            if (comboBox3_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox3_desplegable.Visible = false;


            }
            if (comboBox3_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox3_desplegable.Visible = true;
                criterio_txt_combobox3_desplegable.Items.Clear();
                criterio_txt_combobox3_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox3_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox3_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox3_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox3_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox3_desplegable.Items.Add("144p");
                criterio_txt_combobox3_desplegable.Items.Add("240p");
                criterio_txt_combobox3_desplegable.Items.Add("360p");
                criterio_txt_combobox3_desplegable.Items.Add("480p");
                criterio_txt_combobox3_desplegable.Items.Add("720p");
            }
            if (comboBox3_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox3_desplegable.Visible = false;



            }
            if (comboBox3_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox3_desplegable.Visible = false;


            }
            if (comboBox3_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox3_desplegable.Visible = false;

            }
            criterios.Remove(comboBox3_criterio.Text);
            criterios_seleccionados.Add(comboBox3_criterio.Text);
            foreach (string criterio in criterios)
            {
                comboBox4_criterio.Items.Add(criterio);
            }
            comboBox4_criterio.Enabled = true;
            comboBox3_criterio.Enabled = false;
            criterio_txt_combobox3.Enabled = true;
            if (criterio_txt_combobox2.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox2.Text);
            }
            else if (criterio_txt_combobox2_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox2_desplegable.Text);
            }
        }

        private void criterio_txt_combobox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("Rock");
                criterio_txt_combobox2_desplegable.Items.Add("Country");
                criterio_txt_combobox2_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox2_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox2_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox2_desplegable.Items.Add("House");
                criterio_txt_combobox2_desplegable.Items.Add("Disco");
                criterio_txt_combobox2_desplegable.Items.Add("Urban");
                criterio_txt_combobox2_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox2_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox2_desplegable.Items.Add("Pop");
                criterio_txt_combobox2_desplegable.Items.Add("Jazz");
                criterio_txt_combobox2_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox2_desplegable.Items.Add("Punk");
                criterio_txt_combobox2_desplegable.Items.Add("Otra");

            }
            if (comboBox2_criterio.Text == "Disquera")
            {

                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox2_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox2_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox2_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox2_desplegable.Items.Add("Otra");

            }
            if (comboBox2_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("Femenino");
                criterio_txt_combobox2_desplegable.Items.Add("Masculino");
                criterio_txt_combobox2_desplegable.Items.Add("Otra");

            }
            if (comboBox2_criterio.Text == "Edad del Artista")
            {

                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox2_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox2_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox2_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox2_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox2_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox2_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox2_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox2_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("Terror");
                criterio_txt_combobox2_desplegable.Items.Add("Crimen");
                criterio_txt_combobox2_desplegable.Items.Add("Accion");
                criterio_txt_combobox2_desplegable.Items.Add("Comedia");
                criterio_txt_combobox2_desplegable.Items.Add("Musical");
                criterio_txt_combobox2_desplegable.Items.Add("Drama");
                criterio_txt_combobox2_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox2_desplegable.Items.Add("Otra");

            }
            if (comboBox2_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox2_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox2_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox2_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox2_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox2_desplegable.Items.Add("Otra");
            }
            if (comboBox2_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox2_desplegable.Visible = false;

            }
            if (comboBox2_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox2_desplegable.Visible = false;


            }
            if (comboBox2_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox2_desplegable.Visible = false;


            }
            if (comboBox2_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox2_desplegable.Visible = false;


            }
            if (comboBox2_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox2_desplegable.Visible = false;


            }
            if (comboBox2_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox2_desplegable.Visible = false;


            }
            if (comboBox2_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox2_desplegable.Visible = true;
                criterio_txt_combobox2_desplegable.Items.Clear();
                criterio_txt_combobox2_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox2_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox2_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox2_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox2_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox2_desplegable.Items.Add("144p");
                criterio_txt_combobox2_desplegable.Items.Add("240p");
                criterio_txt_combobox2_desplegable.Items.Add("360p");
                criterio_txt_combobox2_desplegable.Items.Add("480p");
                criterio_txt_combobox2_desplegable.Items.Add("720p");
            }
            if (comboBox2_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox2_desplegable.Visible = false;



            }
            if (comboBox2_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox2_desplegable.Visible = false;


            }
            if (comboBox2_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox2_desplegable.Visible = false;

            }
            criterios.Remove(comboBox2_criterio.Text);
            criterios_seleccionados.Add(comboBox2_criterio.Text);
            foreach (string criterio in criterios)
            {
                comboBox3_criterio.Items.Add(criterio);
            }
            comboBox3_criterio.Enabled = true;
            comboBox2_criterio.Enabled = false;
            criterio_txt_combobox2.Enabled = true;
            if (criterio_txt_combobox1.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox1.Text);
            }
            else if (criterio_txt_combobox1_desplegable.Text != "")
            {
                criterios_introducidos.Add(criterio_txt_combobox1_desplegable.Text);
            }
        }

        private void criterio_txt_combobox1_TextChanged(object sender, EventArgs e)
        {
            //ACTIVATE ESTA
        }

        private void comboBox1_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_criterio.Text == "Genero Cancion")
            {
                desplegable = 0;
                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("Rock");
                criterio_txt_combobox1_desplegable.Items.Add("Country");
                criterio_txt_combobox1_desplegable.Items.Add("K-Pop");
                criterio_txt_combobox1_desplegable.Items.Add("Electrónica");
                criterio_txt_combobox1_desplegable.Items.Add("Heavy Metal");
                criterio_txt_combobox1_desplegable.Items.Add("House");
                criterio_txt_combobox1_desplegable.Items.Add("Disco");
                criterio_txt_combobox1_desplegable.Items.Add("Urban");
                criterio_txt_combobox1_desplegable.Items.Add("Folklorica");
                criterio_txt_combobox1_desplegable.Items.Add("Hip Hop");
                criterio_txt_combobox1_desplegable.Items.Add("Pop");
                criterio_txt_combobox1_desplegable.Items.Add("Jazz");
                criterio_txt_combobox1_desplegable.Items.Add("Indie Rock");
                criterio_txt_combobox1_desplegable.Items.Add("Punk");
                criterio_txt_combobox1_desplegable.Items.Add("Otra");

            }
            if (comboBox1_criterio.Text == "Disquera")
            {
                
                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("Sony Music");
                criterio_txt_combobox1_desplegable.Items.Add("Universal Music");
                criterio_txt_combobox1_desplegable.Items.Add("YG Entertainment");
                criterio_txt_combobox1_desplegable.Items.Add("SM Entretainment");
                criterio_txt_combobox1_desplegable.Items.Add("Otra");

            }
            if (comboBox1_criterio.Text == "Sexo del Artista")
            {

                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("Femenino");
                criterio_txt_combobox1_desplegable.Items.Add("Masculino");
                criterio_txt_combobox1_desplegable.Items.Add("Otra");

            }
            if (comboBox1_criterio.Text == "Edad del Artista")
            {
                
                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("Menores de 25 años");
                criterio_txt_combobox1_desplegable.Items.Add("De 25 a 40 años");
                criterio_txt_combobox1_desplegable.Items.Add("De 40 a 60 años");
                criterio_txt_combobox1_desplegable.Items.Add("Mayores de 60");

            }

            if (comboBox1_criterio.Text == "Categoria Pelicula")
            {
                desplegable = 3;
                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("Infantil (0 - 7 años)");
                criterio_txt_combobox1_desplegable.Items.Add("Infantil-Juvenil (7 - 16 años)");
                criterio_txt_combobox1_desplegable.Items.Add("Adolecente (16 - 18 años)");
                criterio_txt_combobox1_desplegable.Items.Add("Adulto (18+ años)");

            }
            if (comboBox1_criterio.Text == "Genero Video")
            {
                desplegable = 3;
                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("Terror");
                criterio_txt_combobox1_desplegable.Items.Add("Crimen");
                criterio_txt_combobox1_desplegable.Items.Add("Accion");
                criterio_txt_combobox1_desplegable.Items.Add("Comedia");
                criterio_txt_combobox1_desplegable.Items.Add("Musical");
                criterio_txt_combobox1_desplegable.Items.Add("Drama");
                criterio_txt_combobox1_desplegable.Items.Add("Ciencia Ficcion");
                criterio_txt_combobox1_desplegable.Items.Add("Otra");

            }
            if (comboBox1_criterio.Text == "Film Studio")
            {
                desplegable = 3;
                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("Universal Studio Pictures");
                criterio_txt_combobox1_desplegable.Items.Add("Sony Pictures");
                criterio_txt_combobox1_desplegable.Items.Add("YG Entertainment Pictures");
                criterio_txt_combobox1_desplegable.Items.Add("SM Entretainment Pictures");
                criterio_txt_combobox1_desplegable.Items.Add("Warner Bros Pictures");
                criterio_txt_combobox1_desplegable.Items.Add("Otra");
            }
            if (comboBox1_criterio.Text == "Cantante")
            {
                desplegable = 1;
                criterio_txt_combobox1_desplegable.Visible = false;

            }
            if (comboBox1_criterio.Text == "Compositor")
            {
                desplegable = 1;
                criterio_txt_combobox1_desplegable.Visible = false;


            }
            if (comboBox1_criterio.Text == "Director")
            {
                desplegable = 4;
                criterio_txt_combobox1_desplegable.Visible = false;


            }
            if (comboBox1_criterio.Text == "Actor")
            {
                desplegable = 4;
                criterio_txt_combobox1_desplegable.Visible = false;


            }
            if (comboBox1_criterio.Text == "Album")
            {
                desplegable = 1;
                criterio_txt_combobox1_desplegable.Visible = false;


            }
            if (comboBox1_criterio.Text == "Evaluacion")
            {
                desplegable = 6;
                criterio_txt_combobox1_desplegable.Visible = false;


            }
            if (comboBox1_criterio.Text == "Calidad/Resolucion")
            {
                desplegable = 5;
                criterio_txt_combobox1_desplegable.Visible = true;
                criterio_txt_combobox1_desplegable.Items.Clear();
                criterio_txt_combobox1_desplegable.Items.Add("96 kbps");
                criterio_txt_combobox1_desplegable.Items.Add("128 kbps");
                criterio_txt_combobox1_desplegable.Items.Add("160 kbps");
                criterio_txt_combobox1_desplegable.Items.Add("256 kbps");
                criterio_txt_combobox1_desplegable.Items.Add("320 kbps");
                criterio_txt_combobox1_desplegable.Items.Add("144p");
                criterio_txt_combobox1_desplegable.Items.Add("240p");
                criterio_txt_combobox1_desplegable.Items.Add("360p");
                criterio_txt_combobox1_desplegable.Items.Add("480p");
                criterio_txt_combobox1_desplegable.Items.Add("720p");
            }
            if (comboBox1_criterio.Text == "Nombre Cancion")
            {
                desplegable = 1;
                criterio_txt_combobox1_desplegable.Visible = false;



            }
            if (comboBox1_criterio.Text == "Nombre Pelicula")
            {
                desplegable = 4;
                criterio_txt_combobox1_desplegable.Visible = false;


            }
            if (comboBox1_criterio.Text == "Año de Publicacion")
            {
                desplegable = 6;
                criterio_txt_combobox1_desplegable.Visible = false;

            }
            criterios.Remove(comboBox1_criterio.Text);
            criterios_seleccionados.Add(comboBox1_criterio.Text);
            foreach (string criterio in criterios)
            {
                comboBox2_criterio.Items.Add(criterio);
            }
            comboBox2_criterio.Enabled = true;
            comboBox1_criterio.Enabled = false;
            criterio_txt_combobox1.Enabled = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //botonatras_busquedamultiple
            tabla_resultados_busqueda_multiple.Rows.Clear();
            panel_busqueda_multiple.Visible = false;
            criterio_txt_combobox1_desplegable.Items.Clear(); criterio_txt_combobox2_desplegable.Items.Clear();
            criterio_txt_combobox3_desplegable.Items.Clear(); criterio_txt_combobox4_desplegable.Items.Clear();
            criterio_txt_combobox5_desplegable.Items.Clear(); criterio_txt_combobox6_desplegable.Items.Clear();
            criterio_txt_combobox7_desplegable.Items.Clear(); criterio_txt_combobox8_desplegable.Items.Clear();
            criterio_txt_combobox2.Enabled = false; criterio_txt_combobox3.Enabled = false; criterio_txt_combobox4.Enabled = false;
            criterio_txt_combobox5.Enabled = false; criterio_txt_combobox6.Enabled = false; criterio_txt_combobox7.Enabled = false;
            criterio_txt_combobox8.Enabled = false;
            criterio_txt_combobox1_desplegable.Visible = false; criterio_txt_combobox2_desplegable.Visible = false; criterio_txt_combobox3_desplegable.Visible = false;
            criterio_txt_combobox4_desplegable.Visible = false; criterio_txt_combobox5_desplegable.Visible = false; criterio_txt_combobox6_desplegable.Visible = false;
            criterio_txt_combobox7_desplegable.Visible = false; criterio_txt_combobox8_desplegable.Visible = false;
            comboBox1_criterio.Enabled = true;
            comboBox1_criterio.Items.Clear(); comboBox2_criterio.Items.Clear(); comboBox3_criterio.Items.Clear(); comboBox4_criterio.Items.Clear();
            comboBox5_criterio.Items.Clear(); comboBox6_criterio.Items.Clear(); comboBox7_criterio.Items.Clear(); comboBox8_criterio.Items.Clear();
            criterio_txt_combobox1.Text = ""; criterio_txt_combobox2.Text = ""; criterio_txt_combobox3.Text = ""; criterio_txt_combobox4.Text = "";
            criterio_txt_combobox5.Text = ""; criterio_txt_combobox6.Text = ""; criterio_txt_combobox7.Text = ""; criterio_txt_combobox8.Text = "";
            criterio_txt_combobox1_desplegable.Text = ""; criterio_txt_combobox2_desplegable.Text = ""; criterio_txt_combobox3_desplegable.Text = "";
            criterio_txt_combobox4_desplegable.Text = ""; criterio_txt_combobox5_desplegable.Text = ""; criterio_txt_combobox6_desplegable.Text = "";
            criterio_txt_combobox7_desplegable.Text = ""; criterio_txt_combobox8_desplegable.Text = "";
            comboBox1_criterio.Text = ""; comboBox2_criterio.Text = ""; comboBox3_criterio.Text = ""; comboBox4_criterio.Text = "";
            comboBox5_criterio.Text = ""; comboBox6_criterio.Text = ""; comboBox7_criterio.Text = ""; comboBox8_criterio.Text = "";
            criterios.Clear();
            foreach (string criterio in Proyecto_Forms.ALAINID.lista_criterios_filtro2)
            {
                criterios.Add(criterio);
            }
            foreach (string criterio in criterios)
            {
                comboBox1_criterio.Items.Add(criterio);
            }
        }

        private void busquedasimple_criterio_text_SelectedValueChanged(object sender, EventArgs e)
        {
            //en vola en este
        }

        public string nombre_cancion_video_actual;
        public string nombre_cantante_director_actual;
        public Song cancionbuscada;
        public Video videobuscado;
        private void datagratview_busquedasimple_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {// evento doble click cancion buscador simple
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            nombre_cancion_video_actual = datagratview_busquedasimple.Rows[fila].Cells[0].Value.ToString();
            string nombre = nombre_cancion_video_actual;
            nombre_cantante_director_actual = datagratview_busquedasimple.Rows[fila].Cells[1].Value.ToString();
            string nombrea = nombre_cantante_director_actual;
            
            foreach (Song s in Proyecto_Forms.ALAINID.todas_las_canciones)
            {
                if ((s.Nombrecancion.ToLower() == nombre.ToLower()) && (s.Cantante.Name.ToLower() == nombrea.ToLower()))
                {
                    cantante_cancion_reproductor.Text = s.Cantante.Name;
                    nombrecancion_cancion_reproductor.Text = s.Nombrecancion;
                    compositor_cancion_reproductor.Text = s.Compositor.Name;
                    album_cancion_reproductor.Text = s.Album;
                    calificacion_cancion_reproductor.Text = s.Calificacionpromedio.ToString();
                    genero_cancion_reproductor.Text = s.Genero;
                    reproducciones_cancion_reproductor.Text = s.Reproducciones.ToString();

                    panel_cancion_seleccionada_busqueda_simple.Visible = true;
                    panel_cancion_seleccionada_busqueda_simple.Dock = DockStyle.Fill;
                    panel_busqueda_simple.Visible = false;
                    ruta = s.Nombrearchivo;
                    cancionbuscada = s;
                    axWindowsMediaPlayer2.URL = ruta;
                }
            }
            foreach (Video v in Proyecto_Forms.ALAINID.todos_los_videos)
            {
                if ((v.Nombre_video.ToLower() == nombre.ToLower()) && (v.Director.Name.ToLower() == nombrea.ToLower()))
                {
                    textBox_Nombre_Director.Text = v.Director.Name;
                    foreach(Artista actor in v.Actores)
                    {
                        int n = tabla_nombre_actores_reprod_video.Rows.Add();
                        tabla_nombre_actores_reprod_video.Rows[n].Cells[0].Value = actor.Name;
                    }
                    textBox_Calificacion.Text = v.Calificacion_promedio.ToString();
                    textBox_Año_Grabacion.Text = v.Anio_publicacion.ToString();
                    textBox_Reproducciones.Text = v.Reproduccion.ToString();

                    panel_video_seleccionado.Visible = true;
                    panel_video_seleccionado.Dock = DockStyle.Fill;
                    panel_busqueda_simple.Visible = false;
                    ruta = v.Nombrearchivovideo;
                    videobuscado = v;
                    axWindowsMediaPlayerVideo.URL = ruta;
                }
            }

            
        }
       
        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void ruta_cancion_reproducir_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {// atras panel reproducir cancion
            panel_cancion_seleccionada_busqueda_simple.Visible = false;
            panel_busqueda_multiple.Visible = false;
            panel_busqueda_simple.Visible = false;
            cantante_cancion_reproductor.Text = "";
            nombrecancion_cancion_reproductor.Text = "";
            compositor_cancion_reproductor.Text = "";
            album_cancion_reproductor.Text = "";
            calificacion_cancion_reproductor.Text = "";
            genero_cancion_reproductor.Text = "";
            reproducciones_cancion_reproductor.Text = "";
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();

        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();

        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.next();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            axWindowsMediaPlayer2.Ctlcontrols.previous();

        }
        //Panel reproductor video
        private void panel_video_seleccionado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_A_Favoritos_Click(object sender, EventArgs e)
        {
            Proyecto_Forms.ALAINID.Agregar_video_a_favoritos(Program.usuario_activo.Email_, videobuscado);
        }

        private void btnAgregar_A_Playlist_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_A_Cola_Click(object sender, EventArgs e)
        {

        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atrás_Click(object sender, EventArgs e)
        {//atras de reproducir video
            panel_video_seleccionado.Visible = false;
            panel_busqueda_multiple.Visible = false;
            panel_busqueda_simple.Visible = false;
            textBox_Nombre_Director.Text = "";
            tabla_nombre_actores_reprod_video.Rows.Clear();
            textBox_Calificacion.Text = "";
            textBox_Año_Grabacion.Text = "";
            textBox_Reproducciones.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_cancion_seleccionada_busqueda_simple_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_Video_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {//atras panel playlist usuario
            panel_playlist_usuario.Visible = false;

        }

        private void panel_playlist_usuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_atras_favoritos_Click(object sender, EventArgs e)
        {
            panel_favoritos_menu.Visible = false;
            tabla_favoritos_videos.Rows.Clear();
            tabla_favoritos_canciones.Rows.Clear();
        }

        private void btn_atras_social_Click(object sender, EventArgs e)
        {
            panel_social_menu.Visible = false;
        }

        private void btn_atras_karaoke_Click(object sender, EventArgs e)
        {
            panel_karaoke_menu.Visible = false;
        }

        private void btn_atras_historial_Click(object sender, EventArgs e)
        {
            panel_historial_menu.Visible = false;
        }

        private void btn_atras_descargas_Click(object sender, EventArgs e)
        {
            panel_descargas_menu.Visible = false;
        }

        private void btn_atras_listainteligente_menu_Click(object sender, EventArgs e)
        {
            panel_listainteligente_menu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {//btn crear play list
            if (comboBox_tipo_archivo_plylist.Text== "Video")
            {
                PlaylistVideo playlistVideo = new PlaylistVideo(nombreplaylist_text_playlist.Text);
                Program.usuario_activo.Lista_playlistvideousuario_.Add(playlistVideo);
            }
            if (comboBox_tipo_archivo_plylist.Text == "Cancion")
            {
                PlaylistSong playlistSong = new PlaylistSong(nombreplaylist_text_playlist.Text);
                Program.usuario_activo.Lista_playlistusuario_.Add(playlistSong);
            }
            tabla_playlist.Rows.Clear();
            foreach (PlaylistSong plys in Program.usuario_activo.Lista_playlistusuario_)
            {
                int n = tabla_playlist.Rows.Add();
                tabla_playlist.Rows[n].Cells[0].Value = plys.NombrePlaylist;
                tabla_playlist.Rows[n].Cells[1].Value = plys.Listplay.Count();
                tabla_playlist.Rows[n].Cells[1].Value = "Canciones";
            }
            foreach (PlaylistVideo plyv in Program.usuario_activo.Lista_playlistvideousuario_)
            {
                int n = tabla_playlist.Rows.Add();
                tabla_playlist.Rows[n].Cells[0].Value = plyv.NombrePlaylist;
                tabla_playlist.Rows[n].Cells[1].Value = plyv.Listplayvideo.Count();
                tabla_playlist.Rows[n].Cells[1].Value = "Videos";
            }
        }
        

        private void panel_favoritos_menu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void checkBox_busqueda_AND_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_busqueda_AND.Checked == true)
            {
                checkBox_busqueda_OR.Checked = false;
            }
        }

        private void checkBox_busqueda_OR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_busqueda_OR.Checked == true)
            {
                checkBox_busqueda_AND.Checked = false;
            }
        }

        private void btn_agregar_a_ply_Click(object sender, EventArgs e)
        {

        }

        private void btn_calificar_cancion_reproductor_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_a_favoritos_cancion_reproductor_Click(object sender, EventArgs e)
        {
           
            foreach(Song song in Proyecto_Forms.ALAINID.todas_las_canciones)
            {
                if (nombre_cancion_video_actual.ToLower()==song.Nombrecancion.ToLower() && nombre_cantante_director_actual.ToLower() == song.Cantante.Name.ToLower())
                {
                    Proyecto_Forms.ALAINID.Agregar_a_favoritos(Program.usuario_activo.Email_, song);
                }
            }
        }

        private void btn_agregar_a_la_cola_cancion_reproductor_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox1_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox2_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox3_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox4_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox5_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox6_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox7_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void criterio_txt_combobox8_desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atras_resultados_busqueda_multiple_Click(object sender, EventArgs e)
        {
            panel_resultados_busqueda_multiple.Visible = false;
            tabla_resultados_busqueda_multiple.Rows.Clear();
            criterio_txt_combobox1_desplegable.Items.Clear(); criterio_txt_combobox2_desplegable.Items.Clear();
            criterio_txt_combobox3_desplegable.Items.Clear(); criterio_txt_combobox4_desplegable.Items.Clear();
            criterio_txt_combobox5_desplegable.Items.Clear(); criterio_txt_combobox6_desplegable.Items.Clear();
            criterio_txt_combobox7_desplegable.Items.Clear(); criterio_txt_combobox8_desplegable.Items.Clear();
            criterio_txt_combobox2.Enabled = false; criterio_txt_combobox3.Enabled = false; criterio_txt_combobox4.Enabled = false;
            criterio_txt_combobox5.Enabled = false; criterio_txt_combobox6.Enabled = false; criterio_txt_combobox7.Enabled = false;
            criterio_txt_combobox8.Enabled = false;
            criterio_txt_combobox1_desplegable.Visible = false; criterio_txt_combobox2_desplegable.Visible = false; criterio_txt_combobox3_desplegable.Visible = false;
            criterio_txt_combobox4_desplegable.Visible = false; criterio_txt_combobox5_desplegable.Visible = false; criterio_txt_combobox6_desplegable.Visible = false;
            criterio_txt_combobox7_desplegable.Visible = false; criterio_txt_combobox8_desplegable.Visible = false;
            comboBox1_criterio.Enabled = true;
            comboBox1_criterio.Items.Clear(); comboBox2_criterio.Items.Clear(); comboBox3_criterio.Items.Clear(); comboBox4_criterio.Items.Clear();
            comboBox5_criterio.Items.Clear(); comboBox6_criterio.Items.Clear(); comboBox7_criterio.Items.Clear(); comboBox8_criterio.Items.Clear();
            comboBox1_criterio.Text = ""; comboBox2_criterio.Text = ""; comboBox3_criterio.Text = ""; comboBox4_criterio.Text = "";
            comboBox5_criterio.Text = ""; comboBox6_criterio.Text = ""; comboBox7_criterio.Text = ""; comboBox8_criterio.Text = "";
            criterio_txt_combobox1.Text = ""; criterio_txt_combobox2.Text = ""; criterio_txt_combobox3.Text = ""; criterio_txt_combobox4.Text = "";
            criterio_txt_combobox5.Text = ""; criterio_txt_combobox6.Text = ""; criterio_txt_combobox7.Text = ""; criterio_txt_combobox8.Text = "";
            criterio_txt_combobox1_desplegable.Text = ""; criterio_txt_combobox2_desplegable.Text = ""; criterio_txt_combobox3_desplegable.Text = "";
            criterio_txt_combobox4_desplegable.Text = ""; criterio_txt_combobox5_desplegable.Text = ""; criterio_txt_combobox6_desplegable.Text = "";
            criterio_txt_combobox7_desplegable.Text = ""; criterio_txt_combobox8_desplegable.Text = "";
            criterios.Clear();

            foreach (string criterio in Proyecto_Forms.ALAINID.lista_criterios_filtro2)
            {
                criterios.Add(criterio);
            }
            foreach (string criterio in criterios)
            {
                comboBox1_criterio.Items.Add(criterio);
            }
        }

        private void tabla_resultados_busqueda_multiple_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//doble click en resultado busqueda multiple
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            nombre_cancion_video_actual = tabla_resultados_busqueda_multiple.Rows[fila].Cells[0].Value.ToString();
            string nombre = nombre_cancion_video_actual;
            nombre_cantante_director_actual = tabla_resultados_busqueda_multiple.Rows[fila].Cells[1].Value.ToString();
            string nombrea = nombre_cantante_director_actual;

            foreach (Song s in Proyecto_Forms.ALAINID.todas_las_canciones)
            {
                if ((s.Nombrecancion.ToLower() == nombre.ToLower()) && (s.Cantante.Name.ToLower() == nombrea.ToLower()))
                {
                    cantante_cancion_reproductor.Text = s.Cantante.Name;
                    nombrecancion_cancion_reproductor.Text = s.Nombrecancion;
                    compositor_cancion_reproductor.Text = s.Compositor.Name;
                    album_cancion_reproductor.Text = s.Album;
                    calificacion_cancion_reproductor.Text = s.Calificacionpromedio.ToString();
                    genero_cancion_reproductor.Text = s.Genero;
                    reproducciones_cancion_reproductor.Text = s.Reproducciones.ToString();

                    panel_cancion_seleccionada_busqueda_simple.Visible = true;
                    panel_cancion_seleccionada_busqueda_simple.Dock = DockStyle.Fill;
                    panel_busqueda_multiple.Visible = false;
                    ruta = s.Nombrearchivo;
                    cancionbuscada = s;
                    axWindowsMediaPlayer2.URL = ruta;
                }
            }
            foreach (Video v in Proyecto_Forms.ALAINID.todos_los_videos)
            {
                if ((v.Nombre_video.ToLower() == nombre.ToLower()) && (v.Director.Name.ToLower() == nombrea.ToLower()))
                {
                    textBox_Nombre_Director.Text = v.Director.Name;
                    foreach (Artista actor in v.Actores)
                    {
                        int n = tabla_nombre_actores_reprod_video.Rows.Add();
                        tabla_nombre_actores_reprod_video.Rows[n].Cells[0].Value = actor.Name;
                    }
                    textBox_Calificacion.Text = v.Calificacion_promedio.ToString();
                    textBox_Año_Grabacion.Text = v.Anio_publicacion.ToString();
                    textBox_Reproducciones.Text = v.Reproduccion.ToString();

                    panel_video_seleccionado.Visible = true;
                    panel_video_seleccionado.Dock = DockStyle.Fill;
                    panel_busqueda_multiple.Visible = false;
                    ruta = v.Nombrearchivovideo;
                    videobuscado = v;
                    axWindowsMediaPlayerVideo.URL = ruta;
                }
            }
        }

        private void panel_resultados_busqueda_multiple_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public List<Artista> artistas_busqueda_social = new List<Artista>();
        public List<User> usuarios_busqueda_social = new List<User>();

        private void btn_buscar_en_social_Click(object sender, EventArgs e)
        {
            
            foreach(Artista actor in Proyecto_Forms.ALAINID.lista_actores)
            {
                var q = palabra_clave_buscar_social.Text.Any(w => actor.Name.Contains(w));
                var q1= palabra_clave_buscar_social.Text.Any(w => actor.Nacionality.Contains(w));
                int esta = 0;
                if (q == true || q1 == true)
                {
                    foreach (Artista artista in artistas_busqueda_social)
                    {
                        if (actor.Name == artista.Name)
                        {
                            esta = 1;
                        }
                    }
                    if (esta == 0)
                    {
                        artistas_busqueda_social.Add(actor);
                    }
                }
            }
            foreach (Artista director in Proyecto_Forms.ALAINID.lista_directores)
            {
                var q = palabra_clave_buscar_social.Text.Any(w => director.Name.Contains(w));
                var q1 = palabra_clave_buscar_social.Text.Any(w => director.Nacionality.Contains(w));
                int esta = 0;
                if (q == true || q1 == true)
                {
                    foreach (Artista artista in artistas_busqueda_social)
                    {
                        if (director.Name == artista.Name)
                        {
                            esta = 1;
                        }
                    }
                    if (esta == 0)
                    {
                        artistas_busqueda_social.Add(director);
                    }
                }
            }
            foreach (Artista cantante in Proyecto_Forms.ALAINID.lista_cantantes)
            {
                var q = palabra_clave_buscar_social.Text.Any(w => cantante.Name.Contains(w));
                var q1 = palabra_clave_buscar_social.Text.Any(w => cantante.Nacionality.Contains(w));
                int esta = 0;
                if (q == true || q1 == true)
                {
                    foreach (Artista artista in artistas_busqueda_social)
                    {
                        if (cantante.Name == artista.Name)
                        {
                            esta = 1;
                        }
                    }
                    if (esta == 0)
                    {
                        artistas_busqueda_social.Add(cantante);
                    }
                }
            }
            foreach (Artista compositor in Proyecto_Forms.ALAINID.lista_compositores)
            {
                var q = palabra_clave_buscar_social.Text.Any(w => compositor.Name.Contains(w));
                var q1 = palabra_clave_buscar_social.Text.Any(w => compositor.Nacionality.Contains(w));
                int esta = 0;
                if (q == true || q1 == true)
                {
                    foreach (Artista artista in artistas_busqueda_social)
                    {
                        if (compositor.Name == artista.Name)
                        {
                            esta = 1;
                        }
                    }
                    if (esta==0)
                    {
                        artistas_busqueda_social.Add(compositor);
                    }
                }
            }

            foreach(User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                var q = palabra_clave_buscar_social.Text.Any(w => user.Email_.Contains(w));
                var q1 = palabra_clave_buscar_social.Text.Any(w => user.Nombreusuario.Contains(w));
                var q2 = palabra_clave_buscar_social.Text.Any(w => user.Nombre_.Contains(w));
                if (q == true || q1 == true)
                {
                   
                    usuarios_busqueda_social.Add(user);
                }
            }
            foreach(Artista artista in artistas_busqueda_social)
            {
                int n = tabla_resultados_busqueda_social.Rows.Add();
                tabla_resultados_busqueda_social.Rows[n].Cells[0].Value = artista.Name;
                tabla_resultados_busqueda_social.Rows[n].Cells[1].Value = "Artista";
            }
            foreach (User user in usuarios_busqueda_social)
            {
                int n = tabla_resultados_busqueda_social.Rows.Add();
                tabla_resultados_busqueda_social.Rows[n].Cells[0].Value = user.Email_;
                tabla_resultados_busqueda_social.Rows[n].Cells[1].Value = "Usuario";
            }

        }
        public string email_persona_seguir_social;
        public string tipo_persona_seguir_social;

        private void tabla_resultados_busqueda_social_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//doble click en ver usuario para seguir social
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            int fila = e.RowIndex;
            email_persona_seguir_social = tabla_resultados_busqueda_social.Rows[fila].Cells[0].Value.ToString();
            tipo_persona_seguir_social = tabla_resultados_busqueda_social.Rows[fila].Cells[1].Value.ToString();
            
            if (tipo_persona_seguir_social == "Usuario")
            {
                panel_ver_usuario_busqueda_social.Visible = true;
                panel_ver_usuario_busqueda_social.Dock = DockStyle.Fill;
                foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
                {
                    if (user.Email_== email_persona_seguir_social)
                    {
                        social_nombre_user_busqueda.Text = user.Nombre_;
                        social_email_user_busqueda.Text = user.Email_;
                        social_usuario_user_busqueda.Text = user.Nombreusuario;

                    }
                }
                
            }
            if (tipo_persona_seguir_social== "Artista")
            {
                foreach (Artista act in Proyecto_Forms.ALAINID.lista_actores)
                {
                    if (act.Name == email_persona_seguir_social)
                    {
                        social_edad_artista.Text = act.Age.ToString();
                        social_naconalidad_artista.Text = act.Nacionality;
                        social_nombre_artista.Text = act.Name;
                        social_sexo_artista.Text = act.Sexo;
                        social_tipo_artista.Text = "Actor: ";
                    }
                }
                foreach (Artista dir in Proyecto_Forms.ALAINID.lista_directores)
                {
                    if (dir.Name == email_persona_seguir_social)
                    {
                        social_edad_artista.Text = dir.Age.ToString();
                        social_naconalidad_artista.Text = dir.Nacionality;
                        social_nombre_artista.Text = dir.Name;
                        social_sexo_artista.Text = dir.Sexo;
                        social_tipo_artista.Text = "Director: ";
                    }
                }
                foreach (Artista comp in Proyecto_Forms.ALAINID.lista_compositores)
                {
                    if (comp.Name == email_persona_seguir_social)
                    {
                        social_edad_artista.Text = comp.Age.ToString();
                        social_naconalidad_artista.Text = comp.Nacionality;
                        social_nombre_artista.Text = comp.Name;
                        social_sexo_artista.Text = comp.Sexo;
                        social_tipo_artista.Text = "Compositor: ";
                    }
                }
            }
            foreach (Artista cant in Proyecto_Forms.ALAINID.lista_cantantes)
                {
                    if (cant.Name == email_persona_seguir_social)
                    {
                        social_edad_artista.Text = cant.Age.ToString();
                        social_naconalidad_artista.Text = cant.Nacionality;
                        social_nombre_artista.Text = cant.Name;
                        social_sexo_artista.Text = cant.Sexo;
                        social_tipo_artista.Text = "Cantante: ";
                    }
                }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//atras ver usuario busqueda social
            panel_ver_usuario_busqueda_social.Visible = false;
        }
        private void btn_seguir_usuario_Click(object sender, EventArgs e)
        {
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                if (user.Email_ == social_email_user_busqueda.Text)
                {
                    Program.usuario_activo.Usuarios_seguidos_.Add(user);
                    MessageBox.Show("Usuario Seguido Exitosamente", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {// atras ver artista
            panel_ver_artista_busqueda_social.Visible = false;
        }

        private void btn_seguir_artista_Click(object sender, EventArgs e)
        {
            foreach (Artista act in Proyecto_Forms.ALAINID.lista_actores)
            {
                if (act.Name == social_email_user_busqueda.Text)
                {
                    Program.usuario_activo.Artistas_seguidos_.Add(act);
                    MessageBox.Show("Actor Seguido Exitosamente", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);

                }

            }
            foreach (Artista dir in Proyecto_Forms.ALAINID.lista_directores)
            {
                if (dir.Name == social_email_user_busqueda.Text)
                {
                    Program.usuario_activo.Artistas_seguidos_.Add(dir);
                    MessageBox.Show("Director Seguido Exitosamente", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);

                }

            }
            foreach (Artista comp in Proyecto_Forms.ALAINID.lista_compositores)
            {
                if (comp.Name == social_email_user_busqueda.Text)
                {
                    Program.usuario_activo.Artistas_seguidos_.Add(comp);
                    MessageBox.Show("Compositor Seguido Exitosamente", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);

                }

            }
            foreach (Artista cant in Proyecto_Forms.ALAINID.lista_cantantes)
            {
                if (cant.Name == social_email_user_busqueda.Text)
                {
                    Program.usuario_activo.Artistas_seguidos_.Add(cant);
                    MessageBox.Show("Cantante Seguido Exitosamente", "Seguir", MessageBoxButtons.OK, MessageBoxIcon.None);

                }

            }

        }
    }
}
