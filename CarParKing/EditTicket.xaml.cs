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
    /// Interaction logic for EditTicket.xaml
    /// </summary>
    public partial class EditTicket : Page
    {
        public EditTicket()
        {
            InitializeComponent();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TicketList());
        }

        public int TicketId { get; set; }

        public String EntryTime { get; set; }

        public String ExitTime { get; set; }

        public double TicketPrice { get; set; }


    }
}