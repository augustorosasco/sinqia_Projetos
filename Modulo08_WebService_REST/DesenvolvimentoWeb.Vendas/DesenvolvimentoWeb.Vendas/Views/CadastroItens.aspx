<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroItens.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroItens" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container">
        <h2 class="text-center text-primary">Cadastro de Pedidos</h2>
        <div class="row">
            <div class="col-md-5">
                <h3>Forneça os dados</h3>

                <%--Pedido + Cliente--%>
                <div class="form-group">
                    <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
                    <asp:DropDownList ID="pedidosDropDownList" CssClass="form-control" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="pedidoRequiredFieldValidator" runat="server"
                        ControlToValidate="pedidoTextBox" ErrorMessage="O Pedido deve ser informado" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <%--Produto--%>
                <div class="form-group">
                    <asp:Label ID="ProdutoLabel" runat="server" Text="Produto: "></asp:Label>
                    <asp:DropDownList ID="produtosDropDownList" CssClass="form-control" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="produtoRequiredFieldValidator" runat="server"
                        ControlToValidate="produtoTextBox" ErrorMessage="O Produto deve ser informado" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>


                <%--Quantidade--%>
                <div class="form-group">
                    <asp:Label ID="quantidadeLabel" runat="server" Text="Quantidade: "></asp:Label>
                    <asp:TextBox ID="quantidadeTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="quantidadeRequiredFieldValidator" runat="server"
                        ControlToValidate="quantidadeTextBox" ErrorMessage="A quantidade deve ser informado" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="quantidadeRangeValidator" runat="server" ErrorMessage="A quantidade deve estar entre 1 e 100" MaximumValue="100" MinimumValue="1" Type="Double"></asp:RangeValidator>
                </div>

                <%--Botão--%>
                <div class="form-group">
                    <asp:Button ID="enviarButton" CssClass="btn btn-primary" runat="server" Text="Incluir " OnClick="enviarButton_Click"></asp:Button>
                </div>

                <div>
                    <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                </div>

            </div>
            <div class="col-md-7">
                <%--    <h3>Lista de Clientes</h3>
                <asp:Repeater ID="clientesRepeater" runat="server">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <th>CPF</th>
                                    <th>Nome</th>
                                    <th>Telefone</th>
                                    <th>E-mail</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Documento") %>'></asp:Label></td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Nome") %>'></asp:Label></td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Telefone") %>'></asp:Label></td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Email") %>'></asp:Label></td>
                        </tr>
                    </ItemTemplate>

                    <FooterTemplate>
                        </tbody>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>--%>
            </div>

        </div>
    </div>

</asp:Content>
