using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Clase_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CB1Empleados.SelectedIndex = -1;
            CB2Tareas.SelectedIndex = -1;
        }
        
        public List<Persona> ListMain = new List<Persona>();
        public List<Tareas> ListMTareas = new List<Tareas>();


        private void CB1Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CB1Empleados.SelectedItem.ToString()=="Cargar empleados")
            {
                Form1 frm1 = new Form1();
                frm1.Menu2 =this;
                frm1.Show();
                this.Hide();
            }
            else
            {
                ListarEmpleados LE = new ListarEmpleados();

                LE.Menu = this;
                LE.Show();
                this.Hide();
            }
        }

        

        private void CB2Tareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CB2Tareas.SelectedItem.ToString() == "Carga de tareas")
            {
                CargodeTareas CT = new CargodeTareas();
                CT.MenuCargarTareas = this;
                CT.Show();
                this.Hide();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            var Respuesta = MessageBox.Show("Va a cerrarse esta aplicacion",
                                            "Salir",
                                            MessageBoxButtons.YesNoCancel);

            if (Respuesta==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CB1Empleados.SelectedIndex = -1;
            CB2Tareas.SelectedIndex = -1;
        }
    }
}


