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
            //menu function
            //MenuItemDaoSqlBL menuItemDaoSqlBL = new MenuItemDaoSqlBL();
            //Console.WriteLine("Get MENU items ADMIN");
            //menuItemDaoSqlBL.TestGetMenuItemListAdmin(); //done
            //Console.WriteLine("Get MENU items CUstomer");
            //menuItemDaoSqlBL.TestGetMenuItemListCustomer();//done
            //Console.WriteLine("Get menu item ");
            //menuItemDaoSqlBL.TestGetMenuItem();//done
            //Console.WriteLine("Add menu items");
            //menuItemDaoSqlBL.TestAddMenuItem();//done
            //Console.WriteLine("Edit menu items");
            //menuItemDaoSqlBL.TestEditMenuItem();
            //Console.WriteLine("Remove menu item.");
            //menuItemDaoSqlBL.TestRemoveMenuItem();

            
           //cart function
            CartDaoSqlBL cartDaoSqlBL = new CartDaoSqlBL();
           // cartDaoSqlBL.TestAddCartItem();

           
           Console.WriteLine("Enter userid:");
           int userid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter menuid:");
            int menuid = int.Parse(Console.ReadLine());

            cartDaoSqlBL.TestAddCartItem(userid,menuid);

            //cartDaoSqlBL.TestGetCartItems();
            //cartDaoSqlBL.TestRemoveCartItem();

            Console.ReadKey();
          
        }
    }
}
