using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesenvolvimentoWeb.Vendas.Data
{
	public class ClientesDao
	{
		public static void incluirCliente(Cliente cliente)
		{
			using(var context = new VendasEntities())
			{
				context.Clientes.Add(cliente);
				context.SaveChanges();
			}
		}

		public static IEnumerable<Cliente> ListarClientes()
		{
			using(var context = new VendasEntities())
			{
				return context.Clientes.ToList();
			}
		}

		//listando os clientes, usando a sintaxe do LINQ to SQL
		public static IEnumerable<Cliente> ListarClientesLing()
		{
			using(var context = new VendasEntities())
			{
				var clientes = from c in context.Clientes
							   select c;
				return clientes.ToList();
			}
		}

        public static Cliente BuscarCliente( string documento)
        {
            using(var context = new VendasEntities())
            {
                return context.Clientes.FirstOrDefault(p => p.Documento == documento);
            }
        }
	}
}