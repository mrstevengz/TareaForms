namespace Trabajo_Steven
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tbLista = new System.Windows.Forms.TabPage();
            this.tpGrafico = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.tStripEliminar = new System.Windows.Forms.ToolStripButton();
            this.tStripActualizar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNumEst = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.tBoxNombre = new System.Windows.Forms.TextBox();
            this.tBoxApellido = new System.Windows.Forms.TextBox();
            this.tBoxCIF = new System.Windows.Forms.TextBox();
            this.tBoxPromedio = new System.Windows.Forms.TextBox();
            this.tBoxMaterias = new System.Windows.Forms.TextBox();
            this.cBoxCarrera = new System.Windows.Forms.ComboBox();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoEstudiantes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabControl.SuspendLayout();
            this.tbLista.SuspendLayout();
            this.tpGrafico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tbLista);
            this.TabControl.Controls.Add(this.tpGrafico);
            this.TabControl.Location = new System.Drawing.Point(446, 52);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(531, 528);
            this.TabControl.TabIndex = 0;
            // 
            // tbLista
            // 
            this.tbLista.Controls.Add(this.dgvLista);
            this.tbLista.Location = new System.Drawing.Point(4, 22);
            this.tbLista.Name = "tbLista";
            this.tbLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbLista.Size = new System.Drawing.Size(523, 502);
            this.tbLista.TabIndex = 0;
            this.tbLista.Text = "Lista de Estudiantes";
            this.tbLista.UseVisualStyleBackColor = true;
            // 
            // tpGrafico
            // 
            this.tpGrafico.Controls.Add(this.graficoEstudiantes);
            this.tpGrafico.Location = new System.Drawing.Point(4, 22);
            this.tpGrafico.Name = "tpGrafico";
            this.tpGrafico.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrafico.Size = new System.Drawing.Size(523, 502);
            this.tpGrafico.TabIndex = 1;
            this.tpGrafico.Text = "Graficos";
            this.tpGrafico.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxApellido);
            this.groupBox1.Controls.Add(this.tBoxNombre);
            this.groupBox1.Controls.Add(this.lblNumEst);
            this.groupBox1.Controls.Add(this.tBoxCIF);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Estudiante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxCarrera);
            this.groupBox2.Controls.Add(this.lblCarrera);
            this.groupBox2.Controls.Add(this.tBoxMaterias);
            this.groupBox2.Controls.Add(this.tBoxPromedio);
            this.groupBox2.Controls.Add(this.lblPromedio);
            this.groupBox2.Controls.Add(this.lblMaterias);
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Academicos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.ContextMenuStrip = this.contextMenu;
            this.dgvLista.Location = new System.Drawing.Point(6, 15);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(511, 481);
            this.dgvLista.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 502);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(405, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(14, 550);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(196, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(216, 550);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(201, 42);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripGuardar,
            this.tStripEliminar,
            this.tStripActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tStripGuardar
            // 
            this.tStripGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tStripGuardar.Image")));
            this.tStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripGuardar.Name = "tStripGuardar";
            this.tStripGuardar.Size = new System.Drawing.Size(23, 22);
            this.tStripGuardar.Text = "toolStripButton1";
            this.tStripGuardar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tStripEliminar
            // 
            this.tStripEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tStripEliminar.Image")));
            this.tStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripEliminar.Name = "tStripEliminar";
            this.tStripEliminar.Size = new System.Drawing.Size(23, 22);
            this.tStripEliminar.Text = "toolStripButton2";
            this.tStripEliminar.Click += new System.EventHandler(this.tStripEliminar_Click);
            // 
            // tStripActualizar
            // 
            this.tStripActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStripActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tStripActualizar.Image")));
            this.tStripActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripActualizar.Name = "tStripActualizar";
            this.tStripActualizar.Size = new System.Drawing.Size(23, 22);
            this.tStripActualizar.Text = "toolStripButton3";
            this.tStripActualizar.Click += new System.EventHandler(this.tStripActualizar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(989, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripEstado
            // 
            this.toolStripEstado.Name = "toolStripEstado";
            this.toolStripEstado.Size = new System.Drawing.Size(134, 17);
            this.toolStripEstado.Text = "Estudiantes registrados: ";
            this.toolStripEstado.Click += new System.EventHandler(this.toolStripEstado_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(118, 48);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 86);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNumEst
            // 
            this.lblNumEst.AutoSize = true;
            this.lblNumEst.Location = new System.Drawing.Point(6, 143);
            this.lblNumEst.Name = "lblNumEst";
            this.lblNumEst.Size = new System.Drawing.Size(114, 13);
            this.lblNumEst.TabIndex = 2;
            this.lblNumEst.Text = "Numero de estudiante:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(9, 35);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(9, 75);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(94, 13);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio General:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(9, 120);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(104, 13);
            this.lblMaterias.TabIndex = 5;
            this.lblMaterias.Text = "Materias Aprobadas:";
            // 
            // tBoxNombre
            // 
            this.tBoxNombre.Location = new System.Drawing.Point(6, 57);
            this.tBoxNombre.Name = "tBoxNombre";
            this.tBoxNombre.Size = new System.Drawing.Size(380, 20);
            this.tBoxNombre.TabIndex = 6;
            this.tBoxNombre.TextChanged += new System.EventHandler(this.tBoxNombre_TextChanged);
            // 
            // tBoxApellido
            // 
            this.tBoxApellido.Location = new System.Drawing.Point(6, 111);
            this.tBoxApellido.Name = "tBoxApellido";
            this.tBoxApellido.Size = new System.Drawing.Size(380, 20);
            this.tBoxApellido.TabIndex = 7;
            // 
            // tBoxCIF
            // 
            this.tBoxCIF.Location = new System.Drawing.Point(9, 173);
            this.tBoxCIF.Name = "tBoxCIF";
            this.tBoxCIF.Size = new System.Drawing.Size(377, 20);
            this.tBoxCIF.TabIndex = 8;
            // 
            // tBoxPromedio
            // 
            this.tBoxPromedio.Location = new System.Drawing.Point(116, 72);
            this.tBoxPromedio.Name = "tBoxPromedio";
            this.tBoxPromedio.Size = new System.Drawing.Size(68, 20);
            this.tBoxPromedio.TabIndex = 9;
            // 
            // tBoxMaterias
            // 
            this.tBoxMaterias.Location = new System.Drawing.Point(116, 117);
            this.tBoxMaterias.Name = "tBoxMaterias";
            this.tBoxMaterias.Size = new System.Drawing.Size(68, 20);
            this.tBoxMaterias.TabIndex = 10;
            // 
            // cBoxCarrera
            // 
            this.cBoxCarrera.FormattingEnabled = true;
            this.cBoxCarrera.Items.AddRange(new object[] {
            "Ingenieria",
            "Medicina",
            "Derecho",
            "Administracion"});
            this.cBoxCarrera.Location = new System.Drawing.Point(116, 27);
            this.cBoxCarrera.Name = "cBoxCarrera";
            this.cBoxCarrera.Size = new System.Drawing.Size(121, 21);
            this.cBoxCarrera.TabIndex = 11;
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // graficoEstudiantes
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoEstudiantes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoEstudiantes.Legends.Add(legend2);
            this.graficoEstudiantes.Location = new System.Drawing.Point(18, 24);
            this.graficoEstudiantes.Name = "graficoEstudiantes";
            this.graficoEstudiantes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoEstudiantes.Series.Add(series2);
            this.graficoEstudiantes.Size = new System.Drawing.Size(489, 457);
            this.graficoEstudiantes.TabIndex = 0;
            this.graficoEstudiantes.Text = "Grafico Carrera";
            this.graficoEstudiantes.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 637);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Registro de Informacion Academica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tbLista.ResumeLayout(false);
            this.tpGrafico.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficoEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tbLista;
        private System.Windows.Forms.TabPage tpGrafico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripButton tStripGuardar;
        private System.Windows.Forms.ToolStripButton tStripEliminar;
        private System.Windows.Forms.ToolStripButton tStripActualizar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripEstado;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ComboBox cBoxCarrera;
        private System.Windows.Forms.TextBox tBoxApellido;
        private System.Windows.Forms.TextBox tBoxNombre;
        private System.Windows.Forms.Label lblNumEst;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox tBoxMaterias;
        private System.Windows.Forms.TextBox tBoxCIF;
        private System.Windows.Forms.TextBox tBoxPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoEstudiantes;
    }
}

