using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruyumModel;

namespace TruyumDAL
{
    interface ICartDao
    {
        void AddCartItem(long userId, long menuItemId);
        Cart GetAllCartItems(long userId);
        void RemoveCartItem(long userId, long menuItemId);
    }
}
