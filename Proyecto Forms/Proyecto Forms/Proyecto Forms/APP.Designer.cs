namespace Proyecto_Forms
{
    partial class APP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP));
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIniciarsesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel_Registrarse = new System.Windows.Forms.Panel();
            this.panel_Iniciar_Sesion = new System.Windows.Forms.Panel();
            this.Atras_Inicio = new System.Windows.Forms.Button();
            this.Inicio_de_Sesion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password_inicio = new System.Windows.Forms.TextBox();
            this.mail_inicio = new System.Windows.Forms.TextBox();
            this.Atras_registro = new System.Windows.Forms.Button();
            this.Crear_Usuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.nombre_completo = new System.Windows.Forms.TextBox();
            this.nombre_usuario = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.panel_Registrarse.SuspendLayout();
            this.panel_Iniciar_Sesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(178, 64);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(442, 64);
            this.btnRegistrarse.TabIndex = 0;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarsesion
            // 
            this.btnIniciarsesion.Location = new System.Drawing.Point(178, 184);
            this.btnIniciarsesion.Name = "btnIniciarsesion";
            this.btnIniciarsesion.Size = new System.Drawing.Size(442, 64);
            this.btnIniciarsesion.TabIndex = 1;
            this.btnIniciarsesion.Text = "Iniciar Sesion";
            this.btnIniciarsesion.UseVisualStyleBackColor = true;
            this.btnIniciarsesion.Click += new System.EventHandler(this.btnIniciarsesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(178, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(442, 64);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel_Registrarse
            // 
            this.panel_Registrarse.Controls.Add(this.Atras_registro);
            this.panel_Registrarse.Controls.Add(this.Crear_Usuario);
            this.panel_Registrarse.Controls.Add(this.label5);
            this.panel_Registrarse.Controls.Add(this.label4);
            this.panel_Registrarse.Controls.Add(this.label3);
            this.panel_Registrarse.Controls.Add(this.label1);
            this.panel_Registrarse.Controls.Add(this.label2);
            this.panel_Registrarse.Controls.Add(this.password);
            this.panel_Registrarse.Controls.Add(this.nombre_completo);
            this.panel_Registrarse.Controls.Add(this.nombre_usuario);
            this.panel_Registrarse.Controls.Add(this.mail);
            this.panel_Registrarse.Location = new System.Drawing.Point(2, 2);
            this.panel_Registrarse.Name = "panel_Registrarse";
            this.panel_Registrarse.Size = new System.Drawing.Size(802, 450);
            this.panel_Registrarse.TabIndex = 3;
            this.panel_Registrarse.Visible = false;
            this.panel_Registrarse.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Registrarse_Paint);
            // 
            // panel_Iniciar_Sesion
            // 
            this.panel_Iniciar_Sesion.Controls.Add(this.Atras_Inicio);
            this.panel_Iniciar_Sesion.Controls.Add(this.Inicio_de_Sesion);
            this.panel_Iniciar_Sesion.Controls.Add(this.label8);
            this.panel_Iniciar_Sesion.Controls.Add(this.label7);
            this.panel_Iniciar_Sesion.Controls.Add(this.label6);
            this.panel_Iniciar_Sesion.Controls.Add(this.password_inicio);
            this.panel_Iniciar_Sesion.Controls.Add(this.mail_inicio);
            this.panel_Iniciar_Sesion.Location = new System.Drawing.Point(2, 2);
            this.panel_Iniciar_Sesion.Name = "panel_Iniciar_Sesion";
            this.panel_Iniciar_Sesion.Size = new System.Drawing.Size(799, 450);
            this.panel_Iniciar_Sesion.TabIndex = 12;
            this.panel_Iniciar_Sesion.Visible = false;
            this.panel_Iniciar_Sesion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Iniciar_Sesion_Paint);
            // 
            // Atras_Inicio
            // 
            this.Atras_Inicio.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras_Inicio.Location = new System.Drawing.Point(676, 398);
            this.Atras_Inicio.Name = "Atras_Inicio";
            this.Atras_Inicio.Size = new System.Drawing.Size(108, 33);
            this.Atras_Inicio.TabIndex = 6;
            this.Atras_Inicio.Text = "Atrás";
            this.Atras_Inicio.UseVisualStyleBackColor = true;
            this.Atras_Inicio.Click += new System.EventHandler(this.Atras_Inicio_Click_1);
            // 
            // Inicio_de_Sesion
            // 
            this.Inicio_de_Sesion.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio_de_Sesion.Location = new System.Drawing.Point(292, 276);
            this.Inicio_de_Sesion.Name = "Inicio_de_Sesion";
            this.Inicio_de_Sesion.Size = new System.Drawing.Size(182, 54);
            this.Inicio_de_Sesion.TabIndex = 5;
            this.Inicio_de_Sesion.Text = "IR";
            this.Inicio_de_Sesion.UseVisualStyleBackColor = true;
            this.Inicio_de_Sesion.Click += new System.EventHandler(this.Inicio_de_Sesion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "lniciar Sesión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mail";
            // 
            // password_inicio
            // 
            this.password_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_inicio.Location = new System.Drawing.Point(260, 156);
            this.password_inicio.Name = "password_inicio";
            this.password_inicio.Size = new System.Drawing.Size(257, 30);
            this.password_inicio.TabIndex = 1;
            this.password_inicio.TextChanged += new System.EventHandler(this.password_inicio_TextChanged);
            // 
            // mail_inicio
            // 
            this.mail_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_inicio.Location = new System.Drawing.Point(260, 85);
            this.mail_inicio.Name = "mail_inicio";
            this.mail_inicio.Size = new System.Drawing.Size(257, 30);
            this.mail_inicio.TabIndex = 0;
            this.mail_inicio.TextChanged += new System.EventHandler(this.mail_inicio_TextChanged);
            // 
            // Atras_registro
            // 
            this.Atras_registro.Location = new System.Drawing.Point(614, 305);
            this.Atras_registro.Name = "Atras_registro";
            this.Atras_registro.Size = new System.Drawing.Size(101, 68);
            this.Atras_registro.TabIndex = 11;
            this.Atras_registro.Text = "Atras";
            this.Atras_registro.UseVisualStyleBackColor = true;
            this.Atras_registro.Click += new System.EventHandler(this.Atras_registro_Click);
            // 
            // Crear_Usuario
            // 
            this.Crear_Usuario.Location = new System.Drawing.Point(614, 112);
            this.Crear_Usuario.Name = "Crear_Usuario";
            this.Crear_Usuario.Size = new System.Drawing.Size(101, 136);
            this.Crear_Usuario.TabIndex = 10;
            this.Crear_Usuario.Text = "Registrarse";
            this.Crear_Usuario.UseVisualStyleBackColor = true;
            this.Crear_Usuario.Click += new System.EventHandler(this.Crear_Usuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registrarse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "MAIL";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(307, 377);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(170, 30);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // nombre_completo
            // 
            this.nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_completo.Location = new System.Drawing.Point(307, 271);
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.Size = new System.Drawing.Size(170, 30);
            this.nombre_completo.TabIndex = 2;
            this.nombre_completo.TextChanged += new System.EventHandler(this.nombre_completo_TextChanged);
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_usuario.Location = new System.Drawing.Point(307, 165);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(170, 30);
            this.nombre_usuario.TabIndex = 1;
            this.nombre_usuario.TextChanged += new System.EventHandler(this.nombre_usuario_TextChanged);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(307, 64);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(170, 30);
            this.mail.TabIndex = 0;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // APP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Iniciar_Sesion);
            this.Controls.Add(this.panel_Registrarse);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciarsesion);
            this.Controls.Add(this.btnRegistrarse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APP";
            this.Text = "ALAINID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Registrarse.ResumeLayout(false);
            this.panel_Registrarse.PerformLayout();
            this.panel_Iniciar_Sesion.ResumeLayout(false);
            this.panel_Iniciar_Sesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIniciarsesion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel_Registrarse;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox nombre_completo;
        private System.Windows.Forms.TextBox nombre_usuario;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Atras_registro;
        private System.Windows.Forms.Button Crear_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_Iniciar_Sesion;
        private System.Windows.Forms.Button Atras_Inicio;
        private System.Windows.Forms.Button Inicio_de_Sesion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_inicio;
        private System.Windows.Forms.TextBox mail_inicio;
    }
}

