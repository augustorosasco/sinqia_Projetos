using Projeto_CadastroEventos.RepositoryDao;
using Projeto02_AcessoDados.DAL;
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

namespace Projeto_CadastroEventos
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
			ListarEventos();
		}

		private void IncluirEventoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Evento evento = new Evento();
				evento.Descricao = descricaoTextBox.Text;
				evento.Responsavel = ResposnavelTextBox.Text;
				evento.Data = Convert.ToDateTime(DataMaskedTextBox.Text);
				evento.Preco = Convert.ToDouble(PrecoTextBox.Text);

				EventosDao dao = Repository.GetEventosDao();
				dao.Incluir(evento);

				ListarEventos();

				MessageBox.Show("Evento incluído com sucesso");
				//Limpando campo de entrada 
				descricaoTextBox.Clear();
				ResposnavelTextBox.Clear();
				DataMaskedTextBox.Clear();
				PrecoTextBox.Clear();

				descricaoTextBox.Focus();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				
			}
		}

		private void ListarEventos()
		{

			try
			{
				EventosDao dao = Repository.GetEventosDao();
				EventoComboBox.DataSource = dao.Listar();
				EventoComboBox.DisplayMember = "Descricao"; //text
				EventoComboBox.ValueMember = "Id";          //Value
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void IncluirConvidadoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Convidado convidado = new Convidado();    
				ConvidadosDao dao = Repository.GetConvidadosDao();

				convidado.Cpf = CpfTextBox.Text;
				convidado.Nome = nomeTextBox.Text;
				convidado.Email = EmailTextBox.Text;
				convidado.Telefone = telefoneTextBox.Text;

				//obtendo o Id dp evento a partir do ComboBox
				int id = (int)EventoComboBox.SelectedValue;

				convidado.EventoInfo = Repository.GetEventosDao().Buscar(id);

				//incluindo o convidado no banco de dados 
				dao.Incluir(convidado);
				if (dao.StatusInclusaoConvidado == 1)
				{
					MessageBox.Show("Convidado alterado com sucesso");
				}
				else
				{
					MessageBox.Show("Convidado incluido com sucesso");
				}
				CpfTextBox.Clear();
				nomeTextBox.Clear();
				EmailTextBox.Clear();
				telefoneTextBox.Clear();
				CpfTextBox.Focus();
			}	
		
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buscarConvidadosButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)EventoComboBox.SelectedValue;
				ConvidadosDao dao = Repository.GetConvidadosDao();
				//convidadosdataGridView.DataSource = dao.Listar(id); 
				convidadosdataGridView.DataSource = dao.ListarConvidados(id);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
    