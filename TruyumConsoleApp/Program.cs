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
            Console.WriteLine("Function 1: AddToCart  Function 2: ViewCartList   Function 3: RemoveFromCart   " +
                "Function 4: ViewMenuListByAdmin    Function 5: ViewMenuListByUser    Function 6: GetItemFromMenuList  " +
                "Function 7: AddToMenu     Function 8: Updatemenu     Function 9: RemoveFromMenu");
            Console.WriteLine("Enter function id:");
            int function = int.Parse(Console.ReadLine());

            // passing string "subject" in 
            // switch statement
            switch (function)
            {

                case 1:
                   
                    // add cart items for user
                    CartDaoSqlBL cartDaoSqlBL = new CartDaoSqlBL();

                    Console.WriteLine("Enter userid:");
                    int userid = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter menuid:");
                    int menuid = int.Parse(Console.ReadLine());

                    cartDaoSqlBL.TestAddCartItem(userid, menuid);
                    Console.WriteLine("items added to cart succesfully..!:");

                    break;

                case 2:
                    CartDaoSqlBL cartDaoSqlBL2 = new CartDaoSqlBL();

                    Console.WriteLine("Enter userid to view cart items:");
                    int useri = int.Parse(Console.ReadLine());

                    cartDaoSqlBL2.TestGetCartItems(useri);
                    Console.WriteLine("cart items printed succesfully..!:");
                    break;

                case 3:
                    CartDaoSqlBL cartDaoSqlBL3 = new CartDaoSqlBL();
                    Console.WriteLine("Enter userid to remove items from cart:");
                    int user = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter menuid to remove items from cart:");
                    int menuidd = int.Parse(Console.ReadLine());

                    cartDaoSqlBL3.TestRemoveCartItem(user, menuidd);

                    Console.WriteLine("items removed from cart succesfully..!:");
                    break;

                case 4:
                    MenuItemDaoSqlBL menuItemDaoSqlBL = new MenuItemDaoSqlBL();
                    Console.WriteLine("Get MENU items ADMIN");
                    menuItemDaoSqlBL.TestGetMenuItemListAdmin();
                    Console.WriteLine("items of menu displayed succesfully..!:");
                    break;

                case 5:
                    MenuItemDaoSqlBL menuItemDaoSqlBL1 = new MenuItemDaoSqlBL();
                    Console.WriteLine("Get MENU items CUstomer");
                    menuItemDaoSqlBL1.TestGetMenuItemListCustomer();
                    Console.WriteLine("items of menu displayed succesfully..!:");
                    break;

                case 6:
                    MenuItemDaoSqlBL menuItemDaoSqlBL2 = new MenuItemDaoSqlBL();
                    Console.WriteLine("Get menu item ");
                    Console.WriteLine("Enter MenuId:");
                    int MId = int.Parse(Console.ReadLine());
                    menuItemDaoSqlBL2.TestGetMenuItem(MId);
                    Console.WriteLine("Particular Item is displayed succesfully..!:");
                    break;

                case 7:
                    MenuItemDaoSqlBL menuItemDaoSqlBL3 = new MenuItemDaoSqlBL();
                    Console.WriteLine("Add menu items");
                    Console.WriteLine("Enter MenuId:");
                    int iid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name:");
                    string iname = Console.ReadLine();
                    Console.WriteLine("Enter Price:");
                    int iprice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter AvailablityStatus:");
                    int ias = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter dateofLaunch:");
                    DateTime idol = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Category:");
                    string icategory = Console.ReadLine();
                    Console.WriteLine("Enter DeliveryStatus:");
                    int ids = int.Parse(Console.ReadLine());
                    menuItemDaoSqlBL3.TestAddMenuItem(iid,iname,iprice,ias,idol,icategory,ids);
                    Console.WriteLine("item added to menu succesfully..!:");
                    break;

                case 8:
                    MenuItemDaoSqlBL menuItemDaoSqlBL4 = new MenuItemDaoSqlBL();
                    Console.WriteLine("Edit menu items");
                    Console.WriteLine("Enter MenuId:");
                    int iid2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name:");
                    string iname2 = Console.ReadLine();
                    Console.WriteLine("Enter Price:");
                    int iprice2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter AvailablityStatus:");
                    int ias2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter dateofLaunch:");
                    DateTime idol2 = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Category:");
                    string icategory2 = Console.ReadLine();
                    Console.WriteLine("Enter DeliveryStatus:");
                    int ids2 = int.Parse(Console.ReadLine());
                    menuItemDaoSqlBL4.TestEditMenuItem(iid2, iname2, iprice2, ias2, idol2, icategory2, ids2);
                    Console.WriteLine("Changes updated succesfully..!:");
                    break;

                case 9:
                    MenuItemDaoSqlBL menuItemDaoSqlBL5 = new MenuItemDaoSqlBL();
                    Console.WriteLine("Remove menu item:");
                    Console.WriteLine("Enter menuId:");
                    int mid = int.Parse(Console.ReadLine());
                    menuItemDaoSqlBL5.TestRemoveMenuItem(mid);
                    Console.WriteLine("item Removed from menu succesfully..!:");
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }



            /*



                        //menu function
                        MenuItemDaoSqlBL menuItemDaoSqlBL = new MenuItemDaoSqlBL();
                        Console.WriteLine("Get MENU items ADMIN");
                        menuItemDaoSqlBL.TestGetMenuItemListAdmin(); //done
                        Console.WriteLine("Get MENU items CUstomer");
                        menuItemDaoSqlBL.TestGetMenuItemListCustomer();//done
                        Console.WriteLine("Get menu item ");
                        menuItemDaoSqlBL.TestGetMenuItem();//done
                        Console.WriteLine("Add menu items");
                        menuItemDaoSqlBL.TestAddMenuItem();//done
                        Console.WriteLine("Edit menu items");
                        menuItemDaoSqlBL.TestEditMenuItem();
                        Console.WriteLine("Remove menu item.");
                        menuItemDaoSqlBL.TestRemoveMenuItem();


                        // add cart items for user
                       CartDaoSqlBL cartDaoSqlBL = new CartDaoSqlBL();

                       Console.WriteLine("Enter userid:");
                       int userid = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter menuid:");
                        int menuid = int.Parse(Console.ReadLine());

                        cartDaoSqlBL.TestAddCartItem(userid,menuid);
                        Console.WriteLine("items added to cart succesfully..!:");

                        //get cart irems of user
                        Console.WriteLine("Enter userid to view cart items:");
                        int useri = int.Parse(Console.ReadLine());

                        cartDaoSqlBL.TestGetCartItems(useri);
                        Console.WriteLine("cart items printed succesfully..!:");


                        //items remove from cart
                        Console.WriteLine("Enter userid to remove items from cart:");
                        int user = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter menuid to remove items from cart:");
                        int menuidd = int.Parse(Console.ReadLine());

                        cartDaoSqlBL.TestRemoveCartItem(user, menuidd);

                        Console.WriteLine("items removed from cart succesfully..!:");




                        */
            Console.ReadKey();
          
        }
    }
}
