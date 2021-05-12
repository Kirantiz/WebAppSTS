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
            if (Context.User.Identity.IsAuthenticated == false)
            {
                Response.Redirect("~/Account/login"); //Если пользователь не выполнил в
            }

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
            Label3.Text=reader.GetName(0)+ "\t"; Label3.Text+= reader.GetName(1)+"\t";
                Label3.Text+= reader.GetName(2);


          /*  while (await reader.ReadAsync())
            {
                object id = reader.GetValue(0);
                object name = reader.GetValue(1);
                object age = reader.GetValue(2);
                Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
            }*/
        }
        reader.Close();
        }
    }
}