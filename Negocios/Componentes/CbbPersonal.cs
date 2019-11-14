using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios.Componentes
{
    public partial class CbbPersonal : Telerik.WinControls.UI.RadDropDownList
    {
        public CbbPersonal()
        {
            InitializeComponent();
        }



        public Boolean Limpiar { set; get; }
        public Boolean Validar { set; get; }
        public Boolean Correo { set; get; }

    }
}
