using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// Defines common functionality related to Logistics. 
    /// </summary>
    public abstract class Logistics
    {
        #region Constants and Members
        protected static readonly int MinVehicleId = 1;
        protected static readonly int MaxVehicleId = 100;
        protected HashSet<TransportVehicle> m_Vehicles = new HashSet<TransportVehicle>();
        protected Random m_Rnd = new Random();
        #endregion

        public Logistics()
        {
        }

        #region Abstract Methods to be implemented by subclasses
        public abstract TransportVehicle GetFreeVehicle();
        #endregion
    }
}
