﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="EfetuarPagamento.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.EfetuarPagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
         <h2 class="text-center text-primary">Selecionar um item para pagar</h2>

        <div class="form-group">
            <asp:Label ID="pedidoLabel" runat="server" Text="Pedido: "></asp:Label>
            <asp:DropDownList ID="pedidosDropDownList" runat="server" CssClass="form-control" ></asp:DropDownList>
        </div>
        <hr />

        <div class="form-group">
            <asp:Label ID="cartaoLabel" runat="server" Text="Número do Cartão: "></asp:Label>
            <asp:TextBox ID="cartaoTextBox" runat="server" MaxLength="16" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="cartaoRequiredFieldValidator" runat="server" ErrorMessage="Fornecer o número do cartão" 
                controlToValidate="cartaotextBox"  Display="Dynamic" CssClass="text text-danger"></asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Button ID="pagamentoButton" runat="server" Text="Efetuar Pagamento" CssClass="btn btn-primary" OnClick="pagamento_click" />
        </div>

        <div class="form-group">
            <asp:Label ID="mensagemLabel" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content> 

