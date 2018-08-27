using DesingPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2.Cap5
{
    class ImpressoraVisitor : IVisitor
    {
        public void imprimeSoma(Soma soma)
        {
            Console.WriteLine("(");
            soma.Esquerda.Aceita(this);
            Console.WriteLine("+");
            soma.Direita.Aceita(this);
            Console.WriteLine(")");
        }
        public void imprimeSubtracao(Subtracao subtracao)
        {
            Console.WriteLine("(");
            subtracao.Esquerda.Aceita(this);
            Console.WriteLine("-");
            subtracao.Direita.Aceita(this);
            Console.WriteLine(")");
        }
        public void ImprimeNumero (Numero numero)
        {
            Console.WriteLine(numero.Valor);
        }

        public void ImprimeSoma(Soma soma)
        {
            throw new NotImplementedException();
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            throw new NotImplementedException();
        }
    }
}
