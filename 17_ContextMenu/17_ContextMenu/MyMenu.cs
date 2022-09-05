using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ContextMenu
{
    public class MyMenu
    {
        public string Name { get; set; }
        public List<MyMenu> SubMenu { get; set; }

        public MyMenu (string name, MyMenu parentMenu)
        {
            Name = name;
            
            if (parentMenu != null)
            {
                List<MyMenu> list = parentMenu.SubMenu ?? new List<MyMenu>();
                list.Add (this);
                parentMenu.SubMenu = list;
            }
        }
    }
}
