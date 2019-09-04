using DesenvolvimentoWeb.Vendas.Models;
using DesenvolvimentoWeb.Vendas.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesenvolvimentoWeb.Vendas.Data
{
	public class PedidosDao
	{
		public static void IncluirPedido(Pedido pedido)
		{
			using (var context = new VendasEntities())
			{
				context.Pedidos.Add(pedido);
				context.SaveChanges();
			}
		}

		//listando os pedidos, incluindo o nome do cliente e seu pedido
		public static IEnumerable<ClientePedidoViewModel> ListarPedidosVM()
		{
			using (var context = new VendasEntities())
			{
				var pedidos = context.Clientes.Join(
					context.Pedidos,
					c => c.Documento,
					p => p.DocCliente,
					(c, p) => new
					{
						c.Documento,
						c.Nome,
						p.NumeroPedido,
						p.Id
					});

				List<ClientePedidoViewModel> lista = new List<ClientePedidoViewModel>();

				foreach (var item in pedidos)
				{
					lista.Add(new ClientePedidoViewModel()
					{
						DocumentoCliente = item.Documento,
						NomeCliente = item.NumeroPedido + "-" + item.Nome,
						NumeroPedido = item.NumeroPedido,
						IdPedido = item.Id
					});
				}
				return lista;
			}
		}

			public static IEnumerable<ClientePedidoViewModel> ListarPedidosVMLinq()
			{
				using (var context = new VendasEntities())
				{
				var pedidos = from c in context.Clientes
							  join p in context.Pedidos
							  on c.Documento equals p.DocCliente
							  select new
							  {
								  c.Documento,
								  c.Nome,
								  p.NumeroPedido,
								  p.Id
							  };
					List < ClientePedidoViewModel > lista = new List<ClientePedidoViewModel>();

					foreach (var item in pedidos)
					{
						lista.Add(new ClientePedidoViewModel()
						{
							DocumentoCliente = item.Documento,
							NomeCliente = item.NumeroPedido + "-" + item.Nome,
							NumeroPedido = item.NumeroPedido,
							IdPedido = item.Id
						});
					}
					return lista;
				}
			}
	}
} 