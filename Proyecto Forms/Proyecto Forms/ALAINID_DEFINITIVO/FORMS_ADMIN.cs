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
using System.Media;
using System.IO;
using System.Reflection;
using System.Resources;


namespace ALAINID_DEFINITIVO
{
    public partial class FORMS_ADMIN : Form
    {
        int f;
        int c;
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
            panel_agregar_cancion_karaoke.Visible = true;
            panel_agregar_cancion_karaoke.Dock = DockStyle.Fill;
        }

        private void btn_ver_usuarios_admin_Click(object sender, EventArgs e)
        {
            panel_ver_usuarios_admin.Visible = true;
            panel_ver_usuarios_admin.Dock = DockStyle.Fill;
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                int n = tabla_usuarios_admin.Rows.Add();
                tabla_usuarios_admin.Rows[n].Cells[0].Value = user.Nombreusuario;
                tabla_usuarios_admin.Rows[n].Cells[1].Value = user.Nombre_;
                tabla_usuarios_admin.Rows[n].Cells[2].Value = user.Email_;
                tabla_usuarios_admin.Rows[n].Cells[3].Value = user.Password_;
                tabla_usuarios_admin.Rows[n].Cells[4].Value = user.Perfipublico_;
                tabla_usuarios_admin.Rows[n].Cells[5].Value = user.Premium_;
            }
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
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            a.AgregarSong(nombre_cancion_txt_agregar_cancion.Text, cantante, comboBox3.Text, compositor, anopublic_txt_agregar_cancion.Text, comboBox4.Text, album_txt_agregar_cancion.Text, ruta_cancion);
            nombre_cancion_txt_agregar_cancion.Text = "";
            nombrecompositor_txt_agregar_admin.Text = "";
            edadcompositor_txt_agregar_admin.Text = "";
            sexocompositor_txt_agregar_admin.Text = "";
            nacionalidad_txt_agregar_admin.Text = "";
            nombrecantante_txt_agregar_admin.Text = "";
            edadcantante_txt_agregar_admin.Text = "";
            sexocantante_txt_agregar_admin.Text = "";
            nacionalidadcantante_txt_agregar_admin.Text = "";
            comboBox3.Text = "";
            anopublic_txt_agregar_cancion.Text = "";
            comboBox4.Text = "";
            album_txt_agregar_cancion.Text = "";
            ruta_cancion = "";
            ruta_archivo_cancion_txt_subir_cancion.Text = "";
            checkBox_repetir_cantante_como_compositor .Checked = false;

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
        {//txt

        }
        private void btn_importar_cancion_admin_Click(object sender, EventArgs e)
        {
            if (openfile_subircancion_admin.ShowDialog() == DialogResult.OK)
            {
                ruta_archivo_cancion_txt_subir_cancion.Text = openfile_subircancion_admin.FileName;
                ruta_cancion = openfile_subircancion_admin.FileName;
            }
        }

        private void cancionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
            panel_agregar_video_admin.Visible = false;
            panel_ver_artistas.Visible = false;
            panel_ver_usuarios_admin.Visible = false;
            panel_ver_canciones_karaoke.Visible = false;
            panel_ver_canciones_admin.Visible = false;
            panel_ver_videos_admin.Visible = false;
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
        public string ruta_video;
        private void btn_importar_video_agregar_video_admin_Click(object sender, EventArgs e)
        {
            if (openfile_subirvideo_admin.ShowDialog() == DialogResult.OK)
            {
                archivo_video_importar_video.Text = openfile_subirvideo_admin.FileName;
                ruta_video = openfile_subirvideo_admin.FileName;
            }
        }

        private void btn_atras_de_agregar_video_admin_Click(object sender, EventArgs e)
        {
            panel_agregar_video_admin.Visible = false;
        }

        private void btn_subir_video_de_agregar_video_admin_Click(object sender, EventArgs e)
        {
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            Artista director = new Artista(nombredirector_agregar_video_admin.Text, int.Parse(edaddirector_agregar_video_admin.Text), sexodirector_agregar_video_admin.Text, nacionalidaddirector_agregar_video_admin.Text);
            List<Artista> actores = new List<Artista>();
            int existe = 0;
            for (int i = 0; i < tabla_agregar_actores_en_video.Rows.Count-1; i++)
            {
                string nombre_act = tabla_agregar_actores_en_video.Rows[i].Cells[0].Value.ToString();
                string edad_actor = tabla_agregar_actores_en_video.Rows[i].Cells[1].Value.ToString();
                string sexo_actor = tabla_agregar_actores_en_video.Rows[i].Cells[2].Value.ToString();
                string naci_actor = tabla_agregar_actores_en_video.Rows[i].Cells[3].Value.ToString();
                Artista actor = new Artista(nombre_act, int.Parse(edad_actor), sexo_actor, naci_actor);

                foreach (Artista act in Proyecto_Forms.ALAINID.lista_actores)
                {
                    if (act.Name.ToLower() == nombre_act.ToLower() && act.Nacionality.ToLower() == naci_actor.ToLower())
                    {
                        existe = 1;
                        actores.Add(act);
                    }
                }
                if (existe != 1)
                {
                    actores.Add(actor);
                    Proyecto_Forms.ALAINID.lista_actores.Add(actor);
                }
            }

            a.Subir_video(actores, nombrevideo_agregar_video_admin.Text, categoriavideo_agregar_video_admin.Text, director, generovideo_agregar_video_admin.Text, aniopubvideo_agregar_video_admin.Text, filmstudiovideo_agregar_video_admin.Text, ruta_video);
            archivo_video_importar_video.Text = "";
            nombrevideo_agregar_video_admin.Text = "";
            categoriavideo_agregar_video_admin.Text = "";
            generovideo_agregar_video_admin.Text = "";
            aniopubvideo_agregar_video_admin.Text = "";
            filmstudiovideo_agregar_video_admin.Text = "";
            nombredirector_agregar_video_admin.Text = "";
            edaddirector_agregar_video_admin.Text = "";
            sexodirector_agregar_video_admin.Text = "";
            nacionalidaddirector_agregar_video_admin.Text = "";
            ruta_video = "";
        }

        private void videosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
            panel_agregar_cancion_admin.Visible = false;
            panel_ver_artistas.Visible = false;
            panel_ver_usuarios_admin.Visible = false;
            panel_ver_canciones_karaoke.Visible = false;
            panel_ver_canciones_admin.Visible = false;
            panel_ver_videos_admin.Visible = false;
            panel_agregar_video_admin.Visible = true;
            panel_agregar_video_admin.Dock = DockStyle.Fill;
        }



        private void FORMS_ADMIN_Load(object sender, EventArgs e)
        {
            /*for (int i = 0; i < ALAINID.listausuarios.Count; i++)
            {
                lista_usuarios_admin.Items.Add(ALAINID.listausuarios[i].InformacionUsuariopriv());
            }*/

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
        private void cancionesKaraokeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_agregar_video_admin.Visible = false;
            panel_agregar_cancion_admin.Visible = false;
            panel_ver_artistas.Visible = false;
            panel_ver_usuarios_admin.Visible = false;
            panel_ver_canciones_karaoke.Visible = false;
            panel_ver_canciones_admin.Visible = false;
            panel_ver_videos_admin.Visible = false;
            panel_agregar_cancion_karaoke.Visible = true;
            panel_agregar_cancion_karaoke.Dock = DockStyle.Fill;
        }
        // VER USUARIOS ADMIN ======================================================================================================================================================================================
        private void panel_ver_usuarios_admin_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btn_atras_de_ver_usuarios_admin_Click(object sender, EventArgs e)
        {
            tabla_usuarios_admin.Rows.Clear();
            panel_ver_usuarios_admin.Visible = false;
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
            panel_agregar_video_admin.Visible = false;
            panel_agregar_cancion_admin.Visible = false;
            panel_ver_artistas.Visible = false;
            panel_ver_canciones_karaoke.Visible = false;
            panel_ver_videos_admin.Visible = false;
            panel_ver_canciones_admin.Visible = false;
            panel_ver_usuarios_admin.Visible = true;
            panel_ver_usuarios_admin.Dock = DockStyle.Fill;
            foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
            {
                int n = tabla_usuarios_admin.Rows.Add();
                tabla_usuarios_admin.Rows[n].Cells[0].Value = user.Nombreusuario;
                tabla_usuarios_admin.Rows[n].Cells[1].Value = user.Nombre_;
                tabla_usuarios_admin.Rows[n].Cells[2].Value = user.Email_;
                tabla_usuarios_admin.Rows[n].Cells[3].Value = user.Password_;
                tabla_usuarios_admin.Rows[n].Cells[4].Value = user.Perfipublico_;
                tabla_usuarios_admin.Rows[n].Cells[5].Value = user.Premium_;
            }
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
        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
            panel_agregar_video_admin.Visible = false;
            panel_agregar_cancion_admin.Visible = false;
            panel_ver_usuarios_admin.Visible = false;
            panel_ver_canciones_karaoke.Visible = false;
            panel_ver_videos_admin.Visible = false;
            panel_ver_canciones_admin.Visible = false;
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.CargarActores();//??????
            panel_ver_artistas.Visible = true;
            panel_ver_artistas.Dock = DockStyle.Fill;
            foreach(Artista cantante in Proyecto_Forms.ALAINID.lista_cantantes)
            {
                int n = tabla_ver_cantantes_admin.Rows.Add();
                tabla_ver_cantantes_admin.Rows[n].Cells[0].Value = cantante.Name;
                tabla_ver_cantantes_admin.Rows[n].Cells[1].Value = cantante.Age;
                tabla_ver_cantantes_admin.Rows[n].Cells[2].Value = cantante.Nacionality;
                tabla_ver_cantantes_admin.Rows[n].Cells[3].Value = cantante.Sexo;
            }
            foreach (Artista comp in Proyecto_Forms.ALAINID.lista_compositores)
            {
                int n = tabla_ver_compositores_admin.Rows.Add();
                tabla_ver_compositores_admin.Rows[n].Cells[0].Value = comp.Name;
                tabla_ver_compositores_admin.Rows[n].Cells[1].Value = comp.Age;
                tabla_ver_compositores_admin.Rows[n].Cells[2].Value = comp.Nacionality;
                tabla_ver_compositores_admin.Rows[n].Cells[3].Value = comp.Sexo;
            }
            foreach (Artista actor in Proyecto_Forms.ALAINID.lista_actores)
            {
                int n = tabla_ver_actores_admin.Rows.Add();
                tabla_ver_actores_admin.Rows[n].Cells[0].Value = actor.Name;
                tabla_ver_actores_admin.Rows[n].Cells[1].Value = actor.Age;
                tabla_ver_actores_admin.Rows[n].Cells[2].Value = actor.Nacionality;
                tabla_ver_actores_admin.Rows[n].Cells[3].Value = actor.Sexo;
            }
            foreach (Artista dir in Proyecto_Forms.ALAINID.lista_directores)
            {
                int n = tabla_ver_directores_admin.Rows.Add();
                tabla_ver_directores_admin.Rows[n].Cells[0].Value = dir.Name;
                tabla_ver_directores_admin.Rows[n].Cells[1].Value = dir.Age;
                tabla_ver_directores_admin.Rows[n].Cells[2].Value = dir.Nacionality;
                tabla_ver_directores_admin.Rows[n].Cells[3].Value = dir.Sexo;
            }
        }
        private void cerrarSesionYSalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Program.forms_inicio.Show();
            Application.Exit();
        }
        private void tabla_usuarios_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            f = e.RowIndex;
            c = e.ColumnIndex;
        }
        private void tabla_usuarios_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_editar_usuarios_admin_Click(object sender, EventArgs e)
        {
            int fil = tabla_usuarios_admin.RowCount;
            int col = tabla_usuarios_admin.ColumnCount;
            tabla_usuarios_admin.ReadOnly = false;
            for (int i = 1; i < fil; i++)
            {
                for (int ii = 1; ii < col; ii++)
                {
                    if (ii != 2)
                    {
                        tabla_usuarios_admin.Rows[i].Cells[ii].ReadOnly = false;
                    }
                }
            }
        }
        private void btn_guardar_usuarios_admin_Click(object sender, EventArgs e)
        {
            f = tabla_usuarios_admin.Rows.Count;
            c = tabla_usuarios_admin.Columns.Count;/*
            foreach (User user1 in Proyecto_Forms.ALAINID.listausuarios) 
            { 
            }
            Proyecto_Forms.ALAINID.Cambiarcontrasena(Program.usuario_activo.Email_, Program.usuario_activo.Password_, pass_txt_perfil_usuario.Text);
            bool name = Proyecto_Forms.ALAINID.Cambiarnombreusuario(Program.usuario_activo.Email_, Program.usuario_activo.Password_, nombredeusuario_txt_perfil_usuario.Text);
            Proyecto_Forms.ALAINID.Cambiarnombre(Program.usuario_activo.Email_, Program.usuario_activo.Password_, nombrecompleto_txt_perfil_usuario.Text);
            Program.usuario_activo.Password_ = pass_txt_perfil_usuario.Text;
            Program.usuario_activo.Nombre_ = nombrecompleto_txt_perfil_usuario.Text;
            if (name == true)
            {
                Program.usuario_activo.Nombreusuario = nombredeusuario_txt_perfil_usuario.Text;
            }*/
            if (f != -1)
            {
                switch (c)
                {
                    case 1:
                        foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
                        {
                            if ((string)tabla_usuarios_admin.Rows[f].Cells[3].Value == user.Email_)
                            {
                                user.Nombreusuario = (string)tabla_usuarios_admin.Rows[f].Cells[1].Value;
                                Proyecto_Forms.ALAINID.Almacenar(Proyecto_Forms.ALAINID.listausuarios);
                            }
                        }
                        break;
                    case 2:
                        foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
                        {
                            if ((string)tabla_usuarios_admin.Rows[f].Cells[2].Value == user.Email_)
                            {
                                user.Nombre_ = (string)tabla_usuarios_admin.Rows[f].Cells[1].Value;
                                Proyecto_Forms.ALAINID.Almacenar(Proyecto_Forms.ALAINID.listausuarios);
                            }
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
                        {
                            if ((string)tabla_usuarios_admin.Rows[f].Cells[2].Value == user.Email_)
                            {
                                user.Password_ = (string)tabla_usuarios_admin.Rows[f].Cells[3].Value;
                                Proyecto_Forms.ALAINID.Almacenar(Proyecto_Forms.ALAINID.listausuarios);
                            }
                        }
                        break;
                    case 5:
                        foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
                        {
                            if ((string)tabla_usuarios_admin.Rows[f].Cells[4].Value == user.Email_)
                            {
                                user.Perfipublico_ = (string)tabla_usuarios_admin.Rows[f].Cells[4].Value;
                                Proyecto_Forms.ALAINID.Almacenar(Proyecto_Forms.ALAINID.listausuarios);
                            }
                        }
                        break;
                    case 6:
                        foreach (User user in Proyecto_Forms.ALAINID.listausuarios)
                        {
                            if ((string)tabla_usuarios_admin.Rows[f].Cells[4].Value == user.Email_)
                            {
                                user.Premium_ = (string)tabla_usuarios_admin.Rows[f].Cells[5].Value;
                                Proyecto_Forms.ALAINID.Almacenar(Proyecto_Forms.ALAINID.listausuarios);
                            }
                        }
                        break;
                }
            }
            int fil = tabla_usuarios_admin.RowCount;
            int col = tabla_usuarios_admin.ColumnCount;
            tabla_usuarios_admin.ReadOnly = true;
            for (int i = 1; i < fil; i++)
            {
                for (int ii = 1; ii < col; ii++)
                {
                    if (ii != 2)
                    {
                        tabla_usuarios_admin.Rows[i].Cells[ii].ReadOnly = true;
                    }
                }
            }
        }

        private void openfile_subircancion_admin_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
            panel_agregar_video_admin.Visible = false;
            panel_agregar_cancion_admin.Visible = false;
            panel_ver_artistas.Visible = false;
            panel_ver_usuarios_admin.Visible = false;
            panel_ver_canciones_karaoke.Visible = false;
            Proyecto_Forms.ALAINID.Activarlistavideos();
            Proyecto_Forms.ALAINID.Partirlistadirectores();
            Proyecto_Forms.ALAINID.Partirlistaactores();
            panel_ver_canciones_admin.Visible = false;
            panel_ver_videos_admin.Visible = true;
            panel_ver_videos_admin.Dock = DockStyle.Fill;
            foreach (Video video in Proyecto_Forms.ALAINID.todos_los_videos)
            {
                int n = tabla_ver_videos_admin.Rows.Add();
                tabla_ver_videos_admin.Rows[n].Cells[0].Value = video.Nombre_video;
                tabla_ver_videos_admin.Rows[n].Cells[1].Value = video.Duracion;
                tabla_ver_videos_admin.Rows[n].Cells[2].Value = video.Categoria;
                tabla_ver_videos_admin.Rows[n].Cells[3].Value = video.Director.Name;
                tabla_ver_videos_admin.Rows[n].Cells[4].Value = video.Genero;
                tabla_ver_videos_admin.Rows[n].Cells[5].Value = video.Anio_publicacion;
                tabla_ver_videos_admin.Rows[n].Cells[6].Value = video.Tipo_archivo;
                tabla_ver_videos_admin.Rows[n].Cells[7].Value = video.Calidad;
                tabla_ver_videos_admin.Rows[n].Cells[8].Value = video.Film_studio;
                tabla_ver_videos_admin.Rows[n].Cells[9].Value = video.Tamanio;
                tabla_ver_videos_admin.Rows[n].Cells[10].Value = video.Calificacion_promedio;
                tabla_ver_videos_admin.Rows[n].Cells[11].Value = video.Reproduccion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//atras ver videos admin
            panel_ver_videos_admin.Visible = false;
            tabla_ver_videos_admin.Rows.Clear();
        }

        private void cancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
            panel_agregar_video_admin.Visible = false;
            panel_agregar_cancion_admin.Visible = false;
            panel_ver_artistas.Visible = false;
            panel_ver_usuarios_admin.Visible = false;
            panel_ver_canciones_karaoke.Visible = false;
            panel_ver_videos_admin.Visible = false;
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            panel_ver_canciones_admin.Visible = true;
            panel_ver_canciones_admin.Dock = DockStyle.Fill;
            foreach (Song song in Proyecto_Forms.ALAINID.todas_las_canciones)
            {
                int n = tabla_ver_canciones_admin.Rows.Add();
                tabla_ver_canciones_admin.Rows[n].Cells[0].Value = song.Nombrecancion;
                tabla_ver_canciones_admin.Rows[n].Cells[1].Value = song.Cantante.Name;
                tabla_ver_canciones_admin.Rows[n].Cells[2].Value = song.Genero;
                tabla_ver_canciones_admin.Rows[n].Cells[3].Value = song.Compositor.Name;
                tabla_ver_canciones_admin.Rows[n].Cells[4].Value = song.Anopublicacion;
                tabla_ver_canciones_admin.Rows[n].Cells[5].Value = song.Disquera;
                tabla_ver_canciones_admin.Rows[n].Cells[6].Value = song.Album;
                tabla_ver_canciones_admin.Rows[n].Cells[7].Value = song.Calificacionpromedio;
                tabla_ver_canciones_admin.Rows[n].Cells[8].Value = song.Duracion;
                tabla_ver_canciones_admin.Rows[n].Cells[9].Value = song.Reproducciones;
                tabla_ver_canciones_admin.Rows[n].Cells[10].Value = song.Tipoarchivo;
                tabla_ver_canciones_admin.Rows[n].Cells[11].Value = song.Tamano;
                tabla_ver_canciones_admin.Rows[n].Cells[12].Value = song.Calidad;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//atras ver canciones admin
            panel_ver_canciones_admin.Visible = false;
            tabla_ver_canciones_admin.Rows.Clear();
        }

        private void label44_Click(object sender, EventArgs e)
        {// cualquier wea NO BORRAR

        }

        private void button3_Click(object sender, EventArgs e)
        {//atras de ver canciones karaoke
            panel_ver_canciones_karaoke.Visible = false;
            tabla_ver_canciones_karaoke.Rows.Clear();
        }

        private void cancionesKaraokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
            panel_agregar_video_admin.Visible = false;
            panel_agregar_cancion_admin.Visible = false;
            panel_ver_artistas.Visible = false;
            panel_ver_usuarios_admin.Visible = false;
            panel_ver_videos_admin.Visible = false;
            panel_ver_canciones_admin.Visible = false;
            panel_ver_canciones_karaoke.Visible = true;
            panel_ver_canciones_karaoke.Dock = DockStyle.Fill;
            Proyecto_Forms.ALAINID.Activarlistacanciones();
            Proyecto_Forms.ALAINID.Activarlistacantantes();
            Proyecto_Forms.ALAINID.Partirlistacompositores();
            Proyecto_Forms.ALAINID.Partirkaraoke();
            Proyecto_Forms.ALAINID.Partirlistaalbumes();
            foreach (Song song in Proyecto_Forms.ALAINID.todas_las_cancioneskaraoke)
            {
                int n = tabla_ver_canciones_karaoke.Rows.Add();
                tabla_ver_canciones_karaoke.Rows[n].Cells[0].Value = song.Nombrecancion;
                tabla_ver_canciones_karaoke.Rows[n].Cells[1].Value = song.Cantante.Name;
                tabla_ver_canciones_karaoke.Rows[n].Cells[2].Value = song.Genero;
                tabla_ver_canciones_karaoke.Rows[n].Cells[3].Value = song.Compositor.Name;
                tabla_ver_canciones_karaoke.Rows[n].Cells[4].Value = song.Anopublicacion;
                tabla_ver_canciones_karaoke.Rows[n].Cells[5].Value = song.Disquera;
                tabla_ver_canciones_karaoke.Rows[n].Cells[6].Value = song.Album;
                tabla_ver_canciones_karaoke.Rows[n].Cells[7].Value = song.Calificacionpromedio;
                tabla_ver_canciones_karaoke.Rows[n].Cells[8].Value = song.Duracion;
                tabla_ver_canciones_karaoke.Rows[n].Cells[9].Value = song.Reproducciones;
                tabla_ver_canciones_karaoke.Rows[n].Cells[10].Value = song.Tipoarchivo;
                tabla_ver_canciones_karaoke.Rows[n].Cells[11].Value = song.Tamano;
                tabla_ver_canciones_karaoke.Rows[n].Cells[12].Value = song.Calidad;

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btn_atras_agregar_cancion_karaoke_Click(object sender, EventArgs e)
        {
            panel_agregar_cancion_karaoke.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_subir_cancion_karaoke_Click(object sender, EventArgs e)
        {
            Artista cantante = new Artista(nombrecantante_text_cancion_karaoke.Text, int.Parse(edadcantante_text_cancion_karaoke.Text), sexocantante_text_cancion_karaoke.Text, nacioncompositor_text_cancion_karaoke.Text);
            Artista compositor = new Artista(nombrecompositor_text_cancion_karaoke.Text, int.Parse(edadcompositor_text_cancion_karaoke.Text), sexocompositor_text_cancion_karaoke.Text, nacioncompositor_text_cancion_karaoke.Text);
            //Proyecto_Forms.ALAINID.Activarlistacanciones();
            //Proyecto_Forms.ALAINID.Activarlistacantantes();
            //Proyecto_Forms.ALAINID.Partirlistacompositores();
            //Proyecto_Forms.ALAINID.Partirlistaalbumes();
            a.AgregarSongKaraoke(nombre_text_cancion_karaoke.Text, cantante, genero_text_cancion_karaoke.Text, compositor, aniopublicacion_text_cancion_karaoke.Text, Disquera_text_cancion_karaoke.Text, album_text_cancion_karaoke.Text, ruta_cancion_karaoke);
            archivo_text_cancion_karaoke.Text = "";
            nombrecantante_text_cancion_karaoke.Text = "";
            edadcantante_text_cancion_karaoke.Text = "";
            sexocantante_text_cancion_karaoke.Text = "";
            nacioncompositor_text_cancion_karaoke.Text = "";
            nacioncantante_text_cancion_karaoke.Text = "";
            edadcompositor_text_cancion_karaoke.Text = "";
            sexocompositor_text_cancion_karaoke.Text = "";
            nacioncompositor_text_cancion_karaoke.Text = "";
            nombre_text_cancion_karaoke.Text = "";
            genero_text_cancion_karaoke.Text = "";
            aniopublicacion_text_cancion_karaoke.Text = "";
            Disquera_text_cancion_karaoke.Text = "";
            album_text_cancion_karaoke.Text = "";
            ruta_cancion_karaoke = "";
            checkBox_repetir_cantante_como_compositor.Checked = false;
        }

        public string ruta_cancion_karaoke;
        private void btn_importar_archivo_cancion_karaoke_Click(object sender, EventArgs e)
        {
            if (openfile_subircancion_karaoke_admin.ShowDialog() == DialogResult.OK)
            {
                archivo_text_cancion_karaoke.Text = openfile_subircancion_karaoke_admin.FileName;
                ruta_cancion_karaoke = openfile_subircancion_karaoke_admin.FileName;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {//NO BORRAR

        }

        private void button4_Click(object sender, EventArgs e)
        {//btn atras ver artista admin
            panel_ver_artistas.Visible = false;
            tabla_ver_directores_admin.Rows.Clear();
            tabla_ver_compositores_admin.Rows.Clear();
            tabla_ver_actores_admin.Rows.Clear();
            tabla_ver_cantantes_admin.Rows.Clear();
        }

        private void checkBox_repetir_cantante_encompositor_karaoke_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_repetir_cantante_encompositor_karaoke.Checked == true)
            {
                nombrecompositor_text_cancion_karaoke.Text = nombrecantante_text_cancion_karaoke.Text;
                edadcompositor_text_cancion_karaoke.Text = edadcantante_text_cancion_karaoke.Text;
                sexocompositor_text_cancion_karaoke.Text = sexocantante_text_cancion_karaoke.Text;
                nacioncompositor_text_cancion_karaoke.Text = nacioncantante_text_cancion_karaoke.Text;
                nombrecompositor_text_cancion_karaoke.Enabled = false;
                edadcompositor_text_cancion_karaoke.Enabled = false;
                sexocompositor_text_cancion_karaoke.Enabled = false;
                nacioncompositor_text_cancion_karaoke.Enabled = false;
            }
            if (checkBox_repetir_cantante_encompositor_karaoke.Checked == false)
            {
                nombrecompositor_text_cancion_karaoke.Enabled = true;
                edadcompositor_text_cancion_karaoke.Enabled = true;
                sexocompositor_text_cancion_karaoke.Enabled = true;
                nacioncompositor_text_cancion_karaoke.Enabled = true;
            }
        }
    }
}
