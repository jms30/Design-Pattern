using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// A class implementing Rail Transportation logic
    /// </summary>
    public class RailTransportation : ITransportationMode
    {
        public string TrainID
        {
            get;
            private set;
        } = "";

        public string Operator
        {
            get;
            private set;
        }

        public string SourceStation
        {
            get;
            private set;
        } = "";

        public string DestinationStation
        {
            get;
            private set;
        } = "";

        public RailTransportation()
        { }

        public double CalculateDistance()
        {
            return 560; // because deutsche bahn can not go further without interruptions. :P 
        }

        public TimeSpan CalculateDuration()
        {
            return new TimeSpan( 6, 0, 0 ); // because deutsche bahn is "perrrfect" and "punctual"
        }

        public double CalculateCost()
        {
            FindSuitableTrain();
            return CalculateDistance() * CalculateDuration().Hours / 15; // beacuse everything's expensive with DB ;) 
        }

        public void SetLocations( string source, string destination )
        {
            SourceStation = source;
            DestinationStation = destination;
        }

        private void FindSuitableTrain()
        {
            // Let's just pretend that this function performs search for
            // the "best ever(only)" option between two railway stations
            Operator = "Deutsche Bahn";
            TrainID = "RB999";
        }
    }
}
