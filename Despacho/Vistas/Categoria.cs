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
    public partial class Categoria : Telerik.WinControls.UI.RadForm
    {
        private DataSet ds;
        public Categoria()
        {
            InitializeComponent();

            txtPlaca.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCategoria)+1 AS Mayor FROM Categoria").Tables[0].Rows[0]["Mayor"].ToString();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(Negocios.Utilidades.Validar(this,errorProvider1) == false)
            {
                ds = Negocios.Utilidades.Ejecutar($"INSERT INTO Categoria(Descripcion,Estado) VALUES('{txtDescripcion.Text.Trim()}',{(chEstado.ToggleStateMode == Telerik.WinControls.UI.ToggleStateMode.Click)})");
                txtPlaca.Text = Negocios.Utilidades.Ejecutar("SELECT MAX(IdCategoria)+1 AS Mayor FROM Categoria").Tables[0].Rows[0]["Mayor"].ToString();
                this.categoriaTableAdapter.Fill(this.despachoDataSet.Categoria);
            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'despachoDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.despachoDataSet.Categoria);
        }
    }
}
