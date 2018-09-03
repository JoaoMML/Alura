using NUnit.Framework;
using System;

namespace Caelum.Leilao
{
    [TestFixture]  // Adiciona 
    public class AvaliadorTest
    {
        [Test] // Adc
        public void TesteMaiorMenor() // Deixar publico e sem nada dentro do Main()
        {   // Cenário - 1° parte do teste
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));
            leilao.Propoe(new Lance(maria, 250.0));

            // Ação - 2° parte
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            // Validação - 3° parte
            double maiorEsperado = 400;
            double menorEsperado = 250;
            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance); // imprime 400.0
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance); // imprime 200.0
        }
        [Test]
        public void TestDeMedia()
        {
            // cenario: 3 lances em ordem crescente
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(maria, 300.0));
            leilao.Propoe(new Lance(joao, 400.0));
            leilao.Propoe(new Lance(jose, 500.0));

            // executando a acao
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            // comparando a saida com o esperado
            Assert.AreEqual(400, leiloeiro.Media, 0.0001);
        }

        [Test]
        public void DeveIdentificarPalindromoEFiltrarCaracteresInvalidos()
        {
            Palindromo p = new Palindromo();

            bool resultado = p.EhPalindromo(
                "--O-lobo-ama-o-bolo--");
            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeveIdentificarPalindromo()
        {
            Palindromo p = new Palindromo();

            bool resultado = p.EhPalindromo(
                "Roma é amor");
            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeveIdentificarSeNaoEhPalindromo()
        {
            Palindromo p = new Palindromo();

            bool resultado = p.EhPalindromo(
                "Oi meu nome é joao!");
            Assert.IsFalse(resultado);
        }
    }
}