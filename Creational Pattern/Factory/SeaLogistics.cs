using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class SeaLogistics : Logistics
    {
        #region Constructor
        public SeaLogistics()
        {
        }
        #endregion

        #region Public Methods
        public override TransportVehicle GetFreeVehicle()
        {
            Ship newShip = new Ship( m_Rnd.Next( Logistics.MinVehicleId, Logistics.MaxVehicleId ).ToString() );
            Console.WriteLine( "New Ship (id: " + newShip.Id + ") created." );
            m_Vehicles.Add( newShip );
            return newShip;
        }
        #endregion

    }
}
