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
        Conta[] contas;

        private void MostrarConta(Conta conta)
        {
            textoTitular.Text = conta.Titular.Nome;
            textSaldo.Text = Convert.ToString("R$ " + conta.Saldo);
            textN.Text = Convert.ToString(conta.Numero);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            Cliente c1 = new Cliente();
            contas[0] = new Conta();
            contas[0].Titular = c1;
            contas[0].Titular.Nome = "João Marcos";
            contas[0].Numero = 1;
            contas[0].Saldo = 10000;
            contas[0].Titular.Idade = 18;
            contas[0].TipoConta = 1;

            Cliente c2 = new Cliente();

            contas[1] = new Conta();
            contas[1].Titular = c2;
            contas[1].Titular.Nome = "Victor";
            contas[1].Numero = 2;
            contas[1].Saldo = 2500;
            contas[1].Titular.Idade = 18;
            contas[0].TipoConta = 1;

            Cliente c3 = new Cliente();
            contas[2] = new Conta();
            contas[2].Titular = c3;
            contas[2].Titular.Nome = "Henrique";
            contas[2].Numero = 3;
            contas[2].Saldo = 8000;
            contas[2].Titular.Idade = 18;
            contas[0].TipoConta = 1;
            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }

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
            int indiceSelecionado = comboContas.SelectedIndex;

            Conta contaSelecionada = this.contas[indiceSelecionado];
            contaSelecionada.Deposita(valorDeposito);
            this.MostrarConta(contaSelecionada);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string textoDoValorDoSaque = textoValor.Text;
                double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
                int indiceSelecionado = comboContas.SelectedIndex;
                Conta contaSelecionada = this.contas[indiceSelecionado];
                contaSelecionada.Saca(valorSaque);

                this.MostrarConta(contaSelecionada);
            }

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular.Nome;
            textN.Text = Convert.ToString(contaSelecionada.Numero);
            textSaldo.Text = Convert.ToString("R$ " + contaSelecionada.Saldo);
        }

    }
}

