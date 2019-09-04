using DesenvolvimentoWeb.Vendas.Models;
using DesenvolvimentoWeb.Vendas.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesenvolvimentoWeb.Vendas.Data
{
    public class ItensDao
    {
        public static void IncluirItem(Item item)
        {
            using (var context = new VendasEntities())
            {
                context.Itens.Add(item);
                context.SaveChanges();
            }
        }

        public static IEnumerable<ItensPedidoViewModel> ListarItensPorPedido(string numPedido)
        {
            using (var context = new VendasEntities())
            {
                var pedidos = from pedido in context.Pedidos
                              join item in context.Itens
                              on pedido.Id equals item.IdPedido
                              join produto in context.Produtos
                              on item.IdProduto equals produto.Id
                              where pedido.NumeroPedido == numPedido
                              select new
                              {
                                  item.Id,
                                  produto.Descricao,
                                  pedido.NumeroPedido,
                                  pedido.Data,
                                  ValorTotal = produto.Preco * item.Quantidade
                              };

                var lista = new List<ItensPedidoViewModel>();
                foreach (var item in pedidos)
                {
                    lista.Add(new ItensPedidoViewModel()
                    {
                        Iditem = item.Id,
                        DescricaoProduto = item.Descricao,
                        NumeroPedido = item.NumeroPedido,
                        DataPedido = item.Data,
                        ValorTotalItem = item.ValorTotal

                    });
                }
                return lista;
            }

        }

        public static void removerItem(int id)
        {
            using(var context = new VendasEntities())
            {
                Item item = context.Itens.FirstOrDefault(p => p.Id == id);
                if(item != null)
                {
                    context.Entry<Item>(item).State = EntityState.Deleted;
                    context.SaveChanges();


                }
            }
        }
    }

}