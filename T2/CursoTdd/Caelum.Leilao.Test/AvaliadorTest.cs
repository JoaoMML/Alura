using Caelum.Leilao.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Caelum.Leilao
{
    [TestFixture]  // Adiciona 
    public class AvaliadorTest
    {
        [Test] // Adc
        public void TesteOrdemCrescente() // Deixar publico e sem nada dentro do Main()
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
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Usuario joao = new Usuario("Joao");
            Leilao leilao = new Leilao("Xbox Novo");

            leilao.Propoe(new Lance(joao, 2000.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(2000, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(2000, leiloeiro.MenorLance, 0.0001);
        }

        [Test]
        public void DeveEntenderOsTresMaioresLances()
        {
            Usuario joao = new Usuario("joao");
            Usuario maria = new Usuario("maria");
            Leilao leilao = new Leilao("Xbox Novo");

            leilao.Propoe(new Lance(joao, 100.0));
            leilao.Propoe(new Lance(maria, 200.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(maria, 400.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;
            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.0001);
            Assert.AreEqual(300, maiores[1].Valor, 0.00001);
            Assert.AreEqual(200, maiores[2].Valor, 0.00001);
        }
        [Test]
        public void DeveEntenderLancesAleatorios() { 
        Usuario joao = new Usuario("joao");
        Usuario maria = new Usuario("maria");
        Leilao leilao = new Leilao("Xbox Novo");

        leilao.Propoe( new Lance(joao,100.0));
            leilao.Propoe(new Lance(maria, 200.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(maria, 400.0));
            leilao.Propoe(new Lance(joao, 700.0));
            leilao.Propoe(new Lance(maria, 550.0));
            leilao.Propoe(new Lance(joao, 120.0));
            leilao.Propoe(new Lance(maria, 50.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(50, leiloeiro.MenorLance,0.0001);
            Assert.AreEqual(700, leiloeiro.MaiorLance,0.0001);
            
        }

        [Test] // Adc
        public void TesteOrdemDecrescente() // Deixar publico e sem nada dentro do Main()
        {   // Cenário - 1° parte do teste
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");

            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 900.0));
            leilao.Propoe(new Lance(jose, 500.0));
            leilao.Propoe(new Lance(maria, 50.0));

            // Ação - 2° parte
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            // Validação - 3° parte
            Assert.AreEqual(900, leiloeiro.MaiorLance,0.00001); // imprime 400.0
            Assert.AreEqual(50, leiloeiro.MenorLance,0.0001); // imprime 200.0
        }

        public void DeveDevolverListaVaziaCasoNaoHajaLances()
        {
            Leilao leilao = new Leilao("Playstation 3 Novo");

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(0, maiores.Count);
        }
        public class FiltroDeLancesTest
        {
            [Test]
            public void DeveSelecionarLancesEntre1000E3000()
            {
                Usuario joao = new Usuario("Joao");

                FiltroDeLances filtro = new FiltroDeLances();
                IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,2000),
            new Lance(joao,1000),
            new Lance(joao,3000),
            new Lance(joao, 800)});

                Assert.AreEqual(1, resultado.Count);
                Assert.AreEqual(2000, resultado[0].Valor, 0.00001);
            }

            [Test]
            public void DeveSelecionarLancesEntre500E700()
            {
                Usuario joao = new Usuario("Joao");

                FiltroDeLances filtro = new FiltroDeLances();
                IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,600),
            new Lance(joao,500),
            new Lance(joao,700),
            new Lance(joao, 800)});

                Assert.AreEqual(1, resultado.Count);
                Assert.AreEqual(600, resultado[0].Valor, 0.00001);
            }
            [Test]
            public void DeveSelecionarLancesMaioresQue5000()
            {
                Usuario joao = new Usuario("Joao");

                FiltroDeLances filtro = new FiltroDeLances();
                IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
        new Lance(joao,10000),
        new Lance(joao, 800)});

                Assert.AreEqual(1, resultado.Count);
                Assert.AreEqual(10000, resultado[0].Valor, 0.00001);
            }

            [Test]
            public void DeveEliminarMenoresQue500()
            {
                Usuario joao = new Usuario("Joao");

                FiltroDeLances filtro = new FiltroDeLances();
                IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
        new Lance(joao,400),
        new Lance(joao, 300)});

                Assert.AreEqual(0, resultado.Count);
            }

            [Test]
            public void DeveEliminarEntre3000E5000()
            {
                Usuario joao = new Usuario("Joao");

                FiltroDeLances filtro = new FiltroDeLances();
                IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
        new Lance(joao,4000),
        new Lance(joao, 3500)});

                Assert.AreEqual(0, resultado.Count);
            }
        }

        // Daqui pra baixo testes do desafio cap1
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