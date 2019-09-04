<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroPedidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container">
        <h2 class="text-center text-primary">Inclusão de Pedidos</h2>
        <div class="row">
            <div class="col-md-5">
                <h3>Forneça os dados</h3>

                <%--Cliente--%>
                <div class="form-group">
                    <asp:Label ID="clienteLabel" runat="server" Text="Cliente: "></asp:Label>
                    <asp:DropDownList ID="clienteDropDownList" CssClass="form-control" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="clienteRequiredFieldValidator" runat="server"
                        ControlToValidate="clienteTextBox" ErrorMessage="O Cliente deve ser informado" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <%--Data--%>
                <div class="form-group">
                    <asp:Label ID="dataLabel" runat="server" Text="Data: "></asp:Label>
                    <asp:TextBox ID="dataTextBox" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="dataRequiredFieldValidator" runat="server"
                        ControlToValidate="dataTextBox" ErrorMessage="A data deve ser informado" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <%--Número do pedido--%>
                <div class="form-group">
                    <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
                    <asp:TextBox ID="pedidoTextBox" MaxLength="20" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="pedidoTextBox" ErrorMessage="O Pedido deve ser informado" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>

                <%--Botão--%>
                <div class="form-group">
                    <asp:Button ID="enviarButton" CssClass="btn btn-primary" runat="server" Text="Incluir Pedido" OnClick="enviarButton_Click"></asp:Button>
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
