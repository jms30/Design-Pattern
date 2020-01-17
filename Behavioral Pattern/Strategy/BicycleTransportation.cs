using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// A class implementing Bike Transportation logic
    /// </summary>
    public class BicycleTransportation : ITransportationMode
    {
        public string SourcePoint
        {
            get;
            private set;
        } = "";

        public string DestinationPoint
        {
            get;
            private set;
        } = "";

        public BicycleTransportation()
        { }

        public double CalculateDistance()
        {
            return 25; // let's go for a ride in forest
        }

        public TimeSpan CalculateDuration()
        {
            return new TimeSpan( 2, 0, 0 ); // because we are going through some hilly area.
        }

        public double CalculateCost()
        {
            return 0; // because hey, when you ride your own bike, it doesn't cost anything. :) 
        }

        public void SetLocations( string source, string destination )
        {
            SourcePoint = source;
            DestinationPoint = destination;
        }
    }
}
