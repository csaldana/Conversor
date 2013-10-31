using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertir_Click(object sender, EventArgs e)
        {
            double dolares;
            double pesos;
            double cambio;
            try
            {
                dolares = System.Double.Parse(textcambio.Text);
                pesos = System.Double.Parse(textpeso.Text);
                cambio = System.Double.Parse(textcambio.Text)
;
                dolares = pesos / cambio;
                if (dolares == 0)
                {
                    MessageBox.Show("No se puede realizar la operacion" + dolares);
                }
                textdolares.Text = dolares.ToString();
            }
            catch (Exception m)
            {
                MessageBox.Show("Llena los campos para realizar la conversion"+m);
            }
        }
    }
}
