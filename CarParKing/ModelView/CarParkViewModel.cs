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
    class CarParkViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ParkingPlaceData> ParkingPlace { get; set; }
        public ObservableCollection<TicketData> Tickets { get; set; }
        public bool toEdit { get; set; }
        public bool ParkingPlaceDropDown { get; set; }
        private ParkingPlaceData _SelectedParkingPlace = new ParkingPlaceData();
        private TicketData _SelectedTicket = new TicketData();
        private ParkingPlaceData _ParkingPlaceToCreate = new ParkingPlaceData();
        private ParkingPlaceData _ParkingPlaceForTicketSelect = new ParkingPlaceData();

        public CarParkViewModel()
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
        public ParkingPlaceData ParkingPlaceForTicketSelect
        {
            get
            {
                return _ParkingPlaceForTicketSelect;
            }
            set
            {
                OnPropertyChanged("ParkingPlaceForTicketSelect");
                if(ParkingPlaceDropDown == true)
                {
                    _ParkingPlaceForTicketSelect = value;
                    if (_ParkingPlaceForTicketSelect == null)
                    {
                        _ParkingPlaceForTicketSelect = new ParkingPlaceData();
                    }
                    Console.WriteLine("true");
                }
                else
                {
                    
                    Console.WriteLine("false");
                }
                Console.WriteLine(_ParkingPlaceForTicketSelect.id.ToString());
                Console.WriteLine(_ParkingPlaceForTicketSelect.Name);
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
                _SelectedParkingPlace = value;
                if (_SelectedParkingPlace == null)
                {
                    _SelectedParkingPlace = new ParkingPlaceData();
                }
                Console.WriteLine(_SelectedParkingPlace.id.ToString());
            }
        }

        //create parking place
        public int createParkingPlace()
        {
            Webservice Service = new Webservice();
            return Service.createParkingPlace(SelectedParkingPlace);
        }

        public int editParkingPlace()
        {
            Webservice Service = new Webservice();
            return Service.editParkingPlace(SelectedParkingPlace);
        }

        //delete parking place
        public int deleteParkingPlace()
        {
            Webservice Service = new Webservice();
            
            if(SelectedParkingPlace != null)
            {
                SelectedParkingPlace.deleted = 1;
                return Service.editParkingPlace(SelectedParkingPlace);
            }
            return 1;
        }

        //get all parking places from webservice
        public void getAllParkingPlacesFromWebservice()
        {
            //clear list
            if(ParkingPlace == null)
            {
                ParkingPlace = new ObservableCollection<ParkingPlaceData>();
            }
            else
            {
                ParkingPlace.Clear();
            }
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
            Service.getAllTickets(_ParkingPlaceForTicketSelect.id);
            if (_ParkingPlaceForTicketSelect.Name != null)
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
            Service.getInactiveTickets(_ParkingPlaceForTicketSelect.id);
            if (_ParkingPlaceForTicketSelect != null)
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
            if (_ParkingPlaceForTicketSelect != null)
            {
                Service.getActiveTickets(_ParkingPlaceForTicketSelect.id);
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
