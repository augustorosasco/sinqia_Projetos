using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AcessoDados
{
	public abstract class Dao<T, K>
	{
		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();

		}

		// STRING DE CONEXÃO
		private string conexao = @"Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DB_ESCOLA;Data Source=.";

		//objetos de acesso a dados 
		//namespace System.Data.SqlClient
		protected SqlConnection cn;
		protected SqlCommand cmd;
		protected SqlDataReader reader; //modo conectado
		protected SqlDataAdapter adapter; //modo descnonectado

		//MÉTODO PARA ABRIR E FECHAR CONEXÃO
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

		// MÉTODOS ABSTRATOS
		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);
		public abstract IEnumerable<T> Listar(int Id = 0);
	}    
}
