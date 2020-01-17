using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// A class implementing Air Transportation logic
    /// </summary>
    public class AirTransportation : ITransportationMode
    {
        public string FlightCode
        {
            get;
            private set;
        } = "";

        public string Operator
        {
            get;
            private set;
        } = "";

        public string SourceAirport
        {
            get;
            private set;
        } = "";

        public string DestinationAirport
        {
            get;
            private set;
        } = "";

        public AirTransportation()
        {
        }

        public double CalculateDistance()
        {
            return 5000; //just return 5000KM
        }

        public TimeSpan CalculateDuration()
        {
            return new TimeSpan( 15, 12, 0 ); // just return some random 15 hour flight
        }

        public double CalculateCost()
        {
            FindSuitableOption();
            return CalculateDistance() * CalculateDuration().TotalHours / 365;
        }

        public void SetLocations( string source, string destination )
        {
            SourceAirport = source;
            DestinationAirport = destination;
        }

        private void FindSuitableOption()
        {
            // Let's assume that this function performs algorithm search 
            // for the best ever suitable flight between the airports.
            Operator = "Air Canada";
            FlightCode = "AC999";
        }
    }
}
