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
        private int width = 150;
        private int fontSize = 24;

        private string title;

        public string Color 
        {
            get => color; 
            set => color = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int FontSize
        {
            get => fontSize;
            set => fontSize = value;
        }

        public string Title { get => title; set => title = value; }
    }
}
