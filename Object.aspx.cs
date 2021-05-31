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
    public partial class Object : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            // if (Context.User.Identity.IsAuthenticated == false)
            //  {
            //      Response.Redirect("~/Account/login"); //Если пользователь не выполнил в
            //  }

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            //await sqlConnection.OpenAsync();


            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            LabelText1.Visible = false;
            LabelText2.Visible = false;
            LabelText3.Visible = false;
            LabelText4.Visible = false;
            LabelText5.Visible = false;
            LabelText6.Visible = false;
            ButtonAdd.Visible = false;
           // Label3.Text = "проверка таблицы";
         //   Label4.Text = "таблица";

            Label01.Text = ""; Label02.Text = ""; Label03.Text = ""; Label04.Text = ""; Label05.Text = ""; Label06.Text = ""; Label07.Text = "";
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

        protected void AddWorkers_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            LabelText1.Visible = true;
            LabelText2.Visible = true;
            LabelText3.Visible = true;
            LabelText4.Visible = true;
            LabelText5.Visible = true;
            ButtonAdd.Visible = true;
            LabelText1.Text = "Прораб";
            LabelText2.Text = "Кол-во рабочих";
            LabelText3.Text = "Разряд";
            LabelText4.Text = "Телефон";
            LabelText5.Text = "Отпуск";
        }

        protected void AddObject_Click(object sender, EventArgs e)
        {
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
            LabelText1.Text = "Объект";
            LabelText2.Text = "Заказчик";
            LabelText3.Text = "Прораб";
            LabelText4.Text = "Начало работ";
            LabelText5.Text = "Адрес";
            LabelText6.Text = "Статус";
        }

        protected async void DelWorkers0_Click(object sender, EventArgs e) // Список прорабов
        {

            await sqlConnection.OpenAsync();

            SqlCommand matList = new SqlCommand("SELECT * FROM [Workers]", sqlConnection);
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
                    Label01.Text = "Прораб";
                    Label02.Text = "Кол-во рабочих";
                    Label03.Text = "Разряд";
                    Label04.Text = "Телефон";
                    Label05.Text = "Отпуск";

                    switch (iCount)
                    {
                        case 1:
                            {
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + " ";
                                Label13.Text = " "+ reader.GetValue(1) + " ";
                                Label23.Text = " "+ reader.GetValue(2) + " ";
                                Label33.Text = " "+ reader.GetValue(3) + " ";
                                Label43.Text = " "+ reader.GetValue(4) + " ";
                            }
                            break;
                        case 2:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label14.Text = reader.GetValue(1) + "";
                                Label24.Text = reader.GetValue(2) + "";
                                Label34.Text = reader.GetValue(3) + "";
                                Label44.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 3:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label15.Text = reader.GetValue(1) + "";
                                Label25.Text = reader.GetValue(2) + "";
                                Label35.Text = reader.GetValue(3) + "";
                                Label45.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 4:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label16.Text = reader.GetValue(1) + "";
                                Label26.Text = reader.GetValue(2) + "";
                                Label36.Text = reader.GetValue(3) + "";
                                Label46.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 5:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label17.Text = reader.GetValue(1) + "";
                                Label27.Text = reader.GetValue(2) + "";
                                Label37.Text = reader.GetValue(3) + "";
                                Label47.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 6:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label18.Text = reader.GetValue(1) + "";
                                Label28.Text = reader.GetValue(2) + "";
                                Label38.Text = reader.GetValue(3) + "";
                                Label48.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 7:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label19.Text = reader.GetValue(1) + "";
                                Label29.Text = reader.GetValue(2) + "";
                                Label39.Text = reader.GetValue(3) + "";
                                Label49.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 8:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label20.Text = reader.GetValue(1) + "";
                                Label30.Text = reader.GetValue(2) + "";
                                Label40.Text = reader.GetValue(3) + "";
                                Label50.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 9:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label21.Text = reader.GetValue(1) + "";
                                Label31.Text = reader.GetValue(2) + "";
                                Label41.Text = reader.GetValue(3) + "";
                                Label51.Text = reader.GetValue(4) + "";
                            }
                            break;
                        case 10:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label22.Text = reader.GetValue(1) + "";
                                Label32.Text = reader.GetValue(2) + "";
                                Label42.Text = reader.GetValue(3) + "";
                                Label52.Text = reader.GetValue(4) + "";
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

        protected async void ListObject_Click(object sender, EventArgs e)
        {
            await sqlConnection.OpenAsync();

            SqlCommand matList = new SqlCommand("SELECT * FROM [Object]", sqlConnection);
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
                    Label01.Text = "ID Объекта";
                    Label02.Text = "Объект";
                    Label03.Text = "Заказчик";
                    Label04.Text = "Прораб";
                    Label05.Text = "Начало работ";
                    Label06.Text = "Адрес";
                    Label07.Text = "Статус";

                    switch (iCount)
                    {
                        case 1:
                            {
                                Label3.Text = $"{iCount}) " + reader.GetValue(0) + " ";
                                Label13.Text = " " + reader.GetValue(1) + " ";
                                Label23.Text = " " + reader.GetValue(2) + " ";
                                Label33.Text = " " + reader.GetValue(3) + " ";
                                Label43.Text = " " + reader.GetValue(4) + " ";
                                Label53.Text = " " + reader.GetValue(5) + " ";
                                Label63.Text = " " + reader.GetValue(6) + " ";
                            }
                            break;
                        case 2:
                            {
                                Label4.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label14.Text = reader.GetValue(1) + "";
                                Label24.Text = reader.GetValue(2) + "";
                                Label34.Text = reader.GetValue(3) + "";
                                Label44.Text = reader.GetValue(4) + "";
                                Label54.Text = " " + reader.GetValue(5) + " ";
                                Label64.Text = " " + reader.GetValue(6) + " ";
                            }
                            break;
                        case 3:
                            {
                                Label5.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label15.Text = reader.GetValue(1) + "";
                                Label25.Text = reader.GetValue(2) + "";
                                Label35.Text = reader.GetValue(3) + "";
                                Label45.Text = reader.GetValue(4) + "";
                                Label55.Text = reader.GetValue(5) + "";
                                Label65.Text = reader.GetValue(6) + "";
                            }
                            break;
                        case 4:
                            {
                                Label6.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label16.Text = reader.GetValue(1) + "";
                                Label26.Text = reader.GetValue(2) + "";
                                Label36.Text = reader.GetValue(3) + "";
                                Label46.Text = reader.GetValue(4) + "";
                                Label56.Text = reader.GetValue(5) + "";
                                Label66.Text = reader.GetValue(6) + "";
                            }
                            break;
                        case 5:
                            {
                                Label7.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label17.Text = reader.GetValue(1) + "";
                                Label27.Text = reader.GetValue(2) + "";
                                Label37.Text = reader.GetValue(3) + "";
                                Label47.Text = reader.GetValue(4) + "";
                                Label57.Text = reader.GetValue(5) + "";
                                Label67.Text = reader.GetValue(6) + "";
                            }
                            break;
                        case 6:
                            {
                                Label8.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label18.Text = reader.GetValue(1) + "";
                                Label28.Text = reader.GetValue(2) + "";
                                Label38.Text = reader.GetValue(3) + "";
                                Label48.Text = reader.GetValue(4) + "";
                                Label58.Text = reader.GetValue(5) + "";
                                Label68.Text = reader.GetValue(6) + "";
                            }
                            break;
                        case 7:
                            {
                                Label9.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label19.Text = reader.GetValue(1) + "";
                                Label29.Text = reader.GetValue(2) + "";
                                Label39.Text = reader.GetValue(3) + "";
                                Label49.Text = reader.GetValue(4) + "";
                                Label59.Text = reader.GetValue(5) + "";
                                Label69.Text = reader.GetValue(6) + "";
                            }
                            break;
                        case 8:
                            {
                                Label10.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label20.Text = reader.GetValue(1) + "";
                                Label30.Text = reader.GetValue(2) + "";
                                Label40.Text = reader.GetValue(3) + "";
                                Label50.Text = reader.GetValue(4) + "";
                                Label60.Text = reader.GetValue(5) + "";
                                Label70.Text = reader.GetValue(6) + "";
                            }
                            break;
                        case 9:
                            {
                                Label11.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label21.Text = reader.GetValue(1) + "";
                                Label31.Text = reader.GetValue(2) + "";
                                Label41.Text = reader.GetValue(3) + "";
                                Label51.Text = reader.GetValue(4) + "";
                                Label61.Text = reader.GetValue(5) + "";
                                Label71.Text = reader.GetValue(6) + "";
                            }
                            break;
                        case 10:
                            {
                                Label12.Text = $"{iCount}) " + reader.GetValue(0) + "";
                                Label22.Text = reader.GetValue(1) + "";
                                Label32.Text = reader.GetValue(2) + "";
                                Label42.Text = reader.GetValue(3) + "";
                                Label52.Text = reader.GetValue(4) + "";
                                Label62.Text = reader.GetValue(5) + "";
                                Label72.Text = reader.GetValue(6) + "";
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
    }
}