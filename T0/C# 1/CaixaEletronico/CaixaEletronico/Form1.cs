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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.cliente = cliente;
            cliente.nome = "Professor Danton";
            conta.cliente.rg = "13456789-5";
            conta.cliente.cpf = "465879609";
            conta.cliente.endereco = " Rua Benner Sistemas 2018";
            conta.saldo = 100000.50;

            MessageBox.Show(" -> Cliente : " + cliente.nome + "\n -> RG:   " + cliente.rg + "\n -> CPF : " + cliente.cpf + "\n -> End: " + cliente.endereco + "\n -> Saldo atual : " + conta.saldo);
        }
    }
}

 