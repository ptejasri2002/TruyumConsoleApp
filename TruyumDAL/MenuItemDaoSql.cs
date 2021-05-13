using TruyumModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TruyumDAL
{
    public class MenuItemDaoSql
    {
        public List<MenuItem> GetMenuItemListAdmin()
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            List<MenuItem> menuItems = new List<MenuItem>();

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_GetMenuList", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
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
                        menuItems.Add(item);
                    }
                }

            }
            return menuItems;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            List<MenuItem> menuItems = new List<MenuItem>();

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_GetmenulistCustomer", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@today", DateTime.Today);
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
                        menuItems.Add(item);
                    }
                }

            }
            return menuItems;
        }

        public MenuItem GetMenuItem(long menuItemId)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            MenuItem item = new MenuItem();

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_GetMenulistItem", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@menuItemId", menuItemId);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        //MenuItem item = new MenuItem();
                        item.Id = reader.GetInt32(0);
                        item.Name = reader.GetString(1);
                        item.Price = Convert.ToInt32(reader[2]);
                        item.Active = (Convert.ToInt32(reader[3]) == 1 ? true : false);
                        item.DateOfLaunch = reader.GetDateTime(4);
                        item.Category = reader.GetString(5);
                        item.FreeDelivery = (Convert.ToInt32(reader[6]) == 1 ? true : false);
                        break;
                    }
                }

            }
            return item;
        }

        public void EditMenuItem(MenuItem menuItem)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_EditMenuListItem", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", menuItem.Name);
                sqlCommand.Parameters.AddWithValue("@price", menuItem.Price);
                sqlCommand.Parameters.AddWithValue("@active", (menuItem.Active == true) ? "1" : "0");
                sqlCommand.Parameters.AddWithValue("@date", menuItem.DateOfLaunch);
                sqlCommand.Parameters.AddWithValue("@category", menuItem.Category);
                sqlCommand.Parameters.AddWithValue("@delivery", (menuItem.FreeDelivery == true) ? "1" : "0");
                sqlCommand.Parameters.AddWithValue("@id", menuItem.Id);

                sqlCommand.ExecuteNonQuery();
            }

        }

        public void AddMenuItem(MenuItem menuItem)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_addMenuListItem", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", menuItem.Name);
                sqlCommand.Parameters.AddWithValue("@price", menuItem.Price);
                sqlCommand.Parameters.AddWithValue("@active", (menuItem.Active == true) ? "1" : "0");
                sqlCommand.Parameters.AddWithValue("@dateoflaunch", menuItem.DateOfLaunch);
                sqlCommand.Parameters.AddWithValue("@category", menuItem.Category);
                sqlCommand.Parameters.AddWithValue("@freedelivery", (menuItem.FreeDelivery == true) ? "1" : "0");
                sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32( menuItem.Id));

                sqlCommand.ExecuteNonQuery();
            }

        }

        public void RemoveMenuItem(int menuItem)
        {
            SqlConnection sqlConnection = ConnectionHandler.GetConnection();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("T_RemoveMenuListItem", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", menuItem);
              
                sqlCommand.ExecuteNonQuery();
            }

        }


    }
}
