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
    public partial class Error_Usuario_Existente : Form
    {
        public Error_Usuario_Existente()
        {
            InitializeComponent();
        }

        private void Aceptar_Error_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Error_existe_Click(object sender, EventArgs e)
        {

        }

        public void mostrar_mail_ya_existe()
        {
            panel1.Visible  = true;
        }
    }
}
