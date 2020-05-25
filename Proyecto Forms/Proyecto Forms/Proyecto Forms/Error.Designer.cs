namespace Proyecto_Forms
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
            this.Text_Error = new System.Windows.Forms.TextBox();
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
            // Text_Error
            // 
            this.Text_Error.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Error.Location = new System.Drawing.Point(92, 62);
            this.Text_Error.Name = "Text_Error";
            this.Text_Error.Size = new System.Drawing.Size(317, 30);
            this.Text_Error.TabIndex = 1;
            this.Text_Error.TextChanged += new System.EventHandler(this.Text_Error_TextChanged);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 275);
            this.Controls.Add(this.Text_Error);
            this.Controls.Add(this.Aceptar_Error);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar_Error;
        private System.Windows.Forms.TextBox Text_Error;
    }
}