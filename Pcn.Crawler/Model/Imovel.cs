namespace PcnCrawler.Model
{
    public class Imovel
    {
        public decimal ValorImovel { get; set; }

        // TODO - temtar pegar link imagem e link imovel
        // TODO - enum de crawler
        public decimal? ValorCondominio { get; set; }
        public decimal? ValorIptu { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public decimal Tamanho { get; set; }
        public int QuantidadeQuartos { get; set; }
        public int QuantidadeVagas { get; set; }
        public int QuantidadeBanheiros { get; set; }
    }
}
