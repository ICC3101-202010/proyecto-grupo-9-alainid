namespace APP_ALAINID
{
    partial class Registrarme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registro_apellido = new System.Windows.Forms.TextBox();
            this.registro_nombre = new System.Windows.Forms.TextBox();
            this.registro_correo = new System.Windows.Forms.TextBox();
            this.registro_nombre_usuario = new System.Windows.Forms.TextBox();
            this.registro_contraseña = new System.Windows.Forms.TextBox();
            this.boton_crearcuenta = new System.Windows.Forms.Button();
            this.boton_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrarme en ALAINID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nombre de Usuario:";
            // 
            // registro_apellido
            // 
            this.registro_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_apellido.Location = new System.Drawing.Point(260, 162);
            this.registro_apellido.Name = "registro_apellido";
            this.registro_apellido.Size = new System.Drawing.Size(137, 24);
            this.registro_apellido.TabIndex = 8;
            // 
            // registro_nombre
            // 
            this.registro_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_nombre.Location = new System.Drawing.Point(260, 125);
            this.registro_nombre.Name = "registro_nombre";
            this.registro_nombre.Size = new System.Drawing.Size(137, 24);
            this.registro_nombre.TabIndex = 9;
            // 
            // registro_correo
            // 
            this.registro_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_correo.Location = new System.Drawing.Point(260, 90);
            this.registro_correo.Name = "registro_correo";
            this.registro_correo.Size = new System.Drawing.Size(137, 24);
            this.registro_correo.TabIndex = 10;
            // 
            // registro_nombre_usuario
            // 
            this.registro_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_nombre_usuario.Location = new System.Drawing.Point(260, 54);
            this.registro_nombre_usuario.Name = "registro_nombre_usuario";
            this.registro_nombre_usuario.Size = new System.Drawing.Size(137, 24);
            this.registro_nombre_usuario.TabIndex = 11;
            // 
            // registro_contraseña
            // 
            this.registro_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro_contraseña.Location = new System.Drawing.Point(260, 207);
            this.registro_contraseña.Name = "registro_contraseña";
            this.registro_contraseña.PasswordChar = '*';
            this.registro_contraseña.Size = new System.Drawing.Size(137, 24);
            this.registro_contraseña.TabIndex = 12;
            this.registro_contraseña.UseSystemPasswordChar = true;
            // 
            // boton_crearcuenta
            // 
            this.boton_crearcuenta.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_crearcuenta.Location = new System.Drawing.Point(47, 252);
            this.boton_crearcuenta.Name = "boton_crearcuenta";
            this.boton_crearcuenta.Size = new System.Drawing.Size(168, 37);
            this.boton_crearcuenta.TabIndex = 13;
            this.boton_crearcuenta.Text = "Registrar";
            this.boton_crearcuenta.UseVisualStyleBackColor = true;
            this.boton_crearcuenta.Click += new System.EventHandler(this.boton_crearcuenta_Click);
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_cancelar.Location = new System.Drawing.Point(241, 252);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(168, 37);
            this.boton_cancelar.TabIndex = 14;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // Registrarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 324);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_crearcuenta);
            this.Controls.Add(this.registro_contraseña);
            this.Controls.Add(this.registro_nombre_usuario);
            this.Controls.Add(this.registro_correo);
            this.Controls.Add(this.registro_nombre);
            this.Controls.Add(this.registro_apellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Registrarme";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registro_apellido;
        private System.Windows.Forms.TextBox registro_nombre;
        private System.Windows.Forms.TextBox registro_correo;
        private System.Windows.Forms.TextBox registro_nombre_usuario;
        private System.Windows.Forms.TextBox registro_contraseña;
        private System.Windows.Forms.Button boton_crearcuenta;
        private System.Windows.Forms.Button boton_cancelar;
    }
}