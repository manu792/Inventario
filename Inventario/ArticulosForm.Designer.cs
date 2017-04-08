namespace Inventario
{
    partial class ArticulosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticulosForm));
            this.modificatBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.articulosListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unidadColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precioColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.unidadTxt = new System.Windows.Forms.TextBox();
            this.articuloTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageListGrande = new System.Windows.Forms.ImageList(this.components);
            this.imageListPeque = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // modificatBtn
            // 
            this.modificatBtn.Location = new System.Drawing.Point(334, 388);
            this.modificatBtn.Name = "modificatBtn";
            this.modificatBtn.Size = new System.Drawing.Size(75, 23);
            this.modificatBtn.TabIndex = 50;
            this.modificatBtn.Text = "Modificar";
            this.modificatBtn.UseVisualStyleBackColor = true;
            this.modificatBtn.Click += new System.EventHandler(this.modificatBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(252, 388);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 49;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // articulosListView
            // 
            this.articulosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nombreColumn,
            this.unidadColumn,
            this.precioColumn,
            this.descripcionColumn});
            this.articulosListView.LargeImageList = this.imageListGrande;
            this.articulosListView.Location = new System.Drawing.Point(41, 33);
            this.articulosListView.MultiSelect = false;
            this.articulosListView.Name = "articulosListView";
            this.articulosListView.Size = new System.Drawing.Size(497, 166);
            this.articulosListView.SmallImageList = this.imageListPeque;
            this.articulosListView.TabIndex = 48;
            this.articulosListView.UseCompatibleStateImageBehavior = false;
            this.articulosListView.SelectedIndexChanged += new System.EventHandler(this.articulosListView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            // 
            // nombreColumn
            // 
            this.nombreColumn.Text = "Nombre";
            // 
            // unidadColumn
            // 
            this.unidadColumn.Text = "Unidad";
            // 
            // precioColumn
            // 
            this.precioColumn.Text = "Precio";
            // 
            // descripcionColumn
            // 
            this.descripcionColumn.Text = "Descripcion";
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(241, 229);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(161, 20);
            this.idTxt.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Id:";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(171, 388);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarBtn.TabIndex = 45;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(241, 333);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(161, 20);
            this.descripcionTxt.TabIndex = 42;
            // 
            // precioTxt
            // 
            this.precioTxt.Location = new System.Drawing.Point(241, 309);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(161, 20);
            this.precioTxt.TabIndex = 41;
            // 
            // unidadTxt
            // 
            this.unidadTxt.Location = new System.Drawing.Point(241, 283);
            this.unidadTxt.Name = "unidadTxt";
            this.unidadTxt.Size = new System.Drawing.Size(161, 20);
            this.unidadTxt.TabIndex = 40;
            // 
            // articuloTxt
            // 
            this.articuloTxt.Location = new System.Drawing.Point(241, 257);
            this.articuloTxt.Name = "articuloTxt";
            this.articuloTxt.Size = new System.Drawing.Size(161, 20);
            this.articuloTxt.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Unidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre:";
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
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 469);
            this.Controls.Add(this.modificatBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.articulosListView);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.descripcionTxt);
            this.Controls.Add(this.precioTxt);
            this.Controls.Add(this.unidadTxt);
            this.Controls.Add(this.articuloTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArticulosForm";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.ArticulosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificatBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.ListView articulosListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nombreColumn;
        private System.Windows.Forms.ColumnHeader unidadColumn;
        private System.Windows.Forms.ColumnHeader precioColumn;
        private System.Windows.Forms.ColumnHeader descripcionColumn;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.TextBox unidadTxt;
        private System.Windows.Forms.TextBox articuloTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageListGrande;
        private System.Windows.Forms.ImageList imageListPeque;
    }
}