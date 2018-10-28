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
    public partial class PlazoDeEntrega : UserControl
    {
        public PlazoDeEntrega()
        {
            InitializeComponent();
        }

        public TextBox PlazoDeEntregaText {
                                             get {return TxtPlazoEntrega; }
                                           }

        private void PlazoDeEntrega_Load(object sender, EventArgs e)
        {
          
        }

    

        private void TxtPlazoEntrega_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter && TxtPlazoEntrega.Text != string.Empty)
                {
                    Regex GS = new Regex("^[3-9][0-9]?$|^180$");  // Plazos de entrega 30 a 180


                    if (!GS.IsMatch(TxtPlazoEntrega.Text))
                    {
                        MessageBox.Show("Solo se aceptan los plazos de entrega de 30 a 180");
                    }
                }
        }

    }
}
