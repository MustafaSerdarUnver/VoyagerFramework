using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class Route
    {
        private int _breakCount = 0;
        private decimal _basePrice;
        private int _duration;

        public int RouteId { get; set; }
        public string Name
        {
            get
            {
                if (BreakCount != 0)
                {
                    return string.Format("Molalı rota:{0}-{1}/{2} KM'lik {3} molalı rota", DepartureLocation, ArrivalLocation, Distance, BreakCount);
                }
                return string.Format("Malasız rota :{0}-{1}/{2} KM'lik Express rota", DepartureLocation, ArrivalLocation, Distance);
            }
        }

        public string DepartureLocation { get; }
        public string ArrivalLocation { get; }
        public int Distance { get; }

        public int Duration
        {
            get
            {
                CalculateDuration();
                return _duration;
            }
        }

        private const int distancePerBreakCount = 200;
        public int BreakCount
        {
            get
            {
                return _breakCount;
            }
            set
            {
                if (value >= 0)
                {
                    if (value <= Distance / distancePerBreakCount)
                        _breakCount = value;
                    else
                        _breakCount = Distance / distancePerBreakCount;
                }
            }
        }

        public decimal BasePrice
        {
            get
            {
                CalculateBasePrice();
                return _basePrice;
            }
        }

        public Route(string departureLocation, string arrivalLocation, int distance)
        {
            DepartureLocation = departureLocation;
            ArrivalLocation = arrivalLocation;
            Distance = distance;
        }

        private void CalculateDuration()
        {
            const int timeOfBreak = 30;
            const int SecondsPerKm = 45;
            const int SecondsInOneMinute = 60;
            if ((Distance * SecondsPerKm) % SecondsInOneMinute != 0)
            {
                _duration = (Distance * SecondsPerKm) / SecondsInOneMinute + 1;
            }
            else
            {
                _duration = (Distance * SecondsPerKm) / SecondsInOneMinute;
            }
            _duration += BreakCount * timeOfBreak;
        }

        private void CalculateBasePrice()
        {
            const int priceMileStone = 300;
            const int priceForEvery25kmUntil300KM = 5;
            const decimal priceForEvery25kmAfter300KM = 4.5m;
            const int kmValuesForChangePrice = 25;
            if (Distance <= priceMileStone)
            {
                if (Distance % kmValuesForChangePrice != 0)
                {
                    _basePrice = (Distance / kmValuesForChangePrice + 1) * priceForEvery25kmUntil300KM;
                }
                else
                {
                    _basePrice = Distance / kmValuesForChangePrice * priceForEvery25kmUntil300KM;
                }
            }
            else
            {
                _basePrice = 60m;
                int kalanMesafe = Distance - priceMileStone;
                if (kalanMesafe % kmValuesForChangePrice != 0)
                {
                    _basePrice += (decimal)((kalanMesafe / kmValuesForChangePrice + 1) * priceForEvery25kmAfter300KM);
                }
                else
                {
                    _basePrice += (decimal)(kalanMesafe / kmValuesForChangePrice * priceForEvery25kmAfter300KM);
                }
            }
        }
    }
}
