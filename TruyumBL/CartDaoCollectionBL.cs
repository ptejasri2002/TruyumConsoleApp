using TruyumDAL;
using TruyumBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruyumModel;

namespace TruyumBL
{
    public class CartDaoCollectionBL
    {
        public void AddCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            cartDao.AddCartItem(1, 1);
            List<MenuItem> menuItems = cartDao.GetAllCartItems(1).MenuItemList;
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }

        }

        public void GetAllCartItems() { }
        public void RemoveCartItem()
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            cartDao.RemoveCartItem(1, 1);
            try
            {
                cartDao.GetAllCartItems(1);
            }
            catch (CartEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
