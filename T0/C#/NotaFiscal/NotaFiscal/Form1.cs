using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaFiscal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = 3589.0;
            double imposto=0.0;

            if (valorNotaFiscal < 1000.0)
            {
                imposto = 0.02;
            }
            if (valorNotaFiscal >= 1000 && valorNotaFiscal < 3000.0)
            {
                imposto = 0.025;
            }
            if (valorNotaFiscal >= 3000 && valorNotaFiscal < 7000)
            {
                imposto = 0.028;
            }
            if (valorNotaFiscal >= 7000)
            {
                imposto = 0.03;
            }
            MessageBox.Show(" O valor do imposto é de : "+imposto);
        }
    }
}
