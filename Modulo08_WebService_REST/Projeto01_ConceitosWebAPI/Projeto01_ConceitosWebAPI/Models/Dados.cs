using Projeto01_ConceitosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01_ConceitosWebApi.Models
{
    public class Dados
    {
        static List<Produto> produtos = new List<Produto>()
            {
                new Produto()
                {
                    Id = 1, Descricao = "Caneta", Preco = 1.00, CatProduto = new Categoria()
                    {
                        Codigo = 10, Descricao = "Material"
                    }
                },
                new Produto()
                {
                    Id = 2, Descricao = "Bicicleta", Preco = 1500.00, CatProduto = new Categoria()
                    {
                        Codigo = 20, Descricao = "Transporte"
                    }
                }

            };

        public static List<Produto> ListarProdutos()
        {
            return produtos;
        }

        public static List<string> ListarNomes()
        {
            return new List<string>()
            {
                "Vinicius", "Paulinho", "Lula", "Dilma", "Jair"
            };
        }
        public static void IncluirProduto(Produto produto)
        {
            produtos.Add(produto);
        }
    }
}