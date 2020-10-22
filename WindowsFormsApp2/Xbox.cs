using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Xbox : Consola 
    {
        protected string compañia;


        public string Compañia
        {
            get { return compañia; }
            set { compañia = value; }
        }


        public Xbox() : base()
        {
            compañia = "";
        }


        public override string ToString()
        {
            return base.ToString() + " " + compañia;
        }
    }
}
