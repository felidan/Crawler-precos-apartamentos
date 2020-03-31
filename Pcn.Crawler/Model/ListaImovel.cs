using System.Collections.Generic;

namespace PcnCrawler.Model
{
    public class ListaImovel
    {
        public ListaImovel()
        {
            Imoveis = new List<Imovel>();
            Erro = new Erro();
        }
        public List<Imovel> Imoveis { get; set; }
        public Erro Erro { get; set; }
    }
}
