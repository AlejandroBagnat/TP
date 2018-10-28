namespace Clase_4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.CB1Empleados = new System.Windows.Forms.ComboBox();
            this.CB2Tareas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tareas";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(143, 106);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(100, 28);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // CB1Empleados
            // 
            this.CB1Empleados.FormattingEnabled = true;
            this.CB1Empleados.Items.AddRange(new object[] {
            "Cargar empleados",
            "Listar empleados"});
            this.CB1Empleados.Location = new System.Drawing.Point(119, 28);
            this.CB1Empleados.Margin = new System.Windows.Forms.Padding(4);
            this.CB1Empleados.Name = "CB1Empleados";
            this.CB1Empleados.Size = new System.Drawing.Size(148, 24);
            this.CB1Empleados.TabIndex = 3;
            this.CB1Empleados.SelectedIndexChanged += new System.EventHandler(this.CB1Empleados_SelectedIndexChanged);
            // 
            // CB2Tareas
            // 
            this.CB2Tareas.FormattingEnabled = true;
            this.CB2Tareas.Items.AddRange(new object[] {
            "Carga de tareas"});
            this.CB2Tareas.Location = new System.Drawing.Point(119, 62);
            this.CB2Tareas.Margin = new System.Windows.Forms.Padding(4);
            this.CB2Tareas.Name = "CB2Tareas";
            this.CB2Tareas.Size = new System.Drawing.Size(148, 24);
            this.CB2Tareas.TabIndex = 4;
            this.CB2Tareas.SelectedIndexChanged += new System.EventHandler(this.CB2Tareas_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 140);
            this.Controls.Add(this.CB2Tareas);
            this.Controls.Add(this.CB1Empleados);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Menu empleados";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.ComboBox CB1Empleados;
        private System.Windows.Forms.ComboBox CB2Tareas;

        

      
    }
}