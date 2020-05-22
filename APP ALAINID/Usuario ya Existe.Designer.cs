namespace APP_ALAINID
{
    partial class Usuario_ya_Existe
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
            this.b_ok_user_exist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_ok_user_exist
            // 
            this.b_ok_user_exist.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ok_user_exist.Location = new System.Drawing.Point(85, 72);
            this.b_ok_user_exist.Name = "b_ok_user_exist";
            this.b_ok_user_exist.Size = new System.Drawing.Size(116, 30);
            this.b_ok_user_exist.TabIndex = 16;
            this.b_ok_user_exist.Text = "OK";
            this.b_ok_user_exist.UseVisualStyleBackColor = true;
            this.b_ok_user_exist.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lo sentimos, el Nombre de Usuario \r\n    ingresado no esta disponible.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usuario_ya_Existe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 114);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_ok_user_exist);
            this.Name = "Usuario_ya_Existe";
            this.Text = "Usuario_ya_Existe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_ok_user_exist;
        private System.Windows.Forms.Label label1;
    }
}