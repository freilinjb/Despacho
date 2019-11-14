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
    public partial class Vehiculo : Telerik.WinControls.UI.RadForm
    {
        private DataSet ds;

        public Vehiculo()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {
                Negocios.Entidades.Vehiculo propietario = new Negocios.Entidades.Vehiculo(
                    txtPlaca.Text.Trim(),
                    Convert.ToInt32(cbbPropietario.SelectedValue.ToString()),
                    Convert.ToSingle(txtCapacidad.Text.Trim()),
                    txtDescripcion.Text.Trim(),
                    txtObservacion.Text.Trim(),
                    (chEstado.ToggleStateMode == Telerik.WinControls.UI.ToggleStateMode.Click));


                ds = Negocios.Utilidades.Ejecutar(propietario.guardarRegistro());

                if (ds.Tables[0].Rows.Count > 0)
                {
                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    this.vistaVehiculoTableAdapter.Fill(this.despachoDataSet.VistaVehiculo);
                }
            }
        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'despachoDataSet.VistaVehiculo' Puede moverla o quitarla según sea necesario.
            this.vistaVehiculoTableAdapter.Fill(this.despachoDataSet.VistaVehiculo);
        }
    }
}
