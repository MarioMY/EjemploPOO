using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class XboxOneS : Xbox
    {
        string resolucion;


        public string Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }


        public XboxOneS() : base()
        {
            resolucion = "";
        }


        public override string ToString()
        {
            return base.ToString() + " " + resolucion;
        }
    }
}
