using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DataBinding.Entity
{
    class MyData
    {
        private string color = "Red";

        public string Color 
        {
            get  => color; 
            set => color = value;
        }
    }
}
