namespace Despacho.Vistas
{
    partial class Vehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btCancelar = new Telerik.WinControls.UI.RadButton();
            this.btImprimir = new Telerik.WinControls.UI.RadButton();
            this.btGuardar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.dataPropietario = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.cbbPropietario = new Negocios.Componentes.CbbPersonal();
            this.txtObservacion = new Negocios.Componentes.TextPersonal();
            this.txtCapacidad = new Negocios.Componentes.TextPersonal();
            this.txtPlaca = new Negocios.Componentes.TextPersonal();
            this.txtDescripcion = new Negocios.Componentes.TextPersonal();
            this.chEstado = new Telerik.WinControls.UI.RadToggleSwitch();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.despachoDataSet = new Despacho.DespachoDataSet();
            this.vistaVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaVehiculoTableAdapter = new Despacho.DespachoDataSetTableAdapters.VistaVehiculoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btCancelar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btImprimir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(547, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 186);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancelar.Location = new System.Drawing.Point(3, 127);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(140, 56);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.ThemeName = "VisualStudio2012Light";
            // 
            // btImprimir
            // 
            this.btImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btImprimir.Location = new System.Drawing.Point(3, 65);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(140, 56);
            this.btImprimir.TabIndex = 1;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.ThemeName = "VisualStudio2012Light";
            // 
            // btGuardar
            // 
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.Location = new System.Drawing.Point(3, 3);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(140, 56);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.ThemeName = "VisualStudio2012Light";
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.dataPropietario);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Lista de Vehiculos";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 218);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(681, 362);
            this.radGroupBox1.TabIndex = 10;
            this.radGroupBox1.Text = "Lista de Vehiculos";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // dataPropietario
            // 
            this.dataPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataPropietario.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPropietario.EnableHotTracking = false;
            this.dataPropietario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataPropietario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataPropietario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataPropietario.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.dataPropietario.MasterTemplate.AllowAddNewRow = false;
            this.dataPropietario.MasterTemplate.AllowColumnChooser = false;
            this.dataPropietario.MasterTemplate.AllowColumnReorder = false;
            this.dataPropietario.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Placa";
            gridViewTextBoxColumn7.HeaderText = "Placa";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Placa";
            gridViewTextBoxColumn7.Width = 136;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Descripcion";
            gridViewTextBoxColumn8.HeaderText = "Descripcion";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Descripcion";
            gridViewTextBoxColumn8.Width = 136;
            gridViewDecimalColumn5.DataType = typeof(double);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Capacidad";
            gridViewDecimalColumn5.HeaderText = "Capacidad";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "Capacidad";
            gridViewDecimalColumn5.Width = 136;
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "IdPropietario";
            gridViewDecimalColumn6.HeaderText = "IdPropietario";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "IdPropietario";
            gridViewDecimalColumn6.Width = 101;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Propietario";
            gridViewTextBoxColumn9.HeaderText = "Propietario";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Propietario";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 168;
            gridViewCheckBoxColumn3.EnableExpressionEditor = false;
            gridViewCheckBoxColumn3.FieldName = "Estado";
            gridViewCheckBoxColumn3.HeaderText = "Estado";
            gridViewCheckBoxColumn3.IsAutoGenerated = true;
            gridViewCheckBoxColumn3.MinWidth = 20;
            gridViewCheckBoxColumn3.Name = "Estado";
            gridViewCheckBoxColumn3.Width = 106;
            this.dataPropietario.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn9,
            gridViewCheckBoxColumn3});
            this.dataPropietario.MasterTemplate.DataSource = this.vistaVehiculoBindingSource;
            this.dataPropietario.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataPropietario.MasterTemplate.EnableGrouping = false;
            this.dataPropietario.MasterTemplate.EnableSorting = false;
            this.dataPropietario.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataPropietario.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dataPropietario.Name = "dataPropietario";
            this.dataPropietario.ReadOnly = true;
            this.dataPropietario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataPropietario.Size = new System.Drawing.Size(677, 342);
            this.dataPropietario.TabIndex = 0;
            this.dataPropietario.ThemeName = "VisualStudio2012Light";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.cbbPropietario);
            this.radPanel1.Controls.Add(this.txtObservacion);
            this.radPanel1.Controls.Add(this.txtCapacidad);
            this.radPanel1.Controls.Add(this.txtPlaca);
            this.radPanel1.Controls.Add(this.txtDescripcion);
            this.radPanel1.Controls.Add(this.chEstado);
            this.radPanel1.Controls.Add(this.radLabel5);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radSeparator1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Location = new System.Drawing.Point(12, 16);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(528, 186);
            this.radPanel1.TabIndex = 9;
            this.radPanel1.ThemeName = "VisualStudio2012Light";
            // 
            // cbbPropietario
            // 
            this.cbbPropietario.Correo = false;
            this.cbbPropietario.DisplayMember = "Descripcion";
            this.cbbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPropietario.Limpiar = true;
            this.cbbPropietario.Location = new System.Drawing.Point(390, 54);
            this.cbbPropietario.Name = "cbbPropietario";
            this.cbbPropietario.Size = new System.Drawing.Size(125, 25);
            this.cbbPropietario.TabIndex = 6;
            this.cbbPropietario.ThemeName = "VisualStudio2012Light";
            this.cbbPropietario.Validar = true;
            this.cbbPropietario.ValueMember = "IdTipoTelefono";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Correo = false;
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Limpiar = true;
            this.txtObservacion.Location = new System.Drawing.Point(3, 114);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.NullText = "Observación";
            // 
            // 
            // 
            this.txtObservacion.RootElement.StretchVertically = true;
            this.txtObservacion.Size = new System.Drawing.Size(209, 55);
            this.txtObservacion.TabIndex = 5;
            this.txtObservacion.ThemeName = "VisualStudio2012Light";
            this.txtObservacion.Validar = false;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Correo = false;
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Limpiar = true;
            this.txtCapacidad.Location = new System.Drawing.Point(87, 84);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(125, 24);
            this.txtCapacidad.TabIndex = 5;
            this.txtCapacidad.ThemeName = "VisualStudio2012Light";
            this.txtCapacidad.Validar = true;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Correo = false;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Limpiar = true;
            this.txtPlaca.Location = new System.Drawing.Point(57, 12);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(82, 24);
            this.txtPlaca.TabIndex = 5;
            this.txtPlaca.ThemeName = "VisualStudio2012Light";
            this.txtPlaca.Validar = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Correo = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(87, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(125, 24);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.ThemeName = "VisualStudio2012Light";
            this.txtDescripcion.Validar = true;
            // 
            // chEstado
            // 
            this.chEstado.Location = new System.Drawing.Point(429, 89);
            this.chEstado.Name = "chEstado";
            this.chEstado.OffText = "Inactivo";
            this.chEstado.OnText = "Activo";
            this.chEstado.Size = new System.Drawing.Size(86, 20);
            this.chEstado.TabIndex = 4;
            this.chEstado.ThemeName = "VisualStudio2012Light";
            this.chEstado.ThumbTickness = 15;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel5.Location = new System.Drawing.Point(310, 58);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(74, 21);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Propietario";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(11, 88);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(70, 21);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Capacidad";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(3, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(78, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Descripción";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(3, 42);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(522, 10);
            this.radSeparator1.TabIndex = 2;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(13, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(38, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Placa";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // despachoDataSet
            // 
            this.despachoDataSet.DataSetName = "DespachoDataSet";
            this.despachoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaVehiculoBindingSource
            // 
            this.vistaVehiculoBindingSource.DataMember = "VistaVehiculo";
            this.vistaVehiculoBindingSource.DataSource = this.despachoDataSet;
            // 
            // vistaVehiculoTableAdapter
            // 
            this.vistaVehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radPanel1);
            this.Name = "Vehiculo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Vehiculo";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.Vehiculo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btCancelar;
        private Telerik.WinControls.UI.RadButton btImprimir;
        private Telerik.WinControls.UI.RadButton btGuardar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView dataPropietario;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Negocios.Componentes.CbbPersonal cbbPropietario;
        private Negocios.Componentes.TextPersonal txtObservacion;
        private Negocios.Componentes.TextPersonal txtCapacidad;
        private Negocios.Componentes.TextPersonal txtPlaca;
        private Negocios.Componentes.TextPersonal txtDescripcion;
        private Telerik.WinControls.UI.RadToggleSwitch chEstado;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DespachoDataSet despachoDataSet;
        private System.Windows.Forms.BindingSource vistaVehiculoBindingSource;
        private DespachoDataSetTableAdapters.VistaVehiculoTableAdapter vistaVehiculoTableAdapter;
    }
}
