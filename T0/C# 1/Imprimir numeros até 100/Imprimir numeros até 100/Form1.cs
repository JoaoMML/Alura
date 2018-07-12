using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimir_numeros_até_100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for(int i = 0; i <= 1000; i++)
            {
                soma += i;
            }
            MessageBox.Show("A soma dos numeros de 1 até 1000 é de: " + soma);
        }
    }
}
