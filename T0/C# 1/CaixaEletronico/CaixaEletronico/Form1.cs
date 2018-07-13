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
            
            Conta Joao = new Conta();
            Joao.Deposita(5000.0);

            Conta pedro = new Conta();
            pedro.Deposita(2000.0);

            Joao.Transfere(500.0, pedro);
            Joao.Deposita(150.0);
            pedro.Saca(400.0);

            MessageBox.Show("João = " + Joao.saldo);
            MessageBox.Show("mauricio = " + pedro.saldo);
            
        }
    }
}

 