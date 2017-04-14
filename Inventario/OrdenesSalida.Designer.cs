namespace Inventario
{
    partial class OrdenesSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesSalida));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.agregarCarritoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.articulosDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.articulosDataGrid = new System.Windows.Forms.DataGridView();
            this.fechaOrdenSalida = new System.Windows.Forms.DateTimePicker();
            this.comentarioTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.listaProyectos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.articulosVerLista = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.fechaVer = new System.Windows.Forms.DateTimePicker();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.IdVerTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comentarioVerTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ordenesSalidaVerLista = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListGrande = new System.Windows.Forms.ImageList(this.components);
            this.imageListPeque = new System.Windows.Forms.ImageList(this.components);
            this.proyectosVerLista = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadInventarioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVerLista)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.fechaOrdenSalida);
            this.tabPage1.Controls.Add(this.comentarioTxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.agregarBtn);
            this.tabPage1.Controls.Add(this.listaProyectos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.borrarBtn);
            this.groupBox1.Controls.Add(this.agregarCarritoBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buscarTxt);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(29, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 284);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulos";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(783, 228);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(104, 23);
            this.limpiarBtn.TabIndex = 63;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(673, 228);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(104, 23);
            this.borrarBtn.TabIndex = 62;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // agregarCarritoBtn
            // 
            this.agregarCarritoBtn.Location = new System.Drawing.Point(190, 221);
            this.agregarCarritoBtn.Name = "agregarCarritoBtn";
            this.agregarCarritoBtn.Size = new System.Drawing.Size(104, 23);
            this.agregarCarritoBtn.TabIndex = 61;
            this.agregarCarritoBtn.Text = "Agregar";
            this.agregarCarritoBtn.UseVisualStyleBackColor = true;
            this.agregarCarritoBtn.Click += new System.EventHandler(this.agregarCarritoBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Buscar:";
            // 
            // buscarTxt
            // 
            this.buscarTxt.Location = new System.Drawing.Point(131, 31);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(284, 20);
            this.buscarTxt.TabIndex = 59;
            this.buscarTxt.TextChanged += new System.EventHandler(this.buscarTxt_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.articulosDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(512, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 203);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articulos seleccionados";
            // 
            // articulosDataGridView
            // 
            this.articulosDataGridView.AllowUserToAddRows = false;
            this.articulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nombreColumn,
            this.unidadColumn,
            this.precioColumn,
            this.cantidadColumn,
            this.totalColumn});
            this.articulosDataGridView.Location = new System.Drawing.Point(6, 19);
            this.articulosDataGridView.Name = "articulosDataGridView";
            this.articulosDataGridView.Size = new System.Drawing.Size(494, 179);
            this.articulosDataGridView.TabIndex = 1;
            this.articulosDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticulosDataGridView_CellEndEdit);
            this.articulosDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ArticulosDataGridView_EditingControlShowing);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            // 
            // unidadColumn
            // 
            this.unidadColumn.HeaderText = "Unidad";
            this.unidadColumn.Name = "unidadColumn";
            this.unidadColumn.ReadOnly = true;
            // 
            // precioColumn
            // 
            this.precioColumn.HeaderText = "Precio";
            this.precioColumn.Name = "precioColumn";
            this.precioColumn.ReadOnly = true;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad";
            this.cantidadColumn.Name = "cantidadColumn";
            // 
            // totalColumn
            // 
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.articulosDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(22, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 172);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos en Inventario";
            // 
            // articulosDataGrid
            // 
            this.articulosDataGrid.AllowUserToAddRows = false;
            this.articulosDataGrid.AllowUserToDeleteRows = false;
            this.articulosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosDataGrid.Location = new System.Drawing.Point(6, 15);
            this.articulosDataGrid.Name = "articulosDataGrid";
            this.articulosDataGrid.ReadOnly = true;
            this.articulosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articulosDataGrid.Size = new System.Drawing.Size(458, 150);
            this.articulosDataGrid.TabIndex = 0;
            // 
            // fechaOrdenSalida
            // 
            this.fechaOrdenSalida.Location = new System.Drawing.Point(433, 68);
            this.fechaOrdenSalida.Name = "fechaOrdenSalida";
            this.fechaOrdenSalida.Size = new System.Drawing.Size(247, 20);
            this.fechaOrdenSalida.TabIndex = 64;
            // 
            // comentarioTxt
            // 
            this.comentarioTxt.Location = new System.Drawing.Point(433, 97);
            this.comentarioTxt.Multiline = true;
            this.comentarioTxt.Name = "comentarioTxt";
            this.comentarioTxt.Size = new System.Drawing.Size(247, 82);
            this.comentarioTxt.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Comentario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Fecha:";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(497, 475);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarBtn.TabIndex = 60;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // listaProyectos
            // 
            this.listaProyectos.FormattingEnabled = true;
            this.listaProyectos.Location = new System.Drawing.Point(433, 32);
            this.listaProyectos.Name = "listaProyectos";
            this.listaProyectos.Size = new System.Drawing.Size(247, 21);
            this.listaProyectos.TabIndex = 59;
            this.listaProyectos.SelectedIndexChanged += new System.EventHandler(this.listaProyectos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Proyecto:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.fechaVer);
            this.tabPage2.Controls.Add(this.modificarBtn);
            this.tabPage2.Controls.Add(this.eliminarBtn);
            this.tabPage2.Controls.Add(this.IdVerTxt);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.comentarioVerTxt);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.ordenesSalidaVerLista);
            this.tabPage2.Controls.Add(this.proyectosVerLista);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.articulosVerLista);
            this.groupBox5.Location = new System.Drawing.Point(494, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(569, 203);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Articulos";
            // 
            // articulosVerLista
            // 
            this.articulosVerLista.AllowUserToAddRows = false;
            this.articulosVerLista.AllowUserToDeleteRows = false;
            this.articulosVerLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosVerLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.cantidadInventarioColumn});
            this.articulosVerLista.Location = new System.Drawing.Point(6, 19);
            this.articulosVerLista.Name = "articulosVerLista";
            this.articulosVerLista.Size = new System.Drawing.Size(557, 179);
            this.articulosVerLista.TabIndex = 1;
            this.articulosVerLista.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.articulosVerLista_CellEndEdit);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Ordenes de Salida:";
            // 
            // fechaVer
            // 
            this.fechaVer.Location = new System.Drawing.Point(125, 310);
            this.fechaVer.Name = "fechaVer";
            this.fechaVer.Size = new System.Drawing.Size(297, 20);
            this.fechaVer.TabIndex = 81;
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(453, 469);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(75, 23);
            this.modificarBtn.TabIndex = 80;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(534, 469);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 79;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // IdVerTxt
            // 
            this.IdVerTxt.Enabled = false;
            this.IdVerTxt.Location = new System.Drawing.Point(125, 276);
            this.IdVerTxt.Name = "IdVerTxt";
            this.IdVerTxt.Size = new System.Drawing.Size(297, 20);
            this.IdVerTxt.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Id:";
            // 
            // comentarioVerTxt
            // 
            this.comentarioVerTxt.Location = new System.Drawing.Point(125, 339);
            this.comentarioVerTxt.Multiline = true;
            this.comentarioVerTxt.Name = "comentarioVerTxt";
            this.comentarioVerTxt.Size = new System.Drawing.Size(345, 104);
            this.comentarioVerTxt.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Comentario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Fecha:";
            // 
            // ordenesSalidaVerLista
            // 
            this.ordenesSalidaVerLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ordenesSalidaVerLista.FullRowSelect = true;
            this.ordenesSalidaVerLista.LargeImageList = this.imageListGrande;
            this.ordenesSalidaVerLista.Location = new System.Drawing.Point(325, 83);
            this.ordenesSalidaVerLista.MultiSelect = false;
            this.ordenesSalidaVerLista.Name = "ordenesSalidaVerLista";
            this.ordenesSalidaVerLista.Size = new System.Drawing.Size(453, 134);
            this.ordenesSalidaVerLista.SmallImageList = this.imageListPeque;
            this.ordenesSalidaVerLista.TabIndex = 73;
            this.ordenesSalidaVerLista.UseCompatibleStateImageBehavior = false;
            this.ordenesSalidaVerLista.SelectedIndexChanged += new System.EventHandler(this.ordenesEntradaVerLista_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Proyecto";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fecha";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Comentario";
            this.columnHeader8.Width = 150;
            // 
            // imageListGrande
            // 
            this.imageListGrande.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGrande.ImageStream")));
            this.imageListGrande.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGrande.Images.SetKeyName(0, "notebook.png");
            // 
            // imageListPeque
            // 
            this.imageListPeque.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPeque.ImageStream")));
            this.imageListPeque.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPeque.Images.SetKeyName(0, "pencil.png");
            // 
            // proyectosVerLista
            // 
            this.proyectosVerLista.FormattingEnabled = true;
            this.proyectosVerLista.Location = new System.Drawing.Point(453, 33);
            this.proyectosVerLista.Name = "proyectosVerLista";
            this.proyectosVerLista.Size = new System.Drawing.Size(190, 21);
            this.proyectosVerLista.TabIndex = 72;
            this.proyectosVerLista.SelectedIndexChanged += new System.EventHandler(this.proyectosVerLista_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 71;
            this.label14.Text = "Proyecto:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDetalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IdArticulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // cantidadInventarioColumn
            // 
            this.cantidadInventarioColumn.HeaderText = "Cantidad Inventario";
            this.cantidadInventarioColumn.Name = "cantidadInventarioColumn";
            this.cantidadInventarioColumn.ReadOnly = true;
            // 
            // OrdenesSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "OrdenesSalida";
            this.Text = "Ordenes de Salida";
            this.Load += new System.EventHandler(this.OrdenesSalida_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articulosVerLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Button agregarCarritoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView articulosDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView articulosDataGrid;
        private System.Windows.Forms.DateTimePicker fechaOrdenSalida;
        private System.Windows.Forms.TextBox comentarioTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.ComboBox listaProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaVer;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.TextBox IdVerTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox comentarioVerTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView ordenesSalidaVerLista;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox proyectosVerLista;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView articulosVerLista;
        private System.Windows.Forms.ImageList imageListGrande;
        private System.Windows.Forms.ImageList imageListPeque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadInventarioColumn;
    }
}