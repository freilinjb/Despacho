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
    public partial class Propietario : Telerik.WinControls.UI.RadForm
    {
        private DataSet ds;

        public Propietario()
        {
            InitializeComponent();

            txtCodigo.Text = string.Format("{0:00000}", Negocios.Utilidades.Ejecutar("SELECT MAX(IdPropietario)+1 AS Mayor FROM Propietario").Tables[0].Rows[0]["Mayor"].ToString());
        }

        private void Propietario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'despachoDataSet.Propietario' Puede moverla o quitarla según sea necesario.
            this.propietarioTableAdapter.Fill(this.despachoDataSet.Propietario);
            // TODO: esta línea de código carga datos en la tabla 'despachoDataSet.TipoTelefono' Puede moverla o quitarla según sea necesario.
            this.tipoTelefonoTableAdapter.Fill(this.despachoDataSet.TipoTelefono);
            cbbTipoTelefono.SelectedIndex = -1;
            //Propietario_Load(this, null);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Negocios.Utilidades.Validar(this, errorProvider1) == false)
            {
                Negocios.Entidades.Propietario propietario = new Negocios.Entidades.Propietario(
                    Convert.ToInt32(txtCodigo.Text.Trim()),
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtApodo.Text.Trim(),
                    Convert.ToInt32(cbbTipoTelefono.SelectedValue.ToString()),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtObservacion.Text.Trim(),
                    (chEstado.ToggleStateMode == Telerik.WinControls.UI.ToggleStateMode.Click));


                ds = Negocios.Utilidades.Ejecutar(propietario.guardarRegistro());

                if (ds.Tables[0].Rows.Count > 0)
                {
                    RadMessageBox.Show("Se ha guardado exitosamente", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                    Negocios.Utilidades.Limpiar(this, errorProvider1);
                    this.propietarioTableAdapter.Fill(this.despachoDataSet.Propietario);
                    txtCodigo.Text = string.Format("{0:00000}", Negocios.Utilidades.Ejecutar("SELECT MAX(IdPropietario)+1 AS Mayor FROM Propietario").Tables[0].Rows[0]["Mayor"].ToString());
                }
            }
        }

        private void MasterTemplate_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(dataPropietario.Rows.Count > 0)
            {

            }
        }
    }
}
