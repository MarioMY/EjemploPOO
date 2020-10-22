using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            Consola c;
            c = new Consola();
            c.Almacenamiento = "500GB";
            MessageBox.Show(c.ToString());
        }

        private void btnXbox_Click(object sender, EventArgs e)
        {
            Xbox x;
            x = new Xbox();
            x.Compañia = "Microsoft Corporation";
            x.Almacenamiento = "1TB";
            MessageBox.Show(x.ToString());
        }

        private void btnXboxOneS_Click(object sender, EventArgs e)
        {
            XboxOneS xs;
            xs = new XboxOneS();
            xs.Compañia = "Microsoft Corporation";
            xs.Almacenamiento = "1TB";
            xs.Resolucion = "4K";
            MessageBox.Show(xs.ToString());
        }
    }
}
