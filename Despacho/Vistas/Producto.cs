using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Despacho.Vistas
{
    public partial class Producto : Telerik.WinControls.UI.RadForm
    {
        DataSet ds;
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'despachoDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.despachoDataSet.Producto);
            this.unidadTableAdapter.Fill(this.despachoDataSet.Unidad);

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Negocios.Entidades.Producto producto = new Negocios.Entidades.Producto(
                Convert.ToInt32(txtCodigo.Text.Trim()),
                Convert.ToInt32(cbbPersonal1.SelectedValue.ToString()),
                txtDescripcion.Text.Trim(),
                (chEstado.ToggleStateMode == Telerik.WinControls.UI.ToggleStateMode.Click));

            ds = Negocios.Utilidades.Ejecutar(producto.guardarRegistro());

            if(ds.Tables[0].Rows.Count > 0)
            {
                RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                Negocios.Utilidades.Limpiar(this, errorProvider1);
                this.productoTableAdapter.Fill(this.despachoDataSet.Producto);
                txtCodigo.Focus();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
