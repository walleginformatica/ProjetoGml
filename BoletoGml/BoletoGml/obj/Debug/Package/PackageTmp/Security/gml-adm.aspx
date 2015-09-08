<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gml-adm.aspx.cs" Inherits="BoletoGml.Security.gml_adm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:GridView ID="GridDownload" runat="server"  AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField  DataField="Nome"  HeaderText="Nome" />
                    <asp:BoundField DataField="Tamanho" HeaderText="Tamanho" />
                    <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="Modificado" HeaderText="Modificado" />

                    <asp:TemplateField HeaderText="Baixar">
                        <ItemTemplate>
                            <asp:LinkButton ID="lkBaixar" OnClick="lkBaixar_Click" runat="server" CommandArgument='<%# Eval("Nome") %>'>Efetuar Download</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
    </div>
    </form>
</body>
</html>
