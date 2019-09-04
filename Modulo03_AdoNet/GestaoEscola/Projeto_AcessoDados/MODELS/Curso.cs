using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AcessoDados.MODELS
{
	public class Curso
	{
		public int Codigo { get; set; }
		public string Descricao { get; set; }
		public int CargaHoraria { get; set; }
		public double Preco { get; set; }

		//propriedade de navegação 
		public Escola EscolaInfo { get; set; }
	}


}
