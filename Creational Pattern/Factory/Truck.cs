using System;

namespace Factory
{
    /// <summary>
    /// A concrete-product class that defines a vehicle used
    /// in a Road Logistics to deliver goods to cities.
    /// </summary>
    public class Truck : TransportVehicle
    {
        #region Class Members
        private readonly string m_TruckId;
        #endregion

        #region Constructor
        public Truck( string truckId )
        {
            m_TruckId = truckId;
        }
        #endregion

        #region Properties
        public string Id
        {
            get
            {
                return m_TruckId;
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
                Console.WriteLine( "Truck : " + m_TruckId + " is delivering " + item + " to " + this.DestinationPoint + "." );
        }
        #endregion

    }
}
