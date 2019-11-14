namespace Despacho.Vistas
{
    partial class Categoria
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btImprimir = new Telerik.WinControls.UI.RadButton();
            this.btGuardar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.dataPropietario = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescripcion = new Negocios.Componentes.TextPersonal();
            this.txtPlaca = new Negocios.Componentes.TextPersonal();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.despachoDataSet = new Despacho.DespachoDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Despacho.DespachoDataSetTableAdapters.CategoriaTableAdapter();
            this.chEstado = new Telerik.WinControls.UI.RadToggleSwitch();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btImprimir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btGuardar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(272, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 91);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btImprimir
            // 
            this.btImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btImprimir.Location = new System.Drawing.Point(3, 48);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(140, 40);
            this.btImprimir.TabIndex = 1;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.ThemeName = "VisualStudio2012Light";
            // 
            // btGuardar
            // 
            this.btGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btGuardar.Location = new System.Drawing.Point(3, 3);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(140, 39);
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
            this.radGroupBox1.HeaderText = "Categorias";
            this.radGroupBox1.Location = new System.Drawing.Point(9, 109);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(406, 362);
            this.radGroupBox1.TabIndex = 13;
            this.radGroupBox1.Text = "Categorias";
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
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "IdCategoria";
            gridViewDecimalColumn4.HeaderText = "Codigo";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "IdCategoria";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewDecimalColumn4.Width = 77;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Descripcion";
            gridViewTextBoxColumn4.HeaderText = "Categoria";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Descripcion";
            gridViewTextBoxColumn4.Width = 216;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.FieldName = "Estado";
            gridViewCheckBoxColumn4.HeaderText = "Estado";
            gridViewCheckBoxColumn4.IsAutoGenerated = true;
            gridViewCheckBoxColumn4.MinWidth = 20;
            gridViewCheckBoxColumn4.Name = "Estado";
            gridViewCheckBoxColumn4.Width = 112;
            this.dataPropietario.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn4,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn4});
            this.dataPropietario.MasterTemplate.DataSource = this.categoriaBindingSource;
            this.dataPropietario.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataPropietario.MasterTemplate.EnableGrouping = false;
            this.dataPropietario.MasterTemplate.EnableSorting = false;
            this.dataPropietario.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataPropietario.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.dataPropietario.Name = "dataPropietario";
            this.dataPropietario.ReadOnly = true;
            this.dataPropietario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataPropietario.Size = new System.Drawing.Size(402, 342);
            this.dataPropietario.TabIndex = 0;
            this.dataPropietario.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(3, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(51, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Codigo";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(3, 42);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(248, 10);
            this.radSeparator1.TabIndex = 2;
            this.radSeparator1.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(3, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(65, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Correo = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(74, 55);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 24);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.ThemeName = "VisualStudio2012Light";
            this.txtDescripcion.Validar = true;
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
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.chEstado);
            this.radPanel1.Controls.Add(this.txtPlaca);
            this.radPanel1.Controls.Add(this.txtDescripcion);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radSeparator1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(254, 91);
            this.radPanel1.TabIndex = 12;
            this.radPanel1.ThemeName = "VisualStudio2012Light";
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
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.despachoDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // chEstado
            // 
            this.chEstado.Location = new System.Drawing.Point(145, 15);
            this.chEstado.Name = "chEstado";
            this.chEstado.OffText = "Inactivo";
            this.chEstado.OnText = "Activo";
            this.chEstado.Size = new System.Drawing.Size(106, 20);
            this.chEstado.TabIndex = 6;
            this.chEstado.ThemeName = "VisualStudio2012Light";
            this.chEstado.ThumbTickness = 15;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radPanel1);
            this.Name = "Categoria";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Mantenimiento de categoria";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton btImprimir;
        private Telerik.WinControls.UI.RadButton btGuardar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView dataPropietario;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Negocios.Componentes.TextPersonal txtDescripcion;
        private Negocios.Componentes.TextPersonal txtPlaca;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DespachoDataSet despachoDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DespachoDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Telerik.WinControls.UI.RadToggleSwitch chEstado;
    }
}
