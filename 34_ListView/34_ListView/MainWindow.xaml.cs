using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace _34_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            string conncetionString = ConfigurationManager.ConnectionStrings["_34_ListView.Properties.Settings.TestingDatabaseConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(conncetionString);
            ShowPatients();
        }

        private void ShowPatients()
        {
            try
            {
                string query = "select * from Patient";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

                using (adapter)
                {
                    DataTable patientTable = new DataTable();

                    adapter.Fill(patientTable);

                    /*patients.DisplayMemberPath = "Name";
                    patients.SelectedValuePath = "Id";*/
                    patients.ItemsSource = patientTable.DefaultView;
                }
            }
            catch (Exception e)
            {

            }
        }

    }
}
