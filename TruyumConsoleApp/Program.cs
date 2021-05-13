using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruyumBL;

namespace TruyumConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // MenuItemDaoCollectionBL menuItemDaoCollectionTest = new MenuItemDaoCollectionBL();
            MenuItemDaoSqlBL menuItemDaoSqlBL = new MenuItemDaoSqlBL();
            menuItemDaoSqlBL.TestGetMenuItemListAdmin(); //done
            menuItemDaoSqlBL.TestGetMenuItemListCustomer();//done
            menuItemDaoSqlBL.TestGetMenuItem();//done
            menuItemDaoSqlBL.TestAddMenuItem();//done
            menuItemDaoSqlBL.TestEditMenuItem();


            Console.WriteLine("1 object done.");
            Console.ReadKey();
           // CartDaoCollectionBL cartDaoCollectionTest = new CartDaoCollectionBL();
            CartDaoSqlBL cartDaoSqlBL = new CartDaoSqlBL();
            cartDaoSqlBL.TestAddCartItem();
           // cartDaoSqlBL.TestGetMenuItems();
           // cartDaoSqlBL.TestRemoveCartItem();

            //Console.WriteLine("2 objects done.");

          
            //CartDaoSqlBL cartDaoSqlTest = new CartDaoSqlBL();
            //cartDaoSqlTest.TestAddMenuItem();
            //cartDaoSqlTest.TestGetMenuItems();
            //cartDaoSqlTest.TestRemoveMenuItem();

            //Console.WriteLine("4 objects done.");
        }
    }
}
