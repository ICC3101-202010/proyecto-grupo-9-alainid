namespace APP_ALAINID
{
    partial class correo_usadp
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_ok_user_exist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lo sentimos, ya existe una cuenta \r\n       con el correo ingresado.";
            // 
            // b_ok_user_exist
            // 
            this.b_ok_user_exist.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ok_user_exist.Location = new System.Drawing.Point(106, 79);
            this.b_ok_user_exist.Name = "b_ok_user_exist";
            this.b_ok_user_exist.Size = new System.Drawing.Size(116, 30);
            this.b_ok_user_exist.TabIndex = 19;
            this.b_ok_user_exist.Text = "OK";
            this.b_ok_user_exist.UseVisualStyleBackColor = true;
            this.b_ok_user_exist.Click += new System.EventHandler(this.b_ok_user_exist_Click);
            // 
            // correo_usadp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 137);
            this.Controls.Add(this.b_ok_user_exist);
            this.Controls.Add(this.label1);
            this.Name = "correo_usadp";
            this.Text = "correo_usadp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_ok_user_exist;
    }
}