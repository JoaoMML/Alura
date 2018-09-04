using System.Collections.Generic;
namespace Caelum.Leilao
{

    public class Leilao
    {

        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            if (Lances.Count == 0 || (
                !ultimoLanceDado().Usuario.Equals(lance.Usuario) &&
                qtdDelancesDo(lance.Usuario) < 5))
            {
                Lances.Add(lance);
            }
        }

        private int qtdDelancesDo(Usuario usuario)
        {
            int total = 0;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) total++;
            }
            return total;
        }

        private Lance ultimoLanceDado()
        {
            return Lances[Lances.Count - 1];
        }

        public void DobraLance(Usuario usuario)
        {
            Lance ultimoLance = ultimoLanceDo(usuario);
            if (ultimoLance != null)
            {
                Propoe(new Lance(usuario, ultimoLance.Valor * 2));
            }
        }

        private Lance ultimoLanceDo(Usuario usuario)
        {
            Lance ultimo = null;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) ultimo = lance;
            }

            return ultimo;
        }
    }
}