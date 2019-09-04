using Projeto_AcessoDados.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AcessoDados.DAL
{
	public class EscolaDao : Dao<Escola, int>
	{
		public override Escola Buscar (int chave)
		{
			Escola escola = null;

			try
			{
				AbrirConexao();
				cmd.CommandText = "SELECT * FROM TBEscolas WHERE Id = @Id";
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@Id", chave);
				reader = cmd.ExecuteReader();

				if(reader.Read())
				{
					escola = new Escola();

					escola.Codigo = (int)reader["Codigo"];
					escola.Descricao = (string)reader["Descricao"];
					escola.Endereco = (string)reader["Resposavel"];
					escola.Telefone = (string)reader["Telefone"];

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

			return escola;
		}

		public override void Incluir(Escola elemento)
		{
			try
			{
				AbrirConexao();
				cmd.CommandText = "INSERT INTO TBEscolas (Descricao, Endereco, Telefone)" +
					" VALUES (@Descricao, @Endereco, @Telefone)";
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao);
				cmd.Parameters.AddWithValue("@endereco", elemento.Endereco);
				cmd.Parameters.AddWithValue("@Telefone", elemento.Telefone);

				cmd.ExecuteNonQuery();
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

		public override IEnumerable<Escola> Listar(int Id = 0)
		{
			List<Escola> escolas = new List<Escola>();
			try
			{
				if(Id !=0)
				{
					throw new Exception("Nenhum parametro deve ser informado");
				}
				AbrirConexao();
				cmd.CommandText = "SELECT * FROM TBEscolas";
				cmd.CommandType = CommandType.Text;

				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Escola escola = new Escola();

					escola.Codigo = (int)reader["codigo"];
					escola.Descricao = (string)reader["Descricao"];
					escola.Endereco = (string)reader["Endereco"];
					escola.Telefone = (string)reader["Telefone"];

					escolas.Add(escola);
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
			return escolas;
		}
	}
}
