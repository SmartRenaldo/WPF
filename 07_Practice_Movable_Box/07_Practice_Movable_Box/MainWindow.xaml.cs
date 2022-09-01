using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _07_Practice_Movable_Box
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            UIElementCollection children = gridEle.Children;
            Border border = null;

            for (int i = 0; i < children.Count; i++)
            {
                if (children[i] is Border)
                {
                    if (((children[i] as Border).Background as SolidColorBrush).Color.Equals(Colors.White))
                    {
                        border = children[i] as Border;
                    }

                    (children[i] as Border).Background = new SolidColorBrush(Colors.Transparent);
                }
            }

            string name = border.Name;
            int index = Convert.ToInt32(name.Replace("b", ""));

            switch (e.Key)
            {
                case Key.Up:
                    index = index - 3 > 0 ? index - 3 : index;
                    break;
                case Key.Left:
                    index = index - 1 > 0 ? index - 1 : index;
                    break;
                case Key.Down:
                    index = index + 3 < 10 ? index + 3 : index;
                    break;
                case Key.Right:
                    index = index + 1 < 10 ? index + 1 : index;
                    break;
                default:
                    break;
            }

            object control =  gridEle.FindName("b" + index);

            if (control != null)
            {
                (control as Border).Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}
