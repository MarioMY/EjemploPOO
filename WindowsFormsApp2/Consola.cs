using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Consola
    {
        //Variable
        protected string almacenamiento;


        //Propiedades

        public string Almacenamiento
        {
            get { return almacenamiento; }
            set { almacenamiento = value; }
        }

        //Constructores

        public Consola()
        {
            almacenamiento = "";
        }


        public override string ToString()
        {
            return almacenamiento + "";
        }
    }
}
