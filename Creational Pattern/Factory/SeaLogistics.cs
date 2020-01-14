using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{    
    /// <summary>
    /// A concrete subclass that defines what a Sea Logistics mode would look like.
    /// It shows what is used to deliver goods in this mode. So, it tells what type 
    /// of product (<see cref="Ship"/>) it will be responsible for.
    /// </summary>
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
