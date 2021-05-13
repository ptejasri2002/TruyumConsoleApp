using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruyumModel;

namespace TruyumDAL
{
    interface IMenuItemDao
    {
        List<MenuItem> GetMenuItemListAdmin();
        List<MenuItem> GetMenuItemListCustomer();
        void ModifyMenuItem(MenuItem menuItem);
        MenuItem GetMenuItem(long menuItemId);
        //void TestModifyMenuItem();
    }
}
