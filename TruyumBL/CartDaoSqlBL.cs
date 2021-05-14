using TruyumDAL;
using TruyumModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyumBL
{
    public class CartDaoSqlBL
    {
        public void TestAddCartItem()
        {
            CartDaoSql cartDaoSql = new CartDaoSql();
            cartDaoSql.AddCartItem(1, 1);
        }
        public void TestAddCartItem(int userid,int menuid)
        {
            CartDaoSql cartDaoSql = new CartDaoSql();
            cartDaoSql.AddCartItem(userid, menuid);
        }
        public void TestGetCartItems()
        {
            CartDaoSql cartDaoSql = new CartDaoSql();
            foreach (var item in cartDaoSql.GetCartItems(2))
            {
                Console.WriteLine(item);
            }            

        }

        public void TestGetCartItems(int userid)
        {
            CartDaoSql cartDaoSql = new CartDaoSql();
            foreach (var item in cartDaoSql.GetCartItems(userid))
            {
                Console.WriteLine(item);
            }

        }

        public void TestRemoveCartItem()
        {
            CartDaoSql cartDaoSql = new CartDaoSql();
            cartDaoSql.RemoveCartItem(1, 1);
        }
        public void TestRemoveCartItem(int userid, int menuid )
        {
            CartDaoSql cartDaoSql = new CartDaoSql();
            cartDaoSql.RemoveCartItem(userid , menuid );
        }
    }
}
