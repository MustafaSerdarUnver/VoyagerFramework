using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class BusExpedition
    {
        private int _randomCode;
        private Bus _bus;

        public List<Driver> drivers = new List<Driver>();
        public List<Host>  hosts= new List<Host>();
        public List<Ticket> tickets = new List<Ticket>();

        public int BusExpeditionId { get; set; }
        public string Code { get { return CalculateCode(); } }
        public Bus Bus
        {
            get
            {
                return _bus;
            }
            set
            {
                for (int i = 0; i < drivers.Count; i++)
                {
                    if (value is LuxuryBus && drivers[i].LicenseType!=LicenseType.HighLicense)
                    {
                        throw new Exception("Lux Otobüsü sürmek için sürücülerin high licence sahip olması gerekir.");
                    }
                    else if(drivers[i].LicenseType==LicenseType.None)
                    {
                        throw new Exception("Standart otobüsü sürmek için sürücülerin bir lisansa sahip olması gerekir ");
                    }
                    else
                    {
                        _bus = value;
                    }
                }
            }
        }
        public Route Route { get; }
        public DateTime DepartureTime { get; }
        public DateTime EstimatedDepartureTime
        {
            get
            {
                if (EstimatedDepartureTime != null)
                {
                    return EstimatedDepartureTime;
                }
                return DepartureTime;
            }
            set
            {
                if (value < DepartureTime)
                {
                    EstimatedDepartureTime = DepartureTime;
                }
                else
                {
                    EstimatedDepartureTime = value;
                }
            }
        }
        public DateTime EstimatedArrivalTime
        {
            get
            {
                return EstimatedDepartureTime.AddMinutes(Route.Duration);
            }
        }
        public bool HasDelay
        {
            get
            {
                if (DepartureTime != EstimatedArrivalTime)
                {
                    return true;
                }
                return false;
            }
        }
        public bool HasSnackService { get; set; }

        public BusExpedition()
        {
            Random rnd = new Random();
            _randomCode = rnd.Next(1000, 9999);
        }

        private string CalculateCode()
        {
            string busPrefix = "";
            if (Bus is LuxuryBus)
            {
                busPrefix = "LX";
            }
            else if (Bus is StandartBus)
            {
                busPrefix = "ST";
            }
            return string.Format("{0}{1:YYMMDD}-{2}-{3}", Route.DepartureLocation[0], EstimatedDepartureTime, busPrefix, _randomCode);
        }

        public void AddDriver(Driver driver)
        {
            if (Bus!=null)
            {
                const int distancePerDriverCount = 400;
                if (drivers.Count < Math.Ceiling((decimal)(Route.Distance / distancePerDriverCount)))
                {
                    if (Bus is StandartBus && driver.LicenseType != LicenseType.None)
                        drivers.Add(driver);
                    else if (Bus is LuxuryBus && driver.LicenseType == LicenseType.HighLicense)
                        drivers.Add(driver);
                    else
                        throw new Exception("Eklenmek istenen sürücünün lisansı bu aracı sürmeye uygun değil.");
                }
                else
                    throw new Exception("Sürücünün ekleneceği bir otobüs mevcut değil..");
            }            
        }

        public void AddHost(Host host)
        {
            const int distancePerHostCount = 600;
            if (hosts.Count < Math.Ceiling((decimal)(Route.Distance / distancePerHostCount)))
            {
                hosts.Add(host);
            }
        }

        public void RemoveDriver(Driver driver)
        {
            drivers.Remove(driver);
        }

        public void RemoveHost(Host host)
        {
            hosts.Remove(host);
        }

        public decimal GetPriceOf(int seatNumber)
        {
            const decimal ProfitRateForStandartBusAndSingularSeat = 0.25m;
            const decimal ProfitRateForStandartBusAndPairsSeat = 0.20m;
            const decimal ProfitRateForLuxuryBusSeat = 0.35m;
            decimal price = Route.BasePrice;
            if (Bus is StandartBus)
            {
                if (seatNumber % 3 == 1)
                    price += Route.BasePrice * ProfitRateForStandartBusAndSingularSeat;
                else
                    price += Route.BasePrice / ProfitRateForStandartBusAndPairsSeat;
            }
            else if (Bus is LuxuryBus)
                price += (Route.BasePrice * ProfitRateForLuxuryBusSeat);
            return price;
        }

        public Ticket SellTicket(Person person, int seatNumber, decimal fee)
        {
            if (IsSeatAvailableFor(seatNumber, person.Gender) && IsMoneyEnoughForSellTicket(person, fee))
            {
                Ticket ticket = new Ticket(this, Bus.GetSeatInformation(seatNumber), person, fee);
                tickets.Add(ticket);
                return ticket;
            }
            else
                throw new Exception("Bu şartlarda bilet satışı gerçekleşemez..");
        }

        private bool IsMoneyEnoughForSellTicket(Person person, decimal fee)
        {
            bool result = false;
            if (person is Driver || person is Host && fee >= Route.BasePrice)
            {
                result = true;
            }
            else if (fee >= Route.BasePrice * 1.05m)
            {
                result = true;
            }
            return result;
        }

        public List<Ticket> SellDoubleTickets(Person person01, Person person02, int seatNumber, decimal fee)
        {
            if (Bus is StandartBus && seatNumber % 3 != 1)
            {
                if (seatNumber % 3 == 2 && IsSeatEmpty(seatNumber) && IsSeatEmpty(seatNumber + 1) && IsMoneyEnoughForSellDoubleTickets(person01, person02, fee))
                    return AddTickets(seatNumber, seatNumber + 1, person01, person02, fee);
                else if (seatNumber % 3 == 0 && IsSeatEmpty(seatNumber) && IsSeatEmpty(seatNumber + -1) && IsMoneyEnoughForSellDoubleTickets(person01, person02, fee))
                    return AddTickets(seatNumber, seatNumber - 1, person01, person02, fee);
                else
                    throw new Exception("Belirtilen yerden ikili koltuk alınamaz");
            }
            else
                throw new Exception("Seçilen koltuk çiftli bilet almaya uygun değil");
        }

        private List<Ticket> AddTickets(int seatNumber, int otherSeatNumber, Person person01, Person person02, decimal fee)
        {
            List<Ticket> sellTickets = new List<Ticket>();
            Ticket ticket01 = new Ticket(this, Bus.GetSeatInformation(seatNumber), person01, fee / 2);
            Ticket ticket02 = new Ticket(this, Bus.GetSeatInformation(otherSeatNumber), person02, fee / 2);
            sellTickets.Add(ticket01);
            sellTickets.Add(ticket02);
            tickets.AddRange(sellTickets);

            return sellTickets;
        }

        private bool IsMoneyEnoughForSellDoubleTickets(Person person1, Person person2, decimal fee)
        {
            bool result = false;
            if (person1 is Driver || person1 is Host || person2 is Driver || person2 is Host && fee >= 2 * Route.BasePrice)
                result = true;
            else if (fee >= 2 * Route.BasePrice * 1.05m)
                result = true;
            return result;
        }

        public void CancelTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
        }

        public bool IsSeatAvailableFor(int seatNumber, Gender gender)
        {
            bool result = false;
            if (IsSeatEmpty(seatNumber))
            {
                if (Bus is LuxuryBus)
                    result = true;
                else
                {
                    if (seatNumber % 3 == 1)
                        result = true;
                    else
                    {
                        if (seatNumber % 3 == 2)
                        {
                            if (!IsSeatEmpty(seatNumber + 1))
                            {
                                if (IsSameGender(seatNumber + 1, gender))
                                    result = true;
                                else
                                    result = false;
                            }
                            else
                                result = true;
                        }
                        else if (seatNumber % 3 == 0)
                        {
                            if (!IsSeatEmpty(seatNumber - 1))
                            {
                                if (IsSameGender(seatNumber - 1, gender))
                                    result = true;
                                else
                                    result = false;
                            }
                            else
                                result = true;
                        }
                    }
                }
            }
            return result;
        }

        private bool IsSameGender(int seatNumber, Gender gender)
        {
            bool result = false;
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].Passenger.Gender==gender)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool IsSeatEmpty(int seatNumber)
        {
            bool result = false;
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].SeatInformation.Number==seatNumber)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}

