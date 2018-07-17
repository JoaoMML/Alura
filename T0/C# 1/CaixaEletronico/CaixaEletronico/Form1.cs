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
            Cliente cliente = new Cliente("Professor Danton") {rg = "13456789-5",cpf= "465879609",idade=30,endereco = " Rua Benner Sistemas 2018" };
            //conta.saldo = 10000.00; 
            float vl = 1000;
            bool sacou = conta.Saca(vl);
            if (sacou)
            {
                MessageBox.Show(" Saque de  R$" + vl+ " realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível sacar");
            }


            MessageBox.Show(" -> Cliente : " + cliente.nome + "\n -> RG:   " + cliente.rg + "\n -> CPF : " + cliente.cpf + "\n -> End: " + cliente.endereco + "\n -> Saldo atual : " + conta.saldo);
}

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente("Victor");
            conta.titular = cliente;
            conta.titular.nome = cliente.nome;
            conta.Deposita(250.0);
            conta.numero = 1;

            textoTitular.Text = conta.titular.nome;
            textN.Text = Convert.ToString(conta.numero);
            textSaldo.Text = Convert.ToString("R$ "+conta.saldo);


        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

 