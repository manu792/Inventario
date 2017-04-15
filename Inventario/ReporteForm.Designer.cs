namespace Inventario
{
    partial class ReporteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteForm));
            this.proyectosComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.articulosDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageListGrande = new System.Windows.Forms.ImageList(this.components);
            this.imageListPeque = new System.Windows.Forms.ImageList(this.components);
            this.ordenesEntradaListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ordenesSalidaListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.articulosVerLista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVerTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaVer = new System.Windows.Forms.DateTimePicker();
            this.comentarioVerTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.articulosOrdenSalida = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSalidaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.comentarioSalidaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exportarBtn = new System.Windows.Forms.Button();
            this.reporteBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVerLista)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosOrdenSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // proyectosComboBox
            // 
            this.proyectosComboBox.FormattingEnabled = true;
            this.proyectosComboBox.Location = new System.Drawing.Point(491, 24);
            this.proyectosComboBox.Name = "proyectosComboBox";
            this.proyectosComboBox.Size = new System.Drawing.Size(213, 21);
            this.proyectosComboBox.TabIndex = 0;
            this.proyectosComboBox.SelectedIndexChanged += new System.EventHandler(this.proyectosComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyecto:";
            // 
            // articulosDataGridView
            // 
            this.articulosDataGridView.AllowUserToAddRows = false;
            this.articulosDataGridView.AllowUserToDeleteRows = false;
            this.articulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.unidadColumn,
            this.precioColumn,
            this.descripcionColumn,
            this.cantidadColumn,
            this.totalColumn});
            this.articulosDataGridView.Location = new System.Drawing.Point(248, 76);
            this.articulosDataGridView.Name = "articulosDataGridView";
            this.articulosDataGridView.Size = new System.Drawing.Size(644, 150);
            this.articulosDataGridView.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Articulos:";
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
            // descripcionColumn
            // 
            this.descripcionColumn.HeaderText = "Descripcion";
            this.descripcionColumn.Name = "descripcionColumn";
            this.descripcionColumn.ReadOnly = true;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad Inventario";
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.ReadOnly = true;
            // 
            // totalColumn
            // 
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
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
            // ordenesEntradaListView
            // 
            this.ordenesEntradaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ordenesEntradaListView.FullRowSelect = true;
            this.ordenesEntradaListView.LargeImageList = this.imageListGrande;
            this.ordenesEntradaListView.Location = new System.Drawing.Point(84, 19);
            this.ordenesEntradaListView.MultiSelect = false;
            this.ordenesEntradaListView.Name = "ordenesEntradaListView";
            this.ordenesEntradaListView.Size = new System.Drawing.Size(314, 103);
            this.ordenesEntradaListView.SmallImageList = this.imageListPeque;
            this.ordenesEntradaListView.TabIndex = 76;
            this.ordenesEntradaListView.UseCompatibleStateImageBehavior = false;
            this.ordenesEntradaListView.SelectedIndexChanged += new System.EventHandler(this.ordenesEntradaListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proyecto";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comentario";
            this.columnHeader4.Width = 150;
            // 
            // ordenesSalidaListView
            // 
            this.ordenesSalidaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ordenesSalidaListView.FullRowSelect = true;
            this.ordenesSalidaListView.LargeImageList = this.imageListGrande;
            this.ordenesSalidaListView.Location = new System.Drawing.Point(86, 19);
            this.ordenesSalidaListView.MultiSelect = false;
            this.ordenesSalidaListView.Name = "ordenesSalidaListView";
            this.ordenesSalidaListView.Size = new System.Drawing.Size(314, 103);
            this.ordenesSalidaListView.SmallImageList = this.imageListPeque;
            this.ordenesSalidaListView.TabIndex = 77;
            this.ordenesSalidaListView.UseCompatibleStateImageBehavior = false;
            this.ordenesSalidaListView.SelectedIndexChanged += new System.EventHandler(this.ordenesSalidaListView_SelectedIndexChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.IdVerTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fechaVer);
            this.groupBox1.Controls.Add(this.comentarioVerTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ordenesEntradaListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 490);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes de Entrada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.idSalidaTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.fechaSalida);
            this.groupBox2.Controls.Add(this.comentarioSalidaTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ordenesSalidaListView);
            this.groupBox2.Location = new System.Drawing.Point(577, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 490);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenes de Salida";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.articulosVerLista);
            this.groupBox5.Location = new System.Drawing.Point(20, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(519, 203);
            this.groupBox5.TabIndex = 86;
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
            this.dataGridViewTextBoxColumn7});
            this.articulosVerLista.Location = new System.Drawing.Point(6, 19);
            this.articulosVerLista.Name = "articulosVerLista";
            this.articulosVerLista.Size = new System.Drawing.Size(507, 167);
            this.articulosVerLista.TabIndex = 1;
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
            // IdVerTxt
            // 
            this.IdVerTxt.Enabled = false;
            this.IdVerTxt.Location = new System.Drawing.Point(84, 128);
            this.IdVerTxt.Name = "IdVerTxt";
            this.IdVerTxt.Size = new System.Drawing.Size(314, 20);
            this.IdVerTxt.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Id:";
            // 
            // fechaVer
            // 
            this.fechaVer.Enabled = false;
            this.fechaVer.Location = new System.Drawing.Point(84, 156);
            this.fechaVer.Name = "fechaVer";
            this.fechaVer.Size = new System.Drawing.Size(314, 20);
            this.fechaVer.TabIndex = 83;
            // 
            // comentarioVerTxt
            // 
            this.comentarioVerTxt.Enabled = false;
            this.comentarioVerTxt.Location = new System.Drawing.Point(84, 182);
            this.comentarioVerTxt.Multiline = true;
            this.comentarioVerTxt.Name = "comentarioVerTxt";
            this.comentarioVerTxt.Size = new System.Drawing.Size(314, 82);
            this.comentarioVerTxt.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Comentario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Fecha:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.articulosOrdenSalida);
            this.groupBox3.Location = new System.Drawing.Point(22, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 203);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articulos";
            // 
            // articulosOrdenSalida
            // 
            this.articulosOrdenSalida.AllowUserToAddRows = false;
            this.articulosOrdenSalida.AllowUserToDeleteRows = false;
            this.articulosOrdenSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosOrdenSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.articulosOrdenSalida.Location = new System.Drawing.Point(6, 19);
            this.articulosOrdenSalida.Name = "articulosOrdenSalida";
            this.articulosOrdenSalida.Size = new System.Drawing.Size(507, 167);
            this.articulosOrdenSalida.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "IdDetalle";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "IdArticulo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Total";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // idSalidaTxt
            // 
            this.idSalidaTxt.Enabled = false;
            this.idSalidaTxt.Location = new System.Drawing.Point(86, 128);
            this.idSalidaTxt.Name = "idSalidaTxt";
            this.idSalidaTxt.Size = new System.Drawing.Size(314, 20);
            this.idSalidaTxt.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Id:";
            // 
            // fechaSalida
            // 
            this.fechaSalida.Enabled = false;
            this.fechaSalida.Location = new System.Drawing.Point(86, 156);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(314, 20);
            this.fechaSalida.TabIndex = 90;
            // 
            // comentarioSalidaTxt
            // 
            this.comentarioSalidaTxt.Enabled = false;
            this.comentarioSalidaTxt.Location = new System.Drawing.Point(86, 182);
            this.comentarioSalidaTxt.Multiline = true;
            this.comentarioSalidaTxt.Name = "comentarioSalidaTxt";
            this.comentarioSalidaTxt.Size = new System.Drawing.Size(314, 82);
            this.comentarioSalidaTxt.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Comentario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Fecha:";
            // 
            // exportarBtn
            // 
            this.exportarBtn.Location = new System.Drawing.Point(466, 749);
            this.exportarBtn.Name = "exportarBtn";
            this.exportarBtn.Size = new System.Drawing.Size(105, 23);
            this.exportarBtn.TabIndex = 80;
            this.exportarBtn.Text = "Exportar a Excel";
            this.exportarBtn.UseVisualStyleBackColor = true;
            this.exportarBtn.Click += new System.EventHandler(this.exportarBtn_Click);
            // 
            // reporteBtn
            // 
            this.reporteBtn.Location = new System.Drawing.Point(577, 749);
            this.reporteBtn.Name = "reporteBtn";
            this.reporteBtn.Size = new System.Drawing.Size(105, 23);
            this.reporteBtn.TabIndex = 81;
            this.reporteBtn.Text = "Generar Reporte";
            this.reporteBtn.UseVisualStyleBackColor = true;
            this.reporteBtn.Click += new System.EventHandler(this.reporteBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ordenes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Ordenes:";
            // 
            // ReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 784);
            this.Controls.Add(this.reporteBtn);
            this.Controls.Add(this.exportarBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articulosDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proyectosComboBox);
            this.Name = "ReporteForm";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.ReporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articulosVerLista)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.articulosOrdenSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox proyectosComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView articulosDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.ImageList imageListGrande;
        private System.Windows.Forms.ImageList imageListPeque;
        private System.Windows.Forms.ListView ordenesEntradaListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView ordenesSalidaListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView articulosVerLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox IdVerTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechaVer;
        private System.Windows.Forms.TextBox comentarioVerTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView articulosOrdenSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox idSalidaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.TextBox comentarioSalidaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exportarBtn;
        private System.Windows.Forms.Button reporteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}