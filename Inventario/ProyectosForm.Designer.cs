namespace Inventario
{
    partial class ProyectosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectosForm));
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.encargadoTxt = new System.Windows.Forms.TextBox();
            this.proyectoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proyectosListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.encargadoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.direccionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaInicioColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaFinColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListGrande = new System.Windows.Forms.ImageList(this.components);
            this.imageListPeque = new System.Windows.Forms.ImageList(this.components);
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificatBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(238, 209);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(161, 20);
            this.idTxt.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Id:";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(142, 406);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarBtn.TabIndex = 27;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click_1);
            // 
            // fechaFin
            // 
            this.fechaFin.Location = new System.Drawing.Point(238, 365);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(161, 20);
            this.fechaFin.TabIndex = 26;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(238, 339);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(161, 20);
            this.fechaInicio.TabIndex = 25;
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(238, 313);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(161, 20);
            this.descripcionTxt.TabIndex = 24;
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(238, 289);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(161, 20);
            this.direccionTxt.TabIndex = 23;
            // 
            // encargadoTxt
            // 
            this.encargadoTxt.Location = new System.Drawing.Point(238, 263);
            this.encargadoTxt.Name = "encargadoTxt";
            this.encargadoTxt.Size = new System.Drawing.Size(161, 20);
            this.encargadoTxt.TabIndex = 22;
            // 
            // proyectoTxt
            // 
            this.proyectoTxt.Location = new System.Drawing.Point(238, 237);
            this.proyectoTxt.Name = "proyectoTxt";
            this.proyectoTxt.Size = new System.Drawing.Size(161, 20);
            this.proyectoTxt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Encargado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proyecto:";
            // 
            // proyectosListView
            // 
            this.proyectosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nombreColumn,
            this.encargadoColumn,
            this.direccionColumn,
            this.descripcionColumn,
            this.fechaInicioColumn,
            this.fechaFinColumn});
            this.proyectosListView.LargeImageList = this.imageListGrande;
            this.proyectosListView.Location = new System.Drawing.Point(38, 27);
            this.proyectosListView.MultiSelect = false;
            this.proyectosListView.Name = "proyectosListView";
            this.proyectosListView.Size = new System.Drawing.Size(497, 166);
            this.proyectosListView.SmallImageList = this.imageListPeque;
            this.proyectosListView.TabIndex = 30;
            this.proyectosListView.UseCompatibleStateImageBehavior = false;
            this.proyectosListView.SelectedIndexChanged += new System.EventHandler(this.proyectosListView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            // 
            // nombreColumn
            // 
            this.nombreColumn.Text = "Nombre";
            // 
            // encargadoColumn
            // 
            this.encargadoColumn.Text = "Encargado";
            // 
            // direccionColumn
            // 
            this.direccionColumn.Text = "Direccion";
            // 
            // descripcionColumn
            // 
            this.descripcionColumn.Text = "Descripcion";
            // 
            // fechaInicioColumn
            // 
            this.fechaInicioColumn.Text = "Fecha Inicio";
            // 
            // fechaFinColumn
            // 
            this.fechaFinColumn.Text = "Fecha Fin";
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
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(223, 406);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 31;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // modificatBtn
            // 
            this.modificatBtn.Location = new System.Drawing.Point(305, 406);
            this.modificatBtn.Name = "modificatBtn";
            this.modificatBtn.Size = new System.Drawing.Size(75, 23);
            this.modificatBtn.TabIndex = 32;
            this.modificatBtn.Text = "Modificar";
            this.modificatBtn.UseVisualStyleBackColor = true;
            this.modificatBtn.Click += new System.EventHandler(this.modificatBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(386, 406);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 33;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // ProyectosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 469);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.modificatBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.proyectosListView);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.descripcionTxt);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.encargadoTxt);
            this.Controls.Add(this.proyectoTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProyectosForm";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.InventarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.TextBox encargadoTxt;
        private System.Windows.Forms.TextBox proyectoTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView proyectosListView;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificatBtn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nombreColumn;
        private System.Windows.Forms.ColumnHeader encargadoColumn;
        private System.Windows.Forms.ColumnHeader direccionColumn;
        private System.Windows.Forms.ColumnHeader descripcionColumn;
        private System.Windows.Forms.ColumnHeader fechaInicioColumn;
        private System.Windows.Forms.ColumnHeader fechaFinColumn;
        private System.Windows.Forms.ImageList imageListGrande;
        private System.Windows.Forms.ImageList imageListPeque;
        private System.Windows.Forms.Button limpiarBtn;
    }
}

