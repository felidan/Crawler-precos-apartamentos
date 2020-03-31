using PcnTela.Model;
using PcnCrawler.Enum;
using PcnCrawler.Model;
using System;
using System.Windows.Forms;
using System.Text;
using PcnCrawler.Crawlers;

namespace PcnTela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregaComboCidade();
            CarregaTipoResidencia();
            this.txtErroLog.Visible = false;
        }

        private void CarregaTipoResidencia()
        {
            this.cbTipoResidencia.DataSource = new ComboItem[]
            {
                new ComboItem(){Id = 0, Text = "Selecione"},
                new ComboItem(){Id = 1, Text = "Apartamento"},
                new ComboItem(){Id = 2, Text = "Casa"}
            };
            
            this.cbTipoResidencia.DisplayMember = "Text";
            this.cbTipoResidencia.ValueMember = "Id";
        }

        private void CarregaComboCidade()
        {
            this.cbCidade.DataSource = new ComboItem[]
            {
                new ComboItem(){Id = 0, Text = "Selecione"},
                new ComboItem(){Id = 1, Text = "Santo André"},
                new ComboItem(){Id = 2, Text = "São Caetano"},
                new ComboItem(){Id = 3, Text = "São Bernardo"},
                new ComboItem(){Id = 4, Text = "Mauá"}
            };

            this.cbCidade.DisplayMember = "Text";
            this.cbCidade.ValueMember = "Id";
        }

        private void btnConsultar_Click(object sender, System.EventArgs e)
        {
            if (ValidarCamposFiltro())
            {
                FiltroImovel filtro = new FiltroImovel();

                filtro.CidadeEnum = (Cidade)this.cbCidade.SelectedIndex;
                filtro.NumeroPagina = 1;
                filtro.ProcoMinimo = Decimal.Parse(this.txtValorMinimo.Text);
                filtro.ProcoMaximo = Decimal.Parse(this.txtValorMaximo.Text);
                filtro.QuantidadeQuartos = Int32.Parse(this.txtQuantidadeQuartos.Text);
                filtro.TipoResidencia = (this.cbTipoResidencia.SelectedIndex == 1 ? "Apartamento" : "Casa");
                filtro.Transacao = "Venda";
                filtro.Vagas = Int32.Parse(this.txtQuantidadeVagas.Text);

                ExecutaCrawler(filtro);
            }
        }

        private void ExecutaCrawler(FiltroImovel filtro)
        {
            // TODO - INCLUIR PREGRESS BAR
            // TODO - COLOCAR OS DADOS NA TELA
            // TODO - DEIXAR ASYNC
            // TODO - DEIXAR A TELA RESPONSIVA
            if (this.ckZapImoveis.Checked)
            {
                ZapImoveisCrawler crawler = new ZapImoveisCrawler();
                var result = crawler.Executar(filtro);

                if (!result.Erro.Sucesso)
                {
                    this.txtErroLog.Text = result.Erro.DescricaoErro;
                    this.txtErroLog.Visible = true;
                }
            }
        }

        private bool ValidarCamposFiltro()
        {
            StringBuilder log = new StringBuilder();

            if (!this.ckZapImoveis.Checked)
                log.AppendLine("Selecione pelo menos uma fonte de pesquisa.");

            if (this.cbCidade.SelectedIndex == 0)
                log.AppendLine("Selecione uma Cidade.");
            
            if (Decimal.Parse(this.txtValorMaximo.Text) <= Decimal.Parse(this.txtValorMinimo.Text) || Decimal.Parse(this.txtValorMaximo.Text) < 0 || Decimal.Parse(this.txtValorMinimo.Text) < 0)
                log.AppendLine("Valores do Imóvel invalido.");

            if (Int32.Parse(this.txtQuantidadeQuartos.Text) < 1)
                log.AppendLine("Quantidade de Quartos Inválida.");

            if (this.cbTipoResidencia.SelectedIndex == 0)
                log.AppendLine("Selecione um tipo de Residência.");

            if (Int32.Parse(this.txtQuantidadeVagas.Text) < 0)
                log.AppendLine("Quantidade de Vagas Inválido.");

            if (!String.IsNullOrEmpty(log.ToString()))
            {
                this.txtErroLog.Text = log.ToString();
                this.txtErroLog.Visible = true;
                
                return false;
            }
            this.txtErroLog.Visible = false;
            return true;
        }
    }
}
