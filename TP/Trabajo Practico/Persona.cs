using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_4
{
    public class Persona
    {

        public string PNombre { get; set; }
        public string PApellido{ get; set; }
        public string PCargo{ get; set; }
        public double PSueldo1{ get; set; }
        public double PSueldo2 { get; set; }
        public double PSueldo3 { get; set; }

        public double Total { get { return PSueldo1 + PSueldo2 + PSueldo3;} }

        public double PPromedio { get {return Total / 3;} }

     
    }
}
