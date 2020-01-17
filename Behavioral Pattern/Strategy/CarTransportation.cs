using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// A class implementing Cab Transportation logic
    /// </summary>
    public class CarTransportation : ITransportationMode
    {
        public string PickUpFrom
        {
            get;
            private set;
        } = "";

        public string DropOffAt
        {
            get;
            private set;
        } = "";

        public string ServiceProvider
        {
            get;
            private set;
        } = "";

        public string NumberPlate
        {
            get;
            private set;
        } = "";

        public CarTransportation()
        { }

        public double CalculateDistance()
        {
            return 25; // 25 KM
        }

        public TimeSpan CalculateDuration()
        {
            return new TimeSpan( 0, 15, 0 ); 
        }

        public double CalculateCost()
        {
            FindNextAvailableRide();
            return CalculateDistance() * 2.89 * CalculateDuration().TotalMinutes / 60; 
        }

        public void SetLocations( string source, string destination )
        {
            PickUpFrom = source;
            DropOffAt = destination;
        }

        private void FindNextAvailableRide()
        {
            // let's assume this function will find the best, nearest, fastest 
            // and cheapest option available for this trip.
            ServiceProvider = "Uber";
            NumberPlate = "GOGRN-999";
        }
    }
}
