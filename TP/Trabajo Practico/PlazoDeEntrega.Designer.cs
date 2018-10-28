namespace Clase_4
{
    partial class PlazoDeEntrega
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPlazoEntrega = new System.Windows.Forms.TextBox();
            this.ErrUCentrega = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrUCentrega)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plazo de entrega";
            // 
            // TxtPlazoEntrega
            // 
            this.TxtPlazoEntrega.Location = new System.Drawing.Point(182, 8);
            this.TxtPlazoEntrega.Name = "TxtPlazoEntrega";
            this.TxtPlazoEntrega.Size = new System.Drawing.Size(130, 22);
            this.TxtPlazoEntrega.TabIndex = 1;
            this.TxtPlazoEntrega.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPlazoEntrega_KeyDown);
            // 
            // ErrUCentrega
            // 
            this.ErrUCentrega.ContainerControl = this;
            // 
            // PlazoDeEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtPlazoEntrega);
            this.Controls.Add(this.label1);
            this.Name = "PlazoDeEntrega";
            this.Size = new System.Drawing.Size(352, 43);
            this.Load += new System.EventHandler(this.PlazoDeEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrUCentrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPlazoEntrega;
        private System.Windows.Forms.ErrorProvider ErrUCentrega;
    }
}
