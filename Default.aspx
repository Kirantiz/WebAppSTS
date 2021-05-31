<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppSTS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       <% //<h1>ASP.NET</h1>%> 
     <h1>    Здравствуйте,  <% 

                                     if (Context.User.Identity.GetUserName().Length == 0)
                                     {
                                         Response.Write("Гость!");
                                         Label1.Text = "Для использования данного веб приложения необходимо выполнить вход.";
                                     }
                                     else
                                     {
                                         Response.Write(Context.User.Identity.GetUserName());
                                     }%>  


        </h1>
        <p class="lead"> 
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>


        </p>
       <%//  <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>%>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Работа со складом</h2>
            <p>
                Внесение новых материалов и измений в отчёт по материальным ресурсам
            </p>
            <p>
                <a class="btn btn-default" href="/Matot.aspx">Далее &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Работа с объектами</h2>
            <p>
                Добавление и изменение объектов, расход материалов, выполнение работ.
            </p>
            <p>
                <a class="btn btn-default" href="/Object.aspx">Далее &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Заказать смету</h2>
            <p>
                Страница для заказа Смет, актов форм С-2А, С-2Б и Справок формы С-3А.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Далее &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
