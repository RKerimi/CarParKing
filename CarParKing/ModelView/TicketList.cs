using CarParKing.Model;
using CarParKing.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParKing.ModelView
{
    class TicketList : INotifyPropertyChanged
    {
        public ObservableCollection<ParkingPlaceData> ParkingPlace { get; set; }
        public ObservableCollection<TicketData> Tickets { get; set; }
        private ParkingPlaceData _SelectedParkingPlace = new ParkingPlaceData();
        private TicketData _SelectedTicket = new TicketData();
        private ParkingPlaceData _ParkingPlaceToEdit = new ParkingPlaceData();


        public TicketList()
        {
            ParkingPlace = new ObservableCollection<ParkingPlaceData>();
            Tickets = new ObservableCollection<TicketData>();
        }

        //get which ticket is selected
        public TicketData SelectedTicket
        {
            get
            {
                return _SelectedTicket;
            }
            set
            {
                OnPropertyChanged("SelectedTicket");
                if (_SelectedTicket != null)
                {
                    _SelectedTicket = value;
                    if (_SelectedTicket != null)
                    {
                        Console.WriteLine(_SelectedTicket.TicketId.ToString() + " " + _SelectedTicket.EntryTime + " " + _SelectedTicket.ExitTime);
                    }
                }
            }
        }

        //get which parking place is selected
        public ParkingPlaceData SelectedParkingPlace
        {
            get
            {
                return _SelectedParkingPlace;
            }
            set
            {
                OnPropertyChanged("SelectedParkingSpace");
                if (_SelectedParkingPlace != null)
                {
                    _SelectedParkingPlace = value;
                    if (_SelectedParkingPlace != null)
                    {
                        Console.WriteLine(_SelectedParkingPlace.id.ToString());
                    }
                }
            }
        }


        //get all parking places from webservice
        public void getAllParkingPlacesFromWebservice()
        {
            //clear list
            ParkingPlace.Clear();

            Webservice Service = new Webservice();
            Service.getAllParkingPlaces();
            for (int i = 0; i < Service.ParkingPlaceList.Count; i++)
            {
                ParkingPlace.Add(Service.ParkingPlaceList.ElementAt(i));
            }
        }

        //get all tickets from webservice
        //depending which parking place is coosen
        public void getAllTicketsFromWebservice()
        {
            //clear list
            Tickets.Clear();

            Webservice Service = new Webservice();
            Service.getAllTickets(_SelectedParkingPlace.id);
            if (_SelectedParkingPlace.Name != null)
            {
                for (int i = 0; i < Service.TicketList.Count; i++)
                {
                    Tickets.Add(Service.TicketList.ElementAt(i));
                }
            }
        }

        //get inactive tickets from webservice
        public void getInactiveTicketsFromWebservice()
        {
            //clear list
            Tickets.Clear();

            Webservice Service = new Webservice();
            Service.getInactiveTickets(_SelectedParkingPlace.id);
            if (_SelectedParkingPlace != null)
            {
                for (int i = 0; i < Service.TicketList.Count; i++)
                {
                    Tickets.Add(Service.TicketList.ElementAt(i));
                }
            }
        }

        //get active tickets from webservice
        public void getActiveTicketsFromWebservice()
        {
            //clear list
            Tickets.Clear();

            Webservice Service = new Webservice();
            if (_SelectedParkingPlace != null)
            {
                Service.getActiveTickets(_SelectedParkingPlace.id);
                for (int i = 0; i < Service.TicketList.Count; i++)
                {
                    Tickets.Add(Service.TicketList.ElementAt(i));
                }
            }
        }

        public int editTicket()
        {
            if (SelectedParkingPlace.Name.Equals(""))
            {
                return 1;
            }
            else
            {
                Webservice Service = new Webservice();
                return Service.editParkingPlace(_SelectedParkingPlace);
            }
        }

        //clear list
        public void clearList()
        {
            Tickets.Clear();
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
