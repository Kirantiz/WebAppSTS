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
            <asp:Button ID="ButtonAddMat" runat="server" Text="Добавить материалы в отчёт" Width="370px" OnClick="ButtonAddMat_Click" />


        &nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="AddName" runat="server" Visible="False"></asp:TextBox>


            <asp:TextBox ID="AddQt" runat="server" Visible="False" Width="125px"></asp:TextBox>


            <asp:TextBox ID="AddCost" runat="server" Visible="False" Width="64px"></asp:TextBox>


        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAddMat2" runat="server" OnClick="ButtonAddMat2_Click" Text="Добавить" Visible="False" Width="130px" />


        </p>
        <p class="lead"> 
            <asp:Button ID="ButtonDelMat" runat="server" Text="Убрать материалы из отчёта" Width="370px" OnClick="ButtonDelMat_Click" />


        &nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="DelName" runat="server" Visible="False">Наименование</asp:TextBox>


            <asp:TextBox ID="DelQt" runat="server" Visible="False" Width="125px">Количество</asp:TextBox>


            <asp:TextBox ID="DelId" runat="server" Visible="False" Width="64px">ID</asp:TextBox>


        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDelMat2" runat="server" OnClick="ButtonDelMat2_Click" Text="Удалить" Visible="False" Width="130px" />


        </p>
        <p class="lead"> 
            <asp:Button ID="Button4" runat="server" Text="Вывод отчёта на экран" Width="370px" OnClick="Button4_Click" />


        </p>
        <p class="lead"> 
            &nbsp;</p>
       <%//  <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>%>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </div>
    <div class="row">
        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Назад" Visible="False" />
        <asp:Button ID="ButtonNext" runat="server" OnClick="ButtonNext_Click" Text="Далее" Visible="False" />
        <br />
        <asp:Label ID="Label3" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label9" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label11" runat="server" ForeColor="Black"></asp:Label>
        <br />
        <asp:Label ID="Label12" runat="server" ForeColor="Black"></asp:Label>
    </div>

</asp:Content>