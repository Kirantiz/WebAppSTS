using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace WebAppSTS
{
    public partial class Matot : System.Web.UI.Page
    {

        public void Clear()
        {
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
        }




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

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand matList = new SqlCommand("SELECT * FROM [MATOT]", sqlConnection);
            SqlDataReader reader = await matList.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                // выводим названия столбцов
                Label2.Text = reader.GetName(0) + "\t"; Label2.Text += reader.GetName(1) + "\t";
                Label2.Text += reader.GetName(2) + "\n"; Label2.Text += reader.GetName(3) + "\n";

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
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label3.Text += reader.GetValue(1) + "\t";
                                Label3.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 2:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label4.Text += reader.GetValue(1) + "\t";
                                Label4.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 3:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label5.Text += reader.GetValue(1) + "\t";
                                Label5.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 4:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label6.Text += reader.GetValue(1) + "\t";
                                Label6.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 5:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label7.Text += reader.GetValue(1) + "\t";
                                Label7.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 6:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label8.Text += reader.GetValue(1) + "\t";
                                Label8.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 7:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label9.Text += reader.GetValue(1) + "\t";
                                Label9.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 8:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label10.Text += reader.GetValue(1) + "\t";
                                Label10.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 9:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label11.Text += reader.GetValue(1) + "\t";
                                Label11.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 10:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label12.Text += reader.GetValue(1) + "\t";
                                Label12.Text += reader.GetValue(2) + "\t";
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
            reader.Close();
        }

        protected async void ButtonNext_Click(object sender, EventArgs e)
        {
            await sqlConnection.OpenAsync();
            ButtonBack.Visible = true;
            ButtonNext.Visible = false;
            Label01.Text = "ID Материала";
            Label02.Text = "Наименование материала";
            Label03.Text = "Количество";
            Label04.Text = "Стоимость";
            string sqlText = "SELECT * FROM [MATOT]";
            if (Label1.Text == "2")
            {
                Label01.Text = "ID Расхода";
                Label02.Text = "Объект";
                Label03.Text = "Наименование материала";
                Label04.Text = "Количество";

                sqlText = "SELECT USEMAT.IDUSE, [object].ObjName, MATOT.Material, USEMAT.quantity " +
                "FROM MATOT INNER JOIN USEMAT ON MATOT.IdMat = USEMAT.IDMAT " +
                "INNER JOIN [object] ON USEMAT.IDOBJ = [object].IdObj";
            }
            Clear();

            SqlCommand matList = new SqlCommand(sqlText, sqlConnection);

            SqlDataReader reader = await matList.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                // выводим названия столбцов
                //         Label3.Text=reader.GetName(0)+ "\t"; Label3.Text+= reader.GetName(1)+"\t";
                //            Label3.Text+= reader.GetName(2) + "\n";

                int iCount = 0;
                int iWait = 10;
                while (await reader.ReadAsync())
                {
                    iCount++;
                    if (iCount < iWait)
                    {
                        Label3.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                        Label3.Text += reader.GetValue(1) + "\t";
                        Label3.Text += reader.GetValue(2) + "\t"; continue;
                    }


                    switch (iCount)
                    {
                        case 11:
                            {
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label13.Text = reader.GetValue(1) + "\t";
                                Label23.Text = reader.GetValue(2) + "\t";
                                Label33.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 12:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label14.Text = reader.GetValue(1) + "\t";
                                Label24.Text = reader.GetValue(2) + "\t";
                                Label34.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 13:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label15.Text = reader.GetValue(1) + "\t";
                                Label25.Text = reader.GetValue(2) + "\t";
                                Label35.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 14:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label16.Text = reader.GetValue(1) + "\t";
                                Label26.Text = reader.GetValue(2) + "\t";
                                Label36.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 15:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label17.Text = reader.GetValue(1) + "\t";
                                Label27.Text = reader.GetValue(2) + "\t";
                                Label37.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 16:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label18.Text = reader.GetValue(1) + "\t";
                                Label28.Text = reader.GetValue(2) + "\t";
                                Label38.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 17:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label19.Text = reader.GetValue(1) + "\t";
                                Label29.Text = reader.GetValue(2) + "\t";
                                Label39.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 18:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label20.Text = reader.GetValue(1) + "\t";
                                Label30.Text = reader.GetValue(2) + "\t";
                                Label40.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 19:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label21.Text = reader.GetValue(1) + "\t";
                                Label31.Text = reader.GetValue(2) + "\t";
                                Label41.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 20:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label22.Text = reader.GetValue(1) + "\t";
                                Label32.Text = reader.GetValue(2) + "\t";
                                Label42.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        default:
                            {
                                //ButtonNext.Visible = true;
                                iWait = 10;
                            }
                            break;
                    }











                }
            }
            reader.Close();
        }

        protected async void ButtonBack_Click(object sender, EventArgs e)
        {
            Label01.Text = "ID Материала";
            Label02.Text = "Наименование материала";
            Label03.Text = "Количество";
            Label04.Text = "Стоимость";
            await sqlConnection.OpenAsync();
            string sqlText = "SELECT * FROM [MATOT]";
            if (Label1.Text == "2")
            {
                Label01.Text = "ID Расхода";
                Label02.Text = "Объект";
                Label03.Text = "Наименование материала";
                Label04.Text = "Количество";

                sqlText = "SELECT USEMAT.IDUSE, [object].ObjName, MATOT.Material, USEMAT.quantity " +
                "FROM MATOT INNER JOIN USEMAT ON MATOT.IdMat = USEMAT.IDMAT " +
                "INNER JOIN [object] ON USEMAT.IDOBJ = [object].IdObj";
            }
            SqlCommand matList = new SqlCommand(sqlText, sqlConnection);
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

                    switch (iCount)
                    {
                        case 1:
                            {
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label13.Text = reader.GetValue(1) + "\t";
                                Label23.Text = reader.GetValue(2) + "\t";
                                Label33.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 2:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label14.Text = reader.GetValue(1) + "\t";
                                Label24.Text = reader.GetValue(2) + "\t";
                                Label34.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 3:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label15.Text = reader.GetValue(1) + "\t";
                                Label25.Text = reader.GetValue(2) + "\t";
                                Label35.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 4:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label16.Text = reader.GetValue(1) + "\t";
                                Label26.Text = reader.GetValue(2) + "\t";
                                Label36.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 5:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label17.Text = reader.GetValue(1) + "\t";
                                Label27.Text = reader.GetValue(2) + "\t";
                                Label37.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 6:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label18.Text = reader.GetValue(1) + "\t";
                                Label28.Text = reader.GetValue(2) + "\t";
                                Label38.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 7:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label19.Text = reader.GetValue(1) + "\t";
                                Label29.Text = reader.GetValue(2) + "\t";
                                Label39.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 8:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label20.Text = reader.GetValue(1) + "\t";
                                Label30.Text = reader.GetValue(2) + "\t";
                                Label40.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 9:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label21.Text = reader.GetValue(1) + "\t";
                                Label31.Text = reader.GetValue(2) + "\t";
                                Label41.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 10:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label22.Text = reader.GetValue(1) + "\t";
                                Label32.Text = reader.GetValue(2) + "\t";
                                Label42.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        default:
                            {
                                ButtonNext.Visible = true;
                                ButtonBack.Visible = false;
                                iWait = 10;
                            }
                            break;
                    }











                }
            }
            reader.Close();
        }

        protected async void Button4_Click(object sender, EventArgs e) //вывод отчёта на экран
        {
            Clear();
            Label1.Text = "1";
            Label01.Text = "ID Материала";
            Label02.Text = "Наименование материала";
            Label03.Text = "Количество";
            Label04.Text = "Стоимость";
            await sqlConnection.OpenAsync();
            SqlCommand matList = new SqlCommand("SELECT * FROM [MATOT]", sqlConnection);
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
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label13.Text = reader.GetValue(1) + "\t";
                                Label23.Text = reader.GetValue(2) + "\t";
                                Label33.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 2:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label14.Text = reader.GetValue(1) + "\t";
                                Label24.Text = reader.GetValue(2) + "\t";
                                Label34.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 3:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label15.Text = reader.GetValue(1) + "\t";
                                Label25.Text = reader.GetValue(2) + "\t";
                                Label35.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 4:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label16.Text = reader.GetValue(1) + "\t";
                                Label26.Text = reader.GetValue(2) + "\t";
                                Label36.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 5:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label17.Text = reader.GetValue(1) + "\t";
                                Label27.Text = reader.GetValue(2) + "\t";
                                Label37.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 6:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label18.Text = reader.GetValue(1) + "\t";
                                Label28.Text = reader.GetValue(2) + "\t";
                                Label38.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 7:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label19.Text = reader.GetValue(1) + "\t";
                                Label29.Text = reader.GetValue(2) + "\t";
                                Label39.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 8:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label20.Text = reader.GetValue(1) + "\t";
                                Label30.Text = reader.GetValue(2) + "\t";
                                Label40.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 9:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label21.Text = reader.GetValue(1) + "\t";
                                Label31.Text = reader.GetValue(2) + "\t";
                                Label41.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 10:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label22.Text = reader.GetValue(1) + "\t";
                                Label32.Text = reader.GetValue(2) + "\t";
                                Label42.Text = reader.GetValue(3) + "\t";
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

        protected void ButtonAddMat_Click(object sender, EventArgs e)
        {
            //SqlCommand matList = new SqlCommand("INSERT INTO [MATOT] values * FROM [MATOT]", sqlConnection);
            // SqlDataReader reader = await matList.ExecuteReaderAsync();
            if (ButtonAddMat2.Visible == false)
            {
                ButtonAddMat2.Visible = true;
                AddCost.Visible = true;
                AddName.Visible = true;
                AddQt.Visible = true;
            }
            else
            {
                ButtonAddMat2.Visible = false;
                AddCost.Visible = false;
                AddName.Visible = false;
                AddQt.Visible = false;
            }







        }

        protected void ButtonDelMat_Click(object sender, EventArgs e)
        {
            if (ButtonDelMat2.Visible == false)
            {
                ButtonDelMat2.Visible = true;
                DelId.Visible = true;
                //DelName.Visible = true;
                DelQt.Visible = true;
            }
            else
            {
                ButtonDelMat2.Visible = false;
                DelId.Visible = false;
               // DelName.Visible = false;
                DelQt.Visible = false;
            }
        }

        protected void ButtonAddMat2_Click(object sender, EventArgs e)
        {

           //SqlCommand matList = new SqlCommand($"INSERT INTO MATOT(Material, Quantity, Cost) values ('name',12, 22)", sqlConnection);
           // int reader = matList.ExecuteNonQuery();

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            string matName = AddName.Text;
            string matQt = AddQt.Text;
            string matCost = AddCost.Text;
            string sqlExpression = $"INSERT INTO [MATOT] (Material, Quantity, Cost) values (N'{matName}',{matQt},{matCost})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // добавление
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                if (number > 0) Label2.Text = $"Материал {AddName.Text} успешно добавлен в матотчёт";

            }

        }
            protected void ButtonDelMat2_Click(object sender, EventArgs e)
            {
            //SqlCommand matList = new SqlCommand($"INSERT INTO MATOT(Material, Quantity, Cost) values ('name',12, 22)", sqlConnection);
            // int reader = matList.ExecuteNonQuery();

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            string matQt = DelQt.Text;
            string idMat = DelId.Text;
            string matCost = AddCost.Text;
            string sqlExpression = $"SELECT(Quantity) FROM [MATOT] WHERE IdMat = '{idMat}'";
            string sqlUpdate = $"UPDATE MATOT SET Quantity = {matQt} WHERE IdMat = '{idMat}'";
            string sqlDelete = $"DELETE FROM MATOT WHERE IdMat = {idMat}";


            if (matQt == "0")
            {
                //Label2.Text = "Вы указали количество = 0";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // удаление
                    SqlCommand command = new SqlCommand(sqlDelete, connection);
                    int number = command.ExecuteNonQuery();
                    if (number > 0) Label2.Text = $"Материал с ID {idMat} успешно удалён из матотчёта";

                    //    reader.Read();
                    //    if (reader.HasRows) Label2.Text = reader.GetValue(0);
                }
            }
            else
            {
                Label2.Text = "Количество > 0";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // изменение
                    SqlCommand command = new SqlCommand(sqlUpdate, connection);
                    int number = command.ExecuteNonQuery();
                    if (number > 0) Label2.Text = $"Материал c ID {idMat} успешно изменён";

                    //    reader.Read();
                    //    if (reader.HasRows) Label2.Text = reader.GetValue(0);
                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // добавление
                SqlCommand command = new SqlCommand(sqlExpression, connection);
               // int number = command.ExecuteNonQuery();
               // if (number > 0) Label2.Text = $"Материал {DelName.Text} успешно удалён из матотчёта";
                SqlDataReader reader = command.ExecuteReader();

            //    reader.Read();
            //    if (reader.HasRows) Label2.Text = reader.GetValue(0);

            }





        }

        private void DelQt_Click(object sender, EventArgs e)
        {
            DelQt.Text = "";
        }

        protected async void RashodButton_Click(object sender, EventArgs e)
        {
            ButtonNext.Visible = false;
            Clear();
            Label1.Text = "2";
            Label01.Text = "ID Расхода";
            Label02.Text = "Объект";
            Label03.Text = "Наименование материала";
            Label04.Text = "Количество";
            await sqlConnection.OpenAsync();
            SqlCommand matList = new SqlCommand("SELECT USEMAT.IDUSE, [object].ObjName, MATOT.Material, USEMAT.quantity " +
                "FROM MATOT INNER JOIN USEMAT ON MATOT.IdMat = USEMAT.IDMAT " +
                "INNER JOIN [object] ON USEMAT.IDOBJ = [object].IdObj", sqlConnection);
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

                    switch (iCount)
                    {
                        case 1:
                            {
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label13.Text = reader.GetValue(1) + "\t";
                                Label23.Text = reader.GetValue(2) + "\t";
                                Label33.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 2:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label14.Text = reader.GetValue(1) + "\t";
                                Label24.Text = reader.GetValue(2) + "\t";
                                Label34.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 3:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label15.Text = reader.GetValue(1) + "\t";
                                Label25.Text = reader.GetValue(2) + "\t";
                                Label35.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 4:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label16.Text = reader.GetValue(1) + "\t";
                                Label26.Text = reader.GetValue(2) + "\t";
                                Label36.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 5:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label17.Text = reader.GetValue(1) + "\t";
                                Label27.Text = reader.GetValue(2) + "\t";
                                Label37.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 6:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label18.Text = reader.GetValue(1) + "\t";
                                Label28.Text = reader.GetValue(2) + "\t";
                                Label38.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 7:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label19.Text = reader.GetValue(1) + "\t";
                                Label29.Text = reader.GetValue(2) + "\t";
                                Label39.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 8:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label20.Text = reader.GetValue(1) + "\t";
                                Label30.Text = reader.GetValue(2) + "\t";
                                Label40.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 9:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label21.Text = reader.GetValue(1) + "\t";
                                Label31.Text = reader.GetValue(2) + "\t";
                                Label41.Text = reader.GetValue(3) + "\t";
                            }
                            break;
                        case 10:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label22.Text = reader.GetValue(1) + "\t";
                                Label32.Text = reader.GetValue(2) + "\t";
                                Label42.Text = reader.GetValue(3) + "\t";
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

        protected void AddRashodButton_Click(object sender, EventArgs e)
        {

            if (idMat.Visible == false)

            {
                LabelObj.Visible = true;
                LabelMat.Visible = true;
                LabelQt.Visible = true;
                idMat.Visible = true;
                idObj.Visible = true;
                qtRash.Visible = true;
                ButtonAddRashod.Visible = true;
            }
            else
            {
                LabelObj.Visible = false;
                LabelMat.Visible = false;
                LabelQt.Visible = false;
                idMat.Visible = false;
                idObj.Visible = false;
                qtRash.Visible = false;
                ButtonAddRashod.Visible = false;
            }

            idMat.Text = "";
            idObj.Text = "";
            qtRash.Text = "";


        }

        protected void ButtonAddRashod_Click(object sender, EventArgs e)
        {
            string idO = idObj.Text;
            string idM = idMat.Text;
            string qt = qtRash.Text;
            
            //SqlCommand matList = new SqlCommand($"INSERT INTO MATOT(Material, Quantity, Cost) values ('name',12, 22)", sqlConnection);
            // int reader = matList.ExecuteNonQuery();

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            string sqlExpression = $"INSERT INTO [USEMAT] (IDOBJ, IDMAT, quantity) values ({idO}, {idM}, {qt})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // добавление
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                if (number > 0) Label2.Text = $"Материал с ID {idM} упешно добавлен в объект с ID {idO}. ";

            }



            string sqlUpdate = $"UPDATE MATOT SET Quantity = Quantity - {qt} WHERE IdMat = '{idM}'";
            string sqlDelete = $"DELETE FROM MATOT WHERE Quantity < 1 AND Idmat = {idM}";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // изменение
                    SqlCommand command = new SqlCommand(sqlUpdate, connection);
                    int number = command.ExecuteNonQuery();
                    if (number > 0) Label2.Text += $"Материал c ID {idM} успешно изменён. ";

                    //    reader.Read();
                    //    if (reader.HasRows) Label2.Text = reader.GetValue(0);
                }
/*
            //Label2.Text = "Вы указали количество = 0";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // удаление
                SqlCommand command = new SqlCommand(sqlDelete, connection);
                int number = command.ExecuteNonQuery();
                if (number > 0) Label2.Text += $"Материал с ID {idM} кончился и был удалён из матотчёта";

                //    reader.Read();
                //    if (reader.HasRows) Label2.Text = reader.GetValue(0);
            }*/

        }
    } 
    
}
