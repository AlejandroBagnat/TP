namespace Clase_4
{
    partial class ListarEmpleados
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
            this.DGridListarEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridListarEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridListarEmpleados
            // 
            this.DGridListarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridListarEmpleados.Location = new System.Drawing.Point(1, 1);
            this.DGridListarEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.DGridListarEmpleados.Name = "DGridListarEmpleados";
            this.DGridListarEmpleados.Size = new System.Drawing.Size(1105, 175);
            this.DGridListarEmpleados.TabIndex = 0;
            // 
            // ListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 188);
            this.Controls.Add(this.DGridListarEmpleados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarEmpleados";
            this.Text = "ListarEmpleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListarEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.ListarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridListarEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridListarEmpleados;
    }
}