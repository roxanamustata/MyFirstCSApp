using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class BaggageHandler : IObservable<BaggageInfo>
    {
        // A collection of clients that will receive updated info
        private List<IObserver<BaggageInfo>> observers;
        // A collection of flights and their assigned carousels
        private List<BaggageInfo> flights;

        public BaggageHandler()
        {
            observers = new List<IObserver<BaggageInfo>>();
            flights = new List<BaggageInfo>();
        }


        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            if (!observers.Contains(observer))
            {
                // Check whether observer is already registered. If not, add it
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in flights)
                {
                    observer.OnNext(item);
                }
            }
            return new UnSubscriber<BaggageInfo>(observers, observer);
        }

        public void BaggageStatus(int flightNumber)
        {
            BaggageStatus(flightNumber, String.Empty, 0);
        }

        public void BaggageStatus(int flightNumber, string from, int carousel)
        {
            var info = new BaggageInfo(flightNumber, from, carousel);
            // Carousel is assigned, so add new info object to list.
            if (carousel > 0 && !flights.Contains(info))
            {
                flights.Add(info);
                foreach (var observer in observers)
                {
                    observer.OnNext(info);
                }

            }
            else if (carousel == 0)
            {
                // Baggage claim for flight is done
                var flightsToRemove = new List<BaggageInfo>();
                foreach (var flight in flights)
                {
                    if (info.FlightNumber == flight.FlightNumber)
                    {
                        flightsToRemove.Add(flight);
                        foreach (var observer in observers)
                        {
                            observer.OnNext(info);
                        }
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                {
                    flights.Remove(flightToRemove);

                }
                flightsToRemove.Clear();

            }
        }
        public void LastBaggageClaimed()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
            observers.Clear();
        }

    }
}
