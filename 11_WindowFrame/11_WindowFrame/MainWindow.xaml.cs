using _11_WindowFrame.Pages;
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

namespace _11_WindowFrame
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
            //this.myFrame.Source = new Uri("https://www.google.com", UriKind.Absolute);

            //MyPage myPage = new MyPage();
            //this.myFrame.Navigate(myPage);

            MyPage myPage = new MyPage("Param");
            this.myFrame.Navigate(myPage, "Param");
        }

        private void myFrame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            object data = e.ExtraData;
            Console.WriteLine(data);
        }
    }
}
