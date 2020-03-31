using PcnCrawler.Enum;

namespace PcnCrawler.Model
{
    public class FiltroImovel
    {
        public int QuantidadeQuartos { get; set; }
        public decimal ProcoMaximo { get; set; }
        // TODO - renomear nomes abaixo
        public decimal ProcoMinimo { get; set; }
        public int NumeroPagina { get; set; }
        public int Vagas { get; set; }
        public string Cidade { get; set; }
        public string CidadeEncode { get; set; }
        public string Transacao { get; set; }
        public string TipoResidencia { get; set; }
        public Cidade CidadeEnum { get; set; }
    }
}
