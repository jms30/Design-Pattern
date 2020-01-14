using System;

namespace Factory
{
    /// <summary>
    /// A concrete-product class that defines a vehicle used
    /// in a Sea Logistics to deliver goods to ports. 
    /// </summary>
    public class Ship : TransportVehicle
    {
        #region Class Members
        private readonly string m_ShipId;
        #endregion

        #region Constructor
        public Ship( string truckId )
        {
            m_ShipId = truckId;
        }
        #endregion

        #region Properties
        public string Id
        {
            get
            {
                return m_ShipId;
            }
        }

        public string DestinationPoint
        {
            get;
            set;
        } = "";
        #endregion

        #region Public methods
        public void DeliverGoods( string[] goods )
        {
            foreach ( var item in goods )
                Console.WriteLine( "Ship : " + m_ShipId + " is delivering " + item + " to " + this.DestinationPoint + "." );
        }
        #endregion

    }
}
