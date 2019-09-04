using ProjetoWeb_CadastroEventos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb_CadastroEventos.DAL
{
	public class ConvidadosDao
	{
			public static void IncluirConvidados(Convidado convidado)
			{
				using(var context = new DB_EVENTOSEntities())
			    {
				context.Convidados.Add(convidado);
				context.SaveChanges();
			    }
			}
	}
}