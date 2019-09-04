<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroPedidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroPedidos1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container" style="margin-top: 50px">
        <h3 class="text-dark">
                Pedidos
            </h3>
        <div class="row">
            <div class="col-md-5 alert alert-dark">

                <div>
                    <h2>Forneça os dados</h2>
                </div>
                
                <%--Cliente--%>
                <div class="form-group">
                    <asp:Label ID="clienteLabel" runat="server" Text="Cliente"></asp:Label>
                    <asp:DropDownList ID="clienteDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <%--Data--%>
                <div class="form-group">
                    <asp:Label ID="dataLabel" runat="server" Text="Data"></asp:Label>
                    <asp:TextBox ID="dataTextBox" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                </div>

                <%--Pedido--%>
                <div class="form-group">
                    <asp:Label ID="pedidoLabe" runat="server" Text="Pedido"></asp:Label>
                    <asp:TextBox ID="pedidoTextBox" runat="server" MaxLength="20" CssClass="form-control"></asp:TextBox>
                </div>


                <div class="form-group">
                    <asp:Button ID="enviarButton" runat="server" Text="Incluir Pedido" 
                        OnClick="enviarButton_Click" CssClass="btn btn-dark" />
                </div>


                <div class="form-group">
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                </div>

            </div>

            <div class="col-md-7">
                <%--<h3 class="text-center">Lista de Clientes</h3>
                <asp:Repeater ID="clientesRepeater" runat="server">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <th>Documento</th>
                                    <th>Nome</th>
                                    <th>Telefone</th>
                                    <th>Email</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Documento") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Nome") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Telefone") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>--%>
            </div>
        </div>
    </div>
</asp:Content>
