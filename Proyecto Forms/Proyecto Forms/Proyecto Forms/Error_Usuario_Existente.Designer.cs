namespace Proyecto_Forms
{
    partial class Error_Usuario_Existente
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
            this.Aceptar_Error = new System.Windows.Forms.Button();
            this.Error_existe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Contrasena_incorrecta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Contrasena_incorrecta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aceptar_Error
            // 
            this.Aceptar_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar_Error.Location = new System.Drawing.Point(117, 132);
            this.Aceptar_Error.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Aceptar_Error.Name = "Aceptar_Error";
            this.Aceptar_Error.Size = new System.Drawing.Size(143, 37);
            this.Aceptar_Error.TabIndex = 1;
            this.Aceptar_Error.Text = "Aceptar";
            this.Aceptar_Error.UseVisualStyleBackColor = true;
            this.Aceptar_Error.Click += new System.EventHandler(this.Aceptar_Error_Click);
            // 
            // Error_existe
            // 
            this.Error_existe.AutoSize = true;
            this.Error_existe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_existe.Location = new System.Drawing.Point(104, 69);
            this.Error_existe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Error_existe.Name = "Error_existe";
            this.Error_existe.Size = new System.Drawing.Size(161, 20);
            this.Error_existe.TabIndex = 2;
            this.Error_existe.Text = "Este Usuario ya exise";
            this.Error_existe.Click += new System.EventHandler(this.Error_existe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 94);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail ya existente";
            // 
            // Contrasena_incorrecta
            // 
            this.Contrasena_incorrecta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Contrasena_incorrecta.Controls.Add(this.label2);
            this.Contrasena_incorrecta.Location = new System.Drawing.Point(82, 5);
            this.Contrasena_incorrecta.Name = "Contrasena_incorrecta";
            this.Contrasena_incorrecta.Size = new System.Drawing.Size(200, 100);
            this.Contrasena_incorrecta.TabIndex = 4;
            this.Contrasena_incorrecta.Visible = false;
            this.Contrasena_incorrecta.Paint += new System.Windows.Forms.PaintEventHandler(this.Contrasena_incorrecta_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Incorrecta";
            // 
            // Error_Usuario_Existente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 224);
            this.Controls.Add(this.Contrasena_incorrecta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Error_existe);
            this.Controls.Add(this.Aceptar_Error);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Error_Usuario_Existente";
            this.Text = "Error_Usuario_Existente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Contrasena_incorrecta.ResumeLayout(false);
            this.Contrasena_incorrecta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar_Error;
        private System.Windows.Forms.Label Error_existe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Contrasena_incorrecta;
        private System.Windows.Forms.Label label2;
    }
}