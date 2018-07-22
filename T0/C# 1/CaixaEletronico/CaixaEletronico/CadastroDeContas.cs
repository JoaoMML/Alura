using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Numero = Convert.ToInt32(numeroConta.Text);
            conta.Titular = new Cliente(titularConta.Text);
            this.aplicacaoPrincipal.AdicionaConta(conta);  
        }
    }
}
