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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            BtnLimpiar.Visible = false;
            BtnMostrar.Visible = false;
            BtnSalir.Visible = false;
            CBcargo.SelectedIndex = -1;
        }

  


              
        public string TextBoxText_Nombre
        {
            get { 
                return TxtNombre.Text;
            }
            set { TxtNombre.Text = value; } 
        }

        public string TextBoxText_Apellido
        {
            get { return TxtApellido.Text; }
            set { TxtApellido.Text = value; }
        }

        public string TextBoxText_Sueldo1
        {
            get { return TxtSueldo1.Text; }
            set { TxtSueldo1.Text = value; }
        }

        public string TextBoxText_Sueldo2
        {
            get { return TxtSueldo2.Text; }
            set { TxtNombre.Text = value; }
        }

        public string TextBoxText_Sueldo3
        {
            get { return TxtSueldo3.Text; }
            set { TxtSueldo3.Text = value; }
        }

        public string ComboBoxText
        {
            get { return CBcargo.SelectedItem.ToString(); }
           
        }

       
        
        
       
        
        double CantI = 0, CantA = 0, Suma=0, CantG = 0, 
            SumP=0,SumOL=0,SumOG=0, TotalP=0,TotalOL=0,TotalOG=0, promT=0;
        double[] cantTotal= new double[3];
        


        

        
        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
               
       

                // Si es 1 selecciono Pintar
                // Si es 2 selecciono Operario de limpieza
                // Si es 3 selecciono Operario general

                // este SWITCH es para sacar el total y promedio por cargo

                switch (VerficarCargo())      
                {
                    case 1: Suma = 0;           
                            Suma = Suma + SumatoriaSueldo();
                            SumP = SumP + Suma;
                            if (TxtPintor.Text == "1")
	                        {
                                 TotalP = SumP;
                                 double prom = SumP / 3;
                                 prom = (Math.Round(prom, 2));
                                 promT = promT + prom;
                                 cantTotal[0] += TotalP;            
                                 TxtSuma.Text = cantTotal[0].ToString();
                                 TxtPromedio.Text = promT.ToString();
	                        }
                            else
	                        {
                                 TotalP = SumP;
                                 double prom = SumP / double.Parse(TxtPintor.Text);
                                 prom = (Math.Round(prom, 2));
                                 promT = promT + prom;
                                 cantTotal[0] += TotalP;             
                                 TxtSuma.Text = cantTotal[0].ToString();
                                 TxtPromedio.Text = promT.ToString();
	                        }
                           
                        break;
                    case 2: Suma = 0;
                            Suma = Suma + SumatoriaSueldo();
                            SumOL = SumOL + Suma;

                            if (TxtOperarioL.Text == "1")
                            {
                                TotalOL = SumOL;
                                double prom = SumOL / 3;
                                prom = (Math.Round(prom, 2));
                                promT = promT + prom;          
                                cantTotal[1] += TotalOL;
                                TxtSuma.Text = cantTotal[1].ToString();
                                TxtPromedio.Text = promT.ToString();
                            }
                            else
                            {
                                TotalOL = SumOL;
                                double prom = SumOL / double.Parse(TxtOperarioL.Text);
                                prom = (Math.Round(prom, 2));
                                promT = promT + prom;
                                cantTotal[1] += TotalOL;
                                TxtSuma.Text = cantTotal[1].ToString();
                                TxtPromedio.Text = promT.ToString();
                            }

                        break;
                    case 3: Suma = 0;
                            Suma = Suma + SumatoriaSueldo();
                            SumOG = SumOG + Suma;

                            if (TxtOperarioG.Text == "1")
                            {

                                TotalOG = SumOG;
                                double prom = SumOG / 3;
                                prom = (Math.Round(prom, 2));
                                promT = promT + prom;
                                cantTotal[2] += TotalOG;           
                                TxtSuma.Text = cantTotal[2].ToString();
                                TxtPromedio.Text = promT.ToString();
                            }
                            else
                            {
                                TotalOG = SumOG;
                                double prom = SumOG / double.Parse(TxtOperarioG.Text);
                                promT = promT + prom;
                                TxtSuma.Text = cantTotal[2].ToString();
                                TxtPromedio.Text = promT.ToString();
                            }

                        break;
                }

                

                CargarDatos();
                BorrarMensajes();
            }
            else
            {
                MessageBox.Show("Desea ingresar mas datos", "Faltan datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }


        
        public Form2 Menu2 { get; set; }
        
        public void CargarDatos()
        {
            Persona Empleado = new Persona();

            Empleado.PNombre = this.TextBoxText_Nombre;
            Empleado.PApellido = this.TextBoxText_Apellido;
            Empleado.PSueldo1 = double.Parse(this.TextBoxText_Sueldo1);
            Empleado.PSueldo2 = double.Parse(this.TextBoxText_Sueldo2);
            Empleado.PSueldo3 = double.Parse(this.TextBoxText_Sueldo3);
            Empleado.PCargo = this.ComboBoxText;

            this.Menu2.ListMain.Add(Empleado);
        }





        private double SumatoriaSueldo()
        {
            return (double.Parse(TxtSueldo1.Text) + double.Parse(TxtSueldo2.Text) + double.Parse(TxtSueldo3.Text));
        }

   
        private void BorrarMensajes()
        {
            Err1.SetError(TxtNombre, "");
            Err1.SetError(TxtApellido, "");
            Err1.SetError(TxtOperarioL, "");
            Err1.SetError(TxtOperarioG, "");
            Err1.SetError(TxtPintor, "");
            Err1.SetError(TxtSueldo1, "");
            Err1.SetError(TxtSueldo2, "");
            Err1.SetError(TxtSueldo3, "");
            Err1.SetError(CBcargo, "");
        }

        private bool ValidarCampos()
        {
            bool Validar = true;

            if (TxtNombre.Text == "")
            {
                Err1.SetError(TxtNombre, "Ingresar nombre");
                Validar = false;
            }

            if (TxtApellido.Text == "")
            {
                Err1.SetError(TxtApellido, "Ingresar apellido");
                Validar = false;
            }

            if (TxtSueldo1.Text == "")
            {
                Err1.SetError(TxtSueldo1, "Ingresar el sueldo 1");
                Validar = false;
            }

            if (TxtSueldo2.Text == "")
            {
                Err1.SetError(TxtSueldo2, "Ingresar el sueldo 2");
                Validar = false;
            }

            if (TxtSueldo3.Text == "")
            {
                Err1.SetError(TxtSueldo3, "Ingresar el sueldo 3");
                Validar = false;
            }

            if (CBcargo.Text == "")
            {
                Err1.SetError(CBcargo, "Ingresar el cargo");
                Validar = false;
            }
            return Validar;
        }

        private int VerficarCargo()
        {
            int i;

            if (CBcargo.SelectedItem.ToString() == "Pintor")
            {
               i = 1;
            }
            else
            {
                if (CBcargo.SelectedItem.ToString() == "Operario de limpieza")
                {
                    i = 2;
                }
                else
                {
                    i = 3;
                }
            }

            return i;
        }

        private void CantidadCargo()
        {
            if (this.CBcargo.SelectedItem.ToString() == "Pintor")
            {
                CantI++;
            }
            else
            {
                if (this.CBcargo.SelectedItem.ToString() == "Operario de limpieza")
                {
                    CantA++;
                }
                else
                {
                    CantG++;
                }
            }
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Menu2.Show();
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            CBcargo.Text = "";
            TxtSueldo1.Text = "";
            TxtSueldo2.Text = "";
            TxtSueldo3.Text = "";
            BorrarMensajes();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnLimpiar.Visible = true;
            BtnMostrar.Visible = true;
            BtnSalir.Visible = true;

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se admiten letras", "Validar las letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se admiten letras", "Validar las letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void TxtSueldo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros", "Validar los numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtSueldo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros", "Validar los numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtSueldo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros", "Validar los numeros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CBcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (CBcargo.SelectedIndex != -1)
             {
                 CantidadCargo();

                 TxtPintor.Text    = CantI.ToString();
                 TxtOperarioL.Text = CantA.ToString();
                 TxtOperarioG.Text = CantG.ToString();
             }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu2.Show();
        }


    }
}



