using ProjetoWeb_CadastroEventos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb_CadastroEventos.DAL
{
		public class EventosDao
		{
			public static void IncluirEvento(Evento evento)
		{
			using (var context = new DB_EVENTOSEntities())
			{
				context.Eventos.Add(evento);
				context.SaveChanges();
			}
		}

		public static List<Evento> ListarEventos()
		{
			using (var context = new DB_EVENTOSEntities())
			{
				return context.Eventos.ToList();
			}
		}
		public static Evento BuscarEvento(int id)
		{
			using (var context = new DB_EVENTOSEntities())
			{
				return context.Eventos.FirstOrDefault(p => p.Id == id);
			}
		}
	}
}