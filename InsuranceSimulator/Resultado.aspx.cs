using System;
using System.Globalization;

namespace InsuranceSimulator
{
    public partial class Resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Dados da URL
                string nome = Request.QueryString["nome"];
                string dataNascimento = Request.QueryString["dataNascimento"];
                string cpf = Request.QueryString["cpf"];
                string tipoSeguro = Request.QueryString["tipoSeguro"];

                // Exibição dos dados do usuário
                lblNome.Text = nome;
                lblDataNascimento.Text = dataNascimento;
                lblCPF.Text = cpf;
                lblTipoSeguro.Text = GetDescricaoSeguro(tipoSeguro); 

                // Cálculo do valor do seguro
                decimal valorBase = 1000m;
                decimal percentual = 0;

                switch (tipoSeguro)
                {
                    case "Vida":
                        percentual = 0.8m;
                        break;
                    case "MorteAcidental":
                        percentual = 0.9m;
                        break;
                    case "AcidentesPessoais":
                        percentual = 0.5m;
                        break;
                    case "Saude":
                        percentual = 0.4m;
                        break;
                    case "Automovel":
                        percentual = 2.5m;
                        break;
                    case "Residencial":
                        percentual = 0.6m;
                        break;
                    case "Patrimonial":
                        percentual = 1.2m;
                        break;
                    case "Empresarial":
                        percentual = 1.5m;
                        break;
                    default:
                        percentual = 0m;
                        break;
                }

                decimal valorSeguro = valorBase * percentual;
                lblValorSeguro.Text = valorSeguro.ToString("C", new CultureInfo("pt-BR"));
            }
        }

        private string GetDescricaoSeguro(string tipoSeguro)
        {
            switch (tipoSeguro)
            {
                case "Vida":
                    return "Seguro de Vida";
                case "MorteAcidental":
                    return "Seguro de Morte Acidental";
                case "AcidentesPessoais":
                    return "Seguro contra Acidentes Pessoais";
                case "Saude":
                    return "Seguro de Saúde";
                case "Automovel":
                    return "Seguro de Automóvel";
                case "Residencial":
                    return "Seguro Residencial";
                case "Patrimonial":
                    return "Seguro Patrimonial";
                case "Empresarial":
                    return "Seguro Empresarial";
                default:
                    return "Tipo de Seguro Desconhecido";
            }
        }

        protected void btnContratar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.telosconecta.com/pt-BR"); // Endereço botão de contrato - redirecionando para Télos
        }
    }
}
