using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AcessoDados.MODELS
{
	public class Escola
	{
		public int Codigo { get; set; }
		public string Descricao { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }

		// PROPRIEDADE DE NAVEGAÇÃO
		public List<Curso> Cursos { get; set; }
	}


}
