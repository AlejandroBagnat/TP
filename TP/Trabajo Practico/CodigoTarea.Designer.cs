﻿namespace Clase_4
{
    partial class CodigoTarea
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
            this.TxtCodigoTarea = new System.Windows.Forms.TextBox();
            this.ErrUCtarea = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrUCtarea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de tarea";
            // 
            // TxtCodigoTarea
            // 
            this.TxtCodigoTarea.Location = new System.Drawing.Point(177, 13);
            this.TxtCodigoTarea.Name = "TxtCodigoTarea";
            this.TxtCodigoTarea.Size = new System.Drawing.Size(132, 22);
            this.TxtCodigoTarea.TabIndex = 1;
            this.TxtCodigoTarea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoTarea_KeyDown);
            // 
            // ErrUCtarea
            // 
            this.ErrUCtarea.ContainerControl = this;
            // 
            // CodigoTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtCodigoTarea);
            this.Controls.Add(this.label1);
            this.Name = "CodigoTarea";
            this.Size = new System.Drawing.Size(322, 46);
            this.Load += new System.EventHandler(this.CodigoTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrUCtarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigoTarea;
        private System.Windows.Forms.ErrorProvider ErrUCtarea;
    }
}
