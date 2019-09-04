<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="AbrirChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.AbrirChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container" style="margin-top: 50px">
        <h3 class="text-dark">Abrir Chamados
        </h3>
        <div class="row">
            <div class="col-md-5 alert alert-dark">
                <div class="form-group">
                    <asp:Label ID="assuntLabel" runat="server" Text="Assunto"></asp:Label>
                    <asp:DropDownList ID="assuntoDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="form-group">
                    <asp:Label ID="documentoLabel" runat="server" Text="Documento"></asp:Label>
                    <asp:TextBox ID="documentoTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="descricaoLabel" runat="server" Text="Descrição"></asp:Label>
                    <asp:TextBox ID="descricaoTextBox" runat="server" TextMode="MultiLine" Rows="4" Columns="50" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="enviarButton" runat="server" Text="Abrir chamado" OnClick="enviarButton_Click" CssClass="btn btn-dark" />
                </div>
                <div class="form-group">
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
