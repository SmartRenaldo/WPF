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

namespace _14_ComboBox
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //1. use items
            /*this.comboBox1.Items.Add("c");
            this.comboBox1.Items.Add("i");
            this.comboBox1.Items.Add("m");
            this.comboBox1.Items.Add("s");*/

            //2. use DataContext
            List<NewsInfo> list = new List<NewsInfo>();
            list.Add(new NewsInfo() { Name = "BBC", Description = "BBC NEWS" });
            list.Add(new NewsInfo() { Name = "CNN", Description = "CNN NEWS" });
            list.Add(new NewsInfo() { Name = "FBI", Description = "FBI NEWS" });

            this.comboBox1.DataContext = list;
            this.comboBox1.DisplayMemberPath = "Name";
            this.comboBox1.SelectedValuePath = "Description";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<NewsInfo> lists = this.comboBox1.ItemsSource as List<NewsInfo>;
            lists.RemoveAt(0);
            this.comboBox1.ItemsSource = lists;
        }
    }
}
