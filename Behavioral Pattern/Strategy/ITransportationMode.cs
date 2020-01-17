using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// Common interface for different modes of transportation logic.
    /// </summary>
    public interface ITransportationMode
    {
        double CalculateDistance();

        TimeSpan CalculateDuration();

        double CalculateCost();

        void SetLocations( string source, string destination );
    }
}
