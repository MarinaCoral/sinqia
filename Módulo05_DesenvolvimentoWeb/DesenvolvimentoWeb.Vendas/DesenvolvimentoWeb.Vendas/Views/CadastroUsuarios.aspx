<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroUsuarios.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class="text-center text-primary">Cadastro de Usuário</h2>
        <div class="row">
            <div class="col-md-5">

                <%--Nome--%>
                <div class="form-group">
                    <asp:Label ID="nomeLabel" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="nomeTextBox" CssClass="form-control" MaxLength="20" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="nomeRequiredFieldValidator" runat="server"
                        CssClass="text-danger" ControlToValidate="nomeTextBox"
                        ErrorMessage="O nome do usúario deve ser informado!" Display="Dynamic">
                    </asp:RequiredFieldValidator>

                </div>

                <%--Senha--%>
                <div class="form-group">
                    <asp:Label
                        ID="senhaLabel" runat="server" Text="Senha"></asp:Label>
                    <asp:TextBox ID="senhaTextBox" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        ID="senhaRequiredFieldValidator" runat="server"
                        CssClass="text-danger" ControlToValidate="senhaTextBox"
                        ErrorMessage="A senha deve ser informada!" Display="Dynamic">
                    </asp:RequiredFieldValidator>

                </div>

                <%--Confirma--%>
                <div class="form-group">
                    <asp:Label ID="confirmaLabel" runat="server" Text="Confirme sua senha"></asp:Label>
                    <asp:TextBox ID="confirmaTextBox" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:CompareValidator
                        ID="confirmaCompareValidator" runat="server" CssClass="text-danger" ErrorMessage="As senhas não conferem"
                        ControlToValidate="confirmaTextBox" ControlToCompare="senhaTextBox" Display="Dynamic">
                    </asp:CompareValidator>
                </div>

                <div class="form-grupo">
                    <asp:Button ID="enviarButton" runat="server" Text="Incluir usuário"
                        CssClass="btn btn-primary" OnClick="enviarButton_Click1" />
                </div>

                <div class="form-grupo">
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
