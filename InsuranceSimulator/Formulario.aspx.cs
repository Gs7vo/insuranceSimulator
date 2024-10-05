using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace InsuranceSimulator
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string dataNascimentoStr = txtDataNascimento.Text.Trim();
            string cpf = txtCPF.Text.Trim();
            string tipoSeguro = ddlSeguro.SelectedValue;

            // Validação dos campos obrigatórios
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || tipoSeguro == "0" || string.IsNullOrEmpty(dataNascimentoStr))
            {
                lblError.Text = "Por favor, preencha todos os campos corretamente.";
                return;
            }

            // ** do nome completo (nome e sobrenome)
            if (!nome.Contains(" ") || nome.Split(' ').Length < 2)
            {
                lblError.Text = "Por favor, insira o nome completo (nome e sobrenome).";
                return;
            }

            // **  do formato do CPF
            string pattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
            if (!Regex.IsMatch(cpf, pattern))
            {
                lblError.Text = "CPF inválido! Formato correto: 000.000.000-00.";
                return;
            }

            // **  da data de nascimento
            DateTime dataNascimento;
            string[] formatos = { "dd/MM/yy", "dd/MM/yyyy" };
            if (!DateTime.TryParseExact(dataNascimentoStr, formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
            {
                lblError.Text = "Data inválida! Use o formato dd/mm/aa.";
                return;
            }

            // **  de idade (maior de 18 anos)
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

            if (idade < 18)
            {
                lblError.Text = "Você deve ter mais de 18 anos.";
                return;
            }

            // Redireciona para a página de resultado se todos os campos forem VÁLIDOS
            Response.Redirect($"Resultado.aspx?nome={Uri.EscapeDataString(nome)}&dataNascimento={dataNascimento.ToString("dd/MM/yyyy")}&cpf={cpf}&tipoSeguro={tipoSeguro}");
        }
    }
}
