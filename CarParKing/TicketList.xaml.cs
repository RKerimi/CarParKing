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
    /// Interaktionslogik für TicketUbersicht.xaml
    /// </summary>
    public partial class TicketList : Page
    {

        //https://docs.microsoft.com/en-us/windows/uwp/controls-and-patterns/resourcedictionary-and-xaml-resource-references
        private TicketList tmp = (TicketList)App.Current.Resources["ticketlist"];

        public TicketList()
        {
            InitializeComponent();
        }

        internal void getAllParkingPlacesFromWebservice()
        {
            throw new NotImplementedException();
        }


        /*private void GetAllTicket(object sender, RoutedEventArgs e)
        {
            tmp.getAllTicketsFromWebservice();
        }

        private void GetInactiveTicket(object sender, RoutedEventArgs e)
        {
            tmp.getInactiveTicketsFromWebservice();
        }

        private void GetActiveTicket(object sender, RoutedEventArgs e)
        {
            tmp.getActiveTicketsFromWebservice();
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            
                this.NavigationService.Navigate(new EditTicket());

        }



        /*private void PageLoaded(object sender, RoutedEventArgs e)
        {
            //clear list
            tmp.clearList();
        }*/
        /*private void ticketClick(object sender, RoutedEventArgs e)
        {
            ticketPage.Content = new TicketUbersicht();
        }

        private void umsatzClick(object sender, RoutedEventArgs e)
        {
            ticketPage.Content = new Umsatzansicht();
        }*/
    }
}
