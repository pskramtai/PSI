using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebService.Base_Classes;

namespace WebService.Data
{
    public class adonetImplementation
    {
        private string connectionString { get; set; }
        adonetImplementation(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetBars()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select BarID, BarName, BarLocation from dbo.Bar", con);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                return JsonConvert.SerializeObject(dataSet);
            }
        }

        public string GetDrinks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select DrinkID, DrinkName from dbo.Drink", con);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                return JsonConvert.SerializeObject(dataSet);
            }
        }

        public string GetSpecificPrices(Guid id, bool isBar)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "Select BarID, DrinkID, DrinkPrice from dbo.SpecificPrice where ";

                if(isBar)
                {
                    sqlQuery += "BarID = " + id.ToString(); 
                }
                else
                {
                    sqlQuery += "DrinkID = " + id.ToString();
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, con);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                return JsonConvert.SerializeObject(dataSet);
            }
        }

        public void InsertBar(Bar bar)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Insert Into dbo.Bar (BarID, BarName, BarLocation) Values (@BarID, @BarName, @BarLocation)";

                sqlCommand.Parameters.Add(new SqlParameter("@BarID", SqlDbType.VarChar).Value = bar.BarID);
                sqlCommand.Parameters.Add(new SqlParameter("@BarName", SqlDbType.VarChar).Value = bar.BarName);
                sqlCommand.Parameters.Add(new SqlParameter("@BarLocation", SqlDbType.VarChar).Value = bar.BarLocation);

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertDrink(Drink drink)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Insert Into dbo.Drink (DrinkID, DrinkName) Values (@DrinkID, @DrinkName)";

                sqlCommand.Parameters.Add(new SqlParameter("@DrinkID", SqlDbType.VarChar).Value = drink.DrinkID);
                sqlCommand.Parameters.Add(new SqlParameter("@DrinkName", SqlDbType.VarChar).Value = drink.DrinkName);

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertSpecificPrice(SpecificPrice specificPrice)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Insert Into dbo.SpecificPrice (BarID, DrinkID, DrinkPrice) Values (@BarID, @DrinkID, @DrinkPrice)";

                sqlCommand.Parameters.Add(new SqlParameter("@BarID", SqlDbType.VarChar).Value = specificPrice.BarID);
                sqlCommand.Parameters.Add(new SqlParameter("@DrinkID", SqlDbType.VarChar).Value = specificPrice.DrinkID);
                sqlCommand.Parameters.Add(new SqlParameter("@DrinkPrice", SqlDbType.Float).Value = specificPrice.DrinkPrice);

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeleteBar(Guid id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Delete From dbo.Bar Where BarID = @BarID";

                sqlCommand.Parameters.Add(new SqlParameter("@BarID", SqlDbType.VarChar).Value = id);
            }
        }

        public void DeleteDrink(Guid id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Delete From dbo.Drink Where DrinkID = @DrinkID";

                sqlCommand.Parameters.Add(new SqlParameter("@DrinkID", SqlDbType.VarChar).Value = id);
            }
        }

        public void DeleteSpecificPrice(Guid BarID, Guid DrinkID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Delete From dbo.SpecificPrice Where BarID = @BarID AND DrinkID = @DrinkID";

                sqlCommand.Parameters.Add(new SqlParameter("@BarID", SqlDbType.VarChar).Value = BarID);
                sqlCommand.Parameters.Add(new SqlParameter("@DrinkID", SqlDbType.VarChar).Value = DrinkID);
            }
        }

        public void UpdatePrice(Guid BarID, Guid DrinkID, float price)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "Update dbo.SpecificPrice Set DrinkPrice = @DrinkPrice Where BarID = @BarID AND DrinkID = @DrinkID";

                sqlCommand.Parameters.Add(new SqlParameter("@DrinkPrice", SqlDbType.Float).Value = price);
                sqlCommand.Parameters.Add(new SqlParameter("@BarID", SqlDbType.VarChar).Value = BarID);
                sqlCommand.Parameters.Add(new SqlParameter("@DrinkID", SqlDbType.VarChar).Value = DrinkID);
            }
        }
    }
}
