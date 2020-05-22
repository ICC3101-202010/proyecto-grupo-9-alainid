namespace APP_ALAINID
{
    partial class Bienvenido_alainid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.texto_bienvenida = new System.Windows.Forms.Label();
            this.boton_login = new System.Windows.Forms.Button();
            this.boton_registrarse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 86);
            this.dataGridView1.TabIndex = 0;
            // 
            // texto_bienvenida
            // 
            this.texto_bienvenida.AutoSize = true;
            this.texto_bienvenida.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bienvenida.Location = new System.Drawing.Point(60, 9);
            this.texto_bienvenida.Name = "texto_bienvenida";
            this.texto_bienvenida.Size = new System.Drawing.Size(291, 34);
            this.texto_bienvenida.TabIndex = 1;
            this.texto_bienvenida.Text = "BIENVENIDO A ALAINID";
            // 
            // boton_login
            // 
            this.boton_login.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_login.Location = new System.Drawing.Point(48, 79);
            this.boton_login.Name = "boton_login";
            this.boton_login.Size = new System.Drawing.Size(133, 31);
            this.boton_login.TabIndex = 2;
            this.boton_login.Text = "Iniciar Sesion";
            this.boton_login.UseVisualStyleBackColor = true;
            this.boton_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_registrarse
            // 
            this.boton_registrarse.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_registrarse.Location = new System.Drawing.Point(244, 79);
            this.boton_registrarse.Name = "boton_registrarse";
            this.boton_registrarse.Size = new System.Drawing.Size(120, 31);
            this.boton_registrarse.TabIndex = 3;
            this.boton_registrarse.Text = "Registrarme";
            this.boton_registrarse.UseVisualStyleBackColor = true;
            this.boton_registrarse.Click += new System.EventHandler(this.boton_registrarse_Click);
            // 
            // Bienvenido_alainid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 165);
            this.Controls.Add(this.boton_registrarse);
            this.Controls.Add(this.boton_login);
            this.Controls.Add(this.texto_bienvenida);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bienvenido_alainid";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label texto_bienvenida;
        private System.Windows.Forms.Button boton_login;
        private System.Windows.Forms.Button boton_registrarse;
    }
}

