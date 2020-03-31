using HtmlAgilityPack;
using PcnCrawler.Enum;
using PcnCrawler.Model;
using PcnCrawler.Uteis;
using System;
using System.Net;
using System.Text;

namespace PcnCrawler.Crawlers
{
    public class ZapImoveisCrawler
    {
        private string Url = "https://www.zapimoveis.com.br/venda/apartamentos/";
        private string Html = String.Empty;
        FiltroImovel filtros = new FiltroImovel();
        ListaImovel imoveis = new ListaImovel();

        public ZapImoveisCrawler()
        {

        }

        public ListaImovel Executar(FiltroImovel filtro)
        {
            filtros = filtro;
            CarregaCidade(filtro);
            var url = MontarUrl(filtros);

            if (BuscaPagina(url))
            {
                RaspaPagina();
            }

            return imoveis;
        }

        private bool RaspaPagina()
        {
            bool sucesso = false;
            StringBuilder logErro = new StringBuilder(); 
            
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(this.Html);
            
            var nodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'card-listing simple-card js-listing-card')]");

            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    // TODO - decode e caracteres especiais
                    try
                    {
                        var imovel = item.ChildNodes[1];

                        var condominio = imovel.ChildNodes?[0].SelectNodes("ul")?[0].ChildNodes?[0].SelectNodes("span")?[0].InnerText.LimparDelimitadores();
                        var iptu = imovel.ChildNodes?[0].SelectNodes("ul")?[0].ChildNodes?[1].SelectNodes("span")?[0].InnerText.LimparDelimitadores();

                        Imovel itemImovel = new Imovel()
                        {
                            Cidade = filtros.CidadeEnum.ToString().Replace("_", " "),
                            Descricao = imovel.ChildNodes[1].SelectNodes("div/span")[0].InnerHtml,
                            Endereco = imovel.ChildNodes[2].ChildNodes[0].InnerHtml,
                            QuantidadeBanheiros = imovel.ChildNodes[2].ChildNodes[1].SelectNodes("li")[3].ChildNodes[1].InnerText.ConverteStringParaNumerico(),
                            QuantidadeQuartos = imovel.ChildNodes[2].ChildNodes[1].SelectNodes("li")[1].ChildNodes[1].InnerText.ConverteStringParaNumerico(),
                            QuantidadeVagas = imovel.ChildNodes[2].ChildNodes[1].SelectNodes("li")[2].ChildNodes[1].InnerText.ConverteStringParaNumerico(),
                            Tamanho = imovel.ChildNodes[2].ChildNodes[1].SelectNodes("li")[0].ChildNodes[1].InnerText.ConverteStringParaNumerico(),
                            ValorImovel = imovel.ChildNodes[0].SelectNodes("p/strong")[0].InnerHtml.ConverteStringParaDeciaml(),
                            ValorCondominio = (condominio != null ? condominio.ConverteStringParaDeciaml() : 0),
                            ValorIptu = (iptu != null ? iptu.ConverteStringParaDeciaml() : 0)
                        };

                        imoveis.Imoveis.Add(itemImovel);
                    }
                    catch(Exception ex)
                    {
                        logErro.Append($"Erro ao raspar: {ex.Message}");
                    }
                }
                imoveis.Erro.Sucesso = true;
                imoveis.Erro.DescricaoErro = "Processo realizado com sucesso.";
                sucesso = true;
            }
            else
            {
                sucesso = false;
                logErro.Append("Não há dados para o filtro solicitado.");
                imoveis.Erro = new Erro() { Sucesso = false, DescricaoErro = logErro.ToString() };
            }

            return sucesso;
        }

        private bool BuscaPagina(string url)
        {
            using (WebClient client = new WebClient())
            {
                var html = client.DownloadString(url);

                if (html != null)
                {
                    this.Html = html;
                    return true;
                }
                return false;
            }
        }

        private string MontarUrl(FiltroImovel filtro)
        {
            return $@"{this.Url}{filtro.Cidade}/{filtro.QuantidadeQuartos}-quartos/?onde={filtro.CidadeEncode}&quartos={filtro.QuantidadeQuartos}&transacao={filtro.Transacao}&vagas={filtro.Vagas}&precoMaximo={filtro.ProcoMaximo}&precoMinimo={filtro.ProcoMinimo}&tipoUnidade=Residencial,{filtro.TipoResidencia}&tipo=Im%C3%B3vel%20usado&pagina={filtro.NumeroPagina}&ordem=Valor";
        }

        private void CarregaCidade(FiltroImovel filtro)
        {
            switch ((int)filtro.CidadeEnum)
            {
                case (int)Cidade.SANTO_ANDRE:
                    filtros.Cidade = "sp+santo-andre";
                    filtros.CidadeEncode = ",S%C3%A3o%20Paulo,Santo%20Andr%C3%A9,,,,BR%3ESao%20Paulo%3ENULL%3ESanto%20Andre,-23.674222,-46.5436";
                    break;
                case (int)Cidade.SAO_BERNARDO:
                    filtros.Cidade = "sp+sao-bernardo-do-campo";
                    filtros.CidadeEncode = ",S%C3%A3o%20Paulo,S%C3%A3o%20Bernardo%20do%20Campo,,,,BR%3ESao%20Paulo%3ENULL%3ESao%20Bernardo%20do%20Campo,-23.623362,-46.555243";
                    break;
                case (int)Cidade.SAO_CAETANO:
                    filtros.Cidade = "sp+sao-caetano-do-sul";
                    filtros.CidadeEncode = ",S%C3%A3o%20Paulo,S%C3%A3o%20Caetano%20do%20Sul,,,,BR%3ESao%20Paulo%3ENULL%3ESao%20Caetano%20do%20Sul,-23.623362,-46.555243";
                    break;
                case (int)Cidade.MAUA:
                    filtros.Cidade = "sp+maua";
                    filtros.CidadeEncode = ",S%C3%A3o%20Paulo,Mau%C3%A1,,,,BR%3ESao%20Paulo%3ENULL%3EMaua,-23.550519,-46.633309";
                    break;
            }
        }
    }
}
