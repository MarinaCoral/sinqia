using DesenvolvimentoWeb.Vendas.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class ResponderChamado : System.Web.UI.Page
	{
		static Chamado chamado;
		HttpClient client;
		public ResponderChamado()
		{
			if (client == null)
			{
				client = new HttpClient();
				client.BaseAddress = new Uri("http://localhost:50698/");
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			}
		}
		protected async void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				try
				{
					HttpResponseMessage response = client.GetAsync("ChamadosPendentes").Result;
					if (response.IsSuccessStatusCode)
					{
						var resultado = await response.Content.ReadAsStringAsync();
						var lista = JsonConvert.DeserializeObject<Chamado[]>(resultado).ToList();
						chamadoDropDownList.DataSource = lista;
						chamadoDropDownList.DataValueField = "ChamadoId";
						chamadoDropDownList.DataTextField = "ChamadoId";
						chamadoDropDownList.DataBind();
						enviarButton.Enabled = (chamado != null);
					}
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		protected async void BuscarButton_Click1(object sender, EventArgs e)
		{
			try
			{
				int id = int.Parse(chamadoDropDownList.SelectedValue);
				HttpResponseMessage response = client.GetAsync("/api/chamados/" + id).Result;
				if (response.IsSuccessStatusCode)
				{
					var resultado = await response.Content.ReadAsStringAsync();
					chamado = JsonConvert.DeserializeObject<Chamado>(resultado);
					descricaoTextBox.Text = chamado.Assunto + "\n\n" + chamado.Descricao;
				}
				enviarButton.Enabled = (chamado != null);

			}
			catch (Exception)
			{

				throw;
			}

		}

		protected async void EnviarButton_Click1(object sender, EventArgs e)
		{
			try
			{
				if (chamado == null)
				{
					mensagemLabel.CssClass = "alert alert-warning";
					mensagemLabel.Text = "Favor, buscar um chamado";
				}
				chamado.Resposta = responderTextBox.Text;
				string json = JsonConvert.SerializeObject(chamado);

				HttpContent content = new StringContent(json, Encoding.Unicode, "application/json");

				var response = await client.PutAsync("api/chamados", content);
				if (response.IsSuccessStatusCode)
				{
					mensagemLabel.CssClass = "alert alert-success";
					mensagemLabel.Text = "Chamado respondido com sucesso";
				}
				else
				{
					string erro = response.StatusCode + " - " + response.ReasonPhrase;
					throw new Exception(erro);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		protected async void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (chamado == null)
				{
					mensagemLabel.CssClass = "alert alert-warning";
					mensagemLabel.Text = "Por favor, buscar um chamado existente!";
				}

				var response = await client.DeleteAsync("api/chamados/" + chamadoDropDownList.SelectedValue);
				if (response.IsSuccessStatusCode)
				{
					mensagemLabel.CssClass = "alert alert-success";
					mensagemLabel.Text = "Chamado removido com sucesso!";
				}
				else
				{
					string erro = response.StatusCode + " - " + response.ReasonPhrase;
					throw new Exception(erro);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

	}
}