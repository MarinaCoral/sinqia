﻿using ProjetoWeb_CadastroEventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWeb_CadastroEventos.Paginas
{
	public partial class CadastroConvidados : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string s = Request.RequestType;

			if (!IsPostBack)
			{
				try
				{
					eventoDropDownList.DataSource = EventosDao.ListarEventos();
					eventoDropDownList.DataTextField = "Descricao";
					eventoDropDownList.DataValueField = "Id";
					eventoDropDownList.DataBind();
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		protected void incluirButton_Click(object sender, EventArgs e)
		{
			try
			{
				mensagemLabel.ForeColor = System.Drawing.Color.Blue;
				mensagemLabel.Text = "Convidado incluído com sucesso!";
			}
			catch (Exception ex)
			{

				mensagemLabel.ForeColor = System.Drawing.Color.Red;
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}