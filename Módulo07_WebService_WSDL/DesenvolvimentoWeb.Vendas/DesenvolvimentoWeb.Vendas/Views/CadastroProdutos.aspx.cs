using DesenvolvimentoWeb.Vendas.Data;
using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class CadastroProdutos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				categoriaDropDownList.DataSource = ProdutosDao.ListarCategorias();
				categoriaDropDownList.DataTextField = "Descricao";
				categoriaDropDownList.DataValueField = "Id";
				categoriaDropDownList.DataBind();

				List<string> unidades = new List<string>()
				{
					"KILO", "PACOTE", "POLEGADAS", "LITROS", "DECIBEIS", "UNIDADE"
				};

				unidadeDropDownList.DataSource = unidades;
				unidadeDropDownList.DataBind();

				produtosRepeater.DataSource = ProdutosDao.ListarProdutos();
				produtosRepeater.DataBind();
			}
		}

		protected void enviarButton_Click(object sender, EventArgs e)
		{
			try
			{
				HttpPostedFile file = figuraFileUpload.PostedFile;

				//Verificação da foto

				if (file == null ||	string.IsNullOrEmpty(file.FileName) || file.InputStream == null)
				{
					throw new Exception("Arquivo inválido para o produto!");
				}

				Produto produto = new Produto();
				produto.Id_Categoria = Convert.ToInt32(categoriaDropDownList.SelectedValue);
				produto.Descricao = descricaoTextBox.Text;
				produto.Preco = Convert.ToDouble(precoTextBox.Text);
				produto.Unidade = unidadeDropDownList.SelectedValue;
				produto.Mime_Type = figuraFileUpload.PostedFile.ContentType;

				//obtendo o fluxo de bytes do arquivo e criando um array de byte
				byte[] bytes = new byte [figuraFileUpload.PostedFile.InputStream.Length];
				figuraFileUpload.PostedFile.InputStream.Read(bytes, 0, bytes.Length);
				produto.Foto = bytes;

				ProdutosDao.IncluirProduto(produto);

				mensagemLabel.CssClass = "alert alert-sucess";
				mensagemLabel.Text = "Pedido Incluido com sucesso";
			}
			catch (Exception ex)
			{
				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.CssClass = ex.Message;
			}
		}

		protected void produtosRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
		{
			//Obtendo uma referência ao controle HiddenField
			HiddenField idField = (HiddenField)e.Item.FindControl("IdHiddenField");

			if(idField!= null)
			{
				int id = Convert.ToInt32(idField.Value);
				Image image = (Image)e.Item.FindControl("produtoImage");

				//Atribuindo a imagem ao controle Image
				image.ImageUrl = "data:" + ProdutosDao.BuscarProduto(id).Mime_Type + ";base64," + ProdutosDao.ExibirImagem(id);
			}
		}
	}
}