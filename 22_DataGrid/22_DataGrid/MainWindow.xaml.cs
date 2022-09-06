using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _22_DataGrid
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
            List<UserInfo> list = new List<UserInfo>();
            list.Add(new UserInfo() { Id = 0, Age = 26, Name = "Shanne", DeptId = 0 });
            list.Add(new UserInfo() { Id = 1, Age = 22, Name = "Gourge", DeptId = 0 });
            list.Add(new UserInfo() { Id = 2, Age = 28, Name = "Snake", DeptId = 1 });
            list.Add(new UserInfo() { Id = 3, Age = 39, Name = "Albert", DeptId = 1 });

            List<DepartmentInfo> departmentList = new List<DepartmentInfo>();
            departmentList.Add(new DepartmentInfo() { Id = 0, Name = "Technique Apartment" });
            departmentList.Add(new DepartmentInfo() { Id = 1, Name = "Marketing Apartment" });

            this.depts.ItemsSource = departmentList;
            this.depts.DisplayMemberPath = "Name";
            this.depts.SelectedValuePath = "Id";

            //this.awesomeGrid.DataContext = list;
            this.awesomeGrid.ItemsSource = list;

            ICollectionView task = CollectionViewSource.GetDefaultView(awesomeGrid.ItemsSource);

            if (task != null && task.CanSort == true)
            {
                task.SortDescriptions.Clear();
                task.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            }
        }
    }
}
