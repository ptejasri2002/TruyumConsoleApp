using TruyumDAL;
using TruyumModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyumBL
{
    public class MenuItemDaoSqlBL
    {
        public void TestGetMenuItemListAdmin()
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            List<MenuItem> menuItems = menuItemDaoSql.GetMenuItemListAdmin();
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }
        }

        public void TestGetMenuItemListCustomer()
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            List<MenuItem> menuItems = menuItemDaoSql.GetMenuItemListCustomer();
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }
        }

        public void TestGetMenuItem()
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            Console.WriteLine(menuItemDaoSql.GetMenuItem(1));
        }

        public void TestEditMenuItem()
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            menuItemDaoSql.EditMenuItem(new MenuItem(1, "Basil Tomato & Mozzarella Cheese Sandwich",
                235, true, DateTime.Today, "Main Course", true));
            TestGetMenuItem();
        }

        public void TestAddMenuItem()
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            menuItemDaoSql.AddMenuItem(new MenuItem(7, "Biriyani",
                200, true, DateTime.Now, "Starters", true));
            TestGetMenuItem();
        }

        public void TestRemoveMenuItem()
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            menuItemDaoSql.RemoveMenuItem(2);
            TestGetMenuItem();
        }

    }
}
