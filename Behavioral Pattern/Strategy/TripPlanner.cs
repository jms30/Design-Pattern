using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// The abstraction class that invokes functions of concrete
    /// implementer of <see cref="ITransportationMode"/> interface.
    /// The clients only have to provide their choice of mode to this class
    /// which makes it smoother for them to change the 'strategy' on the fly.
    /// </summary>
    public class TripPlanner
    {
        private ITransportationMode m_Mode = null;

        public TripPlanner()
        { }

        public void SetTransportationMode( ITransportationMode mode )
        {
            m_Mode = mode;
        }

        public double CalculateTripExpenses()
        {
            return m_Mode.CalculateCost();
        }

        public void SetTripLocations( string startingPoint, string endingPoint )
        {
            m_Mode.SetLocations( startingPoint, endingPoint );
        }
    }
}
