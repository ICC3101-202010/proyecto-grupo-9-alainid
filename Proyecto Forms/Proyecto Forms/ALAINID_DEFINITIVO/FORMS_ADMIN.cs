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
using System.Windows.Forms.VisualStyles;

namespace ALAINID_DEFINITIVO
{
    public partial class FORMS_ADMIN : Form
    {
        Admin a = new Admin();
        public FORMS_ADMIN()
        {
            InitializeComponent();
        }
        // CERRAR SESION MENU ARRIBA
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Program.forms_inicio.Show();
        }
        // MENU PANEL PRINCIPAL ADMIN 
        private void btn_agregar_cancion_admin_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_admin.Visible = true;
            panel_agregar_cancion_admin.Dock = DockStyle.Fill;
        }

        private void btn_agregar_video_admin_Click(object sender, EventArgs e)
        {
            panel_agregar_video_admin.Visible = true;
            panel_agregar_video_admin.Dock = DockStyle.Fill;
        }

        private void btn_agregar_cancion_karaoke_admin_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke_admin.Visible = true;
            panel_agregar_cancion_karaoke_admin.Dock = DockStyle.Fill;
        }

        private void btn_ver_usuarios_admin_Click(object sender, EventArgs e)
        {
            panel_ver_usuarios_admin.Visible = true;
            panel_ver_usuarios_admin.Dock = DockStyle.Fill;
        }


        // PANEL AGREGAR CANCION ADMIN ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void panel_agregar_cancion_admin_Paint(object sender, PaintEventArgs e)
        {

        }
        //DATOS CANTANTE
        private void nombre_cancion_txt_agregar_cancion_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombrecantante_txt_agregar_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexocantante_txt_agregar_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edadcantante_txt_agregar_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void nacionalidadcantante_txt_agregar_admin_TextChanged(object sender, EventArgs e)
        {

        }
        //DATOS COMPOSITOR
        private void nombrecompositor_txt_agregar_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexocompositor_txt_agregar_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edadcompositor_txt_agregar_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void nacionalidad_txt_agregar_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void album_txt_agregar_cancion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anopublic_txt_agregar_cancion_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn_subir_cancion_admin_Click(object sender, EventArgs e)
        {
            
            Artista cantante = new Artista(nombrecantante_txt_agregar_admin.Text, int.Parse(edadcantante_txt_agregar_admin.Text), sexocantante_txt_agregar_admin.Text, nacionalidadcantante_txt_agregar_admin.Text);
            Artista compositor = new Artista(nombrecompositor_txt_agregar_admin.Text, int.Parse(edadcompositor_txt_agregar_admin.Text), sexocompositor_txt_agregar_admin.Text, nacionalidad_txt_agregar_admin.Text);
            ALAINID.Activarlistacanciones();
            ALAINID.Activarlistacantantes();
            ALAINID.Partirlistacompositores();
            ALAINID.Partirlistaalbumes();
            a.AgregarSong(nombre_cancion_txt_agregar_cancion.Text, cantante, comboBox3.Text, compositor, anopublic_txt_agregar_cancion.Text, comboBox4.Text, album_txt_agregar_cancion.Text, ruta_cancion);
        }
        private void checkBox_repetir_cantante_como_compositor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_repetir_cantante_como_compositor.Checked == true)
            {
                nombrecompositor_txt_agregar_admin.Text = nombrecantante_txt_agregar_admin.Text;
                edadcompositor_txt_agregar_admin.Text = edadcantante_txt_agregar_admin.Text;
                sexocompositor_txt_agregar_admin.Text = sexocantante_txt_agregar_admin.Text;
                nacionalidad_txt_agregar_admin.Text = nacionalidadcantante_txt_agregar_admin.Text;
                nombrecompositor_txt_agregar_admin.Enabled = false;
                edadcompositor_txt_agregar_admin.Enabled = false;
                sexocompositor_txt_agregar_admin.Enabled = false;
                nacionalidad_txt_agregar_admin.Enabled = false;
               
            }
            if (checkBox_repetir_cantante_como_compositor.Checked == false)
            {
                nombrecompositor_txt_agregar_admin.Enabled = true;
                edadcompositor_txt_agregar_admin.Enabled = true;
                sexocompositor_txt_agregar_admin.Enabled = true;
                nacionalidad_txt_agregar_admin.Enabled = true;
            }
        }
        public string ruta_cancion;
        private void ruta_archivo_cancion_txt_subir_cancion_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_importar_cancion_admin_Click(object sender, EventArgs e)
        {
            openfile_subircancion_admin.ShowDialog();
            if (openfile_subircancion_admin.ShowDialog() == DialogResult.OK)
            {
                ruta_archivo_cancion_txt_subir_cancion.Text = openfile_subircancion_admin.FileName;
            }
        }

        private void cancionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_admin.Visible = true;
            panel_agregar_cancion_admin.Dock = DockStyle.Fill;
        }

        private void btn_atras_de_agregar_cancion_admin_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_admin.Visible = false;
        }


        ///////////AGREGAR VIDEO ADMIN///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void nombrevideo_agregar_video_admin_TextChanged(object sender, EventArgs e)
        {

        }
                        //AGREGAR DIRECTOR EN AGREGAR VIDEO ADMIN
        private void nombredirector_agregar_video_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void edaddirector_agregar_video_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexodirector_agregar_video_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nacionalidaddirector_agregar_video_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_agregar_video_admin_Paint(object sender, PaintEventArgs e)
        {
            //NO BORRAR
        }

        private void generovideo_agregar_video_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoriavideo_agregar_video_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filmstudiovideo_agregar_video_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aniopubvideo_agregar_video_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_importar_video_agregar_video_admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_atras_de_agregar_video_admin_Click(object sender, EventArgs e)
        {
            panel_agregar_video_admin.Visible = false;
        }

        private void btn_subir_video_de_agregar_video_admin_Click(object sender, EventArgs e)
        {

        }

        private void videosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_agregar_video_admin.Visible = true;
            panel_agregar_video_admin.Dock = DockStyle.Fill;
        }



        private void FORMS_ADMIN_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ALAINID.listausuarios.Count; i++)
            {
                lista_usuarios_admin.Items.Add(ALAINID.listausuarios[i].InformacionUsuariopriv());
            }

            //no borrar
        }

        // CREAR CANCION KARAOKE ADMIN////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void nombrecancionkaraoke_agregar_cancion_karaoke_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombrecantantecancionkaraoke_agregar_cancion_karaoke_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexocantantecancionkaraoke_agregar_cancion_karaoke_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edadcantantecancionkaraoke_agregar_cancion_karaoke_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void nacionalidadcantantecancionkaraoke_agregar_cancion_karaoke_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombrecompositorcancionkaraoke_agregar_cancion_karaoke_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexocompositorcancionkaraoke_agregar_cancion_karaoke_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edadcompositorcancionkaraoke_agregar_cancion_karaoke_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void nacionalidadcompositorcancionkaraoke_agregar_cancion_karaoke_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void generocancionkaraoke_agregar_cancion_karaoke_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_subir_cancion_de_agregar_cancion_karaoke_admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_importar_video_de_cancion_karaoke_en_agregar_cancion_karaoke_admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_atras_de_agregar_cancion_karaoke_admin_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke_admin.Visible = false;
        }

        private void cancionesKaraokeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke_admin.Visible = true;
            panel_agregar_cancion_karaoke_admin.Dock = DockStyle.Fill;

        }

        // VER USUARIOS ADMIN ======================================================================================================================================================================================
        private void panel_ver_usuarios_admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_atras_de_ver_usuarios_admin_Click(object sender, EventArgs e)
        {
            panel_ver_usuarios_admin.Visible = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_ver_usuarios_admin.Visible = true;
            panel_ver_usuarios_admin.Dock = DockStyle.Fill;

        }

        private void lista_usuarios_admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_atras_de_ver_artistas_admin_Click(object sender, EventArgs e)
        {
            panel_ver_artistas_admin.Visible = false;
        }

        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_ver_artistas_admin.Visible = true; ;
        }

        private void cerrarSesionYSalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Program.forms_inicio.Show();
            Application.Exit();
        }

        
    }  
}