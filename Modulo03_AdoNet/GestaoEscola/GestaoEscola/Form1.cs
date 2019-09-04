using GestaoEscola.RepositoryDao;
using Projeto_AcessoDados.DAL;
using Projeto_AcessoDados.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscola
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void incluirEscolaButton_Click(object sender, EventArgs e)
		{
			try
			{
				Escola escola = new Escola();
				escola.Descricao = nomeTextBox.Text;
				escola.Endereco = enderecoTextBox.Text;
				escola.Telefone = telefoneTextBox.Text;

				EscolaDao dao = Repository.GetEscolaDao();
				dao.Incluir(escola);

				ListarEscola();

				MessageBox.Show("Evento incluído com sucesso");
				//limpado campo de entrada

				nomeTextBox.Clear();
				enderecoTextBox.Clear();
				telefoneTextBox.Clear();

				nomeTextBox.Focus();
			}

			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void ListarEscola()
		{
			try
			{
				EscolaDao dao = Repository.GetEscolaDao();
				codigoEscolaComboBox.DataSource = dao.Listar();
				codigoEscolaComboBox.DisplayMember = "Descricao";  //text
				codigoEscolaComboBox.ValueMember = "Id";		  //Value

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void incluirCursoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Curso curso = new Curso();
				CursoDao dao = Repository.GetCursoDao();

				curso.Descricao = CursoTextBox.Text;
				curso.CargaHoraria = Convert.ToInt32(CargaHorariaTextBox.Text);
				curso.Preco = Convert.ToDouble(PrecoTextBox.Text);

				//obtendo o Id dp evento a partir do ComboBox
				int id = (int)codigoEscolaComboBox.SelectedValue;

				curso.EscolaInfo = Repository.GetEscolaDao().Buscar(id);

				//incluindo o convidado no banco de dados 
				dao.Incluir(curso);
				if(dao.StatusInclusaoCurso == 1)
				{
					MessageBox.Show("Curso alterado com sucesso");
				}
				else
				{
					MessageBox.Show("Curso incluido com sucesso");
				}
				CursoTextBox.Clear();
				CargaHorariaTextBox.Clear();
				PrecoTextBox.Clear();
				CursoTextBox.Focus();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buscarCursoButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)codigoEscolaComboBox.SelectedValue;
				CursoDao dao = Repository.GetCursoDao();
				//convidadosdataGridView.DataSource = dao.Listar(id);
				CursoGridView.DataSource = dao.ListarCursos(id);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
