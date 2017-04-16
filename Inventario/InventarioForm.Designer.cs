namespace Inventario
{
    partial class InventarioForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.articulos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.articulosDataGrid = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosPorProyecto = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.proyectosComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.articulosPorProyectoDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refrescarBtn = new System.Windows.Forms.Button();
            this.refrescar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.articulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGrid)).BeginInit();
            this.articulosPorProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosPorProyectoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.articulos);
            this.tabControl1.Controls.Add(this.articulosPorProyecto);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // articulos
            // 
            this.articulos.Controls.Add(this.refrescarBtn);
            this.articulos.Controls.Add(this.label1);
            this.articulos.Controls.Add(this.articulosDataGrid);
            this.articulos.Location = new System.Drawing.Point(4, 22);
            this.articulos.Name = "articulos";
            this.articulos.Padding = new System.Windows.Forms.Padding(3);
            this.articulos.Size = new System.Drawing.Size(655, 439);
            this.articulos.TabIndex = 0;
            this.articulos.Text = "Todos los Articulos";
            this.articulos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articulos:";
            // 
            // articulosDataGrid
            // 
            this.articulosDataGrid.AllowUserToAddRows = false;
            this.articulosDataGrid.AllowUserToDeleteRows = false;
            this.articulosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.unidadColumn,
            this.precioColumn,
            this.descripcionColumn});
            this.articulosDataGrid.Location = new System.Drawing.Point(53, 111);
            this.articulosDataGrid.Name = "articulosDataGrid";
            this.articulosDataGrid.Size = new System.Drawing.Size(496, 214);
            this.articulosDataGrid.TabIndex = 0;
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
            // articulosPorProyecto
            // 
            this.articulosPorProyecto.Controls.Add(this.refrescar);
            this.articulosPorProyecto.Controls.Add(this.label3);
            this.articulosPorProyecto.Controls.Add(this.proyectosComboBox);
            this.articulosPorProyecto.Controls.Add(this.label2);
            this.articulosPorProyecto.Controls.Add(this.articulosPorProyectoDataGrid);
            this.articulosPorProyecto.Location = new System.Drawing.Point(4, 22);
            this.articulosPorProyecto.Name = "articulosPorProyecto";
            this.articulosPorProyecto.Padding = new System.Windows.Forms.Padding(3);
            this.articulosPorProyecto.Size = new System.Drawing.Size(655, 439);
            this.articulosPorProyecto.TabIndex = 1;
            this.articulosPorProyecto.Text = "Articulos por Proyecto";
            this.articulosPorProyecto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proyecto:";
            // 
            // proyectosComboBox
            // 
            this.proyectosComboBox.FormattingEnabled = true;
            this.proyectosComboBox.Location = new System.Drawing.Point(217, 49);
            this.proyectosComboBox.Name = "proyectosComboBox";
            this.proyectosComboBox.Size = new System.Drawing.Size(185, 21);
            this.proyectosComboBox.TabIndex = 4;
            this.proyectosComboBox.SelectedIndexChanged += new System.EventHandler(this.proyectosComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articulos:";
            // 
            // articulosPorProyectoDataGrid
            // 
            this.articulosPorProyectoDataGrid.AllowUserToAddRows = false;
            this.articulosPorProyectoDataGrid.AllowUserToDeleteRows = false;
            this.articulosPorProyectoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosPorProyectoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.cantidadColumn,
            this.totalColumn});
            this.articulosPorProyectoDataGrid.Location = new System.Drawing.Point(6, 133);
            this.articulosPorProyectoDataGrid.Name = "articulosPorProyectoDataGrid";
            this.articulosPorProyectoDataGrid.Size = new System.Drawing.Size(643, 214);
            this.articulosPorProyectoDataGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // refrescarBtn
            // 
            this.refrescarBtn.Location = new System.Drawing.Point(265, 345);
            this.refrescarBtn.Name = "refrescarBtn";
            this.refrescarBtn.Size = new System.Drawing.Size(75, 23);
            this.refrescarBtn.TabIndex = 2;
            this.refrescarBtn.Text = "Refrescar";
            this.refrescarBtn.UseVisualStyleBackColor = true;
            this.refrescarBtn.Click += new System.EventHandler(this.refrescarBtn_Click);
            // 
            // refrescar
            // 
            this.refrescar.Location = new System.Drawing.Point(288, 367);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(75, 23);
            this.refrescar.TabIndex = 6;
            this.refrescar.Text = "Refrescar";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // InventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "InventarioForm";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.InventarioForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.articulos.ResumeLayout(false);
            this.articulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGrid)).EndInit();
            this.articulosPorProyecto.ResumeLayout(false);
            this.articulosPorProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosPorProyectoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView articulosDataGrid;
        private System.Windows.Forms.TabPage articulosPorProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox proyectosComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView articulosPorProyectoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.Button refrescarBtn;
        private System.Windows.Forms.Button refrescar;
    }
}