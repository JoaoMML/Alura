using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2
{
    class Testes
    {
        //    Cap1 file
        //    Abrir a conexão com o banco de dados !com o GETCONNECTION.
        //    IDbConnection conexao = new ConnectionFactory().GetConnection();

        //    IDbCommand comando = conexao.CreateCommand();
        //    comando.CommandText = "select * from tabela";


        // ----------------------------------------------------------------------------

        //Cap2 file
        //NotasMusicais notas = new NotasMusicais();

        //    IList<INota> musica = new List<INota>()
        //{

        //        notas.Pega("do"),
        //        notas.Pega("re"),
        //        notas.Pega("mi"),
        //        notas.Pega("fa"),
        //        notas.Pega("fa"),
        //        notas.Pega("fa"),
        //        notas.Pega("do"),
        //        notas.Pega("re"),
        //        notas.Pega("do"),
        //        notas.Pega("re"),
        //        notas.Pega("re"),
        //        notas.Pega("re"),
        //        notas.Pega("do"),
        //        notas.Pega("sol"),
        //        notas.Pega("fa"),
        //        notas.Pega("mi"),
        //        notas.Pega("mi"),
        //        notas.Pega("do"),
        //        notas.Pega("re"),
        //        notas.Pega("mi"),
        //        notas.Pega("fa"),
        //        notas.Pega("fa"),
        //        notas.Pega("fa"),
        //    };

        //    Piano piano = new Piano();
        //    piano.Toca(musica);
        //------------------------------------------------------------------------------

        //Cap3 file
        //Historico historico = new Historico();
        //Contrato c = new Contrato(DateTime.Now, "Victor", TipoDoContrato.Novo);

        //historico.Adiciona(c.SalvaEstado());

        //    c.Avanca();
        //    historico.Adiciona(c.SalvaEstado());

        //    c.Avanca();
        //    historico.Adiciona(c.SalvaEstado());

        //    Console.WriteLine(historico.Pega(2).Contrato.Tipo);

        //    Console.ReadKey();
        //------------------------------------------------------------------------------

        //------------------------------------------------------------------------------
        //Cap5 file
        //IExpressao esquerda = new Subtracao(new Numero(1), new Numero(10));
        //IExpressao direita = new Soma(new Numero(20), new Numero(10));
        //IExpressao soma = new Soma(esquerda, direita);

        //int resultado = soma.Avalia();
        //Console.WriteLine(resultado);

        //    //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(10));
        //    //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
        //    //Console.WriteLine(funcao());

        //    ImpressoraVisitor impressora = new ImpressoraVisitor();
        //soma.Aceita(impressora);
        //------------------------------------------------------------------------------
        //Cap6 file
        //IMensagem mensagem = new MensagemCliente("victor");
        //IEnviador enviador = new EnviaPorSMS();
        //mensagem.Enviador = enviador;
        //    mensagem.Envia();


        //------------------------------------------------------------------------------
        //Cap7 file
        //FilaDeTrabalho fila = new FilaDeTrabalho();
        //Pedido pedido1 = new Pedido("Mauricio", 100.0);
        //Pedido pedido2 = new Pedido("Pedro", 200.0);
        //fila.Adiciona(new PagaPedido(pedido1));
        //    fila.Adiciona(new PagaPedido(pedido2));

        //    fila.Adiciona(new FinalizaPedido(pedido1));
        //    fila.Adiciona(new FinalizaPedido(pedido2));

        //    fila.Processa();

        //------------------------------------------------------------------------------
        //Cap8 file

        //------------------------------------------------------------------------------

        //------------------------------------------------------------------------------
    }

}
