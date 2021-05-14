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

        public void TestGetMenuItem(int MId)
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            Console.WriteLine(menuItemDaoSql.GetMenuItem(MId));
        }

        public void TestEditMenuItem(int iid2, string iname2, int iprice2,int ias2, DateTime idol2, string icategory2, int ids2)
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            MenuItem menu = new MenuItem();
            menu.Id = iid2;
            menu.Name = iname2;
            menu.Price = iprice2;
            menu.DateOfLaunch = idol2;
            menu.Active = ias2 == 1 ? true : false;
            menu.FreeDelivery = ids2 == 1 ? true : false;
            menu.Category = icategory2;
            menuItemDaoSql.EditMenuItem(menu);
          //  TestGetMenuItem();
        }

        public void TestAddMenuItem(int iid,string iname,int iprice,int ias,DateTime idol,string icategory,int ids)
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            MenuItem   menu = new MenuItem();
            menu.Id = iid;
            menu.Name = iname;
            menu.Price = iprice;
            menu.DateOfLaunch = idol;
            menu.Active=ias==1 ?  true: false  ;
            menu.FreeDelivery = ids == 1 ? true : false;
            menu.Category = icategory;
            menuItemDaoSql.AddMenuItem(menu);
            //TestGetMenuItem();
        }

        public void TestRemoveMenuItem(int mid)
        {
            MenuItemDaoSql menuItemDaoSql = new MenuItemDaoSql();
            menuItemDaoSql.RemoveMenuItem(mid);
           // TestGetMenuItem();
        }

    }
}
