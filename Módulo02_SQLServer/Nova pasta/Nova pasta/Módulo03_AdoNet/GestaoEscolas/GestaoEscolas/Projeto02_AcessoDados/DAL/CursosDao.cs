using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	public class CursosDao : Dao<Curso, string>
	{
		public override Curso Buscar(string chave)
		{
			throw new NotImplementedException();
		}
		
		public int StatusInclusaoCurso { get; set; }

		public override void Incluir(Curso elemento)
		{
			try
			{
				AbrirConexao();
				cmd.CommandText = "pr_incluir_curso";
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@IdEscola", elemento.IdEscola);
				cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao);
				cmd.Parameters.AddWithValue("@CargaHoraria", elemento.Carga_Horaria);
				cmd.Parameters.AddWithValue("@Preco", elemento.Preco);

				//parametro de saida
				SqlParameter parameter = new SqlParameter();
				parameter.ParameterName = "@status";
				parameter.SqlDbType = SqlDbType.Int;
				parameter.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(parameter);

				cmd.ExecuteNonQuery();
				int status = (int)parameter.Value;
				StatusInclusaoCurso = status;

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
		}

		//metodo que retorna um conjunto de valores provenientes
		//na tabela TBCursos, em forma de objetos - DataTable
		public override IEnumerable<Curso> Listar(int id = 0)
		{
			List<Curso> convidados = new List<Curso>();

			try
			{
				AbrirConexao();

				string sql = "SELECT * FROM TBCursos";
				if(id > 0)
				{
					sql += "WHERE "
				}
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
		}
	}
}
