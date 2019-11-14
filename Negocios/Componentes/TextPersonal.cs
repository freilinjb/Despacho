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
    public partial class TextPersonal : Telerik.WinControls.UI.RadTextBox
    {
        public TextPersonal()
        {
            InitializeComponent();
        }

        public Boolean Limpiar { set; get; }
        public Boolean Validar { set; get; }
        public Boolean Correo { set; get; }
    }
}
