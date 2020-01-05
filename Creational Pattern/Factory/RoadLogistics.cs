using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
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

        public override bool DeliverGoods( string[] goods, TransportVehicle truck )
        {
            if ( !m_Vehicles.Contains( truck ) )
                return false;

            truck.DeliverGoods( goods );
            return true;
        }
        #endregion

    }
}
