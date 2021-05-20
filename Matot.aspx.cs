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
        private SqlConnection sqlConnection = null;

        protected async void Page_Load(object sender, EventArgs e)
        {
            // if (Context.User.Identity.IsAuthenticated == false)
            //  {
            //      Response.Redirect("~/Account/login"); //Если пользователь не выполнил в
            //  }

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

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
            ButtonBack.Visible = true;
            ButtonNext.Visible = false;

            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";
            Label11.Text = "";
            Label12.Text = "";

            SqlCommand matList = new SqlCommand("SELECT * FROM [MATOT]", sqlConnection);
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
                        case 11:
                            {
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label3.Text += reader.GetValue(1) + "\t";
                                Label3.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 12:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label4.Text += reader.GetValue(1) + "\t";
                                Label4.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 13:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label5.Text += reader.GetValue(1) + "\t";
                                Label5.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 14:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label6.Text += reader.GetValue(1) + "\t";
                                Label6.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 15:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label7.Text += reader.GetValue(1) + "\t";
                                Label7.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 16:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label8.Text += reader.GetValue(1) + "\t";
                                Label8.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 17:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label9.Text += reader.GetValue(1) + "\t";
                                Label9.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 18:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label10.Text += reader.GetValue(1) + "\t";
                                Label10.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 19:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label11.Text += reader.GetValue(1) + "\t";
                                Label11.Text += reader.GetValue(2) + "\t";
                            }
                            break;
                        case 20:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "\t";
                                Label12.Text += reader.GetValue(1) + "\t";
                                Label12.Text += reader.GetValue(2) + "\t";
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
        }

        protected async void ButtonAddMat_Click(object sender, EventArgs e)
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
                DelName.Visible = true;
                DelQt.Visible = true;
            }
            else
            {
                ButtonDelMat2.Visible = false;
                DelId.Visible = false;
                DelName.Visible = false;
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // добавление
                SqlCommand command = new SqlCommand(sqlExpression, connection);
               // int number = command.ExecuteNonQuery();
               // if (number > 0) Label2.Text = $"Материал {DelName.Text} успешно удалён из матотчёта";
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                if (reader.HasRows) Label2.Text = reader.GetValue(0);

            }
        }
        } 
}
