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
            <asp:TextBox ID="AddName" runat="server" Visible="False" ForeColor="Black" ToolTip="Наименование материала"></asp:TextBox>


            <asp:TextBox ID="AddQt" runat="server" Visible="False" Width="125px" ForeColor="Black" ToolTip="Количество"></asp:TextBox>


            <asp:TextBox ID="AddCost" runat="server" Visible="False" Width="64px" ForeColor="Black" ToolTip="Стоймость материала"></asp:TextBox>


        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAddMat2" runat="server" OnClick="ButtonAddMat2_Click" Text="Добавить" Visible="False" Width="130px" />


        </p>
        <p class="lead"> 
            <asp:Button ID="ButtonDelMat" runat="server" Text="Изменить количество" Width="370px" OnClick="ButtonDelMat_Click" />


        &nbsp;&nbsp;&nbsp; 
            

            <asp:TextBox ID="DelQt" runat="server" Visible="False" Width="125px" ForeColor="Black" ToolTip="Количество" ViewStateMode="Enabled"></asp:TextBox>


            &nbsp;&nbsp;


            <asp:TextBox ID="DelId" runat="server" Visible="False" Width="64px" ForeColor="Black" ToolTip="ID Матиериала"></asp:TextBox>


        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDelMat2" runat="server" OnClick="ButtonDelMat2_Click" Text="Изменить" Visible="False" Width="130px" />


        </p>
        <p class="lead"> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="LabelObj" runat="server" ForeColor="Black" Visible="False">ID Объекта</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="LabelMat" runat="server" ForeColor="Black" Visible="False">ID Материала</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="LabelQt" runat="server" ForeColor="Black" Visible="False">Кол-во</asp:Label>


        </p>
        <p class="lead"> 
            <asp:Button ID="AddRashodButton" runat="server" Text="Добавить расход материалов" Width="370px" OnClick="AddRashodButton_Click" />


        &nbsp;&nbsp;&nbsp; 
            

            <asp:TextBox ID="idObj" runat="server" Visible="False" Width="120px" ForeColor="Black" ToolTip="Количество" ViewStateMode="Enabled"></asp:TextBox>


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            

            <asp:TextBox ID="idMat" runat="server" Visible="False" Width="120px" ForeColor="Black" ToolTip="Количество" ViewStateMode="Enabled"></asp:TextBox>


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            

            <asp:TextBox ID="qtRash" runat="server" Visible="False" Width="120px" ForeColor="Black" ToolTip="Количество" ViewStateMode="Enabled"></asp:TextBox>


            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAddRashod" runat="server" OnClick="ButtonAddRashod_Click" Text="Добавить" Visible="False" Width="130px" />


        </p>
        <p class="lead"> 
            <asp:Button ID="Button4" runat="server" Text="Вывод отчёта на экран" Width="370px" OnClick="Button4_Click" />


        &nbsp;&nbsp;&nbsp; 
            <asp:Button ID="RashodButton" runat="server" Text="Вывод расхода на экран" Width="370px" OnClick="RashodButton_Click" />


        </p>
        <p class="lead"> 
            &nbsp;</p>
       <%//  <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>%>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Visible="False" />
    </div>
    <div class="row">
        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Назад" Visible="False" />
        <asp:Button ID="ButtonNext" runat="server" OnClick="ButtonNext_Click" Text="Далее" Visible="False" />
        <br />

    <div class="row">

        <table border ="1">

            <tr>
     <td>   <asp:Label ID="Label01" runat="server" ForeColor="Black"></asp:Label>&nbsp; </td><td><asp:Label ID="Label02" runat="server" ForeColor="Black"></asp:Label>&nbsp;</td><td><asp:Label ID="Label03" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label04" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label05" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label06" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label07" runat="server" ForeColor="Black"></asp:Label></td>
 </tr>
<tr>
     <td>   <asp:Label ID="Label3" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label13" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label23" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label33" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label43" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label53" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label63" runat="server" ForeColor="Black"></asp:Label></td>
 </tr>       
  <tr>    <td>  <asp:Label ID="Label4" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label14" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label24" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label34" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label44" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label54" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label64" runat="server" ForeColor="Black"></asp:Label></td>
   </tr>     
    <tr>   <td> <asp:Label ID="Label5" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label15" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label25" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label35" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label45" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label55" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label65" runat="server" ForeColor="Black"></asp:Label></td>
   </tr>     
    <tr>    <td><asp:Label ID="Label6" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label16" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label26" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label36" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label46" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label56" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label66" runat="server" ForeColor="Black"></asp:Label></td>
   </tr>     
   <tr>    <td> <asp:Label ID="Label7" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label17" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label27" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label37" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label47" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label57" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label67" runat="server" ForeColor="Black"></asp:Label></td>
    </tr>    
      <tr>  <td><asp:Label ID="Label8" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label18" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label28" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label38" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label48" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label58" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label68" runat="server" ForeColor="Black"></asp:Label></td>
     </tr>   
      <tr> <td> <asp:Label ID="Label9" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label19" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label29" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label39" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label49" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label59" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label69" runat="server" ForeColor="Black"></asp:Label></td>
      </tr>  
    <tr>    <td><asp:Label ID="Label10" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label20" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label30" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label40" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label50" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label60" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label70" runat="server" ForeColor="Black"></asp:Label></td>
    </tr>    
    <tr>    <td><asp:Label ID="Label11" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label21" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label31" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label41" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label51" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label61" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label71" runat="server" ForeColor="Black"></asp:Label></td>
     </tr>   
     <tr>   <td><asp:Label ID="Label12" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label22" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label32" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label42" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label52" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label62" runat="server" ForeColor="Black"></asp:Label></td><td><asp:Label ID="Label72" runat="server" ForeColor="Black"></asp:Label></td>
</tr>
            </table>
    </div>
    <td><asp:Label ID="Label1" runat="server" ForeColor="Black" Visible="False"></asp:Label></td>
    </div>

</asp:Content>