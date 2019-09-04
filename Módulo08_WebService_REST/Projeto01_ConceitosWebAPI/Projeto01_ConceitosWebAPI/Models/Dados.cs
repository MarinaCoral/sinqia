using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01_ConceitosWebAPI.Models
{
	public class Dados
	{
		public static List<string> ListarNomes()
		{
			return new List<string>() {
				"Vinicius","Paulinho","Lula","Dilma","Jair TeiTei"
			};
		}
		static List<Produto> produtos = new List<Produto>()
			{
				new Produto()
				{
					Id = 1,
					Descricao = "Caneta",
					Preco = 270.99,
					CatProduto = new Categoria()
					{
						Codigo = 001,
						Descricao = "Material"
					}
				},
				new Produto()
				{
					Id = 2,
					Descricao = "Hamburguer",
					Preco = 14.90,
					CatProduto = new Categoria()
					{
						Codigo = 002,
						Descricao = "Embaixador"
					}
				}
			};
		public static List<Produto> ListarProdutos()
		{
			return produtos;
		}

		public static void IncluirProduto(Produto produto)
		{
			produtos.Add(produto);
		}
	}
}


	
	
		
	
				














	
					
			
					

	
