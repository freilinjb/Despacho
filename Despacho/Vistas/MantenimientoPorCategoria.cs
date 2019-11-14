using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Despacho.Vistas
{
    public partial class MantenimientoPorCategoria : Telerik.WinControls.UI.RadForm
    {
        public MantenimientoPorCategoria()
        {
            InitializeComponent();
        }

        private void MantenimientoPorCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'despachoDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.despachoDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'despachoDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.despachoDataSet.Categoria);

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(dataPropietario.Rows.Count > 0)
            {

                for (int i = 0; i < dataPropietario.Rows.Count;i ++)
                {
                    Negocios.Utilidades.Ejecutar($"EXEC InsertarPrecio {cbbPersonal1.SelectedValue.ToString()},{dataPropietario.Rows[i].Cells[0].Value.ToString()},{dataPropietario.Rows[i].Cells[3].Value.ToString()}");
                }
            }
            cbbPersonal1.SelectedIndex = -1;
            this.categoriaTableAdapter.Fill(this.despachoDataSet.Categoria);
            RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
        }
    }
}
