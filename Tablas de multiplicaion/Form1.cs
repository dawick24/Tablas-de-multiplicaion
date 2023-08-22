using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablas_de_multiplicaion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int tabla = int.Parse(txtTablaMultiplicacion.Text);
            int limite = int.Parse(txtLimiteMultiplicacion.Text);
            int resultado;

            for (int i = 1; i <= limite; i++)
            {
                resultado = tabla * i;
                listBox1.Items.Add(tabla + "x" + i + "=" + resultado);
            }
        }
    }
}
