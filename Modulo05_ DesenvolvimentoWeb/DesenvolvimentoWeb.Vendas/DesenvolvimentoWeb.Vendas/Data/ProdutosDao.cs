using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesenvolvimentoWeb.Vendas.Data
{
	public class ProdutosDao
	{
		//Listando todas as categorias
		public static IEnumerable<Categoria> ListarCategorias()
		{
			using (var context = new VendasEntities())
			{
				return context.Categorias.ToList();
			}
		}

		//Incluindo um produto
		public static void IncluirProduto(Produto produto)
		{
			using (var context = new VendasEntities())
			{
				context.Produtos.Add(produto);
				context.SaveChanges();
			}

		}

		//Listando todos os produtos 
		public static IEnumerable<Produto> ListarProdutos()
		{
			using (var context = new VendasEntities())
			{
				return context.Produtos.ToList();
			}
		}

		//retornando um objeto Produto
		public static Produto BuscarProduto(int id)
		{
			using(var context = new VendasEntities())
			{
				return context.Produtos.FirstOrDefault(p => p.Id == id);
			}
		}

		public static Produto BuscarProdutoLinq(int id)
		{
			using (var context = new VendasEntities())
			{
				var produto = (from p in context.Produtos
							  where p.Id == id
							  select p).FirstOrDefault();
				return produto;
			}
		}

		//retornando a imagem do produto selecionado 
		public static string ExibirImagem(int id)
		{
			using (var context = new VendasEntities())
			{
				var imagem = BuscarProduto(id).Foto;
				return Convert.ToBase64String(imagem, 0, imagem.Length);
			}
		}

		//retornando o MimeType do produto selecionado
		public static string ExibirMimeType(int id)
		{
			using (var context = new VendasEntities())
			{
				return BuscarProduto(id).MimeType; 
			}
		}      
	}

}    