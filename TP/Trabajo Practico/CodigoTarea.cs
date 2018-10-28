using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Clase_4
{
    public partial class CodigoTarea : UserControl
    {
        
        public CodigoTarea()
        {
            InitializeComponent();
        }

        public TextBox TxtCodigoTareaText
        {
            get { return TxtCodigoTarea; }
        }

        private void CodigoTarea_Load(object sender, EventArgs e)
        {
         
        }

   


        private void TxtCodigoTarea_KeyDown(object sender, KeyEventArgs e)
        {
                if (Convert.ToInt32(e.KeyCode) == 13)
                {
                    Regex GsTarea = new Regex(@"^[1-9]\d*$");

                    if (!GsTarea.IsMatch(TxtCodigoTarea.Text))
                    {
                        MessageBox.Show("Solo se aceptan los numeros positivos");
                    }
                }
        }
    }
}
