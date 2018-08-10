using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlocoDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("entrada.txt"))
            {
                using (Stream entrada = File.Open("entrada.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    string conteudo = leitor.ReadToEnd();
                    texto.Text = conteudo;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream saida = File.Open("entrada.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(texto.Text);
                escritor.Close();
                saida.Close();
            }
        }
    }
}
