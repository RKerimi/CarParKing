using CarParKing.Model;
using CarParKing.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParKing.Service
{
    public class Webservice
    {
        //List of tickets from webservice
        private List<TicketData> _Ticket = new List<TicketData>();
        private List<ParkingPlaceData> _ParkingPlace = new List<ParkingPlaceData>();

        public void getAllParkingPlaces()
        {
            var client = new ServiceReference1.ParkingClient();
            //check if client id is available
            var x = client.getParkingPlaceList();
            _ParkingPlace.Clear();
            //put received elements into the list
            for (int i = 0; i < x.Length; i++)
            {
                _ParkingPlace.Add(ParkingPlaceFromWebservice(x.ElementAt(i)));
            }
            client.Close();
        }

        public int editParkingPlace(ParkingPlaceData toEdit)
        {
            var client = new ServiceReference1.ParkingClient();
            int tmp = client.editParkingPlace(ParkingPlaceToWebservice(toEdit));
            client.Close();
            return tmp;
        }

        public int createParkingPlace(ParkingPlaceData toCreate)
        {
            var client = new ServiceReference1.ParkingClient();
            int tmp = client.createParkingPlace(ParkingPlaceToWebservice(toCreate));
            client.Close();
            return tmp;
        }


        //get all tickets for a parking place
        public void getAllTickets(int ParkingPlaceId)
        {
            var client = new ServiceReference1.ParkingClient();
            //check if client id is available

            var x = client.getTicketList(ParkingPlaceId, 1);
            _Ticket.Clear();
            //put received elements into the list
            for (int i = 0; i < x.Length; i++)
            {
                _Ticket.Add(TicketFromWebservice(x.ElementAt(i)));
            }
            client.Close();
        }

        //get inactive tickets
        public void getInactiveTickets(int ParkingPlaceId)
        {
            var client = new ServiceReference1.ParkingClient();
            var x = client.getInactiveTicketList(ParkingPlaceId);
            _Ticket.Clear();
            //put received elements into the list
            for (int i = 0; i < x.Length; i++)
            {
                _Ticket.Add(TicketFromWebservice(x.ElementAt(i)));
            }
            client.Close();
        }

        //get active tickets
        public void getActiveTickets(int ParkingPlaceId)
        {
            var client = new ServiceReference1.ParkingClient();
            var x = client.getActiveTicketList(ParkingPlaceId);
            _Ticket.Clear();
            //put received elements into the list
            for (int i = 0; i < x.Length; i++)
            {
                _Ticket.Add(TicketFromWebservice(x.ElementAt(i)));
            }
            client.Close();
        }

        //edit ticket
        public int editTicket(int ParkingPlaceId, TicketData toEdit)
        {
            var client = new ServiceReference1.ParkingClient();
            return client.editTicket(ParkingPlaceId, TicketToWebservice(toEdit));
            //Todo client close
        }

        //convert ticket data from webservice for application
        private TicketData TicketFromWebservice(ServiceReference1.ticket toChange)
        {
            TicketData tempTicket = new TicketData();
            String tmpDateTimeFormat = "yyyyMMddHHmmss";

            //ticket id
            tempTicket.TicketId = toChange.ticketnumber;

            //ticket entry time
            try
            {
                tempTicket.EntryTime = DateTime.ParseExact(toChange.entrytime, tmpDateTimeFormat, null).ToString();
            }
            catch (Exception)
            {
                tempTicket.EntryTime = "";
                //throw;
            }

            //ticket exit time
            try
            {
                tempTicket.ExitTime = DateTime.ParseExact(toChange.exittime, tmpDateTimeFormat, null).ToString();
            }
            catch (Exception)
            {
                tempTicket.ExitTime = "";

                //throw;
            }

            //price
            tempTicket.TicketPrice = toChange.price;

            return tempTicket;
        }

        //convert ticket data from application for webservice
        private ServiceReference1.ticket TicketToWebservice(TicketData toChange)
        {
            ServiceReference1.ticket tmp = new ServiceReference1.ticket();
            tmp.ticketnumber = toChange.TicketId;
            tmp.deleted = toChange.deleted;
            tmp.entrytime = toChange.EntryTime;
            tmp.exittime = toChange.ExitTime;
            return tmp;
        }

        //convert parking place data from webservice for application
        private ParkingPlaceData ParkingPlaceFromWebservice(ServiceReference1.parkingPlace toChange)
        {
            ParkingPlaceData tempParkingPlace = new ParkingPlaceData();

            tempParkingPlace.id = toChange.id;
            tempParkingPlace.Name = toChange.name;
            tempParkingPlace.numberOfParkingSlots = toChange.numberOfParkingSlots;
            tempParkingPlace.pricePerHour = toChange.pricePerHour;
            return tempParkingPlace;
        }

        //convert parking place data from application for webservice
        private ServiceReference1.parkingPlace ParkingPlaceToWebservice(ParkingPlaceData toChange)
        {
            ServiceReference1.parkingPlace tmp = new ServiceReference1.parkingPlace();

            tmp.id = toChange.id;
            tmp.name = toChange.Name;
            tmp.numberOfParkingSlots = toChange.numberOfParkingSlots;
            tmp.pricePerHour = toChange.pricePerHour;
            tmp.deleted = toChange.deleted;
            return tmp;
        }

        //getter and setter for list of tickets
        public List<TicketData> TicketList
        {
            get
            {
                return _Ticket;
            }
            set
            {
                _Ticket = value;
            }
        }

        //getter and setter for parking place
        public List<ParkingPlaceData> ParkingPlaceList
        {
            get
            {
                return _ParkingPlace;
            }
            set
            {
                _ParkingPlace = value;
            }
        }
    }
}
