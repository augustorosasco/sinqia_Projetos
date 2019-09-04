<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ListaItensAjax.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ListaItensAjax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content> 
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <asp:updatepanel runat="server">
        <ContentTemplate>
            <div class="container">
        <h2 class="text-center text-primary">Cadastro de Produtos</h2>

        <%--Pedido + Cliente--%>
        <div class="form-group">
            <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
            <asp:DropDownList ID="pedidosDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="" ></asp:DropDownList>
        </div>

        <hr/>

        <asp:Repeater ID="itensRepeater" runat="server">
            <HeaderTemplate></HeaderTemplate>

            <ItemTemplate>
                <div class="alert alert-secondary">

                    <div style="float: right;">
                        <asp:LinkButton ID="excluirLinkButton" runat="server" OnClientClick="javascript:return confirm('Tem certeza?')"; 
                            Onclick" CommandArgument='<%# Eval("IdItem")%>'>
                            [x]
                        </asp:LinkButton>
                    </div>

                    <strong>Produto:  </strong>
                    <asp:Label ID="produtoLabel" runat="server" Text='<%# Eval("DescricaoProduto")%>'></asp:Label>

                    <strong>Num. Pedido:  </strong>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("NumeroPedido")%>'></asp:Label>

                    <strong>Data Pedido:  </strong>
                    <asp:Label ID="dataLabel" runat="server" Text='<%# Eval("DataPedido")%>'></asp:Label>

                    <strong>Valor Pedido:  </strong>
                    <asp:Label ID="valorLabel" runat="server" Text='<%# Eval("ValorTotalItem")%>'></asp:Label>
                </div>
            </ItemTemplate>

            <FooterTemplate></FooterTemplate>
            
        </asp:Repeater>

    </div>
        </ContentTemplate>

    </asp:updatepanel>
</asp:Content>  


