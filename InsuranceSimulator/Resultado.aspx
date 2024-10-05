<%@ Page Title="Resultado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultado.aspx.cs" Inherits="InsuranceSimulator.Resultado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <meta name="description" content="Simule e escolha o seguro ideal para você de forma rápida e descomplicada com a T-Insurance." /> <!-- Descrição da página -->

    
    <h2>Resultado da Simulação</h2> <!-- Título da página -->

    <!-- Exibição dos resultados da simulação com Label para cada campo -->
    <p>Nome: <asp:Label ID="lblNome" runat="server" /></p> 
    <p>Data de Nascimento: <asp:Label ID="lblDataNascimento" runat="server" /></p> 
    <p>CPF: <asp:Label ID="lblCPF" runat="server" /></p> 
    <p>Tipo de Seguro: <asp:Label ID="lblTipoSeguro" runat="server" /></p> 
    <p>Valor do Seguro: <asp:Label ID="lblValorSeguro" runat="server" /></p> 

    
    <!-- BOTÕES -->
    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" PostBackUrl="~/Formulario.aspx" /> <!--  retornar à página de formulário -->
  
    <asp:Button ID="btnImprimir" runat="server" Text="Imprimir" OnClientClick="window.print(); return false;" /> <!-- imprimir a página -->
    
    <asp:Button ID="btnContratar" runat="server" Text="Contratar" OnClick="btnContratar_Click" CssClass="btn-contratar" />  <!--  contratar o seguro, direcionando para télos -->
</asp:Content> 
