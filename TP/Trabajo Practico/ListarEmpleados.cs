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
    public partial class ListarEmpleados : Form
    {
        
            public ListarEmpleados()
            {
                InitializeComponent();
            }


            private Form2 mainForm = null;

          
        public ListarEmpleados(Form2 callingForm)
        {
            mainForm = callingForm as Form2;
            InitializeComponent();
        }


        public DataGridView DataGridView_tabla
        {
            get { return DGridListarEmpleados; }
            set { DGridListarEmpleados = value; }
        }

        public Form2 Menu { get; set; }

        public void ListarLista()
        {
            DGridListarEmpleados.DataSource = null;
            DGridListarEmpleados.DataSource=Menu.ListMain;
            DGridListarEmpleados.Refresh();
            DGridListarEmpleados.Update();
        }

  

        private void ListarEmpleados_Load(object sender, EventArgs e)
        {
            ListarLista();
        }

        private void ListarEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Menu.Show();
        }

     
    }
}
