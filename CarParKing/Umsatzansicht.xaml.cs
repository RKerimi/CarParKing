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
    /// Interaktionslogik für Umsatzansicht.xaml
    /// </summary>
    public partial class Umsatzansicht : Page
    {
        public Umsatzansicht()
        {
            InitializeComponent();
        }

        private void ticketClick(object sender, RoutedEventArgs e)
        {
            salesPage.Content = new TicketUbersicht();
        }

        private void umsatzClick(object sender, RoutedEventArgs e)
        {
            salesPage.Content = new Umsatzansicht();
        }

    }
}
