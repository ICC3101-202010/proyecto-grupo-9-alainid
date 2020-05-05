using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    class ALAINID
    {
        private Control control;
        public ALAINID(Control c)
        {
            this.control = c;
        }
        public void Operar()
        {
            control.Comenzar_app();
        }
    }
}
