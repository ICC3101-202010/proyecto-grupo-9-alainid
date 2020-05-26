using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Forms
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        public void Text_Error_TextChanged(object sender, EventArgs e)
        {

        }

        public void Aceptar_Error_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        public void text_error_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void mostrar_panel()
        {
            panel1.Visible = true;
            

        }

        


        private void error_user_yaexiste_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
