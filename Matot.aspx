<%@ Page Async="true" Title="Material Report" Language="C#" AutoEventWireup="true" CodeBehind="Matot.aspx.cs" Inherits="WebAppSTS.Matot" MasterPageFile="~/Site.Master"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
   
     <h1>  Работа со складом </h1>
        <p class="lead"> 
            <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>


        </p>
        <p class="lead"> 
            &nbsp;</p>
        <p class="lead"> 
            &nbsp;<asp:Button ID="Button2" runat="server" Text="Добавить материалы в отчёт" Width="425px" />


        </p>
        <p class="lead"> 
            &nbsp;<asp:Button ID="Button3" runat="server" Text="Убрать материалы из отчёта" Width="425px" />


        </p>
        <p class="lead"> 
            <asp:Button ID="Button4" runat="server" Text="Вывод отчёта на экран" Width="425px" />


        </p>
        <p class="lead"> 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


        </p>
       <%//  <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>%>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </div>
    <div class="row">
        <asp:Label ID="Label3" runat="server" ForeColor="Black"></asp:Label>
    </div>

</asp:Content>