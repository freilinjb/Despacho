namespace Despacho.Vistas
{
    partial class Producto
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btCancelar = new Telerik.WinControls.UI.RadButton();
            this.btGuardar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.dataPropietario = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.cbbPersonal1 = new Negocios.Componentes.CbbPersonal();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.despachoDataSet = new Despacho.DespachoDataSet();
            this.txtCodigo = new Negocios.Componentes.TextPersonal();
            this.txtDescripcion = new Negocios.Componentes.TextPersonal();
            this.chEstado = new Telerik.WinControls.UI.RadToggleSwitch();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.unidadTableAdapter = new Despacho.DespachoDataSetTableAdapters.UnidadTableAdapter();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Despacho.DespachoDataSetTableAdapters.ProductoTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btCancelar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(547, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 117);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btCancelar
            // 
            this.btCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancelar.Location = new System.Drawing.Point(3, 61);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(140, 53);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.ThemeName = "VisualStudio2012Light";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.Location = new System.Drawing.Point(3, 3);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(140, 52);
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
            this.radGroupBox1.HeaderText = "Lista de Producto";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 135);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(681, 447);
            this.radGroupBox1.TabIndex = 13;
            this.radGroupBox1.Text = "Lista de Producto";
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
            gridViewDecimalColumn9.DataType = typeof(int);
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "IdProducto";
            gridViewDecimalColumn9.HeaderText = "Codigo";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.Name = "IdProducto";
            gridViewDecimalColumn9.Width = 107;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Producto";
            gridViewTextBoxColumn9.HeaderText = "Producto";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Producto";
            gridViewTextBoxColumn9.Width = 396;
            gridViewDecimalColumn10.DataType = typeof(int);
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FieldName = "IdUnidad";
            gridViewDecimalColumn10.HeaderText = "IdUnidad";
            gridViewDecimalColumn10.IsAutoGenerated = true;
            gridViewDecimalColumn10.IsVisible = false;
            gridViewDecimalColumn10.Name = "IdUnidad";
            gridViewDecimalColumn10.Width = 151;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Unidad";
            gridViewTextBoxColumn10.HeaderText = "Unidad";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "Unidad";
            gridViewTextBoxColumn10.Width = 177;
            this.dataPropietario.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn9,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn10,
            gridViewTextBoxColumn10});
            this.dataPropietario.MasterTemplate.DataSource = this.productoBindingSource;
            this.dataPropietario.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataPropietario.MasterTemplate.EnableGrouping = false;
            this.dataPropietario.MasterTemplate.EnableSorting = false;
            this.dataPropietario.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataPropietario.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.dataPropietario.Name = "dataPropietario";
            this.dataPropietario.ReadOnly = true;
            this.dataPropietario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataPropietario.Size = new System.Drawing.Size(677, 427);
            this.dataPropietario.TabIndex = 0;
            this.dataPropietario.ThemeName = "VisualStudio2012Light";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.cbbPersonal1);
            this.radPanel1.Controls.Add(this.txtCodigo);
            this.radPanel1.Controls.Add(this.txtDescripcion);
            this.radPanel1.Controls.Add(this.chEstado);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radSeparator1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(528, 117);
            this.radPanel1.TabIndex = 12;
            this.radPanel1.ThemeName = "VisualStudio2012Light";
            // 
            // cbbPersonal1
            // 
            this.cbbPersonal1.Correo = false;
            this.cbbPersonal1.DataSource = this.unidadBindingSource;
            this.cbbPersonal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPersonal1.Limpiar = false;
            this.cbbPersonal1.Location = new System.Drawing.Point(87, 84);
            this.cbbPersonal1.Name = "cbbPersonal1";
            this.cbbPersonal1.Size = new System.Drawing.Size(125, 25);
            this.cbbPersonal1.TabIndex = 6;
            this.cbbPersonal1.ThemeName = "VisualStudio2012Light";
            this.cbbPersonal1.Validar = false;
            // 
            // unidadBindingSource
            // 
            this.unidadBindingSource.DataMember = "Unidad";
            this.unidadBindingSource.DataSource = this.despachoDataSet;
            // 
            // despachoDataSet
            // 
            this.despachoDataSet.DataSetName = "DespachoDataSet";
            this.despachoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Correo = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = true;
            this.txtCodigo.Location = new System.Drawing.Point(70, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(82, 24);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.ThemeName = "VisualStudio2012Light";
            this.txtCodigo.Validar = true;
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
            this.chEstado.Location = new System.Drawing.Point(439, 89);
            this.chEstado.Name = "chEstado";
            this.chEstado.OffText = "Inactivo";
            this.chEstado.OnText = "Activo";
            this.chEstado.Size = new System.Drawing.Size(86, 20);
            this.chEstado.TabIndex = 4;
            this.chEstado.ThemeName = "VisualStudio2012Light";
            this.chEstado.ThumbTickness = 15;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(30, 87);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(51, 21);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Unidad";
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
            this.radLabel1.Size = new System.Drawing.Size(51, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Codigo";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // unidadTableAdapter
            // 
            this.unidadTableAdapter.ClearBeforeFill = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.despachoDataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Producto
            // 
            this.AcceptButton = this.btGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Producto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Mantenimiento de producto";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPersonal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btCancelar;
        private Telerik.WinControls.UI.RadButton btGuardar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView dataPropietario;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Negocios.Componentes.TextPersonal txtCodigo;
        private Negocios.Componentes.TextPersonal txtDescripcion;
        private Telerik.WinControls.UI.RadToggleSwitch chEstado;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Negocios.Componentes.CbbPersonal cbbPersonal1;
        private DespachoDataSet despachoDataSet;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private DespachoDataSetTableAdapters.UnidadTableAdapter unidadTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DespachoDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
