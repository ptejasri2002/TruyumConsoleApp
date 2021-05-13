using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruyumDAL;
using TruyumModel;


namespace TruyumBL
{
    public class MenuItemDaoCollectionBL
    {
        public void TestGetMenuItemListAdmin()
        {
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            foreach (var item in menuItemDao.GetMenuItemListAdmin())
            {
                Console.WriteLine(item);
            }
        }
        public void TestGetMenuItemListCustomer()
        {
            MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();
            foreach (var item in menuItemDao.GetMenuItemListCustomer())
            {
                Console.WriteLine(item);
            }
        }
        public void TestModifyMenuItem()
        {
            MenuItem menuItem;
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            menuItem = menuItemDaoCollection.MenuItemList[1];
            menuItemDaoCollection.ModifyMenuItem(menuItem);
            menuItemDaoCollection.GetMenuItem(menuItem.Id);
        }
        public void TestGetMenuItem() { }

    }
}
