<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ResponderChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ResponderChamado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container" style="margin-top: 50px"><

         <h3 class="text-dark">Responder Chamados</h3>
         <div class="row">
             <div class="col-md-7">
                 <div class="form-group">
                     <asp:Label ID="chamadoLabel" runat="server" Text="Chamado"></asp:Label>
                     <asp:DropDownList ID="chamadoDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                 </div>

                 <div class="form-group">
                     <asp:Button ID="buscarButton" runat="server" Text="Buscar chamado" 
                         Onclick="BuscarButton_Click1"/>
                 </div>

                     <div class="form-group">
                     <asp:Button ID="removerButton" runat="server" Text="Remover chamado"
                         Onclick="Button1_Click"/>
                 </div>

                 <div class="form-group">
                     <asp:Label ID="buscarLabel" runat="server" Text="Descrição"></asp:Label>
                     <asp:TextBox ID="descricaoTextBox" TextMode="MultiLine" ReadOnly="true" CssClass="form-control text-primary"
                         runat="server"></asp:TextBox>
                 </div>

                 <asp:Label ID="responderLabel" runat="server" Text="Responder"></asp:Label>
                     <asp:TextBox ID="responderTextBox" TextMode="MultiLine" CssClass="form-control text-primary"
                         runat="server"></asp:TextBox>
                 <div class="form-goup">

                     <div class="form-group">
                         <asp:Button ID="enviarButton" runat="server" Text="Responder chamado"
                             OnClick="EnviarButton_Click1"/>
                     </div>

                     <div class="form-group" style="width:100%;">
                         <asp:Label ID="mensagemLabel" runat="server" ></asp:Label>
                     </div>
                     
                 </div>
             </div>
         </div>
     </div>
</asp:Content>
