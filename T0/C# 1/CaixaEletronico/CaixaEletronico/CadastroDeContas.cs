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

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            this.comboTipo.Items.Add("Conta Corrente");
            this.comboTipo.Items.Add("Conta Poupança");
            this.comboTipo.Items.Add("Conta Investimentos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c;
            if (comboTipo.Text.Equals("Conta Poupança"))
            {
                c = new ContaPoupanca();
            }
            else if (comboTipo.Text.Equals("Conta Corrente"))
            {
                c = new ContaCorrente();
            }
            else
            {
                c = new ContaInvestimento();
            }
           
            c.Numero = Convert.ToInt32(numeroConta.Text);
            c.Titular = new Cliente();
            c.Titular.Nome = titularConta.Text;
            this.aplicacaoPrincipal.AdicionaConta(c);
            this.Close();
        }

        
    }
}
