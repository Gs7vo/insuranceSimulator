<%@ Page Title="Simulador de Seguros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="InsuranceSimulator.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta name="description" content="Simule e escolha o seguro ideal para você de forma rápida e descomplicada com a T-Insurance." />

    <h2>Preencha o Formulário</h2>  <!-- Título do formulário -->
   
    <!-- Campos para preenchimento do usuário. -->
    <asp:Label ID="lblNome" runat="server" Text="Nome: " /> 
    <asp:TextBox ID="txtNome" runat="server" />
    

    <br />

    <asp:Label ID="lblDataNascimento" runat="server" Text="Data de Nascimento (dd/mm/aa): " />
    <asp:TextBox ID="txtDataNascimento" runat="server" OnKeyUp="mascaraData(this)" MaxLength="10" />
  

    <br />

    <asp:Label ID="lblCPF" runat="server" Text="CPF: " />
    <asp:TextBox ID="txtCPF" runat="server" OnKeyUp="mascaraCPF(this)" MaxLength="14" />
   

    <br />

    <asp:Label ID="lblSeguro" runat="server" Text="Tipo de Seguro: " />
    <asp:DropDownList ID="ddlSeguro" runat="server">
        <asp:ListItem Text="Selecione um tipo de seguro" Value="0" />
        <asp:ListItem Text="Seguro de Vida" Value="Vida" />
        <asp:ListItem Text="Seguro de Morte Acidental" Value="MorteAcidental" />
        <asp:ListItem Text="Seguro contra Acidentes Pessoais" Value="AcidentesPessoais" />
        <asp:ListItem Text="Seguro de Saúde" Value="Saude" />
        <asp:ListItem Text="Seguro de Automóvel" Value="Automovel" />
        <asp:ListItem Text="Seguro Residencial" Value="Residencial" />
        <asp:ListItem Text="Seguro Patrimonial" Value="Patrimonial" />
        <asp:ListItem Text="Seguro Empresarial" Value="Empresarial" />
    </asp:DropDownList>

    <br />

    <asp:Button ID="btnEnviar" runat="server" Text="Calcular" OnClick="btnEnviar_Click" />  <!-- Botão para enviar o formulário e calcular o seguro. -->
   

    <asp:Label ID="lblError" runat="server" ForeColor="Red" /> <!-- Rótulo para exibir erros, se houver. -->
    
</asp:Content>
