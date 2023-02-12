using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal nt;

        private void calculatbt_Click(object sender, EventArgs e)
        {
            if (nota1txt.Text == "")
            {
                errorProvider.SetError(nota1txt, "Ingrese un valor");
                return;
            }
            errorProvider.Clear();
            if (nota2txt.Text == "")
            {
                errorProvider.SetError(nota2txt, "Ingrese un valor");
                return;
            }
            errorProvider.Clear();
            if (nota3txt.Text == "")
            {
                errorProvider.SetError(nota3txt, "Ingrese un valor");
                return;
            }
            errorProvider.Clear();
            if (nota4txt.Text == "")
            {
                errorProvider.SetError(nota4txt, "Ingrese un valor");
                return;
            }
            errorProvider.Clear();

            decimal promediofinal = promedio(nt);
            MessageBox.Show("El promedio final es " + promediofinal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private decimal promedio(decimal notafinal)
        {
            notafinal = (Convert.ToDecimal(nota1txt.Text)/100 + Convert.ToDecimal(nota2txt.Text)/100 + Convert.ToDecimal(nota3txt.Text)/100 + Convert.ToDecimal(nota4txt.Text)/100) / 4;
            return notafinal;
        }

    }
}
