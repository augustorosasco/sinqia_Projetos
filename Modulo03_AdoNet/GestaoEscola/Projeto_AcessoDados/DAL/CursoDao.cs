using Projeto_AcessoDados.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AcessoDados.DAL
{
	public class CursoDao : Dao<Curso, string>
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
				cmd.Parameters.AddWithValue("@Codigo", elemento.Codigo);
				cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao);
				cmd.Parameters.AddWithValue("@CargaHoraria", elemento.CargaHoraria);
				cmd.Parameters.AddWithValue("@Preco", elemento.Preco);

				// parametro saida 
				SqlParameter parameter = new SqlParameter();
				parameter.ParameterName  = "@status";
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

		//Método que retoma um conjuto de valores provenientes da tabela TBCursos,
		//em forma de objetos - DataTable

		public DataTable ListarCursos(int id)
		{
			DataTable table = new DataTable();
			try
			{
				AbrirConexao();

				String sql = " SELECT C.Codigo, C.Descricao, c.Endereco, C.cargaHoraria, C.Preco " +
					" FROM TBCursos C, TBEscolas E WHERE" +
					" c.IdEscola = E.Id AND C.IdEscola = " + id;

				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;
				adapter.SelectCommand = cmd;
				adapter.Fill(table);

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}

			return table;
		}

		public override IEnumerable<Curso> Listar(int Id = 0)
		{
			List<Curso> cursos = new List<Curso>();

			try
			{
				if (Id < 0)
				{
					throw new Exception("Não é permitido valor negativo");
				}
				AbrirConexao();

				string sql = "SELECT * FROM TBCursos";
				if (Id > 0)
				{
					sql += "WHERE IdEscolas = @IdEscolas";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("IdEscola", Id);
				}
				cmd.CommandText = sql;
				cmd.CommandType = CommandType.Text;

				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Curso c = new Curso();
					c.Codigo = (int)reader["Codigo"];
					c.Descricao = (string)reader["Descricao"];
					c.CargaHoraria = (int)reader["cargaHoraria"];
					c.Preco = (double)reader["Preco"];
					c.EscolaInfo = new EscolaDao().Buscar((int)reader["IdEscola"]);

					cursos.Add(c);
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

			return cursos;
		}
	}
}