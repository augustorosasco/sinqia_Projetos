using Projeto02_WCFPagamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projeto02_WCFPagamentos
{
   
    public class ServicePagamentos : IServicePagamentos
    {
        public int EfetuarPagamento(PagamentosContract pagamento)
        {

            /* Valores de Retorno:
             * 0 - Pagamento OK
             * 1 - Cartão Inexistente
             * 2 - Pedido já pago
             * 3 - Limite indisponivel no cartao
             */

            using (var context = new DB_PAGAMENTOSEntities())
            {
                //Verificação de exixtencia do cartão
                var cartao = context.TBCartoes
                    .FirstOrDefault(c => c.NumeroCartao == pagamento.NumeroCartao);
                if (cartao == null)
                {
                    return 1;
                }

                //verificação do pedido
                var pedido = context.TBPagamentos
                    .FirstOrDefault(p => p.NumeroPedido == pagamento.NumeroPedido);
                if (pedido != null)
                {
                    return 2;
                }

                // Verificação do limite disponivel 
                double valorPedidos = pagamento.Valor;

                var pagamentosRealizados = context
                    .TBPagamentos.Where(p => p.NumeroCartao == pagamento.NumeroCartao);

                if (pagamentosRealizados.Count() > 0)
                {
                    valorPedidos += pagamentosRealizados.Sum(s => s.Valor);
                }
                if(valorPedidos > cartao.Limite)
                {
                    return 3;
                }

                //Pagamento Realizado
                Pagamento pagto = new Pagamento();
                pagto.NumeroCartao = pagamento.NumeroCartao;
                pagto.NumeroPedido = pagamento.NumeroPedido;
                pagto.Valor = pagamento.Valor;
                context.TBPagamentos.Add(pagto);
                context.SaveChanges();
                return 0;
            }
        }
            public List<CartaoContract> ListarCartoes()
        {


            
             
            using (var context = new DB_PAGAMENTOSEntities())
            {
                var cartoes = context.TBCartoes;
                List<CartaoContract> lista = new List<CartaoContract>();

                foreach (var item in cartoes)
                {
                    lista.Add(new CartaoContract()
                    {
                        Id = item.Id,
                        NumeroCartao = item.NumeroCartao,
                        Limite = item.Limite
                    });
                }
                return lista;
            }
        }

        public List<PagamentosContract> ListarPagamentos()
        {
            using(var context =  new DB_PAGAMENTOSEntities())
            {
                var pagamentos = context.TBPagamentos;
                List<PagamentosContract> lista = new List<PagamentosContract>();

                foreach(var item in pagamentos)
                {
                    lista.Add(new PagamentosContract()
                    {
                        Id = item.Id,
                        NumeroCartao = item.NumeroCartao,
                        NumeroPedido = item.NumeroPedido,
                        Valor = item.Valor

                    });
                }
                return lista;
            }
        }
    }
}
