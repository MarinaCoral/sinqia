using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{
	//classes abstratas nao podem ser instanciadas mas podem ser usadas como variaveis
	//método abstrato: método sem conteudo
	public abstract class Dao<T, K>
	{
		//construtor (ctor)
		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();
		}

		//string de conexão
		private string conexao = "Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DB_EVENTOS;Data Source=.";

		//objetos de acesso a dados
		//namespace System.Data.SqlClient


		protected SqlConnection cn;
		protected SqlCommand cmd;
		protected SqlDataReader reader;     //modo conectado
		protected SqlDataAdapter adapter;   //modo desconectado

		//métodos para abrir e fechar a conexão

		protected void AbrirConexao()
		{
			cn.Open();
		}


		protected void FecharConexao()
		{
            if (cn != null && cn.State == ConnectionState.Open)
			{
				cn.Close();
			}
		}


		//métodos abstratos (obrigar a implementacao dele na subclasse)

		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);
		public abstract IEnumerable<T> Listar(int id = 0);
	}
}
