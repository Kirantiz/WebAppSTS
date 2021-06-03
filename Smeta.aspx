<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Smeta.aspx.cs" Inherits="WebAppSTS.Smeta" Async="true" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
   
     <h1>  Работа со сметами </h1>
        <p class="lead"> 
            <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>


        </p>
        <p class="lead"> 
            &nbsp;</p>
        <p class="lead"> 
            <asp:Button ID="AddSmeta" runat="server" Text="Добавить смету" Width="370px" OnClick="AddSmeta_Click"/>


        &nbsp;&nbsp;&nbsp; 
            

        &nbsp;&nbsp;&nbsp;
            

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   


        <asp:Label ID="LabelId" runat="server" ForeColor="Black" Visible="False">ID Сметы</asp:Label>   


        </p>
        <p class="lead"> 


            <asp:Button ID="DelSmeta" runat="server" Text="Изменить смету" Width="370px" OnClick="DelSmeta_Click"/>


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox7" runat="server" ForeColor="Black" Width="140px" Visible="False"></asp:TextBox>


        <asp:Button ID="findButton" runat="server" Text="Найти" Width="70px" Visible="False" OnClick="findButton_Click"/>


        </p>
        <p class="lead"> 


            <asp:Button ID="ListSmeta" runat="server" Text="Список смет" Width="370px" OnClick="ListSmeta_Click"/>


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        

        </p>
    
        <p class="lead"> 
            <asp:Label ID="LabelText1" runat="server" ForeColor="Black" Width="140px" Font-Size="Medium" Visible="False">Клиент</asp:Label>


            <asp:Label ID="LabelText2" runat="server" ForeColor="Black" Width="140px" Font-Size="Medium" Visible="False">Объект</asp:Label>


            <asp:Label ID="LabelText3" runat="server" ForeColor="Black" Width="140px" Font-Size="Medium" Visible="False">Тип Сметы</asp:Label>


            <asp:Label ID="LabelText4" runat="server" ForeColor="Black" Width="140px" Font-Size="Medium" Visible="False">Примечания</asp:Label>


            <asp:Label ID="LabelText5" runat="server" ForeColor="Black" Width="140px" Font-Size="Medium" Visible="False">Статус</asp:Label>


        </p>
        <p class="lead"> 
            <asp:TextBox ID="TextBox1" runat="server" ForeColor="Black" Width="140px" Visible="False"></asp:TextBox>


            <asp:TextBox ID="TextBox2" runat="server" Width="140px" ForeColor="Black" Visible="False"></asp:TextBox>


            <asp:TextBox ID="TextBox3" runat="server" Width="140px" ForeColor="Black" ViewStateMode="Enabled" Visible="False"></asp:TextBox>


            <asp:TextBox ID="TextBox4" runat="server" Width="140px" ForeColor="Black" ViewStateMode="Enabled" Visible="False"></asp:TextBox>


            <asp:TextBox ID="TextBox5" runat="server" Width="140px" ForeColor="Black" ViewStateMode="Enabled" Visible="False"></asp:TextBox>


        <asp:Button ID="ButtonAdd" runat="server" Text="Добавить" Width="130px" Visible="False" OnClick="ButtonAdd_Click"/>


        </p>
        <p class="lead"> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


            <asp:Label ID="LabelText6" runat="server" ForeColor="Black" Width="146px" Font-Size="Medium" Visible="False" Height="32px">Описание</asp:Label>


        </p>
       <%//  <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>%>


        <asp:Button ID="Button1" runat="server" Text="Button" Visible="False" Height="30px" Width="82px" />


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


            <asp:TextBox ID="TextBox6" runat="server" Width="474px" ForeColor="Black" ViewStateMode="Enabled" Visible="False" Height="117px" TextMode="MultiLine"></asp:TextBox>


    </div>
    <div class="row">
        <asp:Button ID="ButtonBack" runat="server"  Text="Назад" Visible="False" />
        <asp:Button ID="ButtonNext" runat="server"  Text="Далее" Visible="False" />
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