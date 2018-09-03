﻿using NUnit.Framework;
using System;

namespace Caelum.Leilao
{
    [TestFixture]  // Adiciona 
    public class TesteDoAvaliador
    {
        [Test] // Adc
        public void Main() // Deixar publico e sem nada dentro do Main()
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
    }
}