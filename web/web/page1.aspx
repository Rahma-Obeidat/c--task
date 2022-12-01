<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="web.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Label1{
            background-color:aquamarine;
           color:#ff0000;
        }
         #Label2{
            background-color:aquamarine;
           color:#ff0000;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <%--<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Height="42px" Width="102px" /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>--%>
            <asp:Label ID="Label1" runat="server" Text="Label">First Number</asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           <%-- <input id="Text1" type="number" value="" />--%>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Label">Last Number</asp:Label>

            <%--<input id="Text2" type="number" />--%>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>


        </p>
        
        
       
        
        <p>
            <asp:Button ID="Button1" runat="server" Text="Sum" Height="32px" OnClick="Button1_Click1" />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

        </p>
        
        
       
        
        <p>
            <asp:Button ID="Button2" runat="server" Text="Sub" Height="28px" Width="46px" OnClick="Button2_Click" />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </p>
        
        
       
        
        <p>
            <asp:Button ID="Button3" runat="server" Text="Mul" Height="26px" Width="47px" OnClick="Button3_Click" />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>

        </p>
        
        <asp:Button ID="Button4" runat="server" Text="Div" Height="30px" Width="47px" OnClick="Button4_Click" />
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        
    </form>
   
</body>
</html>
