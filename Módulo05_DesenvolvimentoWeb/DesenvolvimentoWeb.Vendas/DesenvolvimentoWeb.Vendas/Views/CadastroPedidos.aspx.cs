﻿using DesenvolvimentoWeb.Vendas.Data;
using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class CadastroPedidos1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				clienteDropDownList.DataSource = ClientesDao.ListarClientes();
				clienteDropDownList.DataTextField = "Nome";
				clienteDropDownList.DataValueField = "Documento";
				clienteDropDownList.DataBind();
			}
		}

		protected void enviarButton_Click(object sender, EventArgs e)
		{
			try
			{
				Pedido pedido = new Pedido();
				pedido.Doc_Cliente = clienteDropDownList.SelectedValue;
				pedido.Numero_Pedido = pedidoTextBox.Text;
				pedido.Data = Convert.ToDateTime(dataTextBox.Text);

				PedidosDao.IncluirPedido(pedido);

				mensagemLabel.Text = "Pedido Incluido com sucesso";

			}
			catch (Exception ex)
			{
				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}
