using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_TreeView
{
    public class MenuGenerator
    {
        public static List<MyMenu> CreateMenus()
        {
            List<MyMenu> menuList = new List<MyMenu>();

            MyMenu m1 = new MyMenu("Beef", null);
            MyMenu m2 = new MyMenu("Pork", null);
            MyMenu m3 = new MyMenu("Lamb", null);

            MyMenu m3_1 = new MyMenu("BBQ", m3);
            MyMenu m3_2 = new MyMenu("Roast", m3);

            menuList.Add(m1);
            menuList.Add(m2);
            menuList.Add(m3);

            return menuList;
        }
    }
}
