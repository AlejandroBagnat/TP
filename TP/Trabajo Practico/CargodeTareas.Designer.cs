namespace Clase_4
{
    partial class CargodeTareas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFechaEntrega = new System.Windows.Forms.TextBox();
            this.CB1Tarea = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ErrTarea = new System.Windows.Forms.ErrorProvider(this.components);
            this.codigoTarea1 = new Clase_4.CodigoTarea();
            this.plazoDeEntrega1 = new Clase_4.PlazoDeEntrega();
            this.dataGridView1_Tareas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ErrTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Tareas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(16, 233);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 28);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Cargar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(139, 233);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 28);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(263, 233);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 28);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion de tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de entrega";
            // 
            // TxtFechaEntrega
            // 
            this.TxtFechaEntrega.Enabled = false;
            this.TxtFechaEntrega.Location = new System.Drawing.Point(191, 180);
            this.TxtFechaEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaEntrega.Name = "TxtFechaEntrega";
            this.TxtFechaEntrega.Size = new System.Drawing.Size(132, 22);
            this.TxtFechaEntrega.TabIndex = 12;
            // 
            // CB1Tarea
            // 
            this.CB1Tarea.FormattingEnabled = true;
            this.CB1Tarea.Items.AddRange(new object[] {
            "Pintar",
            "Lijar",
            "Rasquetear",
            "Enduir",
            "Limpiar"});
            this.CB1Tarea.Location = new System.Drawing.Point(191, 57);
            this.CB1Tarea.Margin = new System.Windows.Forms.Padding(4);
            this.CB1Tarea.Name = "CB1Tarea";
            this.CB1Tarea.Size = new System.Drawing.Size(132, 24);
            this.CB1Tarea.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // ErrTarea
            // 
            this.ErrTarea.ContainerControl = this;
            // 
            // codigoTarea1
            // 
            this.codigoTarea1.Location = new System.Drawing.Point(16, 4);
            this.codigoTarea1.Name = "codigoTarea1";
            this.codigoTarea1.Size = new System.Drawing.Size(322, 46);
            this.codigoTarea1.TabIndex = 19;
            // 
            // plazoDeEntrega1
            // 
            this.plazoDeEntrega1.Location = new System.Drawing.Point(11, 130);
            this.plazoDeEntrega1.Name = "plazoDeEntrega1";
            this.plazoDeEntrega1.Size = new System.Drawing.Size(333, 43);
            this.plazoDeEntrega1.TabIndex = 17;
            // 
            // dataGridView1_Tareas
            // 
            this.dataGridView1_Tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Tareas.Location = new System.Drawing.Point(361, 12);
            this.dataGridView1_Tareas.Name = "dataGridView1_Tareas";
            this.dataGridView1_Tareas.RowTemplate.Height = 24;
            this.dataGridView1_Tareas.Size = new System.Drawing.Size(386, 150);
            this.dataGridView1_Tareas.TabIndex = 20;
            // 
            // CargodeTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 277);
            this.Controls.Add(this.dataGridView1_Tareas);
            this.Controls.Add(this.codigoTarea1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.plazoDeEntrega1);
            this.Controls.Add(this.CB1Tarea);
            this.Controls.Add(this.TxtFechaEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CargodeTareas";
            this.Text = "Cargo de tareas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CargodeTareas_FormClosed);
            this.Load += new System.EventHandler(this.CargodeTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Tareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFechaEntrega;
        private System.Windows.Forms.ComboBox CB1Tarea;
        private PlazoDeEntrega plazoDeEntrega1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider ErrTarea;
        private CodigoTarea codigoTarea1;
        private System.Windows.Forms.DataGridView dataGridView1_Tareas;
    }
}