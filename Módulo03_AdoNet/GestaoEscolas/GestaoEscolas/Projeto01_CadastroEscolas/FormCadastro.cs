using Projeto02_AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto02_AcessoDados
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
			ListarEscolas();
		}

		private void descricaoCursoLabel_Click(object sender, EventArgs e)
		{
			try
			{
				Escola escola = new Escola();
				escola.Descricao = descricaoTextBox.Text;
				escola.Endereco = enderecoTextBox.Text;
				escola.Telefone = telefoneTextBox.Text;


			}
			catch (Exception)
			{

				throw;
			}
		}

		private void incluirEscolaButton_Click(object sender, EventArgs e)
		{

		}
	}
}
