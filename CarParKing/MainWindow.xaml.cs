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
using System.Data.SqlClient;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;

namespace CarParKing
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ticketview_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new TicketList());
        }

        private void ParkingView_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new ParkingList());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }



        /*private void OnClick(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
                "Data Source=DESKTOP-29EL2G5;" +
                "Initial Catalog=CarParKingDB;" +
                "Integrated Security=SSPI;";
            conn.Open();
            Console.WriteLine(conn.State);
            using (SqlCommand command = new SqlCommand("SELECT * FROM parkplatzdetails", conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine(reader.GetValue(i));
                        }
                        Console.WriteLine();
                    }
                }
            }
        }*/

        /* private void ticketClick(object sender, RoutedEventArgs e)
         {
             Main.Content = new TicketUbersicht();
         }

         private void umsatzClick(object sender, RoutedEventArgs e)
         {
             Main.Content = new Umsatzansicht();
         }

         private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {

         }*/
    }
}
