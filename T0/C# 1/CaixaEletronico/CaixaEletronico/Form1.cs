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
        private Conta conta;

        private void MostrarConta()
        {
            textN.Text = Convert.ToString(this.conta.Numero);
            textSaldo.Text = Convert.ToString("R$" + this.conta.Saldo);
            textoTitular.Text = this.conta.Titular.Nome;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente("Professor Danton") { Rg = "13456789-5", Cpf = "465879609", Idade = 30, Endereco = " Rua Benner Sistemas 2018" };
            //conta.saldo = 10000.00; 
            float vl = 1000;
            bool sacou = conta.Saca(vl);
            if (sacou)
            {
                MessageBox.Show(" Saque de  R$" + vl + " realizado com sucesso");
            }


            else
            {
                MessageBox.Show("Não foi possível sacar");
            }


            //  MessageBox.Show(" -> Cliente : " + cliente.nome + "\n -> RG:   " + cliente.rg + "\n -> CPF : " + cliente.cpf + "\n -> End: " + cliente.endereco + "\n -> Saldo atual : " + conta.saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            Cliente cliente = new Cliente("Victor") { Idade = 20 };
            this.conta.Titular = cliente;
            this.conta.Titular.Nome = cliente.Nome;
            this.conta.Numero = 1;
            this.conta.TipoConta = 2;
            
            textoTitular.Text = conta.Titular.Nome;
            textN.Text = Convert.ToString(conta.Numero);
            textSaldo.Text = Convert.ToString("R$ " + conta.Saldo);

            this.MostrarConta();

        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.conta.Deposita(valorDeposito);

            this.MostrarConta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string textoDoValorDoSaque = textoValor.Text;
                double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
                this.conta.Saca(valorSaque);

                this.MostrarConta();
            }

        }
    }
}

