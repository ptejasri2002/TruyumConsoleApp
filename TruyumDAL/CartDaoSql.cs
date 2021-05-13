using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TruyumModel;

namespace TruyumDAL
{
    public class CartDaoSql
    {
        public void AddCartItem(int userId, int menuItemId)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_AddCartItem", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@userId", userId);
                sqlCommand.Parameters.AddWithValue("@menuId", menuItemId);
                sqlCommand.ExecuteNonQuery();
            }            
        }

        public List<MenuItem> GetCartItems(int userId)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            List<MenuItem> cartItems = new List<MenuItem>();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_ViewCartList", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@userId", userId);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MenuItem item = new MenuItem();
                        item.Id = reader.GetInt32(0);
                        item.Name = reader.GetString(1);
                        item.Price = Convert.ToInt32(reader[2]);
                        item.Active = (Convert.ToInt32(reader[3]) == 1 ? true : false);
                        item.DateOfLaunch = reader.GetDateTime(4);
                        item.Category = reader.GetString(5);
                        item.FreeDelivery = (Convert.ToInt32(reader[6]) == 1 ? true : false);
                        cartItems.Add(item);
                    }
                }
            }

            return cartItems;
        }

        public void RemoveCartItem(int userId, int menuItemId)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_RemoveCartItem", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@userId", userId);
                sqlCommand.Parameters.AddWithValue("@menuId", menuItemId);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
