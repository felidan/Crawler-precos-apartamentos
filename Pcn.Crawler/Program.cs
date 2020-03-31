using PcnCrawler.Crawlers;
using PcnCrawler.Enum;
using PcnCrawler.Model;
using System;

namespace PcnCrawler
{
    class Program
    {
        static void Main(string[] args)
        {

            ZapImoveisCrawler a = new ZapImoveisCrawler();
            string urlBase = "https://www.zapimoveis.com.br/venda/apartamentos/";
            FiltroImovel filtro = new FiltroImovel()
            {
                NumeroPagina = 1,
                ProcoMinimo = 100000,
                ProcoMaximo = 200000,
                QuantidadeQuartos = 2,
                TipoResidencia = "Apartamento",
                Transacao = "Venda",
                Vagas = 1,
                CidadeEnum = Cidade.SANTO_ANDRE
            };

            var result = a.Executar(filtro);

            foreach(var x in result.Imoveis)
            {
                Console.WriteLine(x.Cidade);
                Console.WriteLine(x.Descricao);
                Console.WriteLine(x.Endereco);
                Console.WriteLine(x.QuantidadeBanheiros);
                Console.WriteLine(x.QuantidadeQuartos);
                Console.WriteLine(x.QuantidadeVagas);
                Console.WriteLine(x.Tamanho);
                Console.WriteLine(x.ValorCondominio);
                Console.WriteLine(x.ValorImovel);
                Console.WriteLine(x.ValorIptu);

                Console.WriteLine();  
            }

            Console.WriteLine(result.Erro.Sucesso);
            Console.WriteLine(result.Erro.DescricaoErro);
            Console.ReadKey();
            
            
        }
    }
}
