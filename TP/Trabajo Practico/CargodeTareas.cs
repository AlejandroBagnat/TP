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
    public partial class CargodeTareas : Form
    {
        public Form2 MenuCargarTareas { get; set; }

        public CargodeTareas()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposTareas())
            {
                Tareas T = new Tareas();
                
                    T.CodigoTareas = int.Parse(codigoTarea1.TxtCodigoTareaText.Text);
                    T.DescripcionTarea = CB1Tarea.SelectedItem.ToString();
                    T.Fecha = dateTimePicker1.Value.ToShortDateString();
                    T.PlazoEntrega = int.Parse(plazoDeEntrega1.PlazoDeEntregaText.Text);




                //DateTime t1 = dateTimePicker1.Value;
                //DateTime t2 = DateTime.Parse(plazoDeEntrega1.Text);
                //TimeSpan ts = t1.Subtract(t2);

                

                //DateTime mydate = DateTime.ParseExact(ts.ToString(), "dd/MM/yyyy", null);

                ////string Total = mydate.ToString();
                
           
                //T.FechaEntrega = mydate;     /*  ts.ToString();*/




                MenuCargarTareas.ListMTareas.Add(T);
                CargarGrid();
            }
        }

       

        public void CargarGrid()
        {
            dataGridView1_Tareas.DataSource = null;
            dataGridView1_Tareas.DataSource = MenuCargarTareas.ListMTareas;
            dataGridView1_Tareas.Refresh();
            dataGridView1_Tareas.Update();
        }


        private void CargodeTareas_Load(object sender, EventArgs e)
        {

        }

        private void CargodeTareas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuCargarTareas.Show();
        }

        private bool ValidarCamposTareas()
        {
            bool Validar = true;

           if (codigoTarea1.TxtCodigoTareaText.Text == "")
           {
              ErrTarea.SetError(codigoTarea1.TxtCodigoTareaText, "Ingresar el codigo de entrega");
              Validar = false;
           }

            if (CB1Tarea.SelectedIndex == -1)
            {
                ErrTarea.SetError(CB1Tarea, "Seleccionar la descripcion de la Fecha");
                Validar = false;
            }

            if (dateTimePicker1.TabIndex==-1)
            {
                ErrTarea.SetError(dateTimePicker1, "Seleccionar la Fecha");
                Validar = false;
            }

            if (plazoDeEntrega1.PlazoDeEntregaText.Text == "")
            {
                ErrTarea.SetError(plazoDeEntrega1.PlazoDeEntregaText, "Ingresar el plazo de entrega");
                Validar = false;
            }
            return Validar;
        }


            private void BtnSalir_Click(object sender, EventArgs e)
        {
            var Respuesta = MessageBox.Show("Va a cerrarse esta aplicacion",
                                            "Salir",
                                            MessageBoxButtons.YesNoCancel);

            if (Respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

      

        private void plazoDeEntrega2_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1_Tareas.SelectedRows.Count > 0)
            {
                Tareas T = new Tareas();
                MenuCargarTareas.ListMTareas.RemoveAt(this.dataGridView1_Tareas.SelectedRows[0].Index);
            }

            CargarGrid();
        }
    }
}
