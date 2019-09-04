﻿using DesenvolvimentoWeb.Vendas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
    public partial class ListaItens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pedidosDropDownList.DataSource = PedidosDao.ListarPedidosVM();
                pedidosDropDownList.DataTextField = "NomeCliente";
                pedidosDropDownList.DataValueField = "NumeroPedido";
                pedidosDropDownList.DataBind();
                pedidosDropDownList.Items.Insert(0, "SELECIONE UM PEDIDO");

            }
        }

        protected void pedidosDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string numeroPedido = pedidosDropDownList.SelectedValue;

                itensRepeater.DataSource = ItensDao.ListarItensPorPedido(numeroPedido);
                itensRepeater.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void excluirLinkButton_Click(object sender, EventArgs e)
        {
            var x = ((LinkButton)sender).CommandArgument;

            ItensDao.removerItem(int.Parse(x));
        }

        //método para listar os itens atualizados de um pedido
        private void ListarItens()
        {
            try
            {
                string numeroPedido = pedidosDropDownList.SelectedValue;

                itensRepeater.DataSource = ItensDao.ListarItensPorPedido(numeroPedido);
                itensRepeater.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}