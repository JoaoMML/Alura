using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2, b = 25, c = 10;
            double delta, r1, r2;

            delta = b*b-4 * a * c;

            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("O resultado da primira raiz é: " + r1);
            MessageBox.Show("O resultado da segunda raiz é : " + r2);





        }
    }
}
