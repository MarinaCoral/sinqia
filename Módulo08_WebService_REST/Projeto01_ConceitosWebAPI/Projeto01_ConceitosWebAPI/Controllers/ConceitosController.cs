using Projeto01_ConceitosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto01_ConceitosWebAPI.Controllers
{
	public class ConceitosController : ApiController
	{
		[Route("Nomes")]
		public List<string> GetNomes()
		{
			return Dados.ListarNomes();
		}
		[Route("Nome/{id}")]
		public string GetNome(string id)
		{
			return Dados.ListarNomes().Find(n => n.ToLower().Contains(id.ToLower()));
		}
		public List<Produto> GetProdutos()
		{
			return Dados.ListarProdutos();
		}
		[HttpGet]
		[Route("listaprodutos")]
		public List<Produto> BuscarProdutos()
		{
			return Dados.ListarProdutos();
		}
		public Produto GetProduto(int id)
		{
			return Dados.ListarProdutos().Find(p => p.Id == id);
		}

		public int PostProduto(Produto produto)
		{
			try
			{
				Dados.IncluirProduto(produto);
				return 1;
			}
			catch (Exception)
			{

				return -1;
			}

		}
	}
}










