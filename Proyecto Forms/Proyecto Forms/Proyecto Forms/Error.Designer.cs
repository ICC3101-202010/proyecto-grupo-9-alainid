﻿namespace Proyecto_Forms
{
    partial class Error
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
            this.text_error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Campovacio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aceptar_Error
            // 
            this.Aceptar_Error.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar_Error.Location = new System.Drawing.Point(157, 151);
            this.Aceptar_Error.Name = "Aceptar_Error";
            this.Aceptar_Error.Size = new System.Drawing.Size(191, 46);
            this.Aceptar_Error.TabIndex = 0;
            this.Aceptar_Error.Text = "Aceptar";
            this.Aceptar_Error.UseVisualStyleBackColor = true;
            this.Aceptar_Error.Click += new System.EventHandler(this.Aceptar_Error_Click);
            // 
            // text_error
            // 
            this.text_error.AutoSize = true;
            this.text_error.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_error.Location = new System.Drawing.Point(96, 76);
            this.text_error.Name = "text_error";
            this.text_error.Size = new System.Drawing.Size(327, 22);
            this.text_error.TabIndex = 1;
            this.text_error.Text = "Email o Contraseña invalidos";
            this.text_error.Click += new System.EventHandler(this.text_error_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Campovacio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Campovacio
            // 
            this.Campovacio.AutoSize = true;
            this.Campovacio.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campovacio.Location = new System.Drawing.Point(51, 76);
            this.Campovacio.Name = "Campovacio";
            this.Campovacio.Size = new System.Drawing.Size(401, 22);
            this.Campovacio.TabIndex = 2;
            this.Campovacio.Text = "No puede dejar ningun campo vacio";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_error);
            this.Controls.Add(this.Aceptar_Error);
            this.Name = "Error";
            this.Text = "Error";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar_Error;
        private System.Windows.Forms.Label text_error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Campovacio;
    }
}