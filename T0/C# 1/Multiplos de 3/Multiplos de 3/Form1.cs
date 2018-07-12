using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplos_de_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i <= 100; i++)
            {
                if(i % 3 == 0 && i!=0)
                {
                    MessageBox.Show(" O numero, " + i + " é multiplo de três");
                }
            }
        }
    }
}
