using CarParKing.ModelView;
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

namespace CarParKing
{
    /// <summary>
    /// Interaktionslogik für newParking.xaml
    /// </summary>
    public partial class newParking : Page
    {
        private CarParkViewModel tmp = (CarParkViewModel)App.Current.Resources["carParkViewModel"];

        public newParking()
        {
            InitializeComponent();
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ParkingList());
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (tmp.toEdit)
            {
                int result = tmp.editParkingPlace();
                if(result == 0)
                {
                    MessageBox.Show("saved");
                    this.NavigationService.Navigate(new ParkingList());
                }
                else
                {
                    MessageBox.Show("saving failed");
                }
            }
            else
            {
                int result = tmp.createParkingPlace();
                if (result == 0)
                {
                    MessageBox.Show("saved");
                    this.NavigationService.Navigate(new ParkingList());
                }
                else
                {
                    MessageBox.Show("saving failed");
                }
            }
        }
    }
}
