using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSTS
{
    public partial class Smeta : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;
        protected void Page_Load(object sender, EventArgs e)
        {

             if (Context.User.Identity.IsAuthenticated == false)
              {
                  Response.Redirect("~/Account/login"); //Если пользователь не выполнил в
              }

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            //await sqlConnection.OpenAsync();

            LabelId.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            LabelText1.Visible = false;
            LabelText2.Visible = false;
            LabelText3.Visible = false;
            LabelText4.Visible = false;
            LabelText5.Visible = false;
            LabelText6.Visible = false;
            ButtonAdd.Visible = false;
            findButton.Visible = false;
            // Label3.Text = "проверка таблицы";
            //   Label4.Text = "таблица";
            Label3.Text = ""; Label13.Text = ""; Label23.Text = ""; Label33.Text = ""; Label43.Text = ""; Label53.Text = ""; Label63.Text = "";
            Label4.Text = ""; Label14.Text = ""; Label24.Text = ""; Label34.Text = ""; Label44.Text = ""; Label54.Text = ""; Label64.Text = "";
            Label5.Text = ""; Label15.Text = ""; Label25.Text = ""; Label35.Text = ""; Label45.Text = ""; Label55.Text = ""; Label65.Text = "";
            Label6.Text = ""; Label16.Text = ""; Label26.Text = ""; Label36.Text = ""; Label46.Text = ""; Label56.Text = ""; Label66.Text = "";
            Label7.Text = ""; Label17.Text = ""; Label27.Text = ""; Label37.Text = ""; Label47.Text = ""; Label57.Text = ""; Label67.Text = "";
            Label8.Text = ""; Label18.Text = ""; Label28.Text = ""; Label38.Text = ""; Label48.Text = ""; Label58.Text = ""; Label68.Text = "";
            Label9.Text = ""; Label19.Text = ""; Label29.Text = ""; Label39.Text = ""; Label49.Text = ""; Label59.Text = ""; Label69.Text = "";
            Label10.Text = ""; Label20.Text = ""; Label30.Text = ""; Label40.Text = ""; Label50.Text = ""; Label60.Text = ""; Label70.Text = "";
            Label11.Text = ""; Label21.Text = ""; Label31.Text = ""; Label41.Text = ""; Label51.Text = ""; Label61.Text = ""; Label71.Text = "";
            Label12.Text = ""; Label22.Text = ""; Label32.Text = ""; Label42.Text = ""; Label52.Text = ""; Label62.Text = ""; Label72.Text = "";
            Label01.Visible = false;
            Label02.Visible = false;
            Label03.Visible = false;
            Label04.Visible = false;
            Label05.Visible = false;
            Label06.Visible = false;
            Label07.Visible = false;
        }

        protected void AddSmeta_Click(object sender, EventArgs e)
        {

            ButtonAdd.Text = "Добавить";
            Label1.Text = "1";
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            LabelText1.Visible = true;
            LabelText2.Visible = true;
            LabelText3.Visible = true;
            LabelText4.Visible = true;
            LabelText5.Visible = true;
            LabelText6.Visible = true;
            ButtonAdd.Visible = true;
     //       LabelText1.Text = "Прораб";
     //       LabelText2.Text = "Кол-во рабочих";
    //        LabelText3.Text = "Разряд";
     //       LabelText4.Text = "Телефон";
     //       LabelText5.Text = "Отпуск";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";



        }

        protected async void ListSmeta_Click(object sender, EventArgs e)
        {
            Label01.Visible = true;
            Label02.Visible = true;
            Label03.Visible = true;
            Label04.Visible = true;
            Label05.Visible = true;
            Label06.Visible = true;
            Label07.Visible = true;
            Label01.Text = "ID Сметы";
            Label02.Text = "UserName";
            Label03.Text = "Клиент";
            Label04.Text = "Название объекта";
            Label05.Text = "Описание";
            Label06.Text = "Примечание";
            Label07.Text = "Статус";
            await sqlConnection.OpenAsync();

            SqlCommand matList = new SqlCommand("SELECT * FROM [Smeta]", sqlConnection);
            SqlDataReader reader = await matList.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                // выводим названия столбцов
                //         Label3.Text=reader.GetName(0)+ "\t"; Label3.Text+= reader.GetName(1)+"\t";
                //            Label3.Text+= reader.GetName(2) + "\n";

                int iCount = 0;
                int iWait = 0;
                while (await reader.ReadAsync())
                {
                    iCount++;
                    if (iCount < iWait) continue;

                    /*      object id = reader.GetValue(0);
                          object name = reader.GetValue(1);
                          object age = reader.GetValue(2);

                              Label3.Text += $"{iCount}) " + reader.GetValue(0) + "\t";
                              Label3.Text += reader.GetValue(1) + "\t";
                              Label3.Text += reader.GetValue(2) + "\t";

                              iCount++;

                              // Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
                    */
                    switch (iCount)
                    {
                        case 1:
                            {
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + " ";
                                Label13.Text = " " + reader.GetValue(1) + " ";
                                Label23.Text = " " + reader.GetValue(2) + " ";
                                Label33.Text = " " + reader.GetValue(3) + " ";
                                Label43.Text = " " + reader.GetValue(4) + " ";
                                Label53.Text = " " + reader.GetValue(6) + " ";
                                Label63.Text = " " + reader.GetValue(7) + " ";
                            }
                            break;
                        case 2:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label14.Text = reader.GetValue(1) + "";
                                Label24.Text = reader.GetValue(2) + "";
                                Label34.Text = reader.GetValue(3) + "";
                                Label44.Text = reader.GetValue(4) + "";
                                Label54.Text = " " + reader.GetValue(6) + " ";
                                Label64.Text = " " + reader.GetValue(7) + " ";
                            }
                            break;
                        case 3:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label15.Text = reader.GetValue(1) + "";
                                Label25.Text = reader.GetValue(2) + "";
                                Label35.Text = reader.GetValue(3) + "";
                                Label45.Text = reader.GetValue(4) + "";
                                Label55.Text = reader.GetValue(6) + "";
                                Label65.Text = reader.GetValue(7) + "";
                            }
                            break;
                        case 4:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label16.Text = reader.GetValue(1) + "";
                                Label26.Text = reader.GetValue(2) + "";
                                Label36.Text = reader.GetValue(3) + "";
                                Label46.Text = reader.GetValue(4) + "";
                                Label56.Text = reader.GetValue(6) + "";
                                Label66.Text = reader.GetValue(7) + "";
                            }
                            break;
                        case 5:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label17.Text = reader.GetValue(1) + "";
                                Label27.Text = reader.GetValue(2) + "";
                                Label37.Text = reader.GetValue(3) + "";
                                Label47.Text = reader.GetValue(4) + "";
                                Label57.Text = reader.GetValue(6) + "";
                                Label67.Text = reader.GetValue(7) + "";
                            }
                            break;
                        case 6:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label18.Text = reader.GetValue(1) + "";
                                Label28.Text = reader.GetValue(2) + "";
                                Label38.Text = reader.GetValue(3) + "";
                                Label48.Text = reader.GetValue(4) + "";
                                Label58.Text = reader.GetValue(6) + "";
                                Label68.Text = reader.GetValue(7) + "";
                            }
                            break;
                        case 7:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label19.Text = reader.GetValue(1) + "";
                                Label29.Text = reader.GetValue(2) + "";
                                Label39.Text = reader.GetValue(3) + "";
                                Label49.Text = reader.GetValue(4) + "";
                                Label59.Text = reader.GetValue(6) + "";
                                Label69.Text = reader.GetValue(7) + "";
                            }
                            break;
                        case 8:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label20.Text = reader.GetValue(1) + "";
                                Label30.Text = reader.GetValue(2) + "";
                                Label40.Text = reader.GetValue(3) + "";
                                Label50.Text = reader.GetValue(4) + "";
                                Label60.Text = reader.GetValue(6) + "";
                                Label70.Text = reader.GetValue(7) + "";
                            }
                            break;
                        case 9:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label21.Text = reader.GetValue(1) + "";
                                Label31.Text = reader.GetValue(2) + "";
                                Label41.Text = reader.GetValue(3) + "";
                                Label51.Text = reader.GetValue(4) + "";
                                Label61.Text = reader.GetValue(6) + "";
                                Label71.Text = reader.GetValue(7) + "";
                            }
                            break;
                        case 10:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label22.Text = reader.GetValue(1) + "";
                                Label32.Text = reader.GetValue(2) + "";
                                Label42.Text = reader.GetValue(3) + "";
                                Label52.Text = reader.GetValue(4) + "";
                                Label62.Text = reader.GetValue(6) + "";
                                Label72.Text = reader.GetValue(7) + "";
                            }
                            break;
                        default:
                            {
                                ButtonNext.Visible = true;
                                iWait = 10;
                            }
                            break;
                    }
                }
            }



        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

      
           // Label2.Text = Context.User.Identity.Name;


            if (Label1.Text == "1")
            {
                string userName = Context.User.Identity.Name;
                string client = TextBox1.Text;
                string objName = TextBox2.Text;
                string type = TextBox3.Text;
                string note = TextBox4.Text;
                string status = TextBox5.Text;
                string description = TextBox6.Text;

                if (userName == "") userName = "Гость";
                //SqlCommand matList = new SqlCommand($"INSERT INTO MATOT(Material, Quantity, Cost) values ('name',12, 22)", sqlConnection);
                // int reader = matList.ExecuteNonQuery();

                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

                string sqlExpression = $"INSERT INTO [Smeta] (Username, Client, ObjName, Description, Type, Note, Status) values (N'{userName}', N'{client}', N'{objName}', N'{description}', N'{type}', N'{note}' , N'{status}')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // добавление
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    if (number > 0) Label2.Text = $"Смета на объект {objName} успешно добавлена";

                }
            }

            if (Label1.Text == "4") //удаление/Изменение Object
            {

                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

                string userName = Context.User.Identity.Name;
                string client = TextBox1.Text;
                string objName = TextBox2.Text;
                string type = TextBox3.Text;
                string note = TextBox4.Text;
                string status = TextBox5.Text;
                string description = TextBox6.Text;
                string idSmeta = TextBox7.Text;

                //string sqlExpression = $"SELECT(Quantity) FROM [MATOT] WHERE IdMat = '{idMat}'";
                string sqlUpdate = $"UPDATE [Smeta] SET Client= N'{client}', ObjName = N'{objName}', Description = N'{description}', Type = '{type}', Note = N'{note}', Status = N'{status}' WHERE Id = '{idSmeta}'";
                string sqlDelete = $"DELETE FROM [Smeta] WHERE Id = {idSmeta}";


                if (description == "" || description == " ")
                {
                    //Label2.Text = "Вы указали количество = 0";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // удаление
                        SqlCommand command = new SqlCommand(sqlDelete, connection);
                        int number = command.ExecuteNonQuery();
                        if (number > 0) Label2.Text = $"Смета с ID {idSmeta} успешна удалёна";
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // изменение
                        SqlCommand command = new SqlCommand(sqlUpdate, connection);
                        int number = command.ExecuteNonQuery();
                        if (number > 0) Label2.Text = $"Смета c ID {idSmeta} успешно изменёна";
                    }

                }


            }




        }

        protected void DelSmeta_Click(object sender, EventArgs e)
        {
            ButtonAdd.Text = "Добавить";
            Label1.Text = "4";
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            findButton.Visible = true;
            LabelText1.Visible = true;
            LabelText2.Visible = true;
            LabelText3.Visible = true;
            LabelText4.Visible = true;
            LabelText5.Visible = true;
            LabelText6.Visible = true;
            ButtonAdd.Visible = true;
            //       LabelText1.Text = "Прораб";
            //       LabelText2.Text = "Кол-во рабочих";
            //        LabelText3.Text = "Разряд";
            //       LabelText4.Text = "Телефон";
            //       LabelText5.Text = "Отпуск";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            LabelId.Visible = true;


        }

        protected async void findButton_Click(object sender, EventArgs e)
        {

            ButtonAdd.Text = "Изменить";
            Label1.Text = "4";
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            LabelText1.Visible = true;
            LabelText2.Visible = true;
            LabelText3.Visible = true;
            LabelText4.Visible = true;
            LabelText5.Visible = true;
            LabelText6.Visible = true;
            ButtonAdd.Visible = true;
            


            LabelId.Visible = true;
            findButton.Visible = true;

            string idObject = TextBox7.Text;
            await sqlConnection.OpenAsync();

            SqlCommand matList = new SqlCommand($"SELECT * FROM [Smeta] WHERE [Id] = {TextBox7.Text + ""} ", sqlConnection);
            SqlDataReader reader = await matList.ExecuteReaderAsync();
            await reader.ReadAsync();
            if (reader.HasRows)
            {
                // выводим названия столбцов
                //         Label3.Text=reader.GetName(0)+ "\t"; Label3.Text+= reader.GetName(1)+"\t";
                //            Label3.Text+= reader.GetName(2) + "\n";


                TextBox1.Text = reader.GetValue(2) + "";
                TextBox2.Text = reader.GetValue(3) + "";
                TextBox3.Text = reader.GetValue(5) + "";
                TextBox4.Text = reader.GetValue(6) + "";
                TextBox5.Text = reader.GetValue(7) + "";
                TextBox6.Text = reader.GetValue(4) + "";

            }
            else Label2.Text = "Объект с таким ID не обнаружен";


        }
    }
}