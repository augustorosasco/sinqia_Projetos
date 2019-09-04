<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ResponderChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ResponderChamado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container">
        <h2 class="text-center text-primary">Resposta de Chamados</h2>
        <div class="row">
            <div class="col-md-5">
                <%--Chamado--%>
                <div class="form-group">
                    <asp:Label ID="chamadoLabel" runat="server" Text="Chamado: "></asp:Label>
                    <asp:DropDownList ID="chamadoDropDownList" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>

                    <%--Botão--%>
                    <div class="form-group">
                        <asp:Button ID="buscarButton" CssClass="btn btn-info" runat="server" Text="Buscar Chamado" OnClick="buscarButton_Click"></asp:Button>
                    </div>

                    <%--Buscar Chamado--%>
                    <div class="form-group">
                        <asp:Label ID="buscarLabel" runat="server" Text="Descrição: "></asp:Label>
                        <asp:TextBox ID="descricaoTextBox" TextMode="MultiLine" Rows="4" Columns="50" ReadOnly="true" CssClass="form-control text-primary" runat="server"></asp:TextBox>
                        </div>

                        <%--Responder Chamado--%>
                        <div class="form-group">
                            <asp:Label ID="responderLabel" runat="server" Text="Responder: "></asp:Label>
                            <asp:TextBox ID="responderTextBox" TextMode="MultiLine" Rows="4" Columns="50" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>

                            <%--Botão--%>
                            <div class="form-group">
                                <asp:Button ID="enviarButton" CssClass="btn btn-info" runat="server" Text="Responder Chamado" OnClick="enviarButton_Click"></asp:Button>
                            </div>


                            <div>
                                <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                            </div>

                        </div>
                    </div>
                </div>
            

</asp:Content>
