using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// A concrete subclass that defines what a Road Logistics mode would look like.
    /// It shows what is used to deliver goods in this mode. So, it tells what type 
    /// of product (<see cref="Truck"/>) it will be responsible for.
    /// </summary>
    public class RoadLogistics : Logistics
    {
        #region Constructor
        public RoadLogistics()
        {
        }
        #endregion

        #region Public Methods
        public override TransportVehicle GetFreeVehicle()
        {
            Truck newTruck = new Truck( m_Rnd.Next( Logistics.MinVehicleId, Logistics.MaxVehicleId ).ToString() );
            Console.WriteLine( "New Truck (id: " + newTruck.Id + ") created." );
            m_Vehicles.Add( newTruck );
            return newTruck;
        }
        #endregion

    }
}
