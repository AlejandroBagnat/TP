namespace Clase_4
{
    partial class Form1
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
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSueldo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSueldo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSueldo3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBcargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSuma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPintor = new System.Windows.Forms.TextBox();
            this.Err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtOperarioL = new System.Windows.Forms.TextBox();
            this.TxtOperarioG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Err1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(16, 255);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(100, 28);
            this.BtnMostrar.TabIndex = 0;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(155, 255);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(297, 255);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 28);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(117, 12);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(132, 22);
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(117, 44);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(132, 22);
            this.TxtApellido.TabIndex = 6;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // TxtSueldo1
            // 
            this.TxtSueldo1.AcceptsReturn = true;
            this.TxtSueldo1.Location = new System.Drawing.Point(117, 75);
            this.TxtSueldo1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSueldo1.Name = "TxtSueldo1";
            this.TxtSueldo1.Size = new System.Drawing.Size(56, 22);
            this.TxtSueldo1.TabIndex = 8;
            this.TxtSueldo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSueldo1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sueldo 1";
            // 
            // TxtSueldo2
            // 
            this.TxtSueldo2.Location = new System.Drawing.Point(117, 107);
            this.TxtSueldo2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSueldo2.Name = "TxtSueldo2";
            this.TxtSueldo2.Size = new System.Drawing.Size(56, 22);
            this.TxtSueldo2.TabIndex = 10;
            this.TxtSueldo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSueldo2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sueldo 2";
            // 
            // TxtSueldo3
            // 
            this.TxtSueldo3.AcceptsReturn = true;
            this.TxtSueldo3.Location = new System.Drawing.Point(117, 139);
            this.TxtSueldo3.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSueldo3.Name = "TxtSueldo3";
            this.TxtSueldo3.Size = new System.Drawing.Size(56, 22);
            this.TxtSueldo3.TabIndex = 12;
            this.TxtSueldo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSueldo3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sueldo 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cargo";
            // 
            // CBcargo
            // 
            this.CBcargo.FormattingEnabled = true;
            this.CBcargo.Items.AddRange(new object[] {
            "Pintor",
            "Operario de limpieza",
            "Operario general"});
            this.CBcargo.Location = new System.Drawing.Point(117, 14);
            this.CBcargo.Margin = new System.Windows.Forms.Padding(4);
            this.CBcargo.Name = "CBcargo";
            this.CBcargo.Size = new System.Drawing.Size(132, 24);
            this.CBcargo.TabIndex = 14;
            this.CBcargo.SelectedIndexChanged += new System.EventHandler(this.CBcargo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad por cargo";
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.Location = new System.Drawing.Point(152, 43);
            this.TxtPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.Size = new System.Drawing.Size(132, 22);
            this.TxtPromedio.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Promedio";
            // 
            // TxtSuma
            // 
            this.TxtSuma.Location = new System.Drawing.Point(152, 11);
            this.TxtSuma.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSuma.Name = "TxtSuma";
            this.TxtSuma.Size = new System.Drawing.Size(132, 22);
            this.TxtSuma.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Suma";
            // 
            // TxtPintor
            // 
            this.TxtPintor.Location = new System.Drawing.Point(152, 102);
            this.TxtPintor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPintor.Name = "TxtPintor";
            this.TxtPintor.Size = new System.Drawing.Size(132, 22);
            this.TxtPintor.TabIndex = 20;
            // 
            // Err1
            // 
            this.Err1.ContainerControl = this;
            // 
            // TxtOperarioL
            // 
            this.TxtOperarioL.Location = new System.Drawing.Point(152, 137);
            this.TxtOperarioL.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOperarioL.Name = "TxtOperarioL";
            this.TxtOperarioL.Size = new System.Drawing.Size(132, 22);
            this.TxtOperarioL.TabIndex = 21;
            // 
            // TxtOperarioG
            // 
            this.TxtOperarioG.Location = new System.Drawing.Point(152, 169);
            this.TxtOperarioG.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOperarioG.Name = "TxtOperarioG";
            this.TxtOperarioG.Size = new System.Drawing.Size(132, 22);
            this.TxtOperarioG.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Pintor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Operario de limpieza";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Operario general";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSueldo3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtSueldo2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSueldo1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(277, 170);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBcargo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(273, 43);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Punto 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtOperarioG);
            this.groupBox3.Controls.Add(this.TxtOperarioL);
            this.groupBox3.Controls.Add(this.TxtPintor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtPromedio);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtSuma);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(297, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(301, 213);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar resultados";
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(427, 256);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(171, 26);
            this.BtnListar.TabIndex = 29;
            this.BtnListar.Text = "Listar Empleados";
            this.BtnListar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 294);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnMostrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cargar empleados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Err1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSueldo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSueldo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSueldo3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBcargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSuma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPintor;
        private System.Windows.Forms.ErrorProvider Err1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtOperarioG;
        private System.Windows.Forms.TextBox TxtOperarioL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnListar;

        public System.EventHandler Form1_Load { get; set; }
    }
}

