using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.Models
{
	public class Curso
	{
		public string Id { get; set; }
		public string Descricao { get; set; }
		public string Carga_Horaria { get; set; }
		public string Preco { get; set; }

		//propriedade de navegação
		public Escola IdEscola { get; set; }
	}
}
s