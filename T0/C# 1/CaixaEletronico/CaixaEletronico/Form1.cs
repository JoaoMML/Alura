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
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "João Marcos";
            umaConta.saldo = 300000.0 ;
            umaConta.agencia = 0489 ;
            umaConta.Cpf = 78945612309;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = " Gabriel Lima";
            outraConta.saldo = 25.0;
            outraConta.agencia = 1489;
            outraConta.Cpf = 99999999909;


            MessageBox.Show("O titular da conta 1 é: " + umaConta.titular + "\n  Saldo é de: " + umaConta.saldo + "\n Cpf : " + umaConta.Cpf + "\n Agencia n°: " + umaConta.agencia);
        }
    } 
}
