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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proyectoTxt = new System.Windows.Forms.TextBox();
            this.encargadoTxt = new System.Windows.Forms.TextBox();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fechaFinBuscarTxt = new System.Windows.Forms.DateTimePicker();
            this.fechaInicioBuscarTxt = new System.Windows.Forms.DateTimePicker();
            this.descripcionBuscarTxt = new System.Windows.Forms.TextBox();
            this.direccionBuscarTxt = new System.Windows.Forms.TextBox();
            this.encargadoBuscarTxt = new System.Windows.Forms.TextBox();
            this.proyectoBuscarTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listaProyectos = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.idBuscarTxt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.idTxt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.agregarBtn);
            this.tabPage1.Controls.Add(this.fechaFin);
            this.tabPage1.Controls.Add(this.fechaInicio);
            this.tabPage1.Controls.Add(this.descripcionTxt);
            this.tabPage1.Controls.Add(this.direccionTxt);
            this.tabPage1.Controls.Add(this.encargadoTxt);
            this.tabPage1.Controls.Add(this.proyectoTxt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.idBuscarTxt);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.listaProyectos);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.fechaFinBuscarTxt);
            this.tabPage2.Controls.Add(this.fechaInicioBuscarTxt);
            this.tabPage2.Controls.Add(this.descripcionBuscarTxt);
            this.tabPage2.Controls.Add(this.direccionBuscarTxt);
            this.tabPage2.Controls.Add(this.encargadoBuscarTxt);
            this.tabPage2.Controls.Add(this.proyectoBuscarTxt);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encargado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Fin:";
            // 
            // proyectoTxt
            // 
            this.proyectoTxt.Location = new System.Drawing.Point(198, 69);
            this.proyectoTxt.Name = "proyectoTxt";
            this.proyectoTxt.Size = new System.Drawing.Size(161, 20);
            this.proyectoTxt.TabIndex = 6;
            // 
            // encargadoTxt
            // 
            this.encargadoTxt.Location = new System.Drawing.Point(198, 95);
            this.encargadoTxt.Name = "encargadoTxt";
            this.encargadoTxt.Size = new System.Drawing.Size(161, 20);
            this.encargadoTxt.TabIndex = 7;
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(198, 121);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(161, 20);
            this.direccionTxt.TabIndex = 8;
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(198, 145);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(161, 20);
            this.descripcionTxt.TabIndex = 9;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(198, 171);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(161, 20);
            this.fechaInicio.TabIndex = 10;
            // 
            // fechaFin
            // 
            this.fechaFin.Location = new System.Drawing.Point(198, 197);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(161, 20);
            this.fechaFin.TabIndex = 11;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(213, 242);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarBtn.TabIndex = 12;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(198, 41);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(161, 20);
            this.idTxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Proyectos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fechaFinBuscarTxt
            // 
            this.fechaFinBuscarTxt.Location = new System.Drawing.Point(204, 238);
            this.fechaFinBuscarTxt.Name = "fechaFinBuscarTxt";
            this.fechaFinBuscarTxt.Size = new System.Drawing.Size(161, 20);
            this.fechaFinBuscarTxt.TabIndex = 26;
            // 
            // fechaInicioBuscarTxt
            // 
            this.fechaInicioBuscarTxt.Location = new System.Drawing.Point(204, 212);
            this.fechaInicioBuscarTxt.Name = "fechaInicioBuscarTxt";
            this.fechaInicioBuscarTxt.Size = new System.Drawing.Size(161, 20);
            this.fechaInicioBuscarTxt.TabIndex = 25;
            // 
            // descripcionBuscarTxt
            // 
            this.descripcionBuscarTxt.Location = new System.Drawing.Point(204, 186);
            this.descripcionBuscarTxt.Name = "descripcionBuscarTxt";
            this.descripcionBuscarTxt.Size = new System.Drawing.Size(161, 20);
            this.descripcionBuscarTxt.TabIndex = 24;
            // 
            // direccionBuscarTxt
            // 
            this.direccionBuscarTxt.Location = new System.Drawing.Point(204, 162);
            this.direccionBuscarTxt.Name = "direccionBuscarTxt";
            this.direccionBuscarTxt.Size = new System.Drawing.Size(161, 20);
            this.direccionBuscarTxt.TabIndex = 23;
            // 
            // encargadoBuscarTxt
            // 
            this.encargadoBuscarTxt.Location = new System.Drawing.Point(204, 136);
            this.encargadoBuscarTxt.Name = "encargadoBuscarTxt";
            this.encargadoBuscarTxt.Size = new System.Drawing.Size(161, 20);
            this.encargadoBuscarTxt.TabIndex = 22;
            // 
            // proyectoBuscarTxt
            // 
            this.proyectoBuscarTxt.Location = new System.Drawing.Point(204, 110);
            this.proyectoBuscarTxt.Name = "proyectoBuscarTxt";
            this.proyectoBuscarTxt.Size = new System.Drawing.Size(161, 20);
            this.proyectoBuscarTxt.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha Fin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha Inicio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Descripcion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Direccion:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Encargado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Proyecto:";
            // 
            // listaProyectos
            // 
            this.listaProyectos.FormattingEnabled = true;
            this.listaProyectos.Location = new System.Drawing.Point(204, 22);
            this.listaProyectos.Name = "listaProyectos";
            this.listaProyectos.Size = new System.Drawing.Size(161, 21);
            this.listaProyectos.TabIndex = 30;
            this.listaProyectos.SelectedIndexChanged += new System.EventHandler(this.listaProyectos_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Id:";
            // 
            // idBuscarTxt
            // 
            this.idBuscarTxt.Location = new System.Drawing.Point(204, 85);
            this.idBuscarTxt.Name = "idBuscarTxt";
            this.idBuscarTxt.Size = new System.Drawing.Size(161, 20);
            this.idBuscarTxt.TabIndex = 32;
            // 
            // InventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 380);
            this.Controls.Add(this.tabControl1);
            this.Name = "InventarioForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InventarioForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listaProyectos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechaFinBuscarTxt;
        private System.Windows.Forms.DateTimePicker fechaInicioBuscarTxt;
        private System.Windows.Forms.TextBox descripcionBuscarTxt;
        private System.Windows.Forms.TextBox direccionBuscarTxt;
        private System.Windows.Forms.TextBox encargadoBuscarTxt;
        private System.Windows.Forms.TextBox proyectoBuscarTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox idBuscarTxt;
        private System.Windows.Forms.Label label15;

    }
}

