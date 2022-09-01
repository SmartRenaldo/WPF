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

namespace _05_Check
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UIElementCollection children = mainGrid.Children;
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < children.Count; i++)
            {
                if (children[i] is CheckBox && (children[i] as CheckBox).IsChecked.Value)
                {
                    builder.Append((children[i] as CheckBox).Content + " ");
                }
            }

            MessageBox.Show(builder.ToString());
        }
    }
}
